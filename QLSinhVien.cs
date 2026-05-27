using System;
using System.Windows.Forms;

namespace CSharp_68PM1_NguyenHoangTung_0027968
{
    public partial class QLSinhVien : Form
    {
        private UC_QLLH ucLopHoc;
        private UC_QLSV ucSinhVien;

        public QLSinhVien()
        {
            InitializeComponent();
            XoaySoUserControl();
            menuQLSV_Click(this, EventArgs.Empty);
        }

        private void XoaySoUserControl()
        {
            ucLopHoc = new UC_QLLH();
            ucLopHoc.Dock = DockStyle.Fill;
            ucLopHoc.Visible = false;
            this.Controls.Add(ucLopHoc);

            ucSinhVien = new UC_QLSV();
            ucSinhVien.Dock = DockStyle.Fill;
            ucSinhVien.Visible = false;
            this.Controls.Add(ucSinhVien);
        }

        private void menuQLSV_Click(object sender, EventArgs e)
        {
            if (ucLopHoc != null) ucLopHoc.Visible = false;

            if (ucSinhVien != null)
            {
                ucSinhVien.Visible = true;
                ucSinhVien.BringToFront();
                ucSinhVien.LoadDataSinhVien();
            }
        }

        private void menuQLLopHoc_Click(object sender, EventArgs e)
        {
            if (ucSinhVien != null) ucSinhVien.Visible = false;

            if (ucLopHoc != null)
            {
                ucLopHoc.Visible = true;
                ucLopHoc.BringToFront();
                ucLopHoc.LoadDataLopHoc();
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
                Form t = Application.OpenForms["Form1"];
                if (t != null) t.Show();
            }
        }
    }
}