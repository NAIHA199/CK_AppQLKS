namespace CK_AppKS
{
    partial class UC_PHONG
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
            pnlLegend = new Panel();
            label3 = new Label();
            button3 = new Button();
            label2 = new Label();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            flpDanhSach = new FlowLayoutPanel();
            pnlLegend.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLegend
            // 
            pnlLegend.Controls.Add(label3);
            pnlLegend.Controls.Add(button3);
            pnlLegend.Controls.Add(label2);
            pnlLegend.Controls.Add(button2);
            pnlLegend.Controls.Add(label1);
            pnlLegend.Controls.Add(button1);
            pnlLegend.Dock = DockStyle.Top;
            pnlLegend.Location = new Point(0, 0);
            pnlLegend.Name = "pnlLegend";
            pnlLegend.Size = new Size(584, 40);
            pnlLegend.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 8);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 3;
            label3.Text = "Đạng Dọn Dẹp";
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Location = new Point(386, 10);
            button3.Name = "button3";
            button3.Size = new Size(49, 17);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 9);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "Đang Thuê";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(225, 11);
            button2.Name = "button2";
            button2.Size = new Size(49, 17);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 10);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "Phòng Trống";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(38, 12);
            button1.Name = "button1";
            button1.Size = new Size(49, 17);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // flpDanhSach
            // 
            flpDanhSach.AutoScroll = true;
            flpDanhSach.Dock = DockStyle.Fill;
            flpDanhSach.Location = new Point(0, 40);
            flpDanhSach.Name = "flpDanhSach";
            flpDanhSach.Size = new Size(584, 415);
            flpDanhSach.TabIndex = 3;
            flpDanhSach.Paint += flpDanhSach_Paint;
            // 
            // UC_PHONG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flpDanhSach);
            Controls.Add(pnlLegend);
            Name = "UC_PHONG";
            Size = new Size(584, 455);
            pnlLegend.ResumeLayout(false);
            pnlLegend.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLegend;
        private Label label3;
        private Button button3;
        private Label label2;
        private Button button2;
        private Label label1;
        private Button button1;
        private FlowLayoutPanel flpDanhSach;
    }
}
