namespace CK_AppKS
{
    partial class UC_THEPHONG
    {
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
            panel1 = new Panel();
            lblGia = new Label();
            lblLoaiPhong = new Label();
            lblTenPhong = new Label();
            panel2 = new Panel();
            lblTrangThai = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(lblGia);
            panel1.Controls.Add(lblLoaiPhong);
            panel1.Controls.Add(lblTenPhong);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 129);
            panel1.TabIndex = 0;
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblGia.Location = new Point(14, 89);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(36, 23);
            lblGia.TabIndex = 2;
            lblGia.Text = "Giá";
            // 
            // lblLoaiPhong
            // 
            lblLoaiPhong.AutoSize = true;
            lblLoaiPhong.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblLoaiPhong.Location = new Point(14, 55);
            lblLoaiPhong.Name = "lblLoaiPhong";
            lblLoaiPhong.Size = new Size(99, 23);
            lblLoaiPhong.TabIndex = 1;
            lblLoaiPhong.Text = "Loại Phòng";
            // 
            // lblTenPhong
            // 
            lblTenPhong.AutoSize = true;
            lblTenPhong.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTenPhong.Location = new Point(14, 16);
            lblTenPhong.Name = "lblTenPhong";
            lblTenPhong.Size = new Size(61, 23);
            lblTenPhong.TabIndex = 0;
            lblTenPhong.Text = "Phòng";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 128);
            panel2.Controls.Add(lblTrangThai);
            panel2.Dock = DockStyle.Bottom;
            panel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            panel2.Location = new Point(0, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(268, 38);
            panel2.TabIndex = 1;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTrangThai.Location = new Point(14, 6);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(95, 23);
            lblTrangThai.TabIndex = 0;
            lblTrangThai.Text = "Trạng Thái";
            // 
            // UC_THEPHONG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_THEPHONG";
            Size = new Size(268, 167);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblGia;
        private Label lblLoaiPhong;
        private Label lblTrangThai;
        public Label lblTenPhong;
    }
}
