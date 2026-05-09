using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CK_AppKS
{
    public partial class UC_THEPHONG : UserControl
    {
        public UC_THEPHONG()
        {
            InitializeComponent();
        }

        // Hàm này giúp th? t? thay d?i n?i dung khi du?c g?i
        public void NapDuLieu(string soPhong, string loai, bool coKhach, decimal donGia = 0)
        {
            lblTenPhong.Text = "Phòng: " + soPhong;
            lblLoaiPhong.Text = "Lo?i: " + loai;

            // N?u có giá t? database, s? d?ng giá dó. N?u không thì dùng giá m?c d?nh
            if (donGia > 0)
                lblGia.Text = "Giá: " + donGia.ToString("N0");
            else
                lblGia.Text = "Giá: 200.000";

            // Thay d?i màu s?c d?a trên tr?ng thái
            if (coKhach)
            {
                lblTrangThai.Text = "Ðang Thuê";
                lblTrangThai.BackColor = Color.Red; // Ð? cho d? nh?n bi?t
                lblTrangThai.ForeColor = Color.White;
            }
            else
            {
                lblTrangThai.Text = "Tr?ng";
                lblTrangThai.BackColor = Color.Lime;
                lblTrangThai.ForeColor = Color.Black;
            }
        }
    }
}