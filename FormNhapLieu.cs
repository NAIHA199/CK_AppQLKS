using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CK_AppKS
{
    public partial class FormNhapLieu : Form
    {
        private string connectionString = @"Data Source=.\SQL2025;Initial Catalog=QLKS;Integrated Security=True";

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SelectedRoom { get; set; }

        public FormNhapLieu()
        {
            InitializeComponent();
        }

        private void FormNhapLieu_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SelectedRoom))
            {
                LoadRoomData(SelectedRoom);
            }
        }

        /// <summary>
        /// Lấy dữ liệu phòng từ database và hiển thị lên Form
        /// </summary>
        private void LoadRoomData(string soPhong)
        {
            string query = @"
                SELECT P.SoPhong, L.LoaiPhong, P.TrangThai, L.DonGia, P.GhiChu
                FROM PHONG P
                INNER JOIN LOAIPHONG L ON P.MaLoaiPhong = L.MaLoaiPhong
                WHERE P.SoPhong = @SoPhong";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SoPhong", soPhong);
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBox1.Text = reader["SoPhong"].ToString();
                                textBox4.Text = reader["LoaiPhong"].ToString();
                                textBox3.Text = reader["TrangThai"].ToString();
                                textBox5.Text = reader["DonGia"].ToString();
                                textBox2.Text = reader["GhiChu"]?.ToString() ?? "";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

