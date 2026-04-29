namespace CK_AppKS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showUserControl(UserControl uc)
        {
            pnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
            uc.BringToFront();
        }
        private void BoTronControl(Control control, int radius)
        {
            IntPtr ptr = CreateRoundRectRgn(0, 0, control.Width, control.Height, radius, radius);
            control.Region = System.Drawing.Region.FromHrgn(ptr);
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeft, int nTop, int nRight, int nBottom, int nWidth, int nHeight);

        private void Form1_Load(object sender, EventArgs e)
        {
            BoTronControl(btnphong, 15);
            BoTronControl(btndatphong, 15);
            BoTronControl(btnkhachhang, 15);
            BoTronControl(btnqlphong, 15);
            BoTronControl(btnqlloaiphong, 15);
            BoTronControl(btnhoadon, 15);
            BoTronControl(btnbaocao, 15);
            BoTronControl(btntaikhoan, 15);
            BoTronControl(btndangxuat, 15);
            BoTronControl(btnthoat, 15);
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UC_KHACHHANG uc = new UC_KHACHHANG();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }



        private void btnphong_Click_1(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UC_PHONG screen = new UC_PHONG();
            screen.Dock = DockStyle.Fill;


            screen.DoTheVaoPhong();

            pnlMain.Controls.Add(screen);
        }

        private void btnqlloaiphong_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            var uc = new UC_LOAIPHONG();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {

        }
    }
}
