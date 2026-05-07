using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CK_AppKS
{
    public partial class UC_PHONG : UserControl
    {
        public UC_PHONG()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void flpDanhSach_Paint(object sender, PaintEventArgs e)
        {
        }

        // Hiển thị danh sách phòng từ database
        public void DoTheVaoPhong()
        {
            flpDanhSach.Controls.Clear();

            // Lấy dữ liệu phòng từ database
            string sql = @"SELECT p.MaPhong, p.TenPhong, lp.TenLoaiPhong, p.TinhTrang, lp.DonGia
                            FROM dbo.Phong p
                            LEFT JOIN dbo.LoaiPhong lp ON p.MaLoaiPhong = lp.MaLoaiPhong
                            ORDER BY p.MaPhong";
            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);

            if (dt == null || dt.Rows.Count == 0)
                return;

            foreach (DataRow row in dt.Rows)
            {
                string soPhong = row["TenPhong"]?.ToString() ?? "";
                string loaiPhong = row["TenLoaiPhong"]?.ToString() ?? "";
                string tinhTrang = row["TinhTrang"]?.ToString() ?? "";
                long donGia = 0;
                long.TryParse(row["DonGia"]?.ToString() ?? "0", out donGia);

                // Trạng thái: true = đã đặt, false = trống
                bool isDaDat = tinhTrang == "Đã Đặt";

                UC_THEPHONG the = new UC_THEPHONG();
                the.NapDuLieu(soPhong, loaiPhong, isDaDat, donGia);
                the.Margin = new Padding(10);

                // Gán sự kiện Click cho chính cái thẻ
                the.Click += new EventHandler(ThePhong_Click);
                foreach (Control c in the.Controls)
                {
                    c.Click += new EventHandler(ThePhong_Click);
                }
                flpDanhSach.Controls.Add(the);
            }
        }

        private void ThePhong_Click(object? sender, EventArgs e)
        {
            if (sender == null) return;

            Control obj = (Control)sender;
            UC_THEPHONG? theGoc = null;

            // Tìm thẻ gốc
            if (obj is UC_THEPHONG uc)
                theGoc = uc;
            else if (obj.Parent is UC_THEPHONG parentUc)
                theGoc = parentUc;

            if (theGoc != null)
            {
                string tenPhong = theGoc.lblTenPhong.Text;
                using (FormNhapLieu f = new FormNhapLieu())
                {
                    f.Text = "Cập nhật cho " + tenPhong;
                    f.ShowDialog();
                }
            }
        }
    }
}
