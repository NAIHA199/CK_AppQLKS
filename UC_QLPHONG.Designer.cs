
namespace CK_AppKS
{
    partial class UC_QUANLYP
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
            dvgQuanLyPhong = new DataGridView();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            cboLoaiPhong = new ComboBox();
            lblSoPhong = new Label();
            txtSoPhong = new TextBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            lblLoaiPhong = new Label();
            lblTrangThai = new Label();
            btnTrong = new Button();
            btnThue = new Button();
            btnDonDep = new Button();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            pnlPreview = new Panel();
            lblPreview = new Label();
            lblPreviewGia = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnMoi = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgQuanLyPhong).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlPreview.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dvgQuanLyPhong);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 610);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 241);
            panel1.TabIndex = 0;
            // 
            // dvgQuanLyPhong
            // 
            dvgQuanLyPhong.AllowUserToAddRows = false;
            dvgQuanLyPhong.AllowUserToDeleteRows = false;
            dvgQuanLyPhong.BackgroundColor = SystemColors.ButtonHighlight;
            dvgQuanLyPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgQuanLyPhong.Dock = DockStyle.Fill;
            dvgQuanLyPhong.Location = new Point(0, 0);
            dvgQuanLyPhong.Name = "dvgQuanLyPhong";
            dvgQuanLyPhong.ReadOnly = true;
            dvgQuanLyPhong.RowHeadersWidth = 51;
            dvgQuanLyPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgQuanLyPhong.Size = new Size(765, 241);
            dvgQuanLyPhong.TabIndex = 0;
            dvgQuanLyPhong.CellClick += dvgQuanLyPhong_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnMoi);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(765, 520);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboLoaiPhong);
            groupBox1.Controls.Add(lblSoPhong);
            groupBox1.Controls.Add(txtSoPhong);
            groupBox1.Controls.Add(lblDonGia);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(lblLoaiPhong);
            groupBox1.Controls.Add(lblTrangThai);
            groupBox1.Controls.Add(btnTrong);
            groupBox1.Controls.Add(btnThue);
            groupBox1.Controls.Add(btnDonDep);
            groupBox1.Controls.Add(lblGhiChu);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(pnlPreview);
            groupBox1.Location = new Point(18, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 368);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Phòng";
            // 
            // cboLoaiPhong
            // 
            cboLoaiPhong.FormattingEnabled = true;
            cboLoaiPhong.Location = new Point(132, 137);
            cboLoaiPhong.Name = "cboLoaiPhong";
            cboLoaiPhong.Size = new Size(250, 28);
            cboLoaiPhong.TabIndex = 12;
            cboLoaiPhong.SelectedIndexChanged += cboLoaiPhong_SelectedIndexChanged;
            // 
            // lblSoPhong
            // 
            lblSoPhong.AutoSize = true;
            lblSoPhong.Location = new Point(26, 44);
            lblSoPhong.Name = "lblSoPhong";
            lblSoPhong.Size = new Size(72, 20);
            lblSoPhong.TabIndex = 0;
            lblSoPhong.Text = "Số Phòng";
            lblSoPhong.Click += lblSoPhong_Click;
            // 
            // txtSoPhong
            // 
            txtSoPhong.Location = new Point(132, 37);
            txtSoPhong.Name = "txtSoPhong";
            txtSoPhong.PlaceholderText = "Nhập Số Phòng";
            txtSoPhong.Size = new Size(250, 27);
            txtSoPhong.TabIndex = 1;
            txtSoPhong.TextChanged += txtSoPhong_TextChanged;
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
            lblLoaiPhong.Location = new Point(26, 142);
            lblLoaiPhong.Name = "lblLoaiPhong";
            lblLoaiPhong.Size = new Size(83, 20);
            lblLoaiPhong.TabIndex = 4;
            lblLoaiPhong.Text = "Loại Phòng";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(26, 190);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(78, 20);
            lblTrangThai.TabIndex = 8;
            lblTrangThai.Text = "Trạng Thái";
            // 
            // btnTrong
            // 
            btnTrong.BackColor = Color.FromArgb(30, 120, 200);
            btnTrong.ForeColor = Color.White;
            btnTrong.Location = new Point(132, 181);
            btnTrong.Name = "btnTrong";
            btnTrong.Size = new Size(82, 34);
            btnTrong.TabIndex = 9;
            btnTrong.Text = "Trống";
            btnTrong.UseVisualStyleBackColor = false;
            btnTrong.Click += btnTrong_Click;
            // 
            // btnThue
            // 
            btnThue.Location = new Point(222, 181);
            btnThue.Name = "btnThue";
            btnThue.Size = new Size(82, 34);
            btnThue.TabIndex = 10;
            btnThue.Text = "Đang Thuê";
            btnThue.UseVisualStyleBackColor = true;
            btnThue.Click += btnThue_Click;
            // 
            // btnDonDep
            // 
            btnDonDep.Location = new Point(312, 181);
            btnDonDep.Name = "btnDonDep";
            btnDonDep.Size = new Size(100, 34);
            btnDonDep.TabIndex = 11;
            btnDonDep.Text = "Đang Dọn Dẹp";
            btnDonDep.UseVisualStyleBackColor = true;
            btnDonDep.Click += btnDonDep_Click;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(26, 230);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(60, 20);
            lblGhiChu.TabIndex = 13;
            lblGhiChu.Text = "Ghi Chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(132, 223);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.PlaceholderText = "Nhập ghi chú";
            txtGhiChu.Size = new Size(250, 54);
            txtGhiChu.TabIndex = 14;
            // 
            // pnlPreview
            // 
            pnlPreview.BackColor = Color.FromArgb(220, 235, 252);
            pnlPreview.Controls.Add(lblPreview);
            pnlPreview.Controls.Add(lblPreviewGia);
            pnlPreview.Location = new Point(27, 283);
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
            // btnThem
            // 
            btnThem.Location = new Point(32, 489);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 47);
            btnThem.TabIndex = 1;
            btnThem.Text = "+ Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(162, 489);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 47);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(292, 489);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 47);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnMoi
            // 
            btnMoi.Location = new Point(422, 489);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(110, 47);
            btnMoi.TabIndex = 4;
            btnMoi.Text = "↺ Mới";
            btnMoi.UseVisualStyleBackColor = true;
            btnMoi.Click += btnMoi_Click;
            // 
            // UC_QUANLYP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_QUANLYP";
            Size = new Size(765, 851);
            Load += UC_QUANLYP_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgQuanLyPhong).EndInit();
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
        private DataGridView dvgQuanLyPhong;
        private GroupBox groupBox1;
        private Label lblSoPhong;
        private TextBox txtSoPhong;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private Label lblLoaiPhong;
        private Button btnDon;
        private Button btnDoi;
        private Button btnVip;
        private Label lblTrangThai;
        private Button btnTrong;
        private Button btnThue;
        private Button btnDonDep;
        private Panel pnlPreview;
        private Label lblPreview;
        private Label lblPreviewGia;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnMoi;
        private ComboBox comboBox1;
        private ComboBox cboLoaiPhong;
        private Label lblGhiChu;
        private TextBox txtGhiChu;
    }
}
