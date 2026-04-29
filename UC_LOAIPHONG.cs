using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CK_AppKS
{
    public partial class UC_LOAIPHONG : UserControl
    {
        private string selectedLoaiPhong = "Đơn";

        // Danh sách lưu tạm trong RAM (sau này thay bằng database)
        private List<(string SoPhong, string LoaiPhong, long DonGia)> danhSach = new();

        public UC_LOAIPHONG()
        {
            InitializeComponent();
        }

        private void UC_LOAIPHONG_Load(object sender, EventArgs e)
        {
            selectedLoaiPhong = "Đơn";
            UpdateChipStyle();
            UpdatePreview();
            SetupColumns();
            LoadDataGridView();
        }

        // ── Cột DataGridView ─────────────────────────────────────
        private void SetupColumns()
        {
            dvgLoaiPhong.Columns.Clear();

            var colSoPhong = new DataGridViewTextBoxColumn();
            colSoPhong.Name = "SoPhong";
            colSoPhong.HeaderText = "SỐ PHÒNG";
            colSoPhong.Width = 180;

            var colLoaiPhong = new DataGridViewTextBoxColumn();
            colLoaiPhong.Name = "LoaiPhong";
            colLoaiPhong.HeaderText = "LOẠI PHÒNG";
            colLoaiPhong.Width = 200;

            var colDonGia = new DataGridViewTextBoxColumn();
            colDonGia.Name = "DonGia";
            colDonGia.HeaderText = "ĐƠN GIÁ";
            colDonGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDonGia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dvgLoaiPhong.Columns.AddRange(colSoPhong, colLoaiPhong, colDonGia);
        }

        // ── Tải dữ liệu vào grid ─────────────────────────────────
        private void LoadDataGridView()
        {
            dvgLoaiPhong.Rows.Clear();
            foreach (var item in danhSach)
                dvgLoaiPhong.Rows.Add(item.SoPhong, item.LoaiPhong, $"{item.DonGia:N0} đ");
        }

        // ── Chip loại phòng ──────────────────────────────────────
        private void UpdateChipStyle()
        {
            Color active = Color.FromArgb(30, 120, 200);
            Color inactive = SystemColors.ButtonFace;

            btnDon.BackColor = selectedLoaiPhong == "Đơn" ? active : inactive;
            btnDon.ForeColor = selectedLoaiPhong == "Đơn" ? Color.White : SystemColors.ControlText;
            btnDon.UseVisualStyleBackColor = selectedLoaiPhong != "Đơn";

            btnDoi.BackColor = selectedLoaiPhong == "Đôi" ? active : inactive;
            btnDoi.ForeColor = selectedLoaiPhong == "Đôi" ? Color.White : SystemColors.ControlText;
            btnDoi.UseVisualStyleBackColor = selectedLoaiPhong != "Đôi";

            btnVip.BackColor = selectedLoaiPhong == "Vip" ? active : inactive;
            btnVip.ForeColor = selectedLoaiPhong == "Vip" ? Color.White : SystemColors.ControlText;
            btnVip.UseVisualStyleBackColor = selectedLoaiPhong != "Vip";
        }

        // ── Preview giá tham khảo ────────────────────────────────
        private void UpdatePreview()
        {
            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                lblPreview.Text = "Tham khảo";
                lblPreviewGia.Text = "0 đ";
            }
            else
            {
                lblPreview.Text = $"Tham khảo (Phòng {selectedLoaiPhong})";
                lblPreviewGia.Text = txtDonGia.Text.Trim() + " đ";
            }
        }

        // ── Sự kiện chip ─────────────────────────────────────────
        private void btnDon_Click(object sender, EventArgs e)
        {
            selectedLoaiPhong = "Đơn";
            UpdateChipStyle();
            UpdatePreview();
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            selectedLoaiPhong = "Đôi";
            UpdateChipStyle();
            UpdatePreview();
        }

        private void btnVip_Click(object sender, EventArgs e)
        {
            selectedLoaiPhong = "Vip";
            UpdateChipStyle();
            UpdatePreview();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        // ── Thêm ─────────────────────────────────────────────────
        private void btnThem_Click(object sender, EventArgs e)
        {
            string soPhong = txtSoPhong.Text.Trim();

            if (string.IsNullOrWhiteSpace(soPhong))
            {
                MessageBox.Show("Vui lòng nhập số phòng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoPhong.Focus();
                return;
            }

            if (!long.TryParse(txtDonGia.Text.Trim().Replace(",", "").Replace(".", ""), out long donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            // Kiểm tra trùng số phòng
            if (danhSach.Exists(x => x.SoPhong.Equals(soPhong, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"Số phòng {soPhong} đã tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            danhSach.Add((soPhong, selectedLoaiPhong, donGia));
            MessageBox.Show($"Thêm phòng {soPhong} thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            LoadDataGridView();
        }

        // ── Sửa ──────────────────────────────────────────────────
        private void btnSua_Click(object sender, EventArgs e)
        {
            string soPhong = txtSoPhong.Text.Trim();
            if (string.IsNullOrWhiteSpace(soPhong))
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(txtDonGia.Text.Trim().Replace(",", "").Replace(".", ""), out long donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            int idx = danhSach.FindIndex(x => x.SoPhong.Equals(soPhong, StringComparison.OrdinalIgnoreCase));
            if (idx < 0)
            {
                MessageBox.Show("Không tìm thấy phòng để sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            danhSach[idx] = (soPhong, selectedLoaiPhong, donGia);
            MessageBox.Show("Cập nhật thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        // ── Xóa ──────────────────────────────────────────────────
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string soPhong = txtSoPhong.Text.Trim();
            if (string.IsNullOrWhiteSpace(soPhong))
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Xác nhận xóa phòng {soPhong}?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            int removed = danhSach.RemoveAll(x => x.SoPhong.Equals(soPhong, StringComparison.OrdinalIgnoreCase));
            if (removed > 0)
            {
                MessageBox.Show("Xóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadDataGridView();
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

            txtSoPhong.Text = row.Cells["SoPhong"].Value?.ToString() ?? "";
            selectedLoaiPhong = row.Cells["LoaiPhong"].Value?.ToString() ?? "Đơn";

            // Lấy đơn giá dạng số (bỏ " đ" và dấu phẩy)
            string giaRaw = row.Cells["DonGia"].Value?.ToString() ?? "";
            txtDonGia.Text = giaRaw.Replace(" đ", "").Replace(",", "").Trim();

            UpdateChipStyle();
            UpdatePreview();
        }

        // ── Xóa form ─────────────────────────────────────────────
        private void ClearForm()
        {
            txtSoPhong.Clear();
            txtDonGia.Clear();
            selectedLoaiPhong = "Đơn";
            UpdateChipStyle();
            UpdatePreview();
        }

        private void lblSoPhong_Click(object sender, EventArgs e)
        {

        }

        private void txtSoPhong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}