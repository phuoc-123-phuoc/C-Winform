namespace MasterForm
{
    partial class UC_NhapHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_CTHD = new System.Windows.Forms.Button();
            this.btn_CapNhap = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.BTN_Sua = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNhanVien = new System.Windows.Forms.ComboBox();
            this.cbxNhaCC = new System.Windows.Forms.ComboBox();
            this.tklb_ = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1017, 380);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaDh";
            this.Column1.HeaderText = "Mã nhập hàng";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenNv";
            this.Column2.HeaderText = "Nhân viên nhập hàng";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "TenNcc";
            this.Column3.HeaderText = "Nhà cung cấp";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "NgayLap";
            this.Column4.HeaderText = "Ngày nhập";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 46);
            this.label2.TabIndex = 16;
            this.label2.Text = "THÔNG TIN NHẬP HÀNG";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(30, 232);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(135, 46);
            this.btn_Them.TabIndex = 32;
            this.btn_Them.Text = "THÊM";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_CTHD
            // 
            this.btn_CTHD.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_CTHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CTHD.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CTHD.ForeColor = System.Drawing.Color.White;
            this.btn_CTHD.Location = new System.Drawing.Point(616, 232);
            this.btn_CTHD.Name = "btn_CTHD";
            this.btn_CTHD.Size = new System.Drawing.Size(303, 46);
            this.btn_CTHD.TabIndex = 31;
            this.btn_CTHD.Text = "CHI TIẾT HÓA ĐƠN";
            this.btn_CTHD.UseVisualStyleBackColor = false;
            this.btn_CTHD.Click += new System.EventHandler(this.btn_CTHD_Click);
            // 
            // btn_CapNhap
            // 
            this.btn_CapNhap.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_CapNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhap.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhap.ForeColor = System.Drawing.Color.White;
            this.btn_CapNhap.Location = new System.Drawing.Point(616, 176);
            this.btn_CapNhap.Name = "btn_CapNhap";
            this.btn_CapNhap.Size = new System.Drawing.Size(303, 46);
            this.btn_CapNhap.TabIndex = 30;
            this.btn_CapNhap.Text = "NHÀ CUNG CẤP";
            this.btn_CapNhap.UseVisualStyleBackColor = false;
            this.btn_CapNhap.Click += new System.EventHandler(this.btn_CapNhap_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(442, 232);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(135, 46);
            this.btn_Xoa.TabIndex = 29;
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
            this.BTN_Sua.Location = new System.Drawing.Point(237, 232);
            this.BTN_Sua.Name = "BTN_Sua";
            this.BTN_Sua.Size = new System.Drawing.Size(135, 46);
            this.BTN_Sua.TabIndex = 28;
            this.BTN_Sua.Text = "SỬA";
            this.BTN_Sua.UseVisualStyleBackColor = false;
            this.BTN_Sua.Click += new System.EventHandler(this.BTN_Sua_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tên nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(326, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tên nhân viên";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(30, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 32);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ngày nhập hàng";
            // 
            // cbxNhanVien
            // 
            this.cbxNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cbxNhanVien.FormattingEnabled = true;
            this.cbxNhanVien.Location = new System.Drawing.Point(330, 105);
            this.cbxNhanVien.Name = "cbxNhanVien";
            this.cbxNhanVien.Size = new System.Drawing.Size(247, 33);
            this.cbxNhanVien.TabIndex = 33;
            // 
            // cbxNhaCC
            // 
            this.cbxNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cbxNhaCC.FormattingEnabled = true;
            this.cbxNhaCC.Location = new System.Drawing.Point(29, 176);
            this.cbxNhaCC.Name = "cbxNhaCC";
            this.cbxNhaCC.Size = new System.Drawing.Size(247, 33);
            this.cbxNhaCC.TabIndex = 35;
            // 
            // tklb_
            // 
            this.tklb_.AutoSize = true;
            this.tklb_.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tklb_.ForeColor = System.Drawing.Color.Black;
            this.tklb_.Location = new System.Drawing.Point(601, 81);
            this.tklb_.Name = "tklb_";
            this.tklb_.Size = new System.Drawing.Size(202, 23);
            this.tklb_.TabIndex = 36;
            this.tklb_.Text = "Tìm kiếm theo mã nhập";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(605, 105);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(303, 34);
            this.txt_TimKiem.TabIndex = 37;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // UC_NhapHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.tklb_);
            this.Controls.Add(this.cbxNhaCC);
            this.Controls.Add(this.cbxNhanVien);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_CTHD);
            this.Controls.Add(this.btn_CapNhap);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.BTN_Sua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Name = "UC_NhapHang";
            this.Size = new System.Drawing.Size(1023, 664);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_CTHD;
        private System.Windows.Forms.Button btn_CapNhap;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button BTN_Sua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNhanVien;
        private System.Windows.Forms.ComboBox cbxNhaCC;
        private System.Windows.Forms.Label tklb_;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
