using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;

namespace CK_AppKS
{
    public partial class UC_LOAIPHONG : UserControl
    {
        // Chuỗi kết nối Database của bạn (nhớ sửa lại nếu cần)
        private string connectionString = @"Data Source=.\SQL2025;Initial Catalog=QLKS;Integrated Security=True";

        public UC_LOAIPHONG()
        {
            InitializeComponent();
        }

        private void UC_LOAIPHONG_Load(object sender, EventArgs e)
        {
            UpdatePreview();
            SetupColumns();
            LoadDataGridView(); // Lấy dữ liệu từ SQL khi form load
        }

        // ── Cột DataGridView ─────────────────────────────────────
        private void SetupColumns()
        {
            dvgLoaiPhong.Columns.Clear();

            var colLoaiPhong = new DataGridViewTextBoxColumn();
            colLoaiPhong.Name = "LoaiPhong";
            colLoaiPhong.HeaderText = "LOẠI PHÒNG";
            colLoaiPhong.Width = 200;

            var colDonGia = new DataGridViewTextBoxColumn();
            colDonGia.Name = "DonGia";
            colDonGia.HeaderText = "ĐƠN GIÁ";
            colDonGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDonGia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dvgLoaiPhong.Columns.AddRange(colLoaiPhong, colDonGia);
        }

        // ── Tải dữ liệu từ SQL vào grid ──────────────────────────
        private void LoadDataGridView()
        {
            dvgLoaiPhong.Rows.Clear();
            string query = "SELECT LoaiPhong, DonGia FROM LOAIPHONG"; // Thay đổi tên bảng/cột nếu cần

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string loai = reader["LoaiPhong"].ToString();
                                long gia = Convert.ToInt64(reader["DonGia"]);
                                dvgLoaiPhong.Rows.Add(loai, $"{gia:N0} đ");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải dữ liệu từ Database: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // ── Preview giá tham khảo ────────────────────────────────
        private void UpdatePreview()
        {
            string loaiPhong = string.IsNullOrWhiteSpace(txtLoaiPhong.Text) ? "..." : txtLoaiPhong.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                lblPreview.Text = "Tham khảo";
                lblPreviewGia.Text = "0 đ";
            }
            else
            {
                lblPreview.Text = $"Tham khảo (Phòng {loaiPhong})";
                lblPreviewGia.Text = txtDonGia.Text.Trim() + " đ";
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        // Nếu bạn muốn preview cập nhật cả khi gõ loại phòng, hãy gán event TextChanged của txtLoaiPhong vào đây
        private void txtLoaiPhong_TextChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        // ── Thêm loại phòng vào SQL ──────────────────────────────
        private void btnThem_Click(object sender, EventArgs e)
        {
            string loaiPhong = txtLoaiPhong.Text.Trim();

            if (string.IsNullOrEmpty(loaiPhong))
            {
                MessageBox.Show("Vui lòng nhập Loại Phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoaiPhong.Focus();
                return;
            }

            if (!long.TryParse(txtDonGia.Text.Trim().Replace(",", "").Replace(".", ""), out long donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            string query = "INSERT INTO LOAIPHONG (LoaiPhong, DonGia) VALUES (@LoaiPhong, @DonGia)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LoaiPhong", loaiPhong);
                    cmd.Parameters.AddWithValue("@DonGia", donGia);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Thêm loại phòng '{loaiPhong}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearForm();
                        LoadDataGridView(); // Tải lại grid
                    }
                    catch (SqlException sqlEx)
                    {
                        if (sqlEx.Number == 2627) // Lỗi trùng khóa chính
                            MessageBox.Show($"Loại phòng '{loaiPhong}' đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            MessageBox.Show("Lỗi Database: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // ── Sửa loại phòng trong SQL ─────────────────────────────
        private void btnSua_Click(object sender, EventArgs e)
        {
            string loaiPhong = txtLoaiPhong.Text.Trim();

            if (string.IsNullOrEmpty(loaiPhong))
            {
                MessageBox.Show("Vui lòng nhập/chọn Loại Phòng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(txtDonGia.Text.Trim().Replace(",", "").Replace(".", ""), out long donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            string query = "UPDATE LOAIPHONG SET DonGia = @DonGia WHERE LoaiPhong = @LoaiPhong";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DonGia", donGia);
                    cmd.Parameters.AddWithValue("@LoaiPhong", loaiPhong);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy loại phòng này để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // ── Xóa loại phòng khỏi SQL ──────────────────────────────
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string loaiPhong = txtLoaiPhong.Text.Trim();

            if (string.IsNullOrEmpty(loaiPhong))
            {
                MessageBox.Show("Vui lòng nhập/chọn Loại Phòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Xác nhận xóa loại phòng '{loaiPhong}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            string query = "DELETE FROM LOAIPHONG WHERE LoaiPhong = @LoaiPhong";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LoaiPhong", loaiPhong);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                            LoadDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy loại phòng này để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // ── Làm mới ──────────────────────────────────────────────
        private void btnMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // ── Click vào hàng grid → điền vào form ──────────────────
        private void dvgLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dvgLoaiPhong.Rows[e.RowIndex];

            // Lấy tên loại phòng và đơn giá từ DataGridView đẩy ngược lên TextBox
            txtLoaiPhong.Text = row.Cells["LoaiPhong"].Value?.ToString() ?? "";

            string giaRaw = row.Cells["DonGia"].Value?.ToString() ?? "";
            txtDonGia.Text = giaRaw.Replace(" đ", "").Replace(",", "").Replace(".", "").Trim();

            UpdatePreview();
        }

        // ── Xóa form ─────────────────────────────────────────────
        private void ClearForm()
        {
            txtLoaiPhong.Clear();
            txtDonGia.Clear();
            txtLoaiPhong.Focus();
            UpdatePreview();
        }

        private void lblSoPhong_Click(object sender, EventArgs e) { }
        private void txtSoPhong_TextChanged(object sender, EventArgs e) { }
        private void dvgLoaiPhong_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}