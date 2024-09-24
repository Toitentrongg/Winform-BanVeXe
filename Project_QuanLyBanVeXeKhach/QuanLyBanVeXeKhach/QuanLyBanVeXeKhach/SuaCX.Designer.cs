namespace QuanLyBanVeXeKhach
{
    partial class SuaCX
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
            this.label3 = new System.Windows.Forms.Label();
            this.MaCX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTGDi = new System.Windows.Forms.DateTimePicker();
            this.dateTGXuatPhat = new System.Windows.Forms.DateTimePicker();
            this.SoVeCon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSLGhe = new System.Windows.Forms.ComboBox();
            this.cbMaTuyen = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.qLBVXDataSet = new QuanLyBanVeXeKhach.QLBVXDataSet();
            this.tuyenXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tuyenXeTableAdapter = new QuanLyBanVeXeKhach.QLBVXDataSetTableAdapters.TuyenXeTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuyenXeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã Tuyến :";
            // 
            // MaCX
            // 
            this.MaCX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaCX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaCX.Location = new System.Drawing.Point(178, 32);
            this.MaCX.Name = "MaCX";
            this.MaCX.Size = new System.Drawing.Size(163, 30);
            this.MaCX.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã Chuyến Xe : ";
            // 
            // DateTGDi
            // 
            this.DateTGDi.CustomFormat = "HH:mm";
            this.DateTGDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTGDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTGDi.Location = new System.Drawing.Point(602, 78);
            this.DateTGDi.Name = "DateTGDi";
            this.DateTGDi.ShowUpDown = true;
            this.DateTGDi.Size = new System.Drawing.Size(161, 30);
            this.DateTGDi.TabIndex = 30;
            this.DateTGDi.Value = new System.DateTime(2023, 12, 18, 0, 0, 0, 0);
            // 
            // dateTGXuatPhat
            // 
            this.dateTGXuatPhat.CustomFormat = "dd/MM/yyyy";
            this.dateTGXuatPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTGXuatPhat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTGXuatPhat.Location = new System.Drawing.Point(602, 35);
            this.dateTGXuatPhat.Name = "dateTGXuatPhat";
            this.dateTGXuatPhat.Size = new System.Drawing.Size(161, 30);
            this.dateTGXuatPhat.TabIndex = 29;
            this.dateTGXuatPhat.Value = new System.DateTime(2023, 12, 18, 0, 0, 0, 0);
            // 
            // SoVeCon
            // 
            this.SoVeCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoVeCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoVeCon.Location = new System.Drawing.Point(178, 122);
            this.SoVeCon.Name = "SoVeCon";
            this.SoVeCon.Size = new System.Drawing.Size(163, 30);
            this.SoVeCon.TabIndex = 28;
            this.SoVeCon.TextChanged += new System.EventHandler(this.SoVeCon_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Số Vé Còn :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(380, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Số Lượng Ghế :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(380, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Thời Gian Đi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(380, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Thời Gian Xuất Phát :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 38);
            this.label1.TabIndex = 31;
            this.label1.Text = "SỬA CHUYẾN XE";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbSLGhe);
            this.panel1.Controls.Add(this.cbMaTuyen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.MaCX);
            this.panel1.Controls.Add(this.DateTGDi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTGXuatPhat);
            this.panel1.Controls.Add(this.SoVeCon);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 188);
            this.panel1.TabIndex = 32;
            // 
            // cbSLGhe
            // 
            this.cbSLGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSLGhe.FormattingEnabled = true;
            this.cbSLGhe.Items.AddRange(new object[] {
            "36",
            "40",
            "45"});
            this.cbSLGhe.Location = new System.Drawing.Point(602, 121);
            this.cbSLGhe.Name = "cbSLGhe";
            this.cbSLGhe.Size = new System.Drawing.Size(161, 33);
            this.cbSLGhe.TabIndex = 32;
            // 
            // cbMaTuyen
            // 
            this.cbMaTuyen.DataSource = this.tuyenXeBindingSource;
            this.cbMaTuyen.DisplayMember = "MaTuyen";
            this.cbMaTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaTuyen.FormattingEnabled = true;
            this.cbMaTuyen.Location = new System.Drawing.Point(178, 72);
            this.cbMaTuyen.Name = "cbMaTuyen";
            this.cbMaTuyen.Size = new System.Drawing.Size(163, 33);
            this.cbMaTuyen.TabIndex = 31;
            this.cbMaTuyen.ValueMember = "MaTuyen";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(187, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 54);
            this.button1.TabIndex = 33;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(398, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 54);
            this.button2.TabIndex = 34;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // qLBVXDataSet
            // 
            this.qLBVXDataSet.DataSetName = "QLBVXDataSet";
            this.qLBVXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tuyenXeBindingSource
            // 
            this.tuyenXeBindingSource.DataMember = "TuyenXe";
            this.tuyenXeBindingSource.DataSource = this.qLBVXDataSet;
            // 
            // tuyenXeTableAdapter
            // 
            this.tuyenXeTableAdapter.ClearBeforeFill = true;
            // 
            // SuaCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(795, 357);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "SuaCX";
            this.Text = "SuaCX";
            this.Load += new System.EventHandler(this.SuaCX_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuyenXeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaCX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateTGDi;
        private System.Windows.Forms.DateTimePicker dateTGXuatPhat;
        private System.Windows.Forms.TextBox SoVeCon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbMaTuyen;
        private System.Windows.Forms.ComboBox cbSLGhe;
        private QLBVXDataSet qLBVXDataSet;
        private System.Windows.Forms.BindingSource tuyenXeBindingSource;
        private QLBVXDataSetTableAdapters.TuyenXeTableAdapter tuyenXeTableAdapter;
    }
}