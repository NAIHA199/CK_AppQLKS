using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;

namespace CK_AppKS
{
    public partial class UC_KHACHHANG : UserControl
    {
        private int selectedMaKhachHang = 0;
        private List<DataRow> danhSachKhachHang = new List<DataRow>();
        private bool isEditMode = false;

        public UC_KHACHHANG()
        {
            InitializeComponent();
        }

        private void UC_KHACHHANG_Load(object sender, EventArgs e)
        {
            try
            {
                // Setup DataGridView
                SetupDataGridView();

                // Load tất cả khách hàng khi load UC
                LoadAllKhachHang();

                // Disable form khi chưa chọn khách hàng
                DisableForm();

                // Setup sự kiện
                btntimkiem.Click += BtnTimKiem_Click;
                btnsua.Click += BtnSua_Click;
                btnluu.Click += BtnLuu_Click;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Setup DataGridView columns
        private void SetupDataGridView()
        {
            dvgKhachHang.Columns.Clear();

            var colHoTen = new DataGridViewTextBoxColumn();
            colHoTen.Name = "HoTen";
            colHoTen.HeaderText = "HỌ TÊN";
            colHoTen.Width = 120;

            var colSDT = new DataGridViewTextBoxColumn();
            colSDT.Name = "SDT";
            colSDT.HeaderText = "SĐT";
            colSDT.Width = 100;

            var colMaPhong = new DataGridViewTextBoxColumn();
            colMaPhong.Name = "MaPhong";
            colMaPhong.HeaderText = "SỐ PHÒNG";
            colMaPhong.Width = 100;

            var colTenLoaiPhong = new DataGridViewTextBoxColumn();
            colTenLoaiPhong.Name = "TenLoaiPhong";
            colTenLoaiPhong.HeaderText = "LOẠI PHÒNG";
            colTenLoaiPhong.Width = 100;

            var colNgayNhan = new DataGridViewTextBoxColumn();
            colNgayNhan.Name = "NgayNhan";
            colNgayNhan.HeaderText = "NGÀY NHẬN";
            colNgayNhan.Width = 100;

            var colNgayTra = new DataGridViewTextBoxColumn();
            colNgayTra.Name = "NgayTra";
            colNgayTra.HeaderText = "NGÀY TRẢ";
            colNgayTra.Width = 100;

            dvgKhachHang.Columns.AddRange(colHoTen, colSDT, colMaPhong, colTenLoaiPhong, colNgayNhan, colNgayTra);

            dvgKhachHang.CellClick += DvgKhachHang_CellClick;
        }

        // Load tất cả khách hàng
        private void LoadAllKhachHang()
        {
            try
            {
                danhSachKhachHang.Clear();
                dvgKhachHang.Rows.Clear();

                string sql = @"SELECT k.MaKhachHang, k.HoTen, k.SDT, k.SoCCCD, k.GioiTinh, k.LoaiKhach, k.QuocTich, 
                                     k.NgayNhan, k.SoKhach, k.NgayTra, p.TenPhong, lp.TenLoaiPhong
                            FROM dbo.KhachHang k
                            LEFT JOIN dbo.PhieuThue pt ON k.MaKhachHang = pt.MaKhachHang
                            LEFT JOIN dbo.Phong p ON pt.MaPhong = p.MaPhong
                            LEFT JOIN dbo.LoaiPhong lp ON p.MaLoaiPhong = lp.MaLoaiPhong
                            ORDER BY k.MaKhachHang DESC";

                DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        danhSachKhachHang.Add(row);
                        AddRowToGridView(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thêm dòng vào GridView
        private void AddRowToGridView(DataRow row)
        {
            dvgKhachHang.Rows.Add(
                row["HoTen"]?.ToString() ?? "",
                row["SDT"]?.ToString() ?? "",
                row["TenPhong"]?.ToString() ?? "",
                row["TenLoaiPhong"]?.ToString() ?? "",
                row["NgayNhan"] != DBNull.Value ? Convert.ToDateTime(row["NgayNhan"]).ToString("dd/MM/yyyy") : "",
                row["NgayTra"] != DBNull.Value ? Convert.ToDateTime(row["NgayTra"]).ToString("dd/MM/yyyy") : ""
            );
        }

        // Tìm kiếm khách hàng
        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string hoTen = textBox1.Text.Trim();
                string sdt = textBox2.Text.Trim();

                if (string.IsNullOrEmpty(hoTen) && string.IsNullOrEmpty(sdt))
                {
                    MessageBox.Show("Vui lòng nhập Họ Tên hoặc SĐT để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dvgKhachHang.Rows.Clear();

                foreach (DataRow row in danhSachKhachHang)
                {
                    string rowHoTen = row["HoTen"]?.ToString() ?? "";
                    string rowSDT = row["SDT"]?.ToString() ?? "";

                    bool matchHoTen = string.IsNullOrEmpty(hoTen) || rowHoTen.Contains(hoTen);
                    bool matchSDT = string.IsNullOrEmpty(sdt) || rowSDT.Contains(sdt);

                    if (matchHoTen && matchSDT)
                    {
                        AddRowToGridView(row);
                    }
                }

                if (dvgKhachHang.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click vào hàng trong GridView
        private void DvgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow selectedRow = dvgKhachHang.Rows[e.RowIndex];
                string hoTen = selectedRow.Cells["HoTen"].Value?.ToString() ?? "";
                string sdt = selectedRow.Cells["SDT"].Value?.ToString() ?? "";

                // Tìm khách hàng trong danh sách
                DataRow khachHang = danhSachKhachHang.FirstOrDefault(r => 
                    r["HoTen"]?.ToString() == hoTen && r["SDT"]?.ToString() == sdt);

                if (khachHang != null)
                {
                    selectedMaKhachHang = Convert.ToInt32(khachHang["MaKhachHang"]);

                    // Hiển thị thông tin lên form
                    txthoten.Text = khachHang["HoTen"]?.ToString() ?? "";
                    txtsodienthoai.Text = khachHang["SDT"]?.ToString() ?? "";
                    txtsocccd.Text = khachHang["SoCCCD"]?.ToString() ?? "";
                    
                    string gioiTinh = khachHang["GioiTinh"]?.ToString() ?? "Nam";
                    radioButton1.Checked = gioiTinh == "Nam";
                    radioButton2.Checked = gioiTinh == "Nữ";

                    cbLoaiKhach.SelectedItem = khachHang["LoaiKhach"]?.ToString() ?? "Nội Địa";
                    cbQuocTich.SelectedItem = khachHang["QuocTich"]?.ToString() ?? "Việt Nam";

                    // Disable form (chưa sửa)
                    DisableForm();
                    isEditMode = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button Sửa
        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (selectedMaKhachHang == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EnableForm();
            isEditMode = true;
        }

        // Button Lưu
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (selectedMaKhachHang == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txthoten.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string gioiTinh = radioButton1.Checked ? "Nam" : "Nữ";
                string loaiKhach = cbLoaiKhach.SelectedItem?.ToString() ?? "Nội Địa";
                string quocTich = cbQuocTich.SelectedItem?.ToString() ?? "Việt Nam";

                string sql = @"UPDATE dbo.KhachHang 
                            SET HoTen = @HoTen, SDT = @SDT, SoCCCD = @CCCD, 
                                GioiTinh = @GioiTinh, LoaiKhach = @LoaiKhach, QuocTich = @QuocTich
                            WHERE MaKhachHang = @MaKhachHang";

                SqlParameter[] paras = new SqlParameter[]
                {
                    new SqlParameter("@HoTen", txthoten.Text.Trim()),
                    new SqlParameter("@SDT", txtsodienthoai.Text.Trim()),
                    new SqlParameter("@CCCD", txtsocccd.Text.Trim()),
                    new SqlParameter("@GioiTinh", gioiTinh),
                    new SqlParameter("@LoaiKhach", loaiKhach),
                    new SqlParameter("@QuocTich", quocTich),
                    new SqlParameter("@MaKhachHang", selectedMaKhachHang)
                };

                DataProvider.ExcuteNonQuery(sql, CommandType.Text, paras);

                MessageBox.Show("✓ Cập nhật thông tin khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload dữ liệu
                LoadAllKhachHang();
                DisableForm();
                isEditMode = false;
                selectedMaKhachHang = 0;
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"✗ Lỗi cập nhật: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Disable các field
        private void DisableForm()
        {
            txthoten.Enabled = false;
            txtsodienthoai.Enabled = false;
            txtsocccd.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            cbLoaiKhach.Enabled = false;
            cbQuocTich.Enabled = false;
            btnluu.Enabled = false;
        }

        // Enable các field
        private void EnableForm()
        {
            txthoten.Enabled = true;
            txtsodienthoai.Enabled = true;
            txtsocccd.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            cbLoaiKhach.Enabled = true;
            cbQuocTich.Enabled = true;
            btnluu.Enabled = true;
        }

        // Clear form
        private void ClearForm()
        {
            txthoten.Text = "";
            txtsodienthoai.Text = "";
            txtsocccd.Text = "";
            radioButton1.Checked = true;
            cbLoaiKhach.SelectedIndex = 0;
            cbQuocTich.SelectedIndex = 0;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        // Event handlers (từ Designer)
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void dvgKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void lbnphongdango_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
