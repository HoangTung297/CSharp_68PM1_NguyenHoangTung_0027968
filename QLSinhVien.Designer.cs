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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuQLSV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuQLSV, this.menuQLLopHoc, this.menuDangXuat });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(1280, 28);
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.BackColor = System.Drawing.Color.White;

            // menuQLSV
            this.menuQLSV.Text = "Quản Lý Sinh Viên";
            this.menuQLSV.ForeColor = System.Drawing.Color.Black;
            this.menuQLSV.Click += new System.EventHandler(this.menuQLSV_Click);

            // menuQLLopHoc
            this.menuQLLopHoc.Text = "Quản Lý Lớp Học";
            this.menuQLLopHoc.ForeColor = System.Drawing.Color.Black;
            this.menuQLLopHoc.Click += new System.EventHandler(this.menuQLLopHoc_Click);

            // menuDangXuat
            this.menuDangXuat.Text = "Đăng Xuất";
            this.menuDangXuat.ForeColor = System.Drawing.Color.OrangeRed;
            this.menuDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "Quản Lý Sinh Viên";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuQLSV;
        private System.Windows.Forms.ToolStripMenuItem menuQLLopHoc;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
    }
}