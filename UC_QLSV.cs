using System;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_68PM1_NguyenHoangTung_0027968
{
    public partial class UC_QLSV : UserControl
    {
        private const string CONNECTION_STRING =
            @"Data Source=LAPTOP-SGPK0VHD\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;TrustServerCertificate=True";

        public UC_QLSV()
        {
            InitializeComponent();
        }

        private void UC_QLSV_Load(object sender, EventArgs e)
        {
            DisplayClassListForCBX();
            LoadDataSinhVien();
        }

        public void LoadDataSinhVien()
        {
            DisplayStudentList(txtTimKiem.Text.Trim());
        }

        public void DisplayStudentList(string keyword = "")
        {
            try
            {
                using (var db = new databaseDataContext(CONNECTION_STRING))
                {
                    var query = from sv in db.tbl_sinhviens
                                select new
                                {
                                    sv.MaSV,
                                    sv.HoTen,
                                    NgaySinh = sv.NgaySinh.HasValue
                                        ? sv.NgaySinh.Value.ToString("dd/MM/yyyy") : "",
                                    sv.GioiTinh,
                                    sv.QueQuan,
                                    sv.SoDienThoai,
                                    sv.MaLop
                                };

                    if (!string.IsNullOrEmpty(keyword))
                        query = query.Where(sv =>
                            sv.MaSV.Contains(keyword) ||
                            sv.HoTen.Contains(keyword) ||
                            (sv.MaLop != null && sv.MaLop.Contains(keyword)));

                    var list = query.ToList();
                    dgvSinhVien.DataSource = list;
                    lblTrang.Text = $"Trang 1/1  |  {list.Count} bản ghi";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách sinh viên:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplayClassListForCBX()
        {
            try
            {
                using (var db = new databaseDataContext(CONNECTION_STRING))
                {
                    var dsLop = db.lophocs.Select(l => l.MaLop).ToList();
                    cboLop.Items.Clear();
                    foreach (var lop in dsLop)
                        cboLop.Items.Add(lop);
                    if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
                }
            }
            catch
            {
                cboLop.Items.Clear();
                cboLop.Items.Add("68PM1");
                cboLop.Items.Add("68PM2");
                if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
            }
        }

        //  chức năng Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV và Họ tên!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new databaseDataContext(CONNECTION_STRING))
                {
                    bool exists = db.tbl_sinhviens.Any(sv => sv.MaSV == txtMaSV.Text.Trim());
                    if (exists)
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại!",
                            "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var svMoi = new tbl_sinhvien
                    {
                        MaSV = txtMaSV.Text.Trim(),
                        HoTen = txtHoTen.Text.Trim(),
                        NgaySinh = dtpNgaySinh.Value.Date,
                        GioiTinh = cboGioiTinh.Text,
                        MaLop = cboLop.Text,
                        QueQuan = "",
                        SoDienThoai = ""
                    };

                    db.tbl_sinhviens.Add(svMoi);
                    db.SaveChanges();

                    MessageBox.Show("Thêm sinh viên thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    txtMaSV.Clear();
                    txtHoTen.Clear();
                    dtpNgaySinh.Value = DateTime.Today;
                    cboGioiTinh.SelectedIndex = 0;
                    DisplayClassListForCBX();
                    DisplayStudentList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sinh viên:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Sửa phát triển sau.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Xóa phát triển sau.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Làm mới phát triển sau.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DisplayStudentList(txtTimKiem.Text.Trim());
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0) return;
            var row = dgvSinhVien.Rows[e.RowIndex];
            txtMaSV.Text = row.Cells["MaSV"]?.Value?.ToString() ?? "";
            txtHoTen.Text = row.Cells["HoTen"]?.Value?.ToString() ?? "";

            string nsStr = row.Cells["NgaySinh"]?.Value?.ToString() ?? "";
            if (DateTime.TryParseExact(nsStr, "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out DateTime ns))
                dtpNgaySinh.Value = ns;
            else
                dtpNgaySinh.Value = DateTime.Today;

            string gt = row.Cells["GioiTinh"]?.Value?.ToString() ?? "Nam";
            int gtIdx = cboGioiTinh.Items.IndexOf(gt);
            cboGioiTinh.SelectedIndex = gtIdx >= 0 ? gtIdx : 0;

            string lop = row.Cells["MaLop"]?.Value?.ToString() ?? "";
            int lopIdx = cboLop.Items.IndexOf(lop);
            if (lopIdx >= 0) cboLop.SelectedIndex = lopIdx;
        }
    }
}