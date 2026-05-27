using System;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_68PM1_NguyenHoangTung_0027968
{
    public partial class UC_QLLH : UserControl
    {
        private const string CONNECTION_STRING =
            @"Data Source=LAPTOP-SGPK0VHD\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;TrustServerCertificate=True";

        public UC_QLLH()
        {
            InitializeComponent();
            DisableAllButtons();
        }

        private void UC_QLLH_Load(object sender, EventArgs e)
        {
            LoadDataLopHoc();
        }

        public void LoadDataLopHoc()
        {
            DisplayClassList();
        }

        public void DisplayClassList(string keyword = "")
        {
            try
            {
                using (var db = new databaseDataContext(CONNECTION_STRING))
                {
                    var query = from lh in db.lophocs
                                select new
                                {
                                    lh.MaLop,
                                    lh.TenLop,
                                    lh.NienKhoa
                                };

                    var list = query.ToList();
                    dgvLopHoc.DataSource = list;
                    lblTrang.Text = $"Tổng số: {list.Count} lớp học";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách lớp học:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisableAllButtons()
        {
            // Vô hiệu hóa các nút trên panel trái
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = false;
            btnXemDS.Enabled = false;

            // Vô hiệu hóa tìm kiếm
            txtTimKiem.Enabled = false;
            btnTim.Enabled = false;

            // Vô hiệu hóa các textbox nhập liệu
            txtMaID.ReadOnly = true;
            txtMaLop.ReadOnly = true;
            txtTenLop.ReadOnly = true;
            txtGhiChu.ReadOnly = true;

            // Vô hiệu hóa phân trang (nếu có)
            btnDauTrang.Enabled = false;
            btnTrangTruoc.Enabled = false;
            btnTrangSau.Enabled = false;
            btnCuoiTrang.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
        }

        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnDauTrang_Click(object sender, EventArgs e) { }
        private void btnTrangTruoc_Click(object sender, EventArgs e) { }
        private void btnTrangSau_Click(object sender, EventArgs e) { }
        private void btnCuoiTrang_Click(object sender, EventArgs e) { }
    }
}