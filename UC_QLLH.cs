using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UC_QLLH : UserControl
    {
        public UC_QLLH()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Code Thêm lớp học
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Code Sửa lớp học
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Code Xóa lớp học
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaID.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtGhiChu.Clear();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            // Code Tìm kiếm lớp học
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hiển thị danh sách sinh viên thuộc lớp đang chọn!", "Thông báo");
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            // Về trang đầu
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            // Về trang trước
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Sang trang sau
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            // Đến trang cuối
        }
    }
}