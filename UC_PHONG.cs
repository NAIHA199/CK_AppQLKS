using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CK_AppKS
{
    public partial class UC_PHONG : UserControl
    {
        // Chuỗi kết nối - Đã cập nhật theo SQL2025 của bạn
        private string connectionString = @"Data Source=.\SQL2025;Initial Catalog=QLKS;Integrated Security=True";

        public UC_PHONG()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sự kiện Load của UserControl: Tự động đổ dữ liệu khi vừa mở màn hình
        /// </summary>
        private void UC_PHONG_Load(object sender, EventArgs e)
        {
            DoTheVaoPhong();
        }

        /// <summary>
        /// Hàm lấy dữ liệu từ SQL và tạo các thẻ phòng (UC_THEPHONG) tương ứng
        /// </summary>
        public void DoTheVaoPhong()
        {
            // 1. Xóa sạch danh sách cũ trong FlowLayoutPanel
            flpDanhSach.Controls.Clear();

            // 2. Câu lệnh SQL JOIN để lấy tên Loại phòng, Trạng thái và Giá
            string query = @"
                SELECT P.SoPhong, L.LoaiPhong, P.TrangThai, L.DonGia
                FROM PHONG P 
                INNER JOIN LOAIPHONG L ON P.MaLoaiPhong = L.MaLoaiPhong
                ORDER BY P.SoPhong ASC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Đọc dữ liệu từ từng dòng trong Database
                                string soPhong = reader["SoPhong"].ToString();
                                string loaiPhong = reader["LoaiPhong"].ToString();
                                string trangThai = reader["TrangThai"].ToString();
                                decimal donGia = Convert.ToDecimal(reader["DonGia"]);

                                // Xác định trạng thái để đổi màu thẻ (Ví dụ: Đang thuê = true)
                                bool isBusy = (trangThai == "Đang Thuê");

                                // 3. Khởi tạo thẻ phòng (UserControl con)
                                UC_THEPHONG the = new UC_THEPHONG();

                                // Nạp dữ liệu vào thẻ qua hàm NapDuLieu của nó (bao gồm giá)
                                the.NapDuLieu(soPhong, loaiPhong, isBusy, donGia);
                                the.Margin = new Padding(12); // Khoảng cách giữa các thẻ

                                // 4. Gán sự kiện Click cho thẻ
                                the.Click += new EventHandler(ThePhong_Click);

                                // Gán click cho tất cả các con bên trong thẻ (Label, PictureBox...) 
                                // để bấm vào đâu cũng mở được Form nhập liệu
                                foreach (Control c in the.Controls)
                                {
                                    c.Click += new EventHandler(ThePhong_Click);
                                }

                                // 5. Đưa thẻ vào khung hiển thị
                                flpDanhSach.Controls.Add(the);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi nạp sơ đồ phòng: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Xử lý khi người dùng click vào một thẻ phòng bất kỳ
        /// </summary>
        private void ThePhong_Click(object sender, EventArgs e)
        {
            if (sender == null) return;

            // Xác định chính xác thẻ UC_THEPHONG được bấm
            Control obj = (Control)sender;
            UC_THEPHONG theGoc = null;

            if (obj is UC_THEPHONG uc)
                theGoc = uc;
            else if (obj.Parent is UC_THEPHONG parentUc)
                theGoc = parentUc;

            if (theGoc != null)
            {
                // Lấy số phòng từ Label trên thẻ (lblTenPhong hoặc lblSoPhong tùy bạn đặt tên)
                string soPhong = theGoc.lblTenPhong.Text;

                // Mở Form Nhập Liệu
                using (FormNhapLieu f = new FormNhapLieu())
                {
                    f.Text = "Quản lý Phòng: " + soPhong;

                    // Truyền số phòng cho Form để nó load dữ liệu
                    f.SelectedRoom = soPhong;

                    f.StartPosition = FormStartPosition.CenterParent;
                    f.ShowDialog();

                    // QUAN TRỌNG: Sau khi đóng Form nhập liệu (có thể trạng thái phòng đã đổi),
                    // ta load lại toàn bộ sơ đồ phòng để cập nhật màu sắc mới.
                    DoTheVaoPhong();
                }
            }
        }

        // Các sự kiện trống bạn có thể xóa nếu không dùng
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void flpDanhSach_Paint(object sender, PaintEventArgs e) { }
    }
}