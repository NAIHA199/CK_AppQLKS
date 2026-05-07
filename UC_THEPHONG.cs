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
        public void NapDuLieu(string soPhong, string loai, bool coKhach, long donGia)
        {
            lblTenPhong.Text = "Phòng: " + soPhong;
            lblLoaiPhong.Text = "Loại: " + loai;

            // Áp dụng đúng Quy định 1 (QĐ1)
            if (loai == "PHÒNG ĐƠN") lblGia.Text = "Giá: 150.000";
            else if (loai == "PHÒNG ĐÔI") lblGia.Text = "Giá: 170.000";
            else lblGia.Text = "Giá: 200.000";

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