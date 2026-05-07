using System;
using System.Windows.Forms;

namespace CK_AppQLKS
{
    public partial class UC_HoaDon : UserControl
    {
        // Đ? tr?ng cho Designer sinh code layout. Kéo th? tho?i mái trên Designer.
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panelLeft = new Panel();
            btnInPhieuThu = new Button();
            btnLichSu = new Button();
            lstHoaDon = new ListBox();
            txtSearch = new TextBox();
            lblTitle = new Label();
            panelRight = new Panel();
            btnXacNhan = new Button();
            btnXuatHD = new Button();
            groupChiPhi = new GroupBox();
            lblTongCong = new Label();
            lblGiamGia = new Label();
            lblThue = new Label();
            lblPhuThu = new Label();
            lblTienPhong = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupKhach = new GroupBox();
            lblCheckOut = new Label();
            lblCheckIn = new Label();
            lblSoNgayO = new Label();
            lblLoaiPhong = new Label();
            lblSoPhong = new Label();
            lblTenKH = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblMaHD = new Label();
            lblChiTiet = new Label();
            btnTrangThai = new Button();
            tableLayoutPanel1.SuspendLayout();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            groupChiPhi.SuspendLayout();
            groupKhach.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 340F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelLeft, 0, 0);
            tableLayoutPanel1.Controls.Add(panelRight, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(900, 500);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = SystemColors.ButtonHighlight;
            panelLeft.Controls.Add(btnInPhieuThu);
            panelLeft.Controls.Add(btnLichSu);
            panelLeft.Controls.Add(lstHoaDon);
            panelLeft.Controls.Add(txtSearch);
            panelLeft.Controls.Add(lblTitle);
            panelLeft.Dock = DockStyle.Fill;
            panelLeft.Location = new Point(3, 3);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(334, 494);
            panelLeft.TabIndex = 0;
            // 
            // btnInPhieuThu
            // 
            btnInPhieuThu.BackColor = SystemColors.ButtonFace;
            btnInPhieuThu.FlatStyle = FlatStyle.Flat;
            btnInPhieuThu.ForeColor = SystemColors.ControlText;
            btnInPhieuThu.Location = new Point(180, 440);
            btnInPhieuThu.Name = "btnInPhieuThu";
            btnInPhieuThu.Size = new Size(120, 36);
            btnInPhieuThu.TabIndex = 4;
            btnInPhieuThu.Text = "In phiếu thu";
            btnInPhieuThu.UseVisualStyleBackColor = true;
            // 
            // btnLichSu
            // 
            btnLichSu.BackColor = SystemColors.ButtonFace;
            btnLichSu.FlatStyle = FlatStyle.Flat;
            btnLichSu.ForeColor = SystemColors.ControlText;
            btnLichSu.Location = new Point(30, 440);
            btnLichSu.Name = "btnLichSu";
            btnLichSu.Size = new Size(120, 36);
            btnLichSu.TabIndex = 3;
            btnLichSu.Text = "Lịch sử";
            btnLichSu.UseVisualStyleBackColor = true;
            // 
            // lstHoaDon
            // 
            lstHoaDon.BackColor = SystemColors.ButtonHighlight;
            lstHoaDon.BorderStyle = BorderStyle.FixedSingle;
            lstHoaDon.Font = new Font("Segoe UI", 9F);
            lstHoaDon.ForeColor = SystemColors.ControlText;
            lstHoaDon.FormattingEnabled = true;
            lstHoaDon.Items.AddRange(new object[] { "Nguy?n Văn A - 3 đêm (Ch? thanh toán)", "HD002 – P205 | Tr?n Th? B - 1 đêm (Đang ?)", "HD003 – P312 | Lê Văn C - 2 đêm (Đ? thanh toán)", "HD004 – P410 | Ph?m Th? D - 4 đêm (Đang ?)", "HD005 – P502 | Hoàng Văn E - 2 đêm (Đang ?)", "HD006 – P118 | ĐB Th? F - 1 đêm (Ch? thanh toán)" });
            lstHoaDon.Location = new Point(20, 90);
            lstHoaDon.Name = "lstHoaDon";
            lstHoaDon.Size = new Size(280, 322);
            lstHoaDon.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.ButtonHighlight;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.ForeColor = SystemColors.ControlText;
            txtSearch.Location = new Point(20, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm hoá đơn...";
            txtSearch.Size = new Size(280, 27);
            txtSearch.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ControlText;
            lblTitle.Location = new Point(20, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(199, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "DANH SÁCH HOÁ ĐƠN";
            // 
            // panelRight
            // 
            panelRight.BackColor = SystemColors.ButtonHighlight;
            panelRight.Controls.Add(btnXacNhan);
            panelRight.Controls.Add(btnXuatHD);
            panelRight.Controls.Add(groupChiPhi);
            panelRight.Controls.Add(groupKhach);
            panelRight.Controls.Add(lblMaHD);
            panelRight.Controls.Add(lblChiTiet);
            panelRight.Controls.Add(btnTrangThai);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(343, 3);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(554, 494);
            panelRight.TabIndex = 1;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = SystemColors.ButtonFace;
            btnXacNhan.FlatStyle = FlatStyle.Flat;
            btnXacNhan.ForeColor = SystemColors.ControlText;
            btnXacNhan.Location = new Point(280, 430);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(220, 40);
            btnXacNhan.TabIndex = 6;
            btnXacNhan.Text = "Xác nhận thanh toán";
            btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // btnXuatHD
            // 
            btnXuatHD.BackColor = SystemColors.ButtonFace;
            btnXuatHD.FlatStyle = FlatStyle.Flat;
            btnXuatHD.ForeColor = SystemColors.ControlText;
            btnXuatHD.Location = new Point(40, 430);
            btnXuatHD.Name = "btnXuatHD";
            btnXuatHD.Size = new Size(180, 40);
            btnXuatHD.TabIndex = 5;
            btnXuatHD.Text = "Xuất hoá đơn";
            btnXuatHD.UseVisualStyleBackColor = true;
            // 
            // groupChiPhi
            // 
            groupChiPhi.BackColor = SystemColors.ButtonHighlight;
            groupChiPhi.Controls.Add(lblTongCong);
            groupChiPhi.Controls.Add(lblGiamGia);
            groupChiPhi.Controls.Add(lblThue);
            groupChiPhi.Controls.Add(lblPhuThu);
            groupChiPhi.Controls.Add(lblTienPhong);
            groupChiPhi.Controls.Add(label10);
            groupChiPhi.Controls.Add(label9);
            groupChiPhi.Controls.Add(label8);
            groupChiPhi.Controls.Add(label7);
            groupChiPhi.Controls.Add(label6);
            groupChiPhi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupChiPhi.ForeColor = SystemColors.ControlText;
            groupChiPhi.Location = new Point(20, 250);
            groupChiPhi.Name = "groupChiPhi";
            groupChiPhi.Size = new Size(500, 160);
            groupChiPhi.TabIndex = 4;
            groupChiPhi.TabStop = false;
            groupChiPhi.Text = "CHI PHÍ";
            // 
            // lblTongCong
            // 
            lblTongCong.AutoSize = true;
            lblTongCong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTongCong.ForeColor = Color.FromArgb(0, 162, 232);
            lblTongCong.Location = new Point(350, 120);
            lblTongCong.Name = "lblTongCong";
            lblTongCong.Size = new Size(101, 23);
            lblTongCong.TabIndex = 9;
            lblTongCong.Text = "2.820.000đ";
            // 
            // lblGiamGia
            // 
            lblGiamGia.AutoSize = true;
            lblGiamGia.ForeColor = Color.FromArgb(0, 200, 0);
            lblGiamGia.Location = new Point(350, 95);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new Size(82, 20);
            lblGiamGia.TabIndex = 8;
            lblGiamGia.Text = "-150.000đ";
            // 
            // lblThue
            // 
            lblThue.AutoSize = true;
            lblThue.ForeColor = SystemColors.ControlText;
            lblThue.Location = new Point(350, 70);
            lblThue.Name = "lblThue";
            lblThue.Size = new Size(76, 20);
            lblThue.TabIndex = 7;
            lblThue.Text = "220.000đ";
            // 
            // lblPhuThu
            // 
            lblPhuThu.AutoSize = true;
            lblPhuThu.ForeColor = SystemColors.ControlText;
            lblPhuThu.Location = new Point(350, 45);
            lblPhuThu.Name = "lblPhuThu";
            lblPhuThu.Size = new Size(76, 20);
            lblPhuThu.TabIndex = 6;
            lblPhuThu.Text = "350.000đ";
            // 
            // lblTienPhong
            // 
            lblTienPhong.AutoSize = true;
            lblTienPhong.ForeColor = SystemColors.ControlText;
            lblTienPhong.Location = new Point(350, 20);
            lblTienPhong.Name = "lblTienPhong";
            lblTienPhong.Size = new Size(89, 20);
            lblTienPhong.TabIndex = 5;
            lblTienPhong.Text = "2.400.000đ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(20, 120);
            label10.Name = "label10";
            label10.Size = new Size(95, 23);
            label10.TabIndex = 4;
            label10.Text = "Tổng cộng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.GrayText;
            label9.Location = new Point(20, 95);
            label9.Name = "label9";
            label9.Size = new Size(161, 20);
            label9.TabIndex = 3;
            label9.Text = "Giảm giá (thành viên)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.GrayText;
            label8.Location = new Point(20, 70);
            label8.Name = "label8";
            label8.Size = new Size(114, 20);
            label8.TabIndex = 2;
            label8.Text = "Thuế VAT (8%)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.GrayText;
            label7.Location = new Point(20, 45);
            label7.Name = "label7";
            label7.Size = new Size(198, 20);
            label7.TabIndex = 1;
            label7.Text = "Phí thu (dịch vụ, minibar...)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.GrayText;
            label6.Location = new Point(20, 20);
            label6.Name = "label6";
            label6.Size = new Size(231, 20);
            label6.TabIndex = 0;
            label6.Text = "Tiền phòng (3 đêm x 800.000đ)";
            // 
            // groupKhach
            // 
            groupKhach.BackColor = SystemColors.ButtonHighlight;
            groupKhach.Controls.Add(lblCheckOut);
            groupKhach.Controls.Add(lblCheckIn);
            groupKhach.Controls.Add(lblSoNgayO);
            groupKhach.Controls.Add(lblLoaiPhong);
            groupKhach.Controls.Add(lblSoPhong);
            groupKhach.Controls.Add(lblTenKH);
            groupKhach.Controls.Add(label5);
            groupKhach.Controls.Add(label4);
            groupKhach.Controls.Add(label3);
            groupKhach.Controls.Add(label2);
            groupKhach.Controls.Add(label1);
            groupKhach.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupKhach.ForeColor = SystemColors.ControlText;
            groupKhach.Location = new Point(20, 90);
            groupKhach.Name = "groupKhach";
            groupKhach.Size = new Size(500, 140);
            groupKhach.TabIndex = 3;
            groupKhach.TabStop = false;
            groupKhach.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCheckOut.ForeColor = SystemColors.ControlText;
            lblCheckOut.Location = new Point(370, 100);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(95, 20);
            lblCheckOut.TabIndex = 10;
            lblCheckOut.Text = "10/05/2026";
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCheckIn.ForeColor = SystemColors.ControlText;
            lblCheckIn.Location = new Point(120, 100);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(95, 20);
            lblCheckIn.TabIndex = 9;
            lblCheckIn.Text = "07/05/2026";
            // 
            // lblSoNgayO
            // 
            lblSoNgayO.AutoSize = true;
            lblSoNgayO.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSoNgayO.ForeColor = SystemColors.ControlText;
            lblSoNgayO.Location = new Point(370, 60);
            lblSoNgayO.Name = "lblSoNgayO";
            lblSoNgayO.Size = new Size(53, 20);
            lblSoNgayO.TabIndex = 8;
            lblSoNgayO.Text = "3 đêm";
            // 
            // lblLoaiPhong
            // 
            lblLoaiPhong.AutoSize = true;
            lblLoaiPhong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLoaiPhong.ForeColor = SystemColors.ControlText;
            lblLoaiPhong.Location = new Point(120, 60);
            lblLoaiPhong.Name = "lblLoaiPhong";
            lblLoaiPhong.Size = new Size(57, 20);
            lblLoaiPhong.TabIndex = 7;
            lblLoaiPhong.Text = "Deluxe";
            // 
            // lblSoPhong
            // 
            lblSoPhong.AutoSize = true;
            lblSoPhong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSoPhong.ForeColor = SystemColors.ControlText;
            lblSoPhong.Location = new Point(370, 25);
            lblSoPhong.Name = "lblSoPhong";
            lblSoPhong.Size = new Size(36, 20);
            lblSoPhong.TabIndex = 6;
            lblSoPhong.Text = "101";
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenKH.ForeColor = SystemColors.ControlText;
            lblTenKH.Location = new Point(120, 25);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(108, 20);
            lblTenKH.TabIndex = 5;
            lblTenKH.Text = "Nguy?n Văn A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(270, 100);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 4;
            label5.Text = "Check-out";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(20, 100);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "Check-in";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(270, 60);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Số ngày ở";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Loại phòng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Font = new Font("Segoe UI", 9F);
            lblMaHD.ForeColor = SystemColors.GrayText;
            lblMaHD.Location = new Point(20, 50);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(248, 20);
            lblMaHD.TabIndex = 2;
            lblMaHD.Text = "HD001 - Tạo lúc 08:30 – 07/05/2026";
            // 
            // lblChiTiet
            // 
            lblChiTiet.AutoSize = true;
            lblChiTiet.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblChiTiet.ForeColor = SystemColors.ControlText;
            lblChiTiet.Location = new Point(20, 20);
            lblChiTiet.Name = "lblChiTiet";
            lblChiTiet.Size = new Size(153, 25);
            lblChiTiet.TabIndex = 1;
            lblChiTiet.Text = "Chi tiết hoá đơn";
            // 
            // btnTrangThai
            // 
            btnTrangThai.BackColor = Color.FromArgb(255, 193, 7);
            btnTrangThai.FlatStyle = FlatStyle.Flat;
            btnTrangThai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTrangThai.ForeColor = Color.Black;
            btnTrangThai.Location = new Point(339, 20);
            btnTrangThai.Name = "btnTrangThai";
            btnTrangThai.Size = new Size(181, 32);
            btnTrangThai.TabIndex = 0;
            btnTrangThai.Text = "Chờ thanh toán";
            btnTrangThai.UseVisualStyleBackColor = false;
            // 
            // UC_HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_HoaDon";
            Size = new Size(900, 500);
            tableLayoutPanel1.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            groupChiPhi.ResumeLayout(false);
            groupChiPhi.PerformLayout();
            groupKhach.ResumeLayout(false);
            groupKhach.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lstHoaDon;
        private System.Windows.Forms.Button btnLichSu;
        private System.Windows.Forms.Button btnInPhieuThu;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblChiTiet;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Button btnTrangThai;
        private System.Windows.Forms.GroupBox groupKhach;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblSoNgayO;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupChiPhi;
        private System.Windows.Forms.Label lblTongCong;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblThue;
        private System.Windows.Forms.Label lblPhuThu;
        private System.Windows.Forms.Label lblTienPhong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXuatHD;
        private System.Windows.Forms.Button btnXacNhan;
    }
}
