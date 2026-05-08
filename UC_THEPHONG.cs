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

        // Hàm này giúp thẻ tự thay đổi nội dung khi được gọi
        public void NapDuLieu(string soPhong, string loai, bool coKhach, decimal donGia = 0)
        {
            lblTenPhong.Text = "Phòng: " + soPhong;
            lblLoaiPhong.Text = "Loại: " + loai;

            // Nếu có giá từ database, sử dụng giá đó. Nếu không thì dùng giá mặc định
            if (donGia > 0)
                lblGia.Text = "Giá: " + donGia.ToString("N0");
            else
                lblGia.Text = "Giá: 200.000";

            // Thay đổi màu sắc dựa trên trạng thái
            if (coKhach)
            {
                lblTrangThai.Text = "Đang Thuê";
                lblTrangThai.BackColor = Color.Red; // Đỏ cho dễ nhận biết
                lblTrangThai.ForeColor = Color.White;
            }
            else
            {
                lblTrangThai.Text = "Trống";
                lblTrangThai.BackColor = Color.Lime; 
                lblTrangThai.ForeColor = Color.Black;
            }
        }
    }
}