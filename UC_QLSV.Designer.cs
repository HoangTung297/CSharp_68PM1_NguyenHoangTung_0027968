namespace CSharp_68PM1_NguyenHoangTung_0027968
{
    partial class UC_QLSV
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Khai báo
            panelLeft = new System.Windows.Forms.Panel();
            lblThongTin = new System.Windows.Forms.Label();
            lblMaSV = new System.Windows.Forms.Label();
            txtMaSV = new System.Windows.Forms.TextBox();
            lblHoTen = new System.Windows.Forms.Label();
            txtHoTen = new System.Windows.Forms.TextBox();
            lblNgaySinh = new System.Windows.Forms.Label();
            dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            lblGioiTinh = new System.Windows.Forms.Label();
            cboGioiTinh = new System.Windows.Forms.ComboBox();
            lblLop = new System.Windows.Forms.Label();
            cboLop = new System.Windows.Forms.ComboBox();
            btnThem = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnLamMoi = new System.Windows.Forms.Button();

            panelRight = new System.Windows.Forms.Panel();
            lblTimKiem = new System.Windows.Forms.Label();
            txtTimKiem = new System.Windows.Forms.TextBox();
            btnTim = new System.Windows.Forms.Button();
            dgvSinhVien = new System.Windows.Forms.DataGridView();
            btnDauTrang = new System.Windows.Forms.Button();
            btnTrangTruoc = new System.Windows.Forms.Button();
            lblTrang = new System.Windows.Forms.Label();
            btnTrangSau = new System.Windows.Forms.Button();
            btnCuoiTrang = new System.Windows.Forms.Button();

            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();

            // ── panelLeft ─────
            panelLeft.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            panelLeft.Size = new System.Drawing.Size(430, 660);
            panelLeft.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblThongTin, lblMaSV, txtMaSV,
                lblHoTen, txtHoTen,
                lblNgaySinh, dtpNgaySinh,
                lblGioiTinh, cboGioiTinh,
                lblLop, cboLop,
                btnThem, btnSua, btnXoa, btnLamMoi
            });

            // lblThongTin
            lblThongTin.Text = "Thông tin sinh viên";
            lblThongTin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblThongTin.Location = new System.Drawing.Point(20, 18);
            lblThongTin.AutoSize = true;

            // Mã SV
            SetLabel(lblMaSV, "Mã sinh viên:", new System.Drawing.Point(20, 55));
            SetTextBox(txtMaSV, new System.Drawing.Point(20, 75), 385);

            // Họ tên
            SetLabel(lblHoTen, "Họ và tên:", new System.Drawing.Point(20, 115));
            SetTextBox(txtHoTen, new System.Drawing.Point(20, 135), 385);

            // Ngày sinh
            SetLabel(lblNgaySinh, "Ngày Sinh:", new System.Drawing.Point(20, 175));
            dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new System.Drawing.Point(20, 195);
            dtpNgaySinh.Size = new System.Drawing.Size(385, 27);

            // Giới tính
            SetLabel(lblGioiTinh, "Giới tính:", new System.Drawing.Point(20, 235));
            cboGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboGioiTinh.Location = new System.Drawing.Point(20, 255);
            cboGioiTinh.Size = new System.Drawing.Size(385, 27);
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGioiTinh.SelectedIndex = 0;

            // Lớp
            SetLabel(lblLop, "Lớp:", new System.Drawing.Point(20, 295));
            cboLop.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboLop.Location = new System.Drawing.Point(20, 315);
            cboLop.Size = new System.Drawing.Size(385, 27);

            // Buttons
            MakeButton(btnThem, "Thêm", new System.Drawing.Point(20, 385), System.Drawing.Color.FromArgb(0, 188, 212));
            MakeButton(btnSua, "Sửa", new System.Drawing.Point(215, 385), System.Drawing.Color.FromArgb(76, 175, 80));
            MakeButton(btnXoa, "Xóa", new System.Drawing.Point(20, 450), System.Drawing.Color.FromArgb(244, 67, 54));
            MakeButton(btnLamMoi, "Làm mới", new System.Drawing.Point(215, 450), System.Drawing.Color.FromArgb(158, 158, 158));

            btnThem.Click += new System.EventHandler(btnThem_Click);
            btnSua.Click += new System.EventHandler(btnSua_Click);
            btnXoa.Click += new System.EventHandler(btnXoa_Click);
            btnLamMoi.Click += new System.EventHandler(BtnLamMoi_Click);

            // ── panelRight ────
            panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            panelRight.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTimKiem, txtTimKiem, btnTim,
                dgvSinhVien,
                btnDauTrang, btnTrangTruoc, lblTrang, btnTrangSau, btnCuoiTrang
            });

            // Tìm kiếm
            lblTimKiem.Text = "Tìm kiếm (Tên/Mã SV/ Lớp):";
            lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblTimKiem.Location = new System.Drawing.Point(15, 18);
            lblTimKiem.AutoSize = true;

            txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtTimKiem.Location = new System.Drawing.Point(15, 45);
            txtTimKiem.Size = new System.Drawing.Size(550, 27);

            btnTim.Text = "Tìm";
            btnTim.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnTim.Size = new System.Drawing.Size(90, 29);
            btnTim.Location = new System.Drawing.Point(580, 43);
            btnTim.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            btnTim.ForeColor = System.Drawing.Color.White;
            btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTim.FlatAppearance.BorderSize = 0;
            btnTim.Click += new System.EventHandler(btnTim_Click);

            // DataGridView
            dgvSinhVien.Location = new System.Drawing.Point(15, 90);
            dgvSinhVien.Size = new System.Drawing.Size(810, 530);
            dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.RowHeadersVisible = false;
            dgvSinhVien.BackgroundColor = System.Drawing.Color.White;
            dgvSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgvSinhVien.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvSinhVien_CellClick);

            // Phân trang
            MakePagingBtn(btnDauTrang, "<<", new System.Drawing.Point(200, 635));
            MakePagingBtn(btnTrangTruoc, "<", new System.Drawing.Point(265, 635));
            MakePagingBtn(btnTrangSau, ">", new System.Drawing.Point(530, 635));
            MakePagingBtn(btnCuoiTrang, ">>", new System.Drawing.Point(595, 635));

            lblTrang.Text = "Trang 1/1  |  0 bản ghi";
            lblTrang.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblTrang.Location = new System.Drawing.Point(335, 640);
            lblTrang.AutoSize = true;

            // ── UserControl ──────
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Size = new System.Drawing.Size(1280, 680);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Load += new System.EventHandler(UC_QLSV_Load);

            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
        }

        // ── Helpers ─────
        private void SetLabel(System.Windows.Forms.Label lbl, string text, System.Drawing.Point loc)
        {
            lbl.Text = text;
            lbl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl.Location = loc;
            lbl.AutoSize = true;
        }

        private void SetTextBox(System.Windows.Forms.TextBox txt, System.Drawing.Point loc, int width)
        {
            txt.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txt.Location = loc;
            txt.Size = new System.Drawing.Size(width, 27);
            txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void MakeButton(System.Windows.Forms.Button btn, string text, System.Drawing.Point loc, System.Drawing.Color color)
        {
            btn.Text = text;
            btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btn.Size = new System.Drawing.Size(175, 48);
            btn.Location = loc;
            btn.BackColor = color;
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }

        private void MakePagingBtn(System.Windows.Forms.Button btn, string text, System.Drawing.Point loc)
        {
            btn.Text = text;
            btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btn.Size = new System.Drawing.Size(55, 32);
            btn.Location = loc;
            btn.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btn.ForeColor = System.Drawing.Color.Black;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }

        // ── Khai báo controls ────
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
        private System.Windows.Forms.Button btnDauTrang;
        private System.Windows.Forms.Button btnTrangTruoc;
        private System.Windows.Forms.Label lblTrang;
        private System.Windows.Forms.Button btnTrangSau;
        private System.Windows.Forms.Button btnCuoiTrang;
    }
}