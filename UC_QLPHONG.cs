using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CK_AppKS
{
    public partial class UC_QUANLYP : UserControl
    {
        // ⚠️ Thay đổi chuỗi kết nối này cho khớp với máy của bạn
        private string connectionString = @"Data Source=.\SQL2025;Initial Catalog=QLKS;Integrated Security=True";

        private string selectedTrangThai = "Trống";

        public UC_QUANLYP()
        {
            InitializeComponent();
        }

        private void UC_QUANLYP_Load(object sender, EventArgs e)
        {
            selectedTrangThai = "Trống";

            SetupColumns();
            LoadComboBoxLoaiPhong(); // (1) Tải danh sách Loại phòng vào ComboBox trước
            LoadDataGridView();      // (2) Sau đó tải danh sách Phòng

            UpdateChipStyleTrangThai();
            UpdatePreview();
        }

        // ── 1. TẢI COMBOBOX ──────────────────────────────────────
        private void LoadComboBoxLoaiPhong()
        {
            string query = "SELECT MaLoaiPhong, LoaiPhong, DonGia FROM LOAIPHONG";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboLoaiPhong.DataSource = dt;
                    cboLoaiPhong.DisplayMember = "LoaiPhong"; // Hiện chữ (VD: Đơn, Đôi)
                    cboLoaiPhong.ValueMember = "MaLoaiPhong";    // Lưu mã (VD: 1, 2, 3)

                    cboLoaiPhong.SelectedIndex = -1; // Xóa lựa chọn mặc định
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách Loại Phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ── 1B. LẤY ĐƠN GIÁ THEO LOẠI PHÒNG ──────────────────────
        private decimal GetDonGiaByLoaiPhong(int maLoaiPhong)
        {
            string query = "SELECT DonGia FROM LOAIPHONG WHERE MaLoaiPhong = @MaLoaiPhong";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaLoaiPhong", maLoaiPhong);
                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            return Convert.ToDecimal(result);
                    }
                    catch { }
                }
            }
            return 0;
        }

        // ── 2. CỘT DATAGRIDVIEW ──────────────────────────────────
        private void SetupColumns()
        {
            dvgQuanLyPhong.Columns.Clear();

            dvgQuanLyPhong.Columns.Add(new DataGridViewTextBoxColumn { Name = "SoPhong", HeaderText = "SỐ PHÒNG", Width = 100 });
            dvgQuanLyPhong.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenLoaiPhong", HeaderText = "LOẠI PHÒNG", Width = 150 });
            dvgQuanLyPhong.Columns.Add(new DataGridViewTextBoxColumn { Name = "TrangThai", HeaderText = "TRẠNG THÁI", Width = 120 });

            var colDonGia = new DataGridViewTextBoxColumn { Name = "DonGia", HeaderText = "ĐƠN GIÁ", Width = 120 };
            colDonGia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dvgQuanLyPhong.Columns.Add(colDonGia);

            dvgQuanLyPhong.Columns.Add(new DataGridViewTextBoxColumn { Name = "GhiChu", HeaderText = "GHI CHÚ", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            // Thêm 1 cột ẨN để lưu MaLoaiPhong (Dùng cho thao tác gán ngược lên ComboBox)
            var colMaLoaiPhong = new DataGridViewTextBoxColumn { Name = "MaLoaiPhong", Visible = false };
            dvgQuanLyPhong.Columns.Add(colMaLoaiPhong);
        }

        // ── 3. TẢI DATAGRIDVIEW ──────────────────────────────────
        private void LoadDataGridView()
        {
            dvgQuanLyPhong.Rows.Clear();

            // Dùng JOIN để lấy tên loại phòng từ bảng LOAIPHONG
            string query = @"
                SELECT P.SoPhong, L.LoaiPhong, P.TrangThai, P.DonGia, P.GhiChu, P.MaLoaiPhong 
                FROM PHONG P 
                INNER JOIN LOAIPHONG L ON P.MaLoaiPhong = L.MaLoaiPhong
                ORDER BY P.SoPhong";

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
                                string soPhong = reader["SoPhong"].ToString();
                                string tenLoaiPhong = reader["LoaiPhong"].ToString();
                                string trangThai = reader["TrangThai"].ToString();
                                long donGia = Convert.ToInt64(reader["DonGia"]);
                                string ghiChu = reader["GhiChu"]?.ToString() ?? "";
                                string maLoaiPhong = reader["MaLoaiPhong"].ToString();

                                dvgQuanLyPhong.Rows.Add(soPhong, tenLoaiPhong, trangThai, $"{donGia:N0} đ", ghiChu, maLoaiPhong);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tải dữ liệu phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // ── 4. CHIP TRẠNG THÁI & PREVIEW ─────────────────────────
        private void UpdateChipStyleTrangThai()
        {
            Color active = Color.FromArgb(30, 120, 200);
            Color inactive = SystemColors.ButtonFace;

            btnTrong.BackColor = selectedTrangThai == "Trống" ? active : inactive;
            btnTrong.ForeColor = selectedTrangThai == "Trống" ? Color.White : SystemColors.ControlText;
            btnTrong.UseVisualStyleBackColor = selectedTrangThai != "Trống";

            btnThue.BackColor = selectedTrangThai == "Đang Thuê" ? active : inactive;
            btnThue.ForeColor = selectedTrangThai == "Đang Thuê" ? Color.White : SystemColors.ControlText;
            btnThue.UseVisualStyleBackColor = selectedTrangThai != "Đang Thuê";

            btnDonDep.BackColor = selectedTrangThai == "Đang Dọn Dẹp" ? active : inactive;
            btnDonDep.ForeColor = selectedTrangThai == "Đang Dọn Dẹp" ? Color.White : SystemColors.ControlText;
            btnDonDep.UseVisualStyleBackColor = selectedTrangThai != "Đang Dọn Dẹp";
        }

        private void UpdatePreview()
        {
            string loaiPhong = string.IsNullOrWhiteSpace(cboLoaiPhong.Text) ? "..." : cboLoaiPhong.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                lblPreview.Text = "Tham khảo";
                lblPreviewGia.Text = "0 đ";
            }
            else
            {
                lblPreview.Text = $"Tham khảo (Phòng {loaiPhong} - {selectedTrangThai})";
                lblPreviewGia.Text = txtDonGia.Text.Trim() + " đ";
            }
        }

        private void btnTrong_Click(object sender, EventArgs e) { selectedTrangThai = "Trống"; UpdateChipStyleTrangThai(); UpdatePreview(); }
        private void btnThue_Click(object sender, EventArgs e) { selectedTrangThai = "Đang Thuê"; UpdateChipStyleTrangThai(); UpdatePreview(); }
        private void btnDonDep_Click(object sender, EventArgs e) { selectedTrangThai = "Đang Dọn Dẹp"; UpdateChipStyleTrangThai(); UpdatePreview(); }

        private void txtDonGia_TextChanged(object sender, EventArgs e) { UpdatePreview(); }

        private void cboLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tự động gán đơn giá khi chọn loại phòng
            if (cboLoaiPhong.SelectedValue != null && int.TryParse(cboLoaiPhong.SelectedValue.ToString(), out int maLoaiPhong))
            {
                decimal donGia = GetDonGiaByLoaiPhong(maLoaiPhong);
                if (donGia > 0)
                    txtDonGia.Text = donGia.ToString("N0");
            }
            UpdatePreview();
        }

        // ── 5. THÊM ──────────────────────────────────────────────
        private void btnThem_Click(object sender, EventArgs e)
        {
            string soPhong = txtSoPhong.Text.Trim();
            if (string.IsNullOrWhiteSpace(soPhong))
            {
                MessageBox.Show("Vui lòng nhập số phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoPhong.Focus(); return;
            }

            if (cboLoaiPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Loại Phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiPhong.Focus(); return;
            }

            if (!long.TryParse(txtDonGia.Text.Trim().Replace(",", "").Replace(".", ""), out long donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus(); return;
            }

            int maLoaiPhong = Convert.ToInt32(cboLoaiPhong.SelectedValue);
            string ghiChu = txtGhiChu.Text.Trim();

            string query = "INSERT INTO PHONG (SoPhong, MaLoaiPhong, TrangThai, DonGia, GhiChu) VALUES (@SoPhong, @MaLoaiPhong, @TrangThai, @DonGia, @GhiChu)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SoPhong", soPhong);
                    cmd.Parameters.AddWithValue("@MaLoaiPhong", maLoaiPhong);
                    cmd.Parameters.AddWithValue("@TrangThai", selectedTrangThai);
                    cmd.Parameters.AddWithValue("@DonGia", donGia);
                    cmd.Parameters.AddWithValue("@GhiChu", ghiChu);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Thêm phòng '{soPhong}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        LoadDataGridView();
                    }
                    catch (SqlException sqlEx)
                    {
                        if (sqlEx.Number == 2627) MessageBox.Show($"Số phòng '{soPhong}' đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else MessageBox.Show("Lỗi Database: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // ── 6. SỬA ───────────────────────────────────────────────
        private void btnSua_Click(object sender, EventArgs e)
        {
            string soPhong = txtSoPhong.Text.Trim();
            if (string.IsNullOrWhiteSpace(soPhong) || cboLoaiPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng kiểm tra lại Số Phòng và Loại Phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(txtDonGia.Text.Trim().Replace(",", "").Replace(".", ""), out long donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maLoaiPhong = Convert.ToInt32(cboLoaiPhong.SelectedValue);
            string query = "UPDATE PHONG SET MaLoaiPhong = @MaLoaiPhong, TrangThai = @TrangThai, DonGia = @DonGia, GhiChu = @GhiChu WHERE SoPhong = @SoPhong";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SoPhong", soPhong);
                    cmd.Parameters.AddWithValue("@MaLoaiPhong", maLoaiPhong);
                    cmd.Parameters.AddWithValue("@TrangThai", selectedTrangThai);
                    cmd.Parameters.AddWithValue("@DonGia", donGia);
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());

                    try
                    {
                        conn.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataGridView();
                        }
                        else MessageBox.Show("Không tìm thấy phòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        // ── 7. XÓA ───────────────────────────────────────────────
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string soPhong = txtSoPhong.Text.Trim();
            if (string.IsNullOrWhiteSpace(soPhong))
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Xác nhận xóa phòng {soPhong}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            string query = "DELETE FROM PHONG WHERE SoPhong = @SoPhong";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SoPhong", soPhong);
                    try
                    {
                        conn.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                            LoadDataGridView();
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        // ── 8. LÀM MỚI & SỰ KIỆN KHÁC ────────────────────────────
        private void btnMoi_Click(object sender, EventArgs e) { ClearForm(); }

        private void dvgQuanLyPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dvgQuanLyPhong.Rows[e.RowIndex];

            txtSoPhong.Text = row.Cells["SoPhong"].Value?.ToString();

            // Lấy MaLoaiPhong từ cột ẩn, ép kiểu sang int và gán lại cho ComboBox
            if (int.TryParse(row.Cells["MaLoaiPhong"].Value?.ToString(), out int maLoaiPhong))
            {
                cboLoaiPhong.SelectedValue = maLoaiPhong;
            }

            selectedTrangThai = row.Cells["TrangThai"].Value?.ToString() ?? "Trống";
            txtDonGia.Text = row.Cells["DonGia"].Value?.ToString().Replace(" đ", "").Replace(",", "").Trim();
            txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();

            UpdateChipStyleTrangThai();
            UpdatePreview();
        }

        private void ClearForm()
        {
            txtSoPhong.Clear();
            txtDonGia.Clear();
            txtGhiChu.Clear();
            cboLoaiPhong.SelectedIndex = -1;
            selectedTrangThai = "Trống";

            UpdateChipStyleTrangThai();
            UpdatePreview();
        }

        private void lblSoPhong_Click(object sender, EventArgs e) { }
        private void txtSoPhong_TextChanged(object sender, EventArgs e) { }
    }
}