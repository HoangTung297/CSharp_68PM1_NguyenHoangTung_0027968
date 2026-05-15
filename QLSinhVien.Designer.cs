namespace CSharp_68PM1_NguyenHoangTung_0027968
{
    partial class QLSinhVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // ── Controls khai báo ─────────────────────────────
            this.menuStrip1       = new System.Windows.Forms.MenuStrip();
            this.menuQLSV         = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLLopHoc     = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat     = new System.Windows.Forms.ToolStripMenuItem();

            // Panel trái - nhập liệu
            this.panelLeft        = new System.Windows.Forms.Panel();
            this.lblThongTin      = new System.Windows.Forms.Label();
            this.lblMaSV          = new System.Windows.Forms.Label();
            this.txtMaSV          = new System.Windows.Forms.TextBox();
            this.lblHoTen         = new System.Windows.Forms.Label();
            this.txtHoTen         = new System.Windows.Forms.TextBox();
            this.lblNgaySinh      = new System.Windows.Forms.Label();
            this.dtpNgaySinh      = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh      = new System.Windows.Forms.Label();
            this.cboGioiTinh      = new System.Windows.Forms.ComboBox();
            this.lblLop           = new System.Windows.Forms.Label();
            this.cboLop           = new System.Windows.Forms.ComboBox();
            this.btnThem          = new System.Windows.Forms.Button();
            this.btnSua           = new System.Windows.Forms.Button();
            this.btnXoa           = new System.Windows.Forms.Button();
            this.btnLamMoi        = new System.Windows.Forms.Button();

            // Panel phải - tìm kiếm + danh sách
            this.panelRight       = new System.Windows.Forms.Panel();
            this.lblTimKiem       = new System.Windows.Forms.Label();
            this.txtTimKiem       = new System.Windows.Forms.TextBox();
            this.btnTim           = new System.Windows.Forms.Button();
            this.dgvSinhVien      = new System.Windows.Forms.DataGridView();
            this.colMaSV          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh      = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // Phân trang
            this.btnDauTrang      = new System.Windows.Forms.Button();
            this.btnTrangTruoc    = new System.Windows.Forms.Button();
            this.lblTrang         = new System.Windows.Forms.Label();
            this.btnTrangSau      = new System.Windows.Forms.Button();
            this.btnCuoiTrang     = new System.Windows.Forms.Button();

            this.menuStrip1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();

            // ══════════════════════════════════════════════════
            // MenuStrip
            // ══════════════════════════════════════════════════
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuQLSV, this.menuQLLopHoc, this.menuDangXuat });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(1060, 30);

            this.menuQLSV.Text = "Quản Lý Sinh Viên";
            this.menuQLSV.ForeColor = System.Drawing.Color.Black;

            this.menuQLLopHoc.Text = "Quản Lý Lớp Học";
            this.menuQLLopHoc.ForeColor = System.Drawing.Color.Black;

            this.menuDangXuat.Text = "Đăng Xuất";
            this.menuDangXuat.ForeColor = System.Drawing.Color.OrangeRed;
            this.menuDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);

            // ══════════════════════════════════════════════════
            // Panel trái (nhập liệu)
            // ══════════════════════════════════════════════════
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Location = new System.Drawing.Point(10, 38);
            this.panelLeft.Size = new System.Drawing.Size(330, 620);
            this.panelLeft.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblThongTin, lblMaSV, txtMaSV,
                lblHoTen, txtHoTen,
                lblNgaySinh, dtpNgaySinh,
                lblGioiTinh, cboGioiTinh,
                lblLop, cboLop,
                btnThem, btnSua, btnXoa, btnLamMoi
            });

            // lblThongTin
            this.lblThongTin.Text = "Thông tin sinh viên";
            this.lblThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblThongTin.Location = new System.Drawing.Point(10, 10);
            this.lblThongTin.AutoSize = true;

            // Mã SV
            this.lblMaSV.Text = "Mã sinh viên:";
            this.lblMaSV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMaSV.Location = new System.Drawing.Point(10, 45);
            this.lblMaSV.AutoSize = true;

            this.txtMaSV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaSV.Location = new System.Drawing.Point(10, 65);
            this.txtMaSV.Size = new System.Drawing.Size(300, 26);

            // Họ và tên
            this.lblHoTen.Text = "Họ và tên:";
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHoTen.Location = new System.Drawing.Point(10, 105);
            this.lblHoTen.AutoSize = true;

            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtHoTen.Location = new System.Drawing.Point(10, 125);
            this.txtHoTen.Size = new System.Drawing.Size(300, 26);

            // Ngày sinh
            this.lblNgaySinh.Text = "Ngày Sinh:";
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNgaySinh.Location = new System.Drawing.Point(10, 165);
            this.lblNgaySinh.AutoSize = true;

            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(10, 185);
            this.dtpNgaySinh.Size = new System.Drawing.Size(300, 26);

            // Giới tính
            this.lblGioiTinh.Text = "Giới tính:";
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblGioiTinh.Location = new System.Drawing.Point(10, 225);
            this.lblGioiTinh.AutoSize = true;

            this.cboGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Location = new System.Drawing.Point(10, 245);
            this.cboGioiTinh.Size = new System.Drawing.Size(300, 26);
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            this.cboGioiTinh.SelectedIndex = 0;

            // Lớp
            this.lblLop.Text = "Lớp:";
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLop.Location = new System.Drawing.Point(10, 285);
            this.lblLop.AutoSize = true;

            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Location = new System.Drawing.Point(10, 305);
            this.cboLop.Size = new System.Drawing.Size(300, 26);
            this.cboLop.Items.AddRange(new object[] { "68PM1", "68PM2", "67PM1", "67PM2" });
            this.cboLop.SelectedIndex = 0;

            // ── Buttons ────────────────────────────────────────
            // Thêm
            this.btnThem.Text = "Thêm";
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.Size = new System.Drawing.Size(130, 42);
            this.btnThem.Location = new System.Drawing.Point(10, 370);
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(0, 188, 212);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // Sửa
            this.btnSua.Text = "Sửa";
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.Size = new System.Drawing.Size(130, 42);
            this.btnSua.Location = new System.Drawing.Point(175, 370);
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // Xóa
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Size = new System.Drawing.Size(130, 42);
            this.btnXoa.Location = new System.Drawing.Point(10, 430);
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // Làm mới
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.Size = new System.Drawing.Size(130, 42);
            this.btnLamMoi.Location = new System.Drawing.Point(175, 430);
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(158, 158, 158);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // ══════════════════════════════════════════════════
            // Panel phải (tìm kiếm + danh sách)
            // ══════════════════════════════════════════════════
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Location = new System.Drawing.Point(355, 38);
            this.panelRight.Size = new System.Drawing.Size(695, 620);
            this.panelRight.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTimKiem, txtTimKiem, btnTim,
                dgvSinhVien,
                btnDauTrang, btnTrangTruoc, lblTrang, btnTrangSau, btnCuoiTrang
            });

            // Tìm kiếm
            this.lblTimKiem.Text = "Tìm kiếm (Tên/Mã SV/ Lớp)";
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTimKiem.Location = new System.Drawing.Point(10, 10);
            this.lblTimKiem.AutoSize = true;

            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTimKiem.Location = new System.Drawing.Point(10, 38);
            this.txtTimKiem.Size = new System.Drawing.Size(560, 26);

            this.btnTim.Text = "Tìm";
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTim.Size = new System.Drawing.Size(80, 28);
            this.btnTim.Location = new System.Drawing.Point(590, 36);
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(158, 158, 158);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

            // DataGridView
            this.dgvSinhVien.Location = new System.Drawing.Point(10, 80);
            this.dgvSinhVien.Size = new System.Drawing.Size(668, 490);
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSinhVien.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvSinhVien.GridColor = System.Drawing.Color.LightGray;
            this.dgvSinhVien.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.dgvSinhVien.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            // Columns
            this.colMaSV.HeaderText = "Mã SV";
            this.colMaSV.Name = "colMaSV";
            this.colHoTen.HeaderText = "Họ và Tên";
            this.colHoTen.Name = "colHoTen";
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colNgaySinh.HeaderText = "Ngày Sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colMaSV, colHoTen, colGioiTinh, colNgaySinh });

            // ── Phân trang ─────────────────────────────────────
            int py = 580;
            StylePagingButton(this.btnDauTrang,  "<<", new System.Drawing.Point(10,  py));
            StylePagingButton(this.btnTrangTruoc, "<",  new System.Drawing.Point(80,  py));
            StylePagingButton(this.btnTrangSau,   ">",  new System.Drawing.Point(440, py));
            StylePagingButton(this.btnCuoiTrang, ">>", new System.Drawing.Point(510, py));

            this.lblTrang.Text = "Trang 1/1| 3 bản ghi";
            this.lblTrang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrang.Location = new System.Drawing.Point(155, py + 5);
            this.lblTrang.AutoSize = true;

            this.btnDauTrang.Click   += new System.EventHandler(this.btnTim_Click);
            this.btnTrangTruoc.Click += new System.EventHandler(this.btnTim_Click);
            this.btnTrangSau.Click   += new System.EventHandler(this.btnTim_Click);
            this.btnCuoiTrang.Click  += new System.EventHandler(this.btnTim_Click);

            // ══════════════════════════════════════════════════
            // Form chính
            // ══════════════════════════════════════════════════
            this.MainMenuStrip = this.menuStrip1;
            this.ClientSize = new System.Drawing.Size(1060, 670);
            this.Text = "QLSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Helper tạo style nút phân trang
        private void StylePagingButton(System.Windows.Forms.Button btn, string text, System.Drawing.Point loc)
        {
            btn.Text = text;
            btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btn.Size = new System.Drawing.Size(55, 28);
            btn.Location = loc;
            btn.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btn.ForeColor = System.Drawing.Color.Black;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }

        // ── Khai báo controls ──────────────────────────────────
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuQLSV;
        private System.Windows.Forms.ToolStripMenuItem menuQLLopHoc;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;

        private System.Windows.Forms.Button btnDauTrang;
        private System.Windows.Forms.Button btnTrangTruoc;
        private System.Windows.Forms.Label lblTrang;
        private System.Windows.Forms.Button btnTrangSau;
        private System.Windows.Forms.Button btnCuoiTrang;
    }
}
