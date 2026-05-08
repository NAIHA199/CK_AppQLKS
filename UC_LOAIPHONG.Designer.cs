namespace CK_AppKS
{
    partial class UC_LOAIPHONG
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            dvgLoaiPhong = new DataGridView();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            lblLoaiPhong = new Label();
            pnlPreview = new Panel();
            lblPreview = new Label();
            lblPreviewGia = new Label();
            btnthem = new Button();
            btnSua = new Button();
            btnxoa = new Button();
            btnMoi = new Button();
            txtLoaiPhong = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgLoaiPhong).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlPreview.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dvgLoaiPhong);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 571);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 280);
            panel1.TabIndex = 0;
            // 
            // dvgLoaiPhong
            // 
            dvgLoaiPhong.AllowUserToAddRows = false;
            dvgLoaiPhong.AllowUserToDeleteRows = false;
            dvgLoaiPhong.BackgroundColor = SystemColors.ButtonHighlight;
            dvgLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgLoaiPhong.Dock = DockStyle.Fill;
            dvgLoaiPhong.Location = new Point(0, 0);
            dvgLoaiPhong.Name = "dvgLoaiPhong";
            dvgLoaiPhong.ReadOnly = true;
            dvgLoaiPhong.RowHeadersWidth = 51;
            dvgLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgLoaiPhong.Size = new Size(765, 280);
            dvgLoaiPhong.TabIndex = 0;
            dvgLoaiPhong.CellClick += dvgLoaiPhong_CellClick;
            dvgLoaiPhong.CellContentClick += dvgLoaiPhong_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(btnthem);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnxoa);
            panel2.Controls.Add(btnMoi);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(765, 532);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLoaiPhong);
            groupBox1.Controls.Add(lblDonGia);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(lblLoaiPhong);
            groupBox1.Controls.Add(pnlPreview);
            groupBox1.Location = new Point(18, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 390);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Phòng";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(26, 92);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(63, 20);
            lblDonGia.TabIndex = 2;
            lblDonGia.Text = "Đơn Giá";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(132, 85);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.PlaceholderText = "Nhập Đơn Giá";
            txtDonGia.Size = new Size(250, 27);
            txtDonGia.TabIndex = 3;
            txtDonGia.TextChanged += txtDonGia_TextChanged;
            // 
            // lblLoaiPhong
            // 
            lblLoaiPhong.AutoSize = true;
            lblLoaiPhong.Location = new Point(26, 52);
            lblLoaiPhong.Name = "lblLoaiPhong";
            lblLoaiPhong.Size = new Size(83, 20);
            lblLoaiPhong.TabIndex = 4;
            lblLoaiPhong.Text = "Loại Phòng";
            // 
            // pnlPreview
            // 
            pnlPreview.BackColor = Color.FromArgb(220, 235, 252);
            pnlPreview.Controls.Add(lblPreview);
            pnlPreview.Controls.Add(lblPreviewGia);
            pnlPreview.Location = new Point(26, 195);
            pnlPreview.Name = "pnlPreview";
            pnlPreview.Size = new Size(375, 60);
            pnlPreview.TabIndex = 8;
            // 
            // lblPreview
            // 
            lblPreview.AutoSize = true;
            lblPreview.ForeColor = Color.FromArgb(12, 68, 124);
            lblPreview.Location = new Point(12, 10);
            lblPreview.Name = "lblPreview";
            lblPreview.Size = new Size(82, 20);
            lblPreview.TabIndex = 0;
            lblPreview.Text = "Tham khảo";
            // 
            // lblPreviewGia
            // 
            lblPreviewGia.AutoSize = true;
            lblPreviewGia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPreviewGia.ForeColor = Color.FromArgb(24, 95, 165);
            lblPreviewGia.Location = new Point(230, 8);
            lblPreviewGia.Name = "lblPreviewGia";
            lblPreviewGia.Size = new Size(43, 28);
            lblPreviewGia.TabIndex = 1;
            lblPreviewGia.Text = "0 đ";
            // 
            // btnthem
            // 
            btnthem.Location = new Point(44, 457);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(90, 47);
            btnthem.TabIndex = 1;
            btnthem.Text = "+ Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(140, 457);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 47);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(236, 457);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(90, 47);
            btnxoa.TabIndex = 3;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnXoa_Click;
            // 
            // btnMoi
            // 
            btnMoi.Location = new Point(332, 457);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(90, 47);
            btnMoi.TabIndex = 4;
            btnMoi.Text = "↺ Mới";
            btnMoi.UseVisualStyleBackColor = true;
            btnMoi.Click += btnMoi_Click;
            // 
            // txtLoaiPhong
            // 
            txtLoaiPhong.Location = new Point(132, 49);
            txtLoaiPhong.Name = "txtLoaiPhong";
            txtLoaiPhong.PlaceholderText = "Nhập Loại Phòng";
            txtLoaiPhong.Size = new Size(250, 27);
            txtLoaiPhong.TabIndex = 9;
            // 
            // UC_LOAIPHONG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_LOAIPHONG";
            Size = new Size(765, 851);
            Load += UC_LOAIPHONG_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgLoaiPhong).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlPreview.ResumeLayout(false);
            pnlPreview.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dvgLoaiPhong;
        private GroupBox groupBox1;
        private Label lblSoPhong;
        private TextBox txtSoPhong;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private Label lblLoaiPhong;
        private Button btnDon;
        private Button btnDoi;
        private Button btnVip;
        private Panel pnlPreview;
        private Label lblPreview;
        private Label lblPreviewGia;
        private Button btnthem;
        private Button btnSua;
        private Button btnxoa;
        private Button btnMoi;
        private TextBox txtLoaiPhong;
    }
}