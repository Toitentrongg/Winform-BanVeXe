namespace QuanLyBanVeXeKhach
{
    partial class ThongKe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDoanhThuTheoChuyen = new System.Windows.Forms.Button();
            this.btnThongKeTheoTuyen = new System.Windows.Forms.Button();
            this.NgayHienTai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnDoanhThuTheoChuyen);
            this.groupBox1.Controls.Add(this.btnThongKeTheoTuyen);
            this.groupBox1.Controls.Add(this.NgayHienTai);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 322);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thống Kê Theo Tháng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDoanhThuTheoChuyen
            // 
            this.btnDoanhThuTheoChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThuTheoChuyen.Location = new System.Drawing.Point(11, 142);
            this.btnDoanhThuTheoChuyen.Name = "btnDoanhThuTheoChuyen";
            this.btnDoanhThuTheoChuyen.Size = new System.Drawing.Size(266, 42);
            this.btnDoanhThuTheoChuyen.TabIndex = 9;
            this.btnDoanhThuTheoChuyen.Text = "Thống Kê Theo Chuyến";
            this.btnDoanhThuTheoChuyen.UseVisualStyleBackColor = true;
            this.btnDoanhThuTheoChuyen.Click += new System.EventHandler(this.btnDoanhThuTheoChuyen_Click);
            // 
            // btnThongKeTheoTuyen
            // 
            this.btnThongKeTheoTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeTheoTuyen.Location = new System.Drawing.Point(11, 85);
            this.btnThongKeTheoTuyen.Name = "btnThongKeTheoTuyen";
            this.btnThongKeTheoTuyen.Size = new System.Drawing.Size(266, 42);
            this.btnThongKeTheoTuyen.TabIndex = 8;
            this.btnThongKeTheoTuyen.Text = "Thống Kê Theo Tuyến";
            this.btnThongKeTheoTuyen.UseVisualStyleBackColor = true;
            this.btnThongKeTheoTuyen.Click += new System.EventHandler(this.btnThongKeTheoTuyen_Click);
            // 
            // NgayHienTai
            // 
            this.NgayHienTai.AutoSize = true;
            this.NgayHienTai.Location = new System.Drawing.Point(159, 41);
            this.NgayHienTai.Name = "NgayHienTai";
            this.NgayHienTai.Size = new System.Drawing.Size(0, 25);
            this.NgayHienTai.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ngày Hiện Tại :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "THỐNG KÊ DOANH THU";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(11, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 42);
            this.button2.TabIndex = 11;
            this.button2.Text = "Thống Kê Theo Năm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(519, 415);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label NgayHienTai;
        private System.Windows.Forms.Button btnThongKeTheoTuyen;
        private System.Windows.Forms.Button btnDoanhThuTheoChuyen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}