namespace WindowsFormsApp1
{
    partial class UC_QLLH
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panelLeft = new Panel();
            lblThongTin = new Label();
            lblMaID = new Label();
            txtMaID = new TextBox();
            lblMaLop = new Label();
            txtMaLop = new TextBox();
            lblTenLop = new Label();
            txtTenLop = new TextBox();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnXemDS = new Button();
            panelRight = new Panel();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTim = new Button();
            dgvLopHoc = new DataGridView();
            btnDauTrang = new Button();
            btnTrangTruoc = new Button();
            lblTrang = new Label();
            btnTrangSau = new Button();
            btnCuoiTrang = new Button();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLopHoc).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(236, 240, 241);
            panelLeft.Controls.Add(lblThongTin);
            panelLeft.Controls.Add(lblMaID);
            panelLeft.Controls.Add(txtMaID);
            panelLeft.Controls.Add(lblMaLop);
            panelLeft.Controls.Add(txtMaLop);
            panelLeft.Controls.Add(lblTenLop);
            panelLeft.Controls.Add(txtTenLop);
            panelLeft.Controls.Add(lblGhiChu);
            panelLeft.Controls.Add(txtGhiChu);
            panelLeft.Controls.Add(btnThem);
            panelLeft.Controls.Add(btnSua);
            panelLeft.Controls.Add(btnXoa);
            panelLeft.Controls.Add(btnLamMoi);
            panelLeft.Controls.Add(btnXemDS);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(394, 818);
            panelLeft.TabIndex = 0;
            // 
            // lblThongTin
            // 
            lblThongTin.AutoSize = true;
            lblThongTin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblThongTin.ForeColor = Color.FromArgb(44, 62, 80);
            lblThongTin.Location = new Point(25, 30);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(262, 31);
            lblThongTin.TabIndex = 0;
            lblThongTin.Text = "THÔNG TIN LỚP HỌC";
            // 
            // lblMaID
            // 
            lblMaID.AutoSize = true;
            lblMaID.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMaID.Location = new Point(25, 90);
            lblMaID.Name = "lblMaID";
            lblMaID.Size = new Size(61, 23);
            lblMaID.TabIndex = 1;
            lblMaID.Text = "Mã ID:";
            // 
            // txtMaID
            // 
            txtMaID.Font = new Font("Segoe UI", 10.8F);
            txtMaID.Location = new Point(25, 120);
            txtMaID.Name = "txtMaID";
            txtMaID.Size = new Size(340, 31);
            txtMaID.TabIndex = 2;
            // 
            // lblMaLop
            // 
            lblMaLop.AutoSize = true;
            lblMaLop.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMaLop.Location = new Point(25, 170);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Size = new Size(71, 23);
            lblMaLop.TabIndex = 3;
            lblMaLop.Text = "Mã lớp:";
            // 
            // txtMaLop
            // 
            txtMaLop.Font = new Font("Segoe UI", 10.8F);
            txtMaLop.Location = new Point(25, 200);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(340, 31);
            txtMaLop.TabIndex = 4;
            // 
            // lblTenLop
            // 
            lblTenLop.AutoSize = true;
            lblTenLop.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTenLop.Location = new Point(25, 250);
            lblTenLop.Name = "lblTenLop";
            lblTenLop.Size = new Size(73, 23);
            lblTenLop.TabIndex = 5;
            lblTenLop.Text = "Tên lớp:";
            // 
            // txtTenLop
            // 
            txtTenLop.Font = new Font("Segoe UI", 10.8F);
            txtTenLop.Location = new Point(25, 280);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(340, 31);
            txtTenLop.TabIndex = 6;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGhiChu.Location = new Point(25, 330);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(75, 23);
            lblGhiChu.TabIndex = 7;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Segoe UI", 10.8F);
            txtGhiChu.Location = new Point(25, 360);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(340, 31);
            txtGhiChu.TabIndex = 8;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(52, 152, 219);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(25, 430);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(160, 45);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(46, 204, 113);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(205, 430);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(160, 45);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(231, 76, 60);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(25, 490);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(160, 45);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(149, 165, 166);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(205, 490);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(160, 45);
            btnLamMoi.TabIndex = 12;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXemDS
            // 
            btnXemDS.BackColor = Color.FromArgb(52, 73, 94);
            btnXemDS.FlatStyle = FlatStyle.Flat;
            btnXemDS.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXemDS.ForeColor = Color.White;
            btnXemDS.Location = new Point(25, 555);
            btnXemDS.Name = "btnXemDS";
            btnXemDS.Size = new Size(340, 48);
            btnXemDS.TabIndex = 13;
            btnXemDS.Text = "Xem danh sách sinh viên";
            btnXemDS.UseVisualStyleBackColor = false;
            btnXemDS.Click += btnXemDS_Click;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(lblTimKiem);
            panelRight.Controls.Add(txtTimKiem);
            panelRight.Controls.Add(btnTim);
            panelRight.Controls.Add(dgvLopHoc);
            panelRight.Controls.Add(btnDauTrang);
            panelRight.Controls.Add(btnTrangTruoc);
            panelRight.Controls.Add(lblTrang);
            panelRight.Controls.Add(btnTrangSau);
            panelRight.Controls.Add(btnCuoiTrang);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(394, 0);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(20);
            panelRight.Size = new Size(910, 818);
            panelRight.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTimKiem.Location = new Point(23, 30);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(299, 23);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm kiếm (Mã ID / Mã lớp / Tên lớp)";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.Font = new Font("Segoe UI", 11F);
            txtTimKiem.Location = new Point(23, 60);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(734, 32);
            txtTimKiem.TabIndex = 1;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTim.BackColor = Color.FromArgb(44, 62, 80);
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTim.ForeColor = Color.White;
            btnTim.Location = new Point(773, 58);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(110, 35);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // dgvLopHoc
            // 
            dgvLopHoc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLopHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLopHoc.BackgroundColor = Color.White;
            dgvLopHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLopHoc.Location = new Point(23, 120);
            dgvLopHoc.Name = "dgvLopHoc";
            dgvLopHoc.RowHeadersWidth = 51;
            dgvLopHoc.RowTemplate.Height = 24;
            dgvLopHoc.Size = new Size(860, 598);
            dgvLopHoc.TabIndex = 3;
            // 
            // btnDauTrang
            // 
            btnDauTrang.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDauTrang.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDauTrang.Location = new Point(23, 743);
            btnDauTrang.Name = "btnDauTrang";
            btnDauTrang.Size = new Size(55, 40);
            btnDauTrang.TabIndex = 4;
            btnDauTrang.Text = "<<";
            btnDauTrang.UseVisualStyleBackColor = true;
            btnDauTrang.Click += btnFirst_Click;
            // 
            // btnTrangTruoc
            // 
            btnTrangTruoc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTrangTruoc.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTrangTruoc.Location = new Point(84, 743);
            btnTrangTruoc.Name = "btnTrangTruoc";
            btnTrangTruoc.Size = new Size(55, 40);
            btnTrangTruoc.TabIndex = 5;
            btnTrangTruoc.Text = "<";
            btnTrangTruoc.UseVisualStyleBackColor = true;
            btnTrangTruoc.Click += btnPrev_Click;
            // 
            // lblTrang
            // 
            lblTrang.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTrang.Font = new Font("Segoe UI", 10F);
            lblTrang.Location = new Point(145, 743);
            lblTrang.Name = "lblTrang";
            lblTrang.Size = new Size(602, 40);
            lblTrang.TabIndex = 6;
            lblTrang.Text = "Trang 1 / 1";
            lblTrang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTrangSau
            // 
            btnTrangSau.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTrangSau.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTrangSau.Location = new Point(753, 743);
            btnTrangSau.Name = "btnTrangSau";
            btnTrangSau.Size = new Size(55, 40);
            btnTrangSau.TabIndex = 7;
            btnTrangSau.Text = ">";
            btnTrangSau.UseVisualStyleBackColor = true;
            btnTrangSau.Click += btnNext_Click;
            // 
            // btnCuoiTrang
            // 
            btnCuoiTrang.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCuoiTrang.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCuoiTrang.Location = new Point(814, 743);
            btnCuoiTrang.Name = "btnCuoiTrang";
            btnCuoiTrang.Size = new Size(55, 40);
            btnCuoiTrang.TabIndex = 8;
            btnCuoiTrang.Text = ">>";
            btnCuoiTrang.UseVisualStyleBackColor = true;
            btnCuoiTrang.Click += btnLast_Click;
            // 
            // UC_QLLH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Name = "UC_QLLH";
            Size = new Size(1304, 818);
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLopHoc).EndInit();
            ResumeLayout(false);
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