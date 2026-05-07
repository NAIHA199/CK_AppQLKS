using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;

namespace CK_AppKS
{
    public partial class UC_DatPhong : UserControl
    {
        // Danh sách các phòng lưu tạm trong RAM
        private List<(string MaPhong, string TenPhong, string LoaiPhong, string TinhTrang)> danhSachPhong = new();
        private List<(string MaPhong, string TenPhong, string LoaiPhong, string TinhTrang)> danhSachPhongGoc = new();
        private string selectedMaPhong = "";
        private string selectedPhong = "";
        private string selectedLoaiPhong = "";

        public UC_DatPhong()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // Load event - gọi khi UC được load
        private void UC_DatPhong_Load(object sender, EventArgs e)
        {
            try
            {
                // Thiết lập các cột cho DataGridView
                SetupDataGridView();

                // Load dữ liệu phòng từ database
                LoadDataPhongFromDatabase();

                // Nạp dữ liệu vào grid
                LoadDataGridView();

                // Setup bộ lọc
                SetupFilters();

                // Disable các control cho đến khi chọn phòng
                DisableCustomerForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load dữ liệu: {ex.Message}\n\n{ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Xác nhận đặt phòng - Lưu dữ liệu vào database
            if (string.IsNullOrEmpty(selectedMaPhong))
            {
                MessageBox.Show("Vui lòng chọn một phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra nhập liệu
            if (string.IsNullOrWhiteSpace(txthoten.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Lưu dữ liệu khách hàng vào dbo.KhachHang
                int maKhachHang = SaveKhachHang();

                if (maKhachHang > 0)
                {
                    SavePhieuThue(maKhachHang);
                    // 2. Cập nhật trạng thái phòng thành "Đã Đặt"
                    UpdatePhongTrangThai(selectedMaPhong, "Đã Đặt");

                    // 3. Reload dữ liệu
                    LoadDataPhongFromDatabase();
                    LoadDataGridView();

                    MessageBox.Show("✓ Đặt phòng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear form
                    ClearForm();
                    DisableCustomerForm();
                }
                else
                {
                    MessageBox.Show("✗ Lỗi khi lưu dữ liệu khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"✗ Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lưu dữ liệu khách hàng vào database

        private void SavePhieuThue(int maKhachHang)
        {
            try
            {
                string loaiKhach = cbLoaiKhach.SelectedItem?.ToString() ?? "Nội Địa";

                // Câu lệnh SQL lưu vào bảng PhieuThue
                string sql = @"INSERT INTO dbo.PhieuThue (MaPhong, MaKhachHang, LoaiKhach, NgayThue)
                       VALUES (@MaPhong, @MaKhachHang, @LoaiKhach, @NgayThue)";

                SqlParameter[] paras = new SqlParameter[]
                {
            new SqlParameter("@MaPhong", selectedMaPhong),
            new SqlParameter("@MaKhachHang", maKhachHang),
            new SqlParameter("@LoaiKhach", loaiKhach),
            new SqlParameter("@NgayThue", dateTimePicker1.Value) // Ngày thuê lấy từ ngày nhận
                };

                DataProvider.ExcuteNonQuery(sql, CommandType.Text, paras);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tạo phiếu thuê: {ex.Message}");
            }
        }

        private int SaveKhachHang()
        {
            try
            {
                string gioiTinh = radioButton1.Checked ? "Nam" : "Nữ";
                string loaiKhach = cbLoaiKhach.SelectedItem?.ToString() ?? "Nội Địa";
                string quocTich = cbQuocTich.SelectedItem?.ToString() ?? "Việt Nam";

                string sql = @"INSERT INTO dbo.KhachHang (HoTen, SDT, SoCCCD, LoaiKhach, QuocTich, GioiTinh, NgayNhan, NgayTra, SoKhach)
                            VALUES (@HoTen, @SDT, @CCCD, @LoaiKhach, @QuocTich, @GioiTinh, @NgayNhan, @NgayTra, @SoKhach);
                            SELECT SCOPE_IDENTITY();";

                SqlParameter[] paras = new SqlParameter[]
                {
                    new SqlParameter("@HoTen", txthoten.Text.Trim()),
                    new SqlParameter("@SDT", txtsodienthoai.Text.Trim()),
                    new SqlParameter("@CCCD", txtsocccd.Text.Trim()),
                    new SqlParameter("@LoaiKhach", loaiKhach),
                    new SqlParameter("@QuocTich", quocTich),
                    new SqlParameter("@GioiTinh", gioiTinh),
                    new SqlParameter("@NgayNhan", dateTimePicker1.Value),
                    new SqlParameter("@NgayTra", dateTimePicker2.Value),
                    new SqlParameter("@SoKhach", (int)numericUpDown1.Value),
                };

                SqlConnection con = new SqlConnection(DataProvider.ChuoiKetNoi);
                SqlCommand cmd = new SqlCommand(sql, con);
               cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddRange(paras);

                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();

                return result != null ? Convert.ToInt32(result) : 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lưu khách hàng: {ex.Message}");
            }
        }

        // Cập nhật trạng thái phòng
        private void UpdatePhongTrangThai(string maPhong, string tinhTrang)
        {
            try
            {
                string sql = "UPDATE dbo.Phong SET TinhTrang = @TinhTrang WHERE MaPhong = @MaPhong";

                SqlParameter[] paras = new SqlParameter[]
                {
                    new SqlParameter("@TinhTrang", tinhTrang),
                    new SqlParameter("@MaPhong", maPhong)
                };

                DataProvider.ExcuteNonQuery(sql, CommandType.Text, paras);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật trạng thái phòng: {ex.Message}");
            }
        }

        // Load dữ liệu phòng từ database
        private void LoadDataPhongFromDatabase()
        {
            try
            {
                danhSachPhong.Clear();
                
                // Truy vấn dữ liệu từ bảng Phong và LoaiPhong
                string sql = @"SELECT p.MaPhong, p.TenPhong, lp.TenLoaiPhong, p.TinhTrang
                            FROM dbo.Phong p
                            LEFT JOIN dbo.LoaiPhong lp ON p.MaLoaiPhong = lp.MaLoaiPhong
                            ORDER BY p.MaPhong";
                
                DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu phòng trong database!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    string maPhong = row["MaPhong"]?.ToString() ?? "";
                    string tenPhong = row["TenPhong"]?.ToString() ?? "";
                    string loaiPhong = row["TenLoaiPhong"]?.ToString() ?? "Chưa xác định";
                    string tinhTrang = row["TinhTrang"]?.ToString() ?? "";

                    danhSachPhong.Add((maPhong, tenPhong, loaiPhong, tinhTrang));
                }

                // Lưu bản sao dữ liệu gốc để dùng cho lọc
                danhSachPhongGoc = new List<(string MaPhong, string TenPhong, string LoaiPhong, string TinhTrang)>(danhSachPhong);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu phòng: {ex.Message}\n\n{ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thiết lập các cột cho DataGridView
        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();

            // Cột Tên Phòng
            var colTenPhong = new DataGridViewTextBoxColumn();
            colTenPhong.Name = "TenPhong";
            colTenPhong.HeaderText = "TÊN PHÒNG";
            colTenPhong.Width = 150;

            // Cột Loại Phòng
            var colLoaiPhong = new DataGridViewTextBoxColumn();
            colLoaiPhong.Name = "LoaiPhong";
            colLoaiPhong.HeaderText = "LOẠI PHÒNG";
            colLoaiPhong.Width = 150;

            // Cột Tình Trạng
            var colTinhTrang = new DataGridViewTextBoxColumn();
            colTinhTrang.Name = "TinhTrang";
            colTinhTrang.HeaderText = "TÌNH TRẠNG";
            colTinhTrang.Width = 150;
            colTinhTrang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns.AddRange(colTenPhong, colLoaiPhong, colTinhTrang);

            // Gán sự kiện click cho DataGridView
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        // Setup bộ lọc
        private void SetupFilters()
        {
            // Loại Phòng - Load từ database
            try
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("-- Tất Cả --");
                
                string sql = "SELECT TenLoaiPhong FROM dbo.LoaiPhong ORDER BY TenLoaiPhong";
                DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);
                
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string tenLoai = row["TenLoaiPhong"]?.ToString() ?? "";
                        if (!string.IsNullOrEmpty(tenLoai))
                        {
                            comboBox1.Items.Add(tenLoai);
                        }
                    }
                }
                
                comboBox1.SelectedIndex = 0;
            }
            catch
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("-- Tất Cả --");
                comboBox1.Items.Add("Phòng Đơn");
                comboBox1.Items.Add("Phòng Đôi");
                comboBox1.Items.Add("Phòng Vip");
                comboBox1.SelectedIndex = 0;
            }

            // Tình Trạng
            comboBox2.Items.Clear();
            comboBox2.Items.Add("-- Tất Cả --");
            comboBox2.Items.Add("Trống");
            comboBox2.Items.Add("Đã Đặt");
            comboBox2.SelectedIndex = 0;

            // Gán sự kiện cho button Lọc
            button2.Click += Button2_Click;
        }

        // Xử lý sự kiện button Lọc
        private void Button2_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        // Áp dụng bộ lọc
        private void ApplyFilter()
        {
            string selectedLoaiPhong = comboBox1.SelectedItem?.ToString() ?? "-- Tất Cả --";
            string selectedTinhTrang = comboBox2.SelectedItem?.ToString() ?? "-- Tất Cả --";

            // Lọc dữ liệu
            var filteredData = danhSachPhongGoc.AsEnumerable();

            if (selectedLoaiPhong != "-- Tất Cả --")
            {
                filteredData = filteredData.Where(p => p.LoaiPhong == selectedLoaiPhong);
            }

            if (selectedTinhTrang != "-- Tất Cả --")
            {
                filteredData = filteredData.Where(p => p.TinhTrang == selectedTinhTrang);
            }

            danhSachPhong = filteredData.ToList();
            LoadDataGridView();
        }

        // Nạp dữ liệu vào DataGridView
        private void LoadDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in danhSachPhong)
            {
                dataGridView1.Rows.Add(item.TenPhong, item.LoaiPhong, item.TinhTrang);
            }
        }

        // Xử lý sự kiện click vào hàng trong DataGridView
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Nếu click vào header

            var row = dataGridView1.Rows[e.RowIndex];
            string tenPhong = row.Cells["TenPhong"].Value?.ToString() ?? "";
            string tinhTrang = row.Cells["TinhTrang"].Value?.ToString() ?? "";

            // Kiểm tra trạng thái phòng
            if (tinhTrang == "Đã Đặt")
            {
                MessageBox.Show($"Phòng {tenPhong} đã được đặt rồi. Vui lòng chọn phòng khác!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tìm MaPhong từ dữ liệu
            var phongInfo = danhSachPhong.FirstOrDefault(p => p.TenPhong == tenPhong);
            
            selectedMaPhong = phongInfo.MaPhong;
            selectedPhong = tenPhong;
            selectedLoaiPhong = row.Cells["LoaiPhong"].Value?.ToString() ?? "";

            // Hiển thị số phòng vào textBox1
            textBox1.Text = selectedPhong;

            // Kích hoạt form để điền thông tin khách hàng
            EnableCustomerForm();
        }

        // Disable các control cho đến khi chọn phòng
        private void DisableCustomerForm()
        {
            txthoten.Enabled = false;
            txtsodienthoai.Enabled = false;
            txtsocccd.Enabled = false;
            cbLoaiKhach.Enabled = false;
            cbQuocTich.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            numericUpDown1.Enabled = false;
        }

        // Kích hoạt form sau khi chọn phòng
        private void EnableCustomerForm()
        {
            txthoten.Enabled = true;
            txtsodienthoai.Enabled = true;
            txtsocccd.Enabled = true;
            cbLoaiKhach.Enabled = true;
            cbQuocTich.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            numericUpDown1.Enabled = true;
        }

        // Clear form
        private void ClearForm()
        {
            textBox1.Text = "";
            txthoten.Text = "";
            txtsodienthoai.Text = "";
            txtsocccd.Text = "";
            cbLoaiKhach.SelectedIndex = 0;
            cbQuocTich.SelectedIndex = 0;
            radioButton1.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now.AddDays(1);
            numericUpDown1.Value = 1;
            selectedMaPhong = "";
            selectedPhong = "";
        }

        // Làm sạch lựa chọn
        private void ClearSelection()
        {
            selectedMaPhong = "";
            selectedPhong = "";
            selectedLoaiPhong = "";
            textBox1.Text = "";
            dataGridView1.ClearSelection();
            DisableCustomerForm();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
