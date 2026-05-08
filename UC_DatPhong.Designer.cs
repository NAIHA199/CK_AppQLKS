namespace CK_AppKS
{
    partial class UC_DatPhong
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label10 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            label13 = new Label();
            dateTimePicker3 = new DateTimePicker();
            label14 = new Label();
            dateTimePicker4 = new DateTimePicker();
            button1 = new Button();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label12 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            cbQuocTich = new ComboBox();
            cbLoaiKhach = new ComboBox();
            txtsocccd = new TextBox();
            txtsodienthoai = new TextBox();
            textBox1 = new TextBox();
            txthoten = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 146F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(990, 487);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 344);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(984, 140);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(cbQuocTich);
            groupBox1.Controls.Add(cbLoaiKhach);
            groupBox1.Controls.Add(txtsocccd);
            groupBox1.Controls.Add(txtsodienthoai);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(txthoten);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(984, 335);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi Tiết Đặt Phòng";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(comboBox1);
            flowLayoutPanel1.Controls.Add(label10);
            flowLayoutPanel1.Controls.Add(comboBox2);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(label13);
            flowLayoutPanel1.Controls.Add(dateTimePicker3);
            flowLayoutPanel1.Controls.Add(label14);
            flowLayoutPanel1.Controls.Add(dateTimePicker4);
            flowLayoutPanel1.Location = new Point(22, 235);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(564, 89);
            flowLayoutPanel1.TabIndex = 40;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(8, 12);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 41;
            label1.Text = "Loại Phòng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(81, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 39;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(208, 12);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 41;
            label10.Text = "Trạng Thái";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(277, 8);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 39;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(404, 8);
            button2.Name = "button2";
            button2.Size = new Size(98, 23);
            button2.TabIndex = 40;
            button2.Text = "Lọc";
            button2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Location = new Point(8, 40);
            label13.Margin = new Padding(3, 0, 18, 0);
            label13.Name = "label13";
            label13.Size = new Size(52, 15);
            label13.TabIndex = 41;
            label13.Text = "Từ Ngày";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            label13.Click += label13_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "dd/mm/yyyy";
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(81, 36);
            dateTimePicker3.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(121, 23);
            dateTimePicker3.TabIndex = 25;
            dateTimePicker3.Tag = "0,1,2,3,4,5,6,7,8,9,10";
            dateTimePicker3.Value = new DateTime(2026, 5, 5, 14, 7, 47, 0);
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Location = new Point(208, 40);
            label14.Margin = new Padding(3, 0, 7, 0);
            label14.Name = "label14";
            label14.Size = new Size(59, 15);
            label14.TabIndex = 41;
            label14.Text = "Đến Ngày";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            label14.Click += label13_Click;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.CustomFormat = "dd/mm/yyyy";
            dateTimePicker4.Format = DateTimePickerFormat.Short;
            dateTimePicker4.Location = new Point(277, 36);
            dateTimePicker4.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(121, 23);
            dateTimePicker4.TabIndex = 25;
            dateTimePicker4.Tag = "0,1,2,3,4,5,6,7,8,9,10";
            dateTimePicker4.Value = new DateTime(2026, 5, 5, 14, 7, 47, 0);
            // 
            // button1
            // 
            button1.Location = new Point(594, 283);
            button1.Name = "button1";
            button1.Size = new Size(114, 41);
            button1.TabIndex = 38;
            button1.Text = "Xác Nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(396, 135);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 37;
            label11.Text = "Ngày Trả";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(395, 173);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 36;
            label9.Text = "Số Khách";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 211);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 35;
            label8.Text = "Giới Tính";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(395, 101);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 34;
            label7.Text = "Ngày Nhận";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 171);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 33;
            label6.Text = "Quốc Tịch";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(396, 69);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 32;
            label5.Text = "Loại Khách";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 137);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 31;
            label4.Text = "Số CCCD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 105);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 30;
            label3.Text = "SĐT";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 34);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 29;
            label12.Text = "Số Phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 71);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 29;
            label2.Text = "Họ Tên";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(488, 169);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(219, 23);
            numericUpDown1.TabIndex = 28;
            numericUpDown1.Tag = "0,1,2,3,4,5,6,7,8,9,10";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(189, 208);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(41, 19);
            radioButton2.TabIndex = 27;
            radioButton2.TabStop = true;
            radioButton2.Tag = "0,1,2,3,4,5,6,7,8,9,10";
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(115, 209);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 26;
            radioButton1.TabStop = true;
            radioButton1.Tag = "0,1,2,3,4,5,6,7,8,9,10";
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(488, 131);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(219, 23);
            dateTimePicker2.TabIndex = 25;
            dateTimePicker2.Tag = "0,1,2,3,4,5,6,7,8,9,10";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(488, 97);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 25;
            dateTimePicker1.Tag = "0,1,2,3,4,5,6,7,8,9,10";
            // 
            // cbQuocTich
            // 
            cbQuocTich.DropDownStyle = ComboBoxStyle.DropDownList;
            cbQuocTich.FormattingEnabled = true;
            cbQuocTich.Items.AddRange(new object[] { "Việt Nam", "Khác" });
            cbQuocTich.Location = new Point(115, 165);
            cbQuocTich.Margin = new Padding(3, 2, 3, 2);
            cbQuocTich.Name = "cbQuocTich";
            cbQuocTich.Size = new Size(219, 23);
            cbQuocTich.TabIndex = 24;
            cbQuocTich.Tag = "0,1,2,3,4,5,6,7,8,9,10";
            // 
            // cbLoaiKhach
            // 
            cbLoaiKhach.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoaiKhach.FormattingEnabled = true;
            cbLoaiKhach.Items.AddRange(new object[] { "Nội Địa ", "Nước Ngoài" });
            cbLoaiKhach.Location = new Point(488, 63);
            cbLoaiKhach.Margin = new Padding(3, 2, 3, 2);
            cbLoaiKhach.Name = "cbLoaiKhach";
            cbLoaiKhach.Size = new Size(219, 23);
            cbLoaiKhach.TabIndex = 23;
            cbLoaiKhach.Tag = "0,1,2,3,4,5,6,7,8,9,10";
            // 
            // txtsocccd
            // 
            txtsocccd.Location = new Point(116, 132);
            txtsocccd.Margin = new Padding(3, 2, 3, 2);
            txtsocccd.Name = "txtsocccd";
            txtsocccd.PlaceholderText = "Nhập Số CCCD";
            txtsocccd.Size = new Size(219, 23);
            txtsocccd.TabIndex = 22;
            txtsocccd.Tag = "0,1,2,3,4,5,6,7,8,9,10";
            // 
            // txtsodienthoai
            // 
            txtsodienthoai.Location = new Point(116, 100);
            txtsodienthoai.Margin = new Padding(3, 2, 3, 2);
            txtsodienthoai.Name = "txtsodienthoai";
            txtsodienthoai.PlaceholderText = "Nhập Số Điện Thoại";
            txtsodienthoai.Size = new Size(219, 23);
            txtsodienthoai.TabIndex = 21;
            txtsodienthoai.Tag = "0,1,2,3,4,5,6,7,8,9,10";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(116, 31);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 23);
            textBox1.TabIndex = 20;
            textBox1.Tag = "0,1,2,3,4,5,6,7,8,9,10";
            // 
            // txthoten
            // 
            txthoten.Location = new Point(116, 66);
            txthoten.Margin = new Padding(3, 2, 3, 2);
            txthoten.Name = "txthoten";
            txthoten.PlaceholderText = "Nhập Họ Và Tên";
            txthoten.Size = new Size(219, 23);
            txthoten.TabIndex = 20;
            txthoten.Tag = "0,1,2,3,4,5,6,7,8,9,10";
            // 
            // UC_DatPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_DatPhong";
            Size = new Size(990, 487);
            Load += UC_DatPhong_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbQuocTich;
        private ComboBox cbLoaiKhach;
        private TextBox txtsocccd;
        private TextBox txtsodienthoai;
        private TextBox txthoten;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button2;
        private Label label1;
        private Label label10;
        private Label label13;
        private DateTimePicker dateTimePicker3;
        private Label label12;
        private TextBox textBox1;
        private Label label14;
        private DateTimePicker dateTimePicker4;
    }
}
