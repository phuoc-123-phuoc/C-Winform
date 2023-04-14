namespace MasterForm
{
    partial class FormHoaDon
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
            this.label_HoaDon = new System.Windows.Forms.Label();
            this.label_ThanhTien = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.label_ChiTietHoaDon = new System.Windows.Forms.Label();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxDm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.comboBox_TenSP = new System.Windows.Forms.ComboBox();
            this.label_ThongTinHoaDon = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SoHoaDon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.export_Excel = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxTong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_HoaDon
            // 
            this.label_HoaDon.AutoSize = true;
            this.label_HoaDon.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HoaDon.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_HoaDon.Location = new System.Drawing.Point(342, 9);
            this.label_HoaDon.Name = "label_HoaDon";
            this.label_HoaDon.Size = new System.Drawing.Size(152, 38);
            this.label_HoaDon.TabIndex = 0;
            this.label_HoaDon.Text = "HÓA ĐƠN";
            // 
            // label_ThanhTien
            // 
            this.label_ThanhTien.AutoSize = true;
            this.label_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThanhTien.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_ThanhTien.Location = new System.Drawing.Point(434, 843);
            this.label_ThanhTien.Name = "label_ThanhTien";
            this.label_ThanhTien.Size = new System.Drawing.Size(152, 26);
            this.label_ThanhTien.TabIndex = 5;
            this.label_ThanhTien.Text = "THÀNH TIỀN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 523);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(825, 306);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Masp";
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "tenSanPham";
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "gia";
            this.Column3.HeaderText = "Giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "SoLuong";
            this.Column5.HeaderText = "Số lượng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "danhMuc";
            this.Column4.HeaderText = "Danh mục";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btn_Exit.IconColor = System.Drawing.Color.Red;
            this.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit.IconSize = 24;
            this.btn_Exit.Location = new System.Drawing.Point(792, -2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(31, 25);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label_ChiTietHoaDon
            // 
            this.label_ChiTietHoaDon.AutoSize = true;
            this.label_ChiTietHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label_ChiTietHoaDon.Location = new System.Drawing.Point(113, 18);
            this.label_ChiTietHoaDon.Name = "label_ChiTietHoaDon";
            this.label_ChiTietHoaDon.Size = new System.Drawing.Size(178, 25);
            this.label_ChiTietHoaDon.TabIndex = 0;
            this.label_ChiTietHoaDon.Text = "Chi Tiết Hóa Đơn";
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Them.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_Them.Location = new System.Drawing.Point(9, 339);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(102, 48);
            this.button_Them.TabIndex = 7;
            this.button_Them.Text = "THÊM";
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xoa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_Xoa.Location = new System.Drawing.Point(118, 339);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(87, 48);
            this.button_Xoa.TabIndex = 8;
            this.button_Xoa.Text = "XÓA ";
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sua.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sua.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_Sua.Location = new System.Drawing.Point(209, 339);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(198, 48);
            this.button_Sua.TabIndex = 9;
            this.button_Sua.Text = "SỬA";
            this.button_Sua.UseVisualStyleBackColor = false;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên sản phẩm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.panel2.Controls.Add(this.textBoxDm);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_SoLuong);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_DonGia);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox_TenSP);
            this.panel2.Controls.Add(this.button_Sua);
            this.panel2.Controls.Add(this.button_Xoa);
            this.panel2.Controls.Add(this.button_Them);
            this.panel2.Controls.Add(this.label_ChiTietHoaDon);
            this.panel2.Location = new System.Drawing.Point(413, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 445);
            this.panel2.TabIndex = 2;
            // 
            // textBoxDm
            // 
            this.textBoxDm.BackColor = System.Drawing.Color.White;
            this.textBoxDm.Enabled = false;
            this.textBoxDm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDm.Location = new System.Drawing.Point(209, 267);
            this.textBoxDm.Name = "textBoxDm";
            this.textBoxDm.ReadOnly = true;
            this.textBoxDm.Size = new System.Drawing.Size(172, 34);
            this.textBoxDm.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(205, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Danh Mục";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số Lượng";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.BackColor = System.Drawing.Color.White;
            this.txt_SoLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.ForeColor = System.Drawing.Color.Gray;
            this.txt_SoLuong.Location = new System.Drawing.Point(30, 266);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(154, 34);
            this.txt_SoLuong.TabIndex = 0;
            this.txt_SoLuong.Text = "Thêm Số Lượng";
            this.txt_SoLuong.Enter += new System.EventHandler(this.textBox_SoLuong_Enter);
            this.txt_SoLuong.Leave += new System.EventHandler(this.textBox_SoLuong_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Đơn giá";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.BackColor = System.Drawing.Color.White;
            this.txt_DonGia.Enabled = false;
            this.txt_DonGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonGia.ForeColor = System.Drawing.Color.Gray;
            this.txt_DonGia.Location = new System.Drawing.Point(30, 172);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(351, 34);
            this.txt_DonGia.TabIndex = 0;
            this.txt_DonGia.Enter += new System.EventHandler(this.textBox_DonGia_Enter);
            this.txt_DonGia.Leave += new System.EventHandler(this.textBox_DonGia_Leave);
            // 
            // comboBox_TenSP
            // 
            this.comboBox_TenSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TenSP.FormattingEnabled = true;
            this.comboBox_TenSP.Location = new System.Drawing.Point(30, 92);
            this.comboBox_TenSP.Name = "comboBox_TenSP";
            this.comboBox_TenSP.Size = new System.Drawing.Size(351, 36);
            this.comboBox_TenSP.TabIndex = 0;
            this.comboBox_TenSP.SelectedIndexChanged += new System.EventHandler(this.comboBox_TenSP_SelectedIndexChanged);
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
            // txt_MaNV
            // 
            this.txt_MaNV.BackColor = System.Drawing.Color.White;
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Location = new System.Drawing.Point(39, 97);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.ReadOnly = true;
            this.txt_MaNV.Size = new System.Drawing.Size(333, 34);
            this.txt_MaNV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên khách hàng";
            // 
            // txt_SoHoaDon
            // 
            this.txt_SoHoaDon.BackColor = System.Drawing.Color.White;
            this.txt_SoHoaDon.Enabled = false;
            this.txt_SoHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoHoaDon.Location = new System.Drawing.Point(39, 339);
            this.txt_SoHoaDon.Name = "txt_SoHoaDon";
            this.txt_SoHoaDon.ReadOnly = true;
            this.txt_SoHoaDon.Size = new System.Drawing.Size(172, 34);
            this.txt_SoHoaDon.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số Hóa Đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ngày Ghi";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(408, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 443);
            this.panel3.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.export_Excel);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_SoHoaDon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_MaNV);
            this.panel1.Controls.Add(this.label_ThongTinHoaDon);
            this.panel1.Location = new System.Drawing.Point(-2, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 445);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // export_Excel
            // 
            this.export_Excel.BackColor = System.Drawing.Color.DarkGreen;
            this.export_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export_Excel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export_Excel.ForeColor = System.Drawing.Color.GhostWhite;
            this.export_Excel.Location = new System.Drawing.Point(232, 331);
            this.export_Excel.Name = "export_Excel";
            this.export_Excel.Size = new System.Drawing.Size(130, 56);
            this.export_Excel.TabIndex = 15;
            this.export_Excel.Text = "Excel";
            this.export_Excel.UseVisualStyleBackColor = false;
            this.export_Excel.Click += new System.EventHandler(this.export_Excel_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(39, 267);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(333, 34);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(39, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(333, 34);
            this.textBox1.TabIndex = 12;
            // 
            // textBoxTong
            // 
            this.textBoxTong.BackColor = System.Drawing.Color.White;
            this.textBoxTong.Enabled = false;
            this.textBoxTong.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTong.Location = new System.Drawing.Point(592, 835);
            this.textBoxTong.Name = "textBoxTong";
            this.textBoxTong.ReadOnly = true;
            this.textBoxTong.Size = new System.Drawing.Size(172, 41);
            this.textBoxTong.TabIndex = 15;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 880);
            this.Controls.Add(this.textBoxTong);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_ThanhTien);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_HoaDon);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_HoaDon;
        private System.Windows.Forms.Label label_ThanhTien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private System.Windows.Forms.Label label_ChiTietHoaDon;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.ComboBox comboBox_TenSP;
        private System.Windows.Forms.Label label_ThongTinHoaDon;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SoHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxDm;
        private System.Windows.Forms.TextBox textBoxTong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button export_Excel;
    }
}