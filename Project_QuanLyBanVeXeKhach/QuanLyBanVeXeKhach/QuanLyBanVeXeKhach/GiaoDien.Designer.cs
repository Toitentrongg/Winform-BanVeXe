namespace QuanLyBanVeXeKhach
{
    partial class GiaoDien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.QLTK = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.OUT = new System.Windows.Forms.ToolStripMenuItem();
            this.Ve = new System.Windows.Forms.ToolStripMenuItem();
            this.CTCX = new System.Windows.Forms.ToolStripMenuItem();
            this.BanVe = new System.Windows.Forms.ToolStripMenuItem();
            this.QLTuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.Ve,
            this.btnThongKe,
            this.btnTimKiem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DangNhap,
            this.DangXuat,
            this.QLTK,
            this.QLNV,
            this.OUT});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // DangNhap
            // 
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(175, 22);
            this.DangNhap.Text = "Đăng Nhập";
            this.DangNhap.Click += new System.EventHandler(this.DangNhap_Click);
            // 
            // DangXuat
            // 
            this.DangXuat.Enabled = false;
            this.DangXuat.Name = "DangXuat";
            this.DangXuat.Size = new System.Drawing.Size(175, 22);
            this.DangXuat.Text = "Đăng Xuất";
            this.DangXuat.Click += new System.EventHandler(this.DangXuat_Click);
            // 
            // QLTK
            // 
            this.QLTK.Enabled = false;
            this.QLTK.Name = "QLTK";
            this.QLTK.Size = new System.Drawing.Size(175, 22);
            this.QLTK.Text = "Quản Lý Tài Khoản";
            this.QLTK.Click += new System.EventHandler(this.QLTK_Click);
            // 
            // QLNV
            // 
            this.QLNV.Enabled = false;
            this.QLNV.Name = "QLNV";
            this.QLNV.Size = new System.Drawing.Size(175, 22);
            this.QLNV.Text = "Quản Lý Nhân Viên";
            this.QLNV.Click += new System.EventHandler(this.QLNV_Click);
            // 
            // OUT
            // 
            this.OUT.Name = "OUT";
            this.OUT.Size = new System.Drawing.Size(175, 22);
            this.OUT.Text = "Thoát";
            this.OUT.Click += new System.EventHandler(this.OUT_Click);
            // 
            // Ve
            // 
            this.Ve.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTCX,
            this.BanVe,
            this.QLTuyen});
            this.Ve.Enabled = false;
            this.Ve.Name = "Ve";
            this.Ve.Size = new System.Drawing.Size(31, 20);
            this.Ve.Text = "Vé";
            // 
            // CTCX
            // 
            this.CTCX.Name = "CTCX";
            this.CTCX.Size = new System.Drawing.Size(174, 22);
            this.CTCX.Text = "Chi Tiết Chuyến Xe";
            this.CTCX.Click += new System.EventHandler(this.CTCX_Click);
            // 
            // BanVe
            // 
            this.BanVe.Name = "BanVe";
            this.BanVe.Size = new System.Drawing.Size(174, 22);
            this.BanVe.Text = "Bán Vé";
            this.BanVe.Click += new System.EventHandler(this.BanVe_Click);
            // 
            // QLTuyen
            // 
            this.QLTuyen.Name = "QLTuyen";
            this.QLTuyen.Size = new System.Drawing.Size(174, 22);
            this.QLTuyen.Text = "Quản Lý Tuyến Xe";
            this.QLTuyen.Click += new System.EventHandler(this.QLTuyen_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Enabled = false;
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(130, 20);
            this.btnThongKe.Text = "Thống Kê Doanh Thu";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Enabled = false;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(69, 20);
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(1, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(881, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "  QUẢN LÝ BÁN VÉ XE KHÁCH                       ";
            // 
            // chuyenXeTableAdapter1
            // 
            // 
            // GiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanVeXeKhach.Properties.Resources._ee9d11f2_6b26_4aff_82a6_96f2fb408c4e__1_;
            this.ClientSize = new System.Drawing.Size(817, 794);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GiaoDien";
            this.Text = "GiaoDien";
            this.Load += new System.EventHandler(this.GiaoDien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DangNhap;
        private System.Windows.Forms.ToolStripMenuItem DangXuat;
        private System.Windows.Forms.ToolStripMenuItem QLTK;
        private System.Windows.Forms.ToolStripMenuItem QLNV;
        private System.Windows.Forms.ToolStripMenuItem OUT;
        private System.Windows.Forms.ToolStripMenuItem Ve;
        private System.Windows.Forms.ToolStripMenuItem CTCX;
        private System.Windows.Forms.ToolStripMenuItem BanVe;
        private System.Windows.Forms.ToolStripMenuItem btnThongKe;
        private System.Windows.Forms.ToolStripMenuItem btnTimKiem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem QLTuyen;
    }
}