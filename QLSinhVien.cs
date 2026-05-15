using System;
using System.Windows.Forms;

namespace CSharp_68PM1_NguyenHoangTung_0027968
{
    public partial class QLSinhVien : Form
    {
        public QLSinhVien()
        {
            InitializeComponent();
        }

        // ── Đăng xuất ──────────────────────────────────────────
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có chắc muốn đăng xuất?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();           // đóng form này
                // new Form1().Show(); // nếu muốn quay lại màn đăng nhập
            }
        }

        // ── Làm mới form nhập ─────────────────────────────────
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            cboGioiTinh.SelectedIndex = 0;
            cboLop.SelectedIndex = 0;
        }

        // ── Placeholder: Thêm ─────────────────────────────────
        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Thêm (sẽ cài đặt sau)", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ── Placeholder: Sửa ──────────────────────────────────
        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Sửa (sẽ cài đặt sau)", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ── Placeholder: Xóa ──────────────────────────────────
        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Xóa (sẽ cài đặt sau)", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // ── Placeholder: Tìm ──────────────────────────────────
        private void btnTim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Tìm (sẽ cài đặt sau)", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
