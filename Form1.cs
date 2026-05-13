using System;
using System.Windows.Forms;

namespace CSharp_68PM1_NguyenHoangTung_0027968
{
    public partial class Form1 : Form
    {
        private const string STUDENT_EMAIL = "tung0027968@st.huce.edu.vn"; 
        private const string STUDENT_MSSV = "0027968";               
        

        public Form1()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == STUDENT_EMAIL && password == STUDENT_MSSV)
            {
                MessageBox.Show(
                    "Đăng nhập thành công! Chào mừng bạn.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Đăng nhập thất bại!\nTên đăng nhập hoặc mật khẩu không đúng.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }
    }
}