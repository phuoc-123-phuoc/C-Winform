namespace MasterForm
{
    partial class FormNhapHang
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
            this.textBox_GiaB = new System.Windows.Forms.TextBox();
            this.comboBox_TenSP = new System.Windows.Forms.ComboBox();
            this.label_TienNhap = new System.Windows.Forms.Label();
            this.button_Sua = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_LoaiHang = new System.Windows.Forms.TextBox();
            this.textBox_GiaN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_SoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.label_ChiTiet = new System.Windows.Forms.Label();
            this.label_ThongTinHoaDon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.textBox_Ngay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text_NCC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_maHd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NV = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_NhapHang = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.tienNhap = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_GiaB
            // 
            this.textBox_GiaB.BackColor = System.Drawing.Color.White;
            this.textBox_GiaB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_GiaB.ForeColor = System.Drawing.Color.Gray;
            this.textBox_GiaB.Location = new System.Drawing.Point(216, 178);
            this.textBox_GiaB.Name = "textBox_GiaB";
            this.textBox_GiaB.Size = new System.Drawing.Size(194, 34);
            this.textBox_GiaB.TabIndex = 0;
            // 
            // comboBox_TenSP
            // 
            this.comboBox_TenSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TenSP.FormattingEnabled = true;
            this.comboBox_TenSP.Location = new System.Drawing.Point(20, 87);
            this.comboBox_TenSP.Name = "comboBox_TenSP";
            this.comboBox_TenSP.Size = new System.Drawing.Size(390, 36);
            this.comboBox_TenSP.TabIndex = 0;
            this.comboBox_TenSP.SelectedValueChanged += new System.EventHandler(this.comboBox_TenSP_SelectedValueChanged);
            // 
            // label_TienNhap
            // 
            this.label_TienNhap.AutoSize = true;
            this.label_TienNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TienNhap.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_TienNhap.Location = new System.Drawing.Point(421, 843);
            this.label_TienNhap.Name = "label_TienNhap";
            this.label_TienNhap.Size = new System.Drawing.Size(138, 26);
            this.label_TienNhap.TabIndex = 11;
            this.label_TienNhap.Text = "TIỀN NHẬP";
            // 
            // button_Sua
            // 
            this.button_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sua.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sua.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_Sua.Location = new System.Drawing.Point(265, 350);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(145, 48);
            this.button_Sua.TabIndex = 9;
            this.button_Sua.Text = "SỬA";
            this.button_Sua.UseVisualStyleBackColor = false;
            this.button_Sua.Click += new System.EventHandler(this.button_ThanhToan_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.panel2.Controls.Add(this.textBox_LoaiHang);
            this.panel2.Controls.Add(this.textBox_GiaN);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox_SoLuong);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_GiaB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBox_TenSP);
            this.panel2.Controls.Add(this.button_Sua);
            this.panel2.Controls.Add(this.button_Xoa);
            this.panel2.Controls.Add(this.button_Them);
            this.panel2.Controls.Add(this.label_ChiTiet);
            this.panel2.Location = new System.Drawing.Point(396, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 445);
            this.panel2.TabIndex = 8;
            // 
            // textBox_LoaiHang
            // 
            this.textBox_LoaiHang.BackColor = System.Drawing.Color.White;
            this.textBox_LoaiHang.Enabled = false;
            this.textBox_LoaiHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LoaiHang.ForeColor = System.Drawing.Color.Gray;
            this.textBox_LoaiHang.Location = new System.Drawing.Point(216, 268);
            this.textBox_LoaiHang.Name = "textBox_LoaiHang";
            this.textBox_LoaiHang.ReadOnly = true;
            this.textBox_LoaiHang.Size = new System.Drawing.Size(194, 34);
            this.textBox_LoaiHang.TabIndex = 43;
            // 
            // textBox_GiaN
            // 
            this.textBox_GiaN.BackColor = System.Drawing.Color.White;
            this.textBox_GiaN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_GiaN.ForeColor = System.Drawing.Color.Gray;
            this.textBox_GiaN.Location = new System.Drawing.Point(20, 178);
            this.textBox_GiaN.Name = "textBox_GiaN";
            this.textBox_GiaN.Size = new System.Drawing.Size(175, 34);
            this.textBox_GiaN.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(212, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Giá Bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Loại Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Số Lượng";
            // 
            // textBox_SoLuong
            // 
            this.textBox_SoLuong.BackColor = System.Drawing.Color.White;
            this.textBox_SoLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SoLuong.ForeColor = System.Drawing.Color.Gray;
            this.textBox_SoLuong.Location = new System.Drawing.Point(20, 265);
            this.textBox_SoLuong.Name = "textBox_SoLuong";
            this.textBox_SoLuong.Size = new System.Drawing.Size(175, 34);
            this.textBox_SoLuong.TabIndex = 0;
            this.textBox_SoLuong.TextChanged += new System.EventHandler(this.textBox_SoLuong_TextChanged);
            this.textBox_SoLuong.Enter += new System.EventHandler(this.textBox_SoLuong_Enter);
            this.textBox_SoLuong.Leave += new System.EventHandler(this.textBox_SoLuong_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Giá Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tên SP";
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xoa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_Xoa.Location = new System.Drawing.Point(143, 350);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(116, 48);
            this.button_Xoa.TabIndex = 8;
            this.button_Xoa.Text = "XÓA ";
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Them.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_Them.Location = new System.Drawing.Point(8, 350);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(119, 48);
            this.button_Them.TabIndex = 7;
            this.button_Them.Text = "THÊM";
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // label_ChiTiet
            // 
            this.label_ChiTiet.AutoSize = true;
            this.label_ChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label_ChiTiet.Location = new System.Drawing.Point(113, 18);
            this.label_ChiTiet.Name = "label_ChiTiet";
            this.label_ChiTiet.Size = new System.Drawing.Size(194, 25);
            this.label_ChiTiet.TabIndex = 0;
            this.label_ChiTiet.Text = "Chi Tiết Sản Phẩm";
            // 
            // label_ThongTinHoaDon
            // 
            this.label_ThongTinHoaDon.AutoSize = true;
            this.label_ThongTinHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label_ThongTinHoaDon.Location = new System.Drawing.Point(99, 18);
            this.label_ThongTinHoaDon.Name = "label_ThongTinHoaDon";
            this.label_ThongTinHoaDon.Size = new System.Drawing.Size(201, 25);
            this.label_ThongTinHoaDon.TabIndex = 0;
            this.label_ThongTinHoaDon.Text = "Thông Tin Hóa Đơn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.btn_Excel);
            this.panel1.Controls.Add(this.textBox_Ngay);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.text_NCC);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_maHd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_NV);
            this.panel1.Controls.Add(this.label_ThongTinHoaDon);
            this.panel1.Location = new System.Drawing.Point(-1, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 445);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Excel
            // 
            this.btn_Excel.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excel.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Excel.Location = new System.Drawing.Point(238, 347);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(119, 48);
            this.btn_Excel.TabIndex = 44;
            this.btn_Excel.Text = "Excel";
            this.btn_Excel.UseVisualStyleBackColor = false;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // textBox_Ngay
            // 
            this.textBox_Ngay.BackColor = System.Drawing.Color.White;
            this.textBox_Ngay.Enabled = false;
            this.textBox_Ngay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Ngay.Location = new System.Drawing.Point(34, 268);
            this.textBox_Ngay.Name = "textBox_Ngay";
            this.textBox_Ngay.Size = new System.Drawing.Size(333, 34);
            this.textBox_Ngay.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Tên nhà cung cấp";
            // 
            // text_NCC
            // 
            this.text_NCC.BackColor = System.Drawing.Color.White;
            this.text_NCC.Enabled = false;
            this.text_NCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_NCC.Location = new System.Drawing.Point(34, 176);
            this.text_NCC.Name = "text_NCC";
            this.text_NCC.Size = new System.Drawing.Size(333, 34);
            this.text_NCC.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Ngày lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã Phiếu Nhập";
            // 
            // textBox_maHd
            // 
            this.textBox_maHd.BackColor = System.Drawing.Color.White;
            this.textBox_maHd.Enabled = false;
            this.textBox_maHd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_maHd.Location = new System.Drawing.Point(34, 355);
            this.textBox_maHd.Name = "textBox_maHd";
            this.textBox_maHd.Size = new System.Drawing.Size(161, 34);
            this.textBox_maHd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tên nhân viên";
            // 
            // textBox_NV
            // 
            this.textBox_NV.BackColor = System.Drawing.Color.White;
            this.textBox_NV.Enabled = false;
            this.textBox_NV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NV.Location = new System.Drawing.Point(38, 88);
            this.textBox_NV.Name = "textBox_NV";
            this.textBox_NV.Size = new System.Drawing.Size(333, 34);
            this.textBox_NV.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(389, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 443);
            this.panel3.TabIndex = 38;
            // 
            // label_NhapHang
            // 
            this.label_NhapHang.AutoSize = true;
            this.label_NhapHang.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NhapHang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_NhapHang.Location = new System.Drawing.Point(327, 10);
            this.label_NhapHang.Name = "label_NhapHang";
            this.label_NhapHang.Size = new System.Drawing.Size(188, 38);
            this.label_NhapHang.TabIndex = 6;
            this.label_NhapHang.Text = "NHẬP HÀNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 510);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(820, 306);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Ten";
            this.Column1.HeaderText = "Tên sản phẩm";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "SoLuong";
            this.Column2.HeaderText = "Số lượng";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "GiaNhap";
            this.Column3.HeaderText = "Giá nhập";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "GiaBan";
            this.Column4.HeaderText = "Giá bán";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Loai";
            this.Column5.HeaderText = "Loại Hàng";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // btn_Exit
            // 
            this.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btn_Exit.IconColor = System.Drawing.Color.Red;
            this.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit.IconSize = 24;
            this.btn_Exit.Location = new System.Drawing.Point(788, 1);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(31, 25);
            this.btn_Exit.TabIndex = 43;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // tienNhap
            // 
            this.tienNhap.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienNhap.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tienNhap.Location = new System.Drawing.Point(565, 833);
            this.tienNhap.Name = "tienNhap";
            this.tienNhap.ReadOnly = true;
            this.tienNhap.Size = new System.Drawing.Size(220, 41);
            this.tienNhap.TabIndex = 44;
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 893);
            this.Controls.Add(this.tienNhap);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label_TienNhap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_NhapHang);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhapHang";
            this.Load += new System.EventHandler(this.FormNhapHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_GiaB;
        private System.Windows.Forms.ComboBox comboBox_TenSP;
        private System.Windows.Forms.Label label_TienNhap;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Label label_ChiTiet;
        private System.Windows.Forms.Label label_ThongTinHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_maHd;
        private System.Windows.Forms.TextBox textBox_NV;
        private System.Windows.Forms.Label label_NhapHang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_SoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_NCC;
        private System.Windows.Forms.TextBox textBox_LoaiHang;
        private System.Windows.Forms.TextBox textBox_GiaN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox tienNhap;
        private System.Windows.Forms.Button btn_Excel;
    }
}