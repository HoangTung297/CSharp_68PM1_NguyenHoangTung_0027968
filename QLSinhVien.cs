using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace CSharp_68PM1_NguyenHoangTung_0027968
{
    public partial class QLSinhVien : Form
    {
        private UC_QLLH ucLopHoc;

        public QLSinhVien()
        {
            InitializeComponent();
            XoaySoUserControl();
        }

        private void XoaySoUserControl()
        {
            ucLopHoc = new UC_QLLH();
            ucLopHoc.Dock = DockStyle.Fill;
            ucLopHoc.Visible = false;
            this.Controls.Add(ucLopHoc);
            ucLopHoc.BringToFront();
        }

        private void menuQLSV_Click(object sender, EventArgs e)
        {
            if (ucLopHoc != null)
            {
                ucLopHoc.Visible = false;
            }
            panelLeft.Visible = true;
            panelRight.Visible = true;
        }

        private void menuQLLopHoc_Click(object sender, EventArgs e)
        {
            panelLeft.Visible = false;
            panelRight.Visible = false;
            if (ucLopHoc != null)
            {
                ucLopHoc.Visible = true;
                ucLopHoc.BringToFront();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có chắc muốn đăng xuất?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            cboGioiTinh.SelectedIndex = 0;
            cboLop.SelectedIndex = 0;
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

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void lblThongTin_Click(object sender, EventArgs e)
        {

        }
    }
}