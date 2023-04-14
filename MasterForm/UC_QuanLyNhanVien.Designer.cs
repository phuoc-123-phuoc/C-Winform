namespace MasterForm
{
    partial class UC_QuanLyNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker6 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker7 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker8 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker9 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.BTN_Sua = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dTime_Ngayvaolam = new System.Windows.Forms.DateTimePicker();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DangNhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(3, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1017, 364);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaNv";
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Hoten";
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "NgayVaolam";
            this.Column3.HeaderText = "Ngày Vào Làm";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "SDT";
            this.Column4.HeaderText = "Số Điện Thoại";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 46);
            this.label2.TabIndex = 16;
            this.label2.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(570, 231);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(135, 46);
            this.btn_Them.TabIndex = 35;
            this.btn_Them.Text = "THÊM";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(852, 231);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(135, 46);
            this.btn_Xoa.TabIndex = 33;
            this.btn_Xoa.Text = "XÓA";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // BTN_Sua
            // 
            this.BTN_Sua.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Sua.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Sua.ForeColor = System.Drawing.Color.White;
            this.BTN_Sua.Location = new System.Drawing.Point(711, 231);
            this.BTN_Sua.Name = "BTN_Sua";
            this.BTN_Sua.Size = new System.Drawing.Size(135, 46);
            this.BTN_Sua.TabIndex = 32;
            this.BTN_Sua.Text = "SỬA";
            this.BTN_Sua.UseVisualStyleBackColor = false;
            this.BTN_Sua.Click += new System.EventHandler(this.BTN_Sua_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ngày Vào Làm";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(358, 173);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(276, 34);
            this.txt_SDT.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(354, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Số Điện Thoại";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(358, 99);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(276, 34);
            this.txt_HoTen.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(354, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Họ Tên";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Location = new System.Drawing.Point(21, 99);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.ReadOnly = true;
            this.txt_MaNV.Size = new System.Drawing.Size(276, 34);
            this.txt_MaNV.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // dTime_Ngayvaolam
            // 
            this.dTime_Ngayvaolam.AllowDrop = true;
            this.dTime_Ngayvaolam.CustomFormat = "yyyy-MM-dd";
            this.dTime_Ngayvaolam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dTime_Ngayvaolam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTime_Ngayvaolam.Location = new System.Drawing.Point(21, 176);
            this.dTime_Ngayvaolam.Name = "dTime_Ngayvaolam";
            this.dTime_Ngayvaolam.Size = new System.Drawing.Size(281, 30);
            this.dTime_Ngayvaolam.TabIndex = 36;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(20, 248);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(507, 34);
            this.txt_TimKiem.TabIndex = 37;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 23);
            this.label6.TabIndex = 38;
            this.label6.Text = "Tìm Kiếm Theo Tên Nhân Viên";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_DangNhap
            // 
            this.txt_DangNhap.BackColor = System.Drawing.Color.DodgerBlue;
            this.txt_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_DangNhap.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DangNhap.ForeColor = System.Drawing.Color.White;
            this.txt_DangNhap.Location = new System.Drawing.Point(697, 99);
            this.txt_DangNhap.Name = "txt_DangNhap";
            this.txt_DangNhap.Size = new System.Drawing.Size(229, 97);
            this.txt_DangNhap.TabIndex = 39;
            this.txt_DangNhap.Text = "THÔNG TIN ĐĂNG NHẬP";
            this.txt_DangNhap.UseVisualStyleBackColor = false;
            this.txt_DangNhap.Click += new System.EventHandler(this.txt_DangNhap_Click);
            // 
            // UC_QuanLyNhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.txt_DangNhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.dTime_Ngayvaolam);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.BTN_Sua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Name = "UC_QuanLyNhanVien";
            this.Size = new System.Drawing.Size(1023, 664);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.ComponentModel.BackgroundWorker backgroundWorker6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker7;
        private System.ComponentModel.BackgroundWorker backgroundWorker8;
        private System.ComponentModel.BackgroundWorker backgroundWorker9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button BTN_Sua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dTime_Ngayvaolam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button txt_DangNhap;
    }
}
