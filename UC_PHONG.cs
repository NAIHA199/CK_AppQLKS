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
        public void DoTheVaoPhong()
        {
            flpDanhSach.Controls.Clear();

            for (int i = 1; i <= 20; i++)
            {
                UC_THEPHONG the = new UC_THEPHONG();
                the.NapDuLieu("10" + i, (i % 2 != 0) ? "PHÒNG ĐƠN" : "PHÒNG ĐÔI", (i % 5 == 0));
                the.Margin = new Padding(10);

                // --- BẮT ĐẦU PHẦN QUAN TRỌNG ---
                // 1. Gán sự kiện Click cho chính cái thẻ
                the.Click += new EventHandler(ThePhong_Click);

                // 2. Gán sự kiện Click cho tất cả các Label bên trong thẻ 
                // (Để khi khách bấm trúng chữ "Phòng" hay "Giá" thì nó vẫn hiểu là đang bấm vào thẻ)
                foreach (Control c in the.Controls)
                {
                    c.Click += new EventHandler(ThePhong_Click);
                }
                // --- KẾT THÚC PHẦN QUAN TRỌNG ---

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
                // Sử dụng tên chính xác bạn đã đặt cho Label
                string tenPhong = theGoc.lblTenPhong.Text;

                // Đảm bảo FormNhapLieu là một FORM, không phải User Control
                using (FormNhapLieu f = new FormNhapLieu())
                {
                    f.Text = "Cập nhật cho " + tenPhong;
                    f.ShowDialog();
                }
            }
        }
    }
}
