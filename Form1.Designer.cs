namespace CK_AppKS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            flpMenu = new FlowLayoutPanel();
            lblGroupOpen = new Label();
            btnphong = new Button();
            btndatphong = new Button();
            btnkhachhang = new Button();
            lblGroupManager = new Label();
            btnqlphong = new Button();
            btnqlloaiphong = new Button();
            btnhoadon = new Button();
            btnbaocao = new Button();
            lblGroupClose = new Label();
            btntaikhoan = new Button();
            btndangxuat = new Button();
            btnthoat = new Button();
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlMain = new Panel();
            pnlSidebar.SuspendLayout();
            flpMenu.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Controls.Add(flpMenu);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(250, 866);
            pnlSidebar.TabIndex = 0;
            // 
            // flpMenu
            // 
            flpMenu.Controls.Add(lblGroupOpen);
            flpMenu.Controls.Add(btnphong);
            flpMenu.Controls.Add(btndatphong);
            flpMenu.Controls.Add(btnkhachhang);
            flpMenu.Controls.Add(lblGroupManager);
            flpMenu.Controls.Add(btnqlphong);
            flpMenu.Controls.Add(btnqlloaiphong);
            flpMenu.Controls.Add(btnhoadon);
            flpMenu.Controls.Add(btnbaocao);
            flpMenu.Controls.Add(lblGroupClose);
            flpMenu.Controls.Add(btntaikhoan);
            flpMenu.Controls.Add(btndangxuat);
            flpMenu.Controls.Add(btnthoat);
            flpMenu.Dock = DockStyle.Fill;
            flpMenu.FlowDirection = FlowDirection.TopDown;
            flpMenu.Location = new Point(0, 0);
            flpMenu.Name = "flpMenu";
            flpMenu.Size = new Size(250, 866);
            flpMenu.TabIndex = 0;
            flpMenu.WrapContents = false;
            // 
            // lblGroupOpen
            // 
            lblGroupOpen.AutoSize = true;
            lblGroupOpen.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGroupOpen.ForeColor = Color.Gray;
            lblGroupOpen.Location = new Point(3, 0);
            lblGroupOpen.Name = "lblGroupOpen";
            lblGroupOpen.Size = new Size(57, 23);
            lblGroupOpen.TabIndex = 0;
            lblGroupOpen.Text = "OPEN";
            // 
            // btnphong
            // 
            btnphong.FlatAppearance.BorderSize = 0;
            btnphong.FlatStyle = FlatStyle.Flat;
            btnphong.ImageAlign = ContentAlignment.MiddleLeft;
            btnphong.Location = new Point(3, 26);
            btnphong.Name = "btnphong";
            btnphong.Size = new Size(240, 50);
            btnphong.TabIndex = 11;
            btnphong.Text = "PHÒNG";
            btnphong.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnphong.UseVisualStyleBackColor = true;
            btnphong.Click += btnphong_Click_1;
            // 
            // btndatphong
            // 
            btndatphong.FlatAppearance.BorderSize = 0;
            btndatphong.FlatStyle = FlatStyle.Flat;
            btndatphong.ImageAlign = ContentAlignment.MiddleLeft;
            btndatphong.Location = new Point(3, 82);
            btndatphong.Name = "btndatphong";
            btndatphong.Size = new Size(240, 50);
            btndatphong.TabIndex = 12;
            btndatphong.Text = "ĐẶT PHÒNG";
            btndatphong.TextImageRelation = TextImageRelation.TextBeforeImage;
            btndatphong.UseVisualStyleBackColor = true;
            // 
            // btnkhachhang
            // 
            btnkhachhang.FlatAppearance.BorderSize = 0;
            btnkhachhang.FlatStyle = FlatStyle.Flat;
            btnkhachhang.ImageAlign = ContentAlignment.MiddleLeft;
            btnkhachhang.Location = new Point(3, 138);
            btnkhachhang.Name = "btnkhachhang";
            btnkhachhang.Size = new Size(240, 50);
            btnkhachhang.TabIndex = 13;
            btnkhachhang.Text = "KHÁCH HÀNG";
            btnkhachhang.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnkhachhang.UseVisualStyleBackColor = true;
            btnkhachhang.Click += btnkhachhang_Click;
            // 
            // lblGroupManager
            // 
            lblGroupManager.AutoSize = true;
            lblGroupManager.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGroupManager.ForeColor = Color.Gray;
            lblGroupManager.Location = new Point(3, 191);
            lblGroupManager.Name = "lblGroupManager";
            lblGroupManager.Size = new Size(100, 23);
            lblGroupManager.TabIndex = 4;
            lblGroupManager.Text = "MANAGER";
            // 
            // btnqlphong
            // 
            btnqlphong.FlatAppearance.BorderSize = 0;
            btnqlphong.FlatStyle = FlatStyle.Flat;
            btnqlphong.ImageAlign = ContentAlignment.MiddleLeft;
            btnqlphong.Location = new Point(3, 217);
            btnqlphong.Name = "btnqlphong";
            btnqlphong.Size = new Size(240, 50);
            btnqlphong.TabIndex = 14;
            btnqlphong.Text = "QL PHÒNG";
            btnqlphong.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnqlphong.UseVisualStyleBackColor = true;
            btnqlphong.Click += btnqlphong_Click;
            // 
            // btnqlloaiphong
            // 
            btnqlloaiphong.FlatAppearance.BorderSize = 0;
            btnqlloaiphong.FlatStyle = FlatStyle.Flat;
            btnqlloaiphong.ImageAlign = ContentAlignment.MiddleLeft;
            btnqlloaiphong.Location = new Point(3, 273);
            btnqlloaiphong.Name = "btnqlloaiphong";
            btnqlloaiphong.Size = new Size(240, 50);
            btnqlloaiphong.TabIndex = 15;
            btnqlloaiphong.Text = "QL LOẠI PHÒNG";
            btnqlloaiphong.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnqlloaiphong.UseVisualStyleBackColor = true;
            btnqlloaiphong.Click += btnqlloaiphong_Click;
            // 
            // btnhoadon
            // 
            btnhoadon.FlatAppearance.BorderSize = 0;
            btnhoadon.FlatStyle = FlatStyle.Flat;
            btnhoadon.ImageAlign = ContentAlignment.MiddleLeft;
            btnhoadon.Location = new Point(3, 329);
            btnhoadon.Name = "btnhoadon";
            btnhoadon.Size = new Size(240, 50);
            btnhoadon.TabIndex = 16;
            btnhoadon.Text = "QL HÓA ĐƠN";
            btnhoadon.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnhoadon.UseVisualStyleBackColor = true;
            btnhoadon.Click += btnhoadon_Click;
            // 
            // btnbaocao
            // 
            btnbaocao.FlatAppearance.BorderSize = 0;
            btnbaocao.FlatStyle = FlatStyle.Flat;
            btnbaocao.ImageAlign = ContentAlignment.MiddleLeft;
            btnbaocao.Location = new Point(3, 385);
            btnbaocao.Name = "btnbaocao";
            btnbaocao.Size = new Size(240, 50);
            btnbaocao.TabIndex = 17;
            btnbaocao.Text = "BÁO CÁO";
            btnbaocao.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnbaocao.UseVisualStyleBackColor = true;
            // 
            // lblGroupClose
            // 
            lblGroupClose.AutoSize = true;
            lblGroupClose.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGroupClose.ForeColor = Color.Gray;
            lblGroupClose.Location = new Point(3, 438);
            lblGroupClose.Name = "lblGroupClose";
            lblGroupClose.Size = new Size(62, 23);
            lblGroupClose.TabIndex = 10;
            lblGroupClose.Text = "CLOSE";
            // 
            // btntaikhoan
            // 
            btntaikhoan.FlatAppearance.BorderSize = 0;
            btntaikhoan.FlatStyle = FlatStyle.Flat;
            btntaikhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btntaikhoan.Location = new Point(3, 464);
            btntaikhoan.Name = "btntaikhoan";
            btntaikhoan.Size = new Size(240, 50);
            btntaikhoan.TabIndex = 18;
            btntaikhoan.Text = "TÀI KHOẢN";
            btntaikhoan.TextImageRelation = TextImageRelation.TextBeforeImage;
            btntaikhoan.UseVisualStyleBackColor = true;
            // 
            // btndangxuat
            // 
            btndangxuat.FlatAppearance.BorderSize = 0;
            btndangxuat.FlatStyle = FlatStyle.Flat;
            btndangxuat.ImageAlign = ContentAlignment.MiddleLeft;
            btndangxuat.Location = new Point(3, 520);
            btndangxuat.Name = "btndangxuat";
            btndangxuat.Size = new Size(240, 50);
            btndangxuat.TabIndex = 19;
            btndangxuat.Text = "ĐĂNG XUẤT";
            btndangxuat.TextImageRelation = TextImageRelation.TextBeforeImage;
            btndangxuat.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.FlatAppearance.BorderSize = 0;
            btnthoat.FlatStyle = FlatStyle.Flat;
            btnthoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnthoat.Location = new Point(3, 576);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(240, 50);
            btnthoat.TabIndex = 20;
            btnthoat.Text = "THOÁT";
            btnthoat.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.ControlLight;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(250, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1228, 60);
            pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(25, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(286, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "DANH MỤC CHỨC NĂNG";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.LightGray;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(250, 60);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1228, 806);
            pnlMain.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 866);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Khách Sạn";
            Load += Form1_Load;
            pnlSidebar.ResumeLayout(false);
            flpMenu.ResumeLayout(false);
            flpMenu.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlHeader;
        private FlowLayoutPanel flpMenu;
        private Label lblGroupOpen;
        private Panel pnlMain;
        private Label lblGroupManager;
        private Label lblGroupClose;
        private Label lblTitle;
        private Button btnphong;
        private Button btndatphong;
        private Button btnkhachhang;
        private Button btnqlphong;
        private Button btnqlloaiphong;
        private Button btnhoadon;
        private Button btnbaocao;
        private Button btntaikhoan;
        private Button btndangxuat;
        private Button btnthoat;
    }
}
