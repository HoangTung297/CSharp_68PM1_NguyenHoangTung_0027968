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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            menuQLSV = new ToolStripMenuItem();
            menuQLLopHoc = new ToolStripMenuItem();
            menuDangXuat = new ToolStripMenuItem();
            panelLeft = new Panel();
            lblThongTin = new Label();
            lblMaSV = new Label();
            txtMaSV = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblGioiTinh = new Label();
            cboGioiTinh = new ComboBox();
            lblLop = new Label();
            cboLop = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            panelRight = new Panel();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTim = new Button();
            dgvSinhVien = new DataGridView();
            colMaSV = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            btnDauTrang = new Button();
            btnTrangTruoc = new Button();
            lblTrang = new Label();
            btnTrangSau = new Button();
            btnCuoiTrang = new Button();
            menuStrip1.SuspendLayout();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuQLSV, menuQLLopHoc, menuDangXuat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1060, 31);
            menuStrip1.TabIndex = 0;
            // 
            // menuQLSV
            // 
            menuQLSV.ForeColor = Color.Black;
            menuQLSV.Name = "menuQLSV";
            menuQLSV.Size = new Size(163, 27);
            menuQLSV.Text = "Quản Lý Sinh Viên";
            menuQLSV.Click += menuQLSV_Click;
            // 
            // menuQLLopHoc
            // 
            menuQLLopHoc.ForeColor = Color.Black;
            menuQLLopHoc.Name = "menuQLLopHoc";
            menuQLLopHoc.Size = new Size(154, 27);
            menuQLLopHoc.Text = "Quản Lý Lớp Học";
            menuQLLopHoc.Click += menuQLLopHoc_Click;
            // 
            // menuDangXuat
            // 
            menuDangXuat.ForeColor = Color.OrangeRed;
            menuDangXuat.Name = "menuDangXuat";
            menuDangXuat.Size = new Size(105, 27);
            menuDangXuat.Text = "Đăng Xuất";
            menuDangXuat.Click += btnDangXuat_Click;
            // 
            // panelLeft
            // 
            panelLeft.BorderStyle = BorderStyle.FixedSingle;
            panelLeft.Controls.Add(lblThongTin);
            panelLeft.Controls.Add(lblMaSV);
            panelLeft.Controls.Add(txtMaSV);
            panelLeft.Controls.Add(lblHoTen);
            panelLeft.Controls.Add(txtHoTen);
            panelLeft.Controls.Add(lblNgaySinh);
            panelLeft.Controls.Add(dtpNgaySinh);
            panelLeft.Controls.Add(lblGioiTinh);
            panelLeft.Controls.Add(cboGioiTinh);
            panelLeft.Controls.Add(lblLop);
            panelLeft.Controls.Add(cboLop);
            panelLeft.Controls.Add(btnThem);
            panelLeft.Controls.Add(btnSua);
            panelLeft.Controls.Add(btnXoa);
            panelLeft.Controls.Add(btnLamMoi);
            panelLeft.Location = new Point(10, 38);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(330, 620);
            panelLeft.TabIndex = 1;
            // 
            // lblThongTin
            // 
            lblThongTin.AutoSize = true;
            lblThongTin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblThongTin.Location = new Point(10, 10);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(163, 23);
            lblThongTin.TabIndex = 0;
            lblThongTin.Text = "Thông tin sinh viên";
            lblThongTin.Click += lblThongTin_Click;
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Font = new Font("Segoe UI", 9.5F);
            lblMaSV.Location = new Point(10, 45);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(101, 21);
            lblMaSV.TabIndex = 1;
            lblMaSV.Text = "Mã sinh viên:";
            // 
            // txtMaSV
            // 
            txtMaSV.Font = new Font("Segoe UI", 9.5F);
            txtMaSV.Location = new Point(10, 65);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(300, 29);
            txtMaSV.TabIndex = 2;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 9.5F);
            lblHoTen.Location = new Point(10, 105);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(79, 21);
            lblHoTen.TabIndex = 3;
            lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 9.5F);
            txtHoTen.Location = new Point(10, 125);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(300, 29);
            txtHoTen.TabIndex = 4;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 9.5F);
            lblNgaySinh.Location = new Point(10, 165);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(85, 21);
            lblNgaySinh.TabIndex = 5;
            lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Segoe UI", 9.5F);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(10, 185);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(300, 29);
            dtpNgaySinh.TabIndex = 6;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 9.5F);
            lblGioiTinh.Location = new Point(10, 225);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(73, 21);
            lblGioiTinh.TabIndex = 7;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Font = new Font("Segoe UI", 9.5F);
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(10, 245);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(300, 29);
            cboGioiTinh.TabIndex = 8;
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Font = new Font("Segoe UI", 9.5F);
            lblLop.Location = new Point(10, 285);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(40, 21);
            lblLop.TabIndex = 9;
            lblLop.Text = "Lớp:";
            // 
            // cboLop
            // 
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.Font = new Font("Segoe UI", 9.5F);
            cboLop.Items.AddRange(new object[] { "68PM1", "68PM2" });
            cboLop.Location = new Point(10, 305);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(300, 29);
            cboLop.TabIndex = 10;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 188, 212);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(10, 370);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(130, 42);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(76, 175, 80);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(175, 370);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(130, 42);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(244, 67, 54);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(10, 430);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(130, 42);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(158, 158, 158);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(175, 430);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(130, 42);
            btnLamMoi.TabIndex = 14;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // panelRight
            // 
            panelRight.BorderStyle = BorderStyle.FixedSingle;
            panelRight.Controls.Add(lblTimKiem);
            panelRight.Controls.Add(txtTimKiem);
            panelRight.Controls.Add(btnTim);
            panelRight.Controls.Add(dgvSinhVien);
            panelRight.Controls.Add(btnDauTrang);
            panelRight.Controls.Add(btnTrangTruoc);
            panelRight.Controls.Add(lblTrang);
            panelRight.Controls.Add(btnTrangSau);
            panelRight.Controls.Add(btnCuoiTrang);
            panelRight.Location = new Point(355, 38);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(695, 620);
            panelRight.TabIndex = 2;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTimKiem.Location = new Point(10, 10);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(233, 23);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm kiếm (Tên/Mã SV/ Lớp)";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9.5F);
            txtTimKiem.Location = new Point(10, 38);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(560, 29);
            txtTimKiem.TabIndex = 1;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(158, 158, 158);
            btnTim.FlatAppearance.BorderSize = 0;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTim.ForeColor = Color.White;
            btnTim.Location = new Point(590, 36);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(80, 28);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.BackgroundColor = Color.White;
            dgvSinhVien.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { colMaSV, colHoTen, colGioiTinh, colNgaySinh });
            dgvSinhVien.Font = new Font("Segoe UI", 9.5F);
            dgvSinhVien.GridColor = Color.LightGray;
            dgvSinhVien.Location = new Point(10, 80);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.RowHeadersVisible = false;
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(668, 490);
            dgvSinhVien.TabIndex = 3;
            // 
            // colMaSV
            // 
            colMaSV.HeaderText = "Mã SV";
            colMaSV.MinimumWidth = 6;
            colMaSV.Name = "colMaSV";
            colMaSV.ReadOnly = true;
            // 
            // colHoTen
            // 
            colHoTen.HeaderText = "Họ và Tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            // 
            // colGioiTinh
            // 
            colGioiTinh.HeaderText = "Giới Tính";
            colGioiTinh.MinimumWidth = 6;
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.ReadOnly = true;
            // 
            // colNgaySinh
            // 
            colNgaySinh.HeaderText = "Ngày Sinh";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.ReadOnly = true;
            // 
            // btnDauTrang
            // 
            btnDauTrang.Location = new Point(0, 0);
            btnDauTrang.Name = "btnDauTrang";
            btnDauTrang.Size = new Size(75, 23);
            btnDauTrang.TabIndex = 4;
            btnDauTrang.Click += btnTim_Click;
            // 
            // btnTrangTruoc
            // 
            btnTrangTruoc.Location = new Point(0, 0);
            btnTrangTruoc.Name = "btnTrangTruoc";
            btnTrangTruoc.Size = new Size(75, 23);
            btnTrangTruoc.TabIndex = 5;
            btnTrangTruoc.Click += btnTim_Click;
            // 
            // lblTrang
            // 
            lblTrang.AutoSize = true;
            lblTrang.Font = new Font("Segoe UI", 9F);
            lblTrang.Location = new Point(155, 580);
            lblTrang.Name = "lblTrang";
            lblTrang.Size = new Size(142, 20);
            lblTrang.TabIndex = 6;
            lblTrang.Text = "Trang 1/1| 3 bản ghi";
            // 
            // btnTrangSau
            // 
            btnTrangSau.Location = new Point(0, 0);
            btnTrangSau.Name = "btnTrangSau";
            btnTrangSau.Size = new Size(75, 23);
            btnTrangSau.TabIndex = 7;
            btnTrangSau.Click += btnTim_Click;
            // 
            // btnCuoiTrang
            // 
            btnCuoiTrang.Location = new Point(0, 0);
            btnCuoiTrang.Name = "btnCuoiTrang";
            btnCuoiTrang.Size = new Size(75, 23);
            btnCuoiTrang.TabIndex = 8;
            btnCuoiTrang.Click += btnTim_Click;
            // 
            // QLSinhVien
            // 
            ClientSize = new Size(1060, 670);
            Controls.Add(menuStrip1);
            Controls.Add(panelLeft);
            Controls.Add(panelRight);
            Font = new Font("Segoe UI", 9F);
            MainMenuStrip = menuStrip1;
            Name = "QLSinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QLSinhVien";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

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