namespace CSharp_68PM1_NguyenHoangTung_0027968
{
    partial class UC_QLLH
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panelLeft = new System.Windows.Forms.Panel();
            lblThongTin = new System.Windows.Forms.Label();
            lblMaID = new System.Windows.Forms.Label();
            txtMaID = new System.Windows.Forms.TextBox();
            lblMaLop = new System.Windows.Forms.Label();
            txtMaLop = new System.Windows.Forms.TextBox();
            lblTenLop = new System.Windows.Forms.Label();
            txtTenLop = new System.Windows.Forms.TextBox();
            lblGhiChu = new System.Windows.Forms.Label();
            txtGhiChu = new System.Windows.Forms.TextBox();
            btnThem = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnLamMoi = new System.Windows.Forms.Button();
            btnXemDS = new System.Windows.Forms.Button();
            panelRight = new System.Windows.Forms.Panel();
            lblTimKiem = new System.Windows.Forms.Label();
            txtTimKiem = new System.Windows.Forms.TextBox();
            btnTim = new System.Windows.Forms.Button();
            dgvLopHoc = new System.Windows.Forms.DataGridView();
            btnDauTrang = new System.Windows.Forms.Button();
            btnTrangTruoc = new System.Windows.Forms.Button();
            lblTrang = new System.Windows.Forms.Label();
            btnTrangSau = new System.Windows.Forms.Button();
            btnCuoiTrang = new System.Windows.Forms.Button();

            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLopHoc).BeginInit();
            SuspendLayout();

            // ── panelLeft ──────────────────────────────────────────
            panelLeft.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            panelLeft.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblThongTin, lblMaID, txtMaID, lblMaLop, txtMaLop,
                lblTenLop, txtTenLop, lblGhiChu, txtGhiChu,
                btnThem, btnSua, btnXoa, btnLamMoi, btnXemDS
            });
            panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            panelLeft.Size = new System.Drawing.Size(430, 660);

            // lblThongTin
            lblThongTin.Text = "THÔNG TIN LỚP HỌC";
            lblThongTin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblThongTin.Location = new System.Drawing.Point(20, 18);
            lblThongTin.AutoSize = true;

            // Mã ID
            SetLbl(lblMaID, "Mã ID:", new System.Drawing.Point(20, 60));
            SetTxt(txtMaID, new System.Drawing.Point(20, 80), 385);
            txtMaID.ReadOnly = true;
            txtMaID.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);

            // Mã lớp
            SetLbl(lblMaLop, "Mã lớp:", new System.Drawing.Point(20, 120));
            SetTxt(txtMaLop, new System.Drawing.Point(20, 140), 385);

            // Tên lớp
            SetLbl(lblTenLop, "Tên lớp:", new System.Drawing.Point(20, 180));
            SetTxt(txtTenLop, new System.Drawing.Point(20, 200), 385);

            // Ghi chú (dùng làm Niên khóa)
            SetLbl(lblGhiChu, "Niên khóa / Ghi chú:", new System.Drawing.Point(20, 240));
            txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtGhiChu.Location = new System.Drawing.Point(20, 260);
            txtGhiChu.Multiline = true;
            txtGhiChu.Size = new System.Drawing.Size(385, 60);
            txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Buttons
            MakeBtn(btnThem, "Thêm", new System.Drawing.Point(20, 350), System.Drawing.Color.FromArgb(0, 188, 212));
            MakeBtn(btnSua, "Sửa", new System.Drawing.Point(215, 350), System.Drawing.Color.FromArgb(76, 175, 80));
            MakeBtn(btnXoa, "Xóa", new System.Drawing.Point(20, 415), System.Drawing.Color.FromArgb(244, 67, 54));
            MakeBtn(btnLamMoi, "Làm mới", new System.Drawing.Point(215, 415), System.Drawing.Color.FromArgb(158, 158, 158));

            btnXemDS.Text = "Xem danh sách sinh viên";
            btnXemDS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnXemDS.Size = new System.Drawing.Size(385, 48);
            btnXemDS.Location = new System.Drawing.Point(20, 480);
            btnXemDS.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            btnXemDS.ForeColor = System.Drawing.Color.White;
            btnXemDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXemDS.FlatAppearance.BorderSize = 0;

            btnThem.Click += new System.EventHandler(btnThem_Click);
            btnSua.Click += new System.EventHandler(btnSua_Click);
            btnXoa.Click += new System.EventHandler(btnXoa_Click);
            btnLamMoi.Click += new System.EventHandler(btnLamMoi_Click);
            btnXemDS.Click += new System.EventHandler(btnXemDS_Click);

            // ── panelRight ─────────────────────────────────────────
            panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            panelRight.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTimKiem, txtTimKiem, btnTim, dgvLopHoc,
                btnDauTrang, btnTrangTruoc, lblTrang, btnTrangSau, btnCuoiTrang
            });

            // Tìm kiếm
            lblTimKiem.Text = "Tìm kiếm (Mã ID / Mã lớp / Tên lớp):";
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
            dgvLopHoc.Location = new System.Drawing.Point(15, 90);
            dgvLopHoc.Size = new System.Drawing.Size(810, 530);
            dgvLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLopHoc.ReadOnly = true;
            dgvLopHoc.AllowUserToAddRows = false;
            dgvLopHoc.RowHeadersVisible = false;
            dgvLopHoc.BackgroundColor = System.Drawing.Color.White;
            dgvLopHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgvLopHoc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dgvLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvLopHoc_CellClick);

            // Phân trang
            MakePagingBtn(btnDauTrang, "<<", new System.Drawing.Point(200, 635));
            MakePagingBtn(btnTrangTruoc, "<", new System.Drawing.Point(265, 635));
            MakePagingBtn(btnTrangSau, ">", new System.Drawing.Point(530, 635));
            MakePagingBtn(btnCuoiTrang, ">>", new System.Drawing.Point(595, 635));

            lblTrang.Text = "Trang 1/1  |  0 bản ghi";
            lblTrang.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblTrang.Location = new System.Drawing.Point(335, 640);
            lblTrang.AutoSize = true;

            btnDauTrang.Click += new System.EventHandler(btnDauTrang_Click);
            btnTrangTruoc.Click += new System.EventHandler(btnTrangTruoc_Click);
            btnTrangSau.Click += new System.EventHandler(btnTrangSau_Click);
            btnCuoiTrang.Click += new System.EventHandler(btnCuoiTrang_Click);

            // ── UserControl ────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Size = new System.Drawing.Size(1280, 680);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Load += new System.EventHandler(UC_QLLH_Load);

            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLopHoc).EndInit();
            ResumeLayout(false);
        }

        private void SetLbl(System.Windows.Forms.Label lbl, string text, System.Drawing.Point loc)
        {
            lbl.Text = text;
            lbl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl.Location = loc;
            lbl.AutoSize = true;
        }

        private void SetTxt(System.Windows.Forms.TextBox txt, System.Drawing.Point loc, int width)
        {
            txt.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txt.Location = loc;
            txt.Size = new System.Drawing.Size(width, 27);
            txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void MakeBtn(System.Windows.Forms.Button btn, string text, System.Drawing.Point loc, System.Drawing.Color color)
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

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblMaID;
        private System.Windows.Forms.TextBox txtMaID;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXemDS;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvLopHoc;
        private System.Windows.Forms.Button btnDauTrang;
        private System.Windows.Forms.Button btnTrangTruoc;
        private System.Windows.Forms.Label lblTrang;
        private System.Windows.Forms.Button btnTrangSau;
        private System.Windows.Forms.Button btnCuoiTrang;
    }
}