namespace QuanLyBanVeXeKhach
{
    partial class ThemVe
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
            this.btnThemTuyen = new System.Windows.Forms.Button();
            this.cbMaTuyen = new System.Windows.Forms.ComboBox();
            this.tuyenXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBVXDataSet = new QuanLyBanVeXeKhach.QLBVXDataSet();
            this.cbSLGhe = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DateTGDi = new System.Windows.Forms.DateTimePicker();
            this.dateTGXuatPhat = new System.Windows.Forms.DateTimePicker();
            this.SoVeCon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaCX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chuyenXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chuyenXeTableAdapter = new QuanLyBanVeXeKhach.QLBVXDataSetTableAdapters.ChuyenXeTableAdapter();
            this.tuyenXeTableAdapter = new QuanLyBanVeXeKhach.QLBVXDataSetTableAdapters.TuyenXeTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tuyenXeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenXeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemTuyen);
            this.groupBox1.Controls.Add(this.cbMaTuyen);
            this.groupBox1.Controls.Add(this.cbSLGhe);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.DateTGDi);
            this.groupBox1.Controls.Add(this.dateTGXuatPhat);
            this.groupBox1.Controls.Add(this.SoVeCon);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MaCX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tuyến";
            // 
            // btnThemTuyen
            // 
            this.btnThemTuyen.Location = new System.Drawing.Point(483, 199);
            this.btnThemTuyen.Name = "btnThemTuyen";
            this.btnThemTuyen.Size = new System.Drawing.Size(148, 43);
            this.btnThemTuyen.TabIndex = 24;
            this.btnThemTuyen.Text = "Thêm Tuyến";
            this.btnThemTuyen.UseVisualStyleBackColor = true;
            this.btnThemTuyen.Click += new System.EventHandler(this.btnThemTuyen_Click);
            // 
            // cbMaTuyen
            // 
            this.cbMaTuyen.DataSource = this.tuyenXeBindingSource;
            this.cbMaTuyen.DisplayMember = "MaTuyen";
            this.cbMaTuyen.FormattingEnabled = true;
            this.cbMaTuyen.Location = new System.Drawing.Point(182, 94);
            this.cbMaTuyen.Name = "cbMaTuyen";
            this.cbMaTuyen.Size = new System.Drawing.Size(240, 33);
            this.cbMaTuyen.TabIndex = 23;
            this.cbMaTuyen.ValueMember = "MaTuyen";
            // 
            // tuyenXeBindingSource
            // 
            this.tuyenXeBindingSource.DataMember = "TuyenXe";
            this.tuyenXeBindingSource.DataSource = this.qLBVXDataSet;
            // 
            // qLBVXDataSet
            // 
            this.qLBVXDataSet.DataSetName = "QLBVXDataSet";
            this.qLBVXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbSLGhe
            // 
            this.cbSLGhe.FormattingEnabled = true;
            this.cbSLGhe.Items.AddRange(new object[] {
            "36",
            "40",
            "45"});
            this.cbSLGhe.Location = new System.Drawing.Point(659, 139);
            this.cbSLGhe.Name = "cbSLGhe";
            this.cbSLGhe.Size = new System.Drawing.Size(240, 33);
            this.cbSLGhe.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(637, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 43);
            this.button4.TabIndex = 21;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(329, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 43);
            this.button3.TabIndex = 20;
            this.button3.Text = "Sửa Chuyến";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 43);
            this.button2.TabIndex = 19;
            this.button2.Text = "Xoá Chuyến";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 43);
            this.button1.TabIndex = 18;
            this.button1.Text = "Thêm Chuyến";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DateTGDi
            // 
            this.DateTGDi.CustomFormat = "HH:mm";
            this.DateTGDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTGDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTGDi.Location = new System.Drawing.Point(659, 92);
            this.DateTGDi.Name = "DateTGDi";
            this.DateTGDi.ShowUpDown = true;
            this.DateTGDi.Size = new System.Drawing.Size(161, 27);
            this.DateTGDi.TabIndex = 17;
            this.DateTGDi.Value = new System.DateTime(2023, 12, 18, 0, 0, 0, 0);
            // 
            // dateTGXuatPhat
            // 
            this.dateTGXuatPhat.CustomFormat = "dd/MM/yyyy";
            this.dateTGXuatPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTGXuatPhat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTGXuatPhat.Location = new System.Drawing.Point(659, 40);
            this.dateTGXuatPhat.Name = "dateTGXuatPhat";
            this.dateTGXuatPhat.Size = new System.Drawing.Size(161, 27);
            this.dateTGXuatPhat.TabIndex = 16;
            this.dateTGXuatPhat.Value = new System.DateTime(2023, 12, 18, 0, 0, 0, 0);
            // 
            // SoVeCon
            // 
            this.SoVeCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoVeCon.Location = new System.Drawing.Point(182, 147);
            this.SoVeCon.Name = "SoVeCon";
            this.SoVeCon.Size = new System.Drawing.Size(240, 30);
            this.SoVeCon.TabIndex = 12;
            this.SoVeCon.TextChanged += new System.EventHandler(this.SoVeCon_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Số Vé Còn :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Số Lượng Ghế :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Thời Gian Đi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thời Gian Xuất Phát :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Tuyến : ";
            // 
            // MaCX
            // 
            this.MaCX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaCX.Location = new System.Drawing.Point(182, 37);
            this.MaCX.Name = "MaCX";
            this.MaCX.Size = new System.Drawing.Size(240, 30);
            this.MaCX.TabIndex = 2;
            this.MaCX.TextChanged += new System.EventHandler(this.MaCX_TextChanged);
            this.MaCX.Leave += new System.EventHandler(this.MaCX_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Chuyến Xe : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Tiết Chuyến Xe";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(899, 265);
            this.dataGridView1.TabIndex = 4;
            // 
            // chuyenXeBindingSource
            // 
            this.chuyenXeBindingSource.DataMember = "ChuyenXe";
            this.chuyenXeBindingSource.DataSource = this.qLBVXDataSet;
            // 
            // chuyenXeTableAdapter
            // 
            this.chuyenXeTableAdapter.ClearBeforeFill = true;
            // 
            // tuyenXeTableAdapter
            // 
            this.tuyenXeTableAdapter.ClearBeforeFill = true;
            // 
            // ThemVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(921, 611);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThemVe";
            this.Text = "ThemVe";
            this.Load += new System.EventHandler(this.ThemVe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tuyenXeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBVXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenXeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaCX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SoVeCon;
        private System.Windows.Forms.DateTimePicker dateTGXuatPhat;
        private System.Windows.Forms.DateTimePicker DateTGDi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbSLGhe;
        private System.Windows.Forms.ComboBox cbMaTuyen;
        private System.Windows.Forms.Button btnThemTuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuyenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianXuatPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoVeCon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChuyenXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianXuatPhatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianDiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongGheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soVeConDataGridViewTextBoxColumn;
        private QLBVXDataSet qLBVXDataSet;
        private System.Windows.Forms.BindingSource chuyenXeBindingSource;
        private QLBVXDataSetTableAdapters.ChuyenXeTableAdapter chuyenXeTableAdapter;
        private System.Windows.Forms.BindingSource tuyenXeBindingSource;
        private QLBVXDataSetTableAdapters.TuyenXeTableAdapter tuyenXeTableAdapter;
    }
}