namespace MasterForm
{
    partial class FormMain
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
            this.panelLabel = new System.Windows.Forms.Panel();
            this.btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btn_DangXuat = new FontAwesome.Sharp.IconButton();
            this.btn_QuanLy = new FontAwesome.Sharp.IconButton();
            this.btn_NhapHang = new FontAwesome.Sharp.IconButton();
            this.btn_KhachHang = new FontAwesome.Sharp.IconButton();
            this.btn_SanPham = new FontAwesome.Sharp.IconButton();
            this.btn_HoaDon = new FontAwesome.Sharp.IconButton();
            this.btn_TrangChu = new FontAwesome.Sharp.IconButton();
            this.panelShow = new System.Windows.Forms.Panel();
            this.panelLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLabel
            // 
            this.panelLabel.BackColor = System.Drawing.Color.White;
            this.panelLabel.Controls.Add(this.btn_Minimize);
            this.panelLabel.Controls.Add(this.btn_Exit);
            this.panelLabel.Controls.Add(this.label1);
            this.panelLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLabel.ForeColor = System.Drawing.Color.Gray;
            this.panelLabel.Location = new System.Drawing.Point(195, 0);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(1023, 77);
            this.panelLabel.TabIndex = 3;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_Minimize.IconColor = System.Drawing.Color.Red;
            this.btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Minimize.IconSize = 24;
            this.btn_Minimize.Location = new System.Drawing.Point(955, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(31, 25);
            this.btn_Minimize.TabIndex = 2;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btn_Exit.IconColor = System.Drawing.Color.Red;
            this.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit.IconSize = 24;
            this.btn_Exit.Location = new System.Drawing.Point(989, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(31, 25);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(411, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "VNB SPORTS";
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = global::MasterForm.Properties.Resources.Logo_Shop;
            this.pictureBox_Logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(195, 114);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.White;
            this.panelButton.Controls.Add(this.btn_DangXuat);
            this.panelButton.Controls.Add(this.btn_QuanLy);
            this.panelButton.Controls.Add(this.btn_NhapHang);
            this.panelButton.Controls.Add(this.btn_KhachHang);
            this.panelButton.Controls.Add(this.btn_SanPham);
            this.panelButton.Controls.Add(this.btn_HoaDon);
            this.panelButton.Controls.Add(this.btn_TrangChu);
            this.panelButton.Controls.Add(this.pictureBox_Logo);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(195, 741);
            this.panelButton.TabIndex = 2;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_DangXuat.FlatAppearance.BorderSize = 0;
            this.btn_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.ForeColor = System.Drawing.Color.White;
            this.btn_DangXuat.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btn_DangXuat.IconColor = System.Drawing.Color.Black;
            this.btn_DangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DangXuat.IconSize = 44;
            this.btn_DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.Location = new System.Drawing.Point(0, 684);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(195, 57);
            this.btn_DangXuat.TabIndex = 17;
            this.btn_DangXuat.Text = "ĐĂNG XUẤT";
            this.btn_DangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_QuanLy
            // 
            this.btn_QuanLy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_QuanLy.FlatAppearance.BorderSize = 0;
            this.btn_QuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLy.ForeColor = System.Drawing.Color.White;
            this.btn_QuanLy.IconChar = FontAwesome.Sharp.IconChar.DriversLicense;
            this.btn_QuanLy.IconColor = System.Drawing.Color.Black;
            this.btn_QuanLy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_QuanLy.IconSize = 44;
            this.btn_QuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLy.Location = new System.Drawing.Point(0, 450);
            this.btn_QuanLy.Name = "btn_QuanLy";
            this.btn_QuanLy.Size = new System.Drawing.Size(195, 57);
            this.btn_QuanLy.TabIndex = 16;
            this.btn_QuanLy.Text = "QUẢN LÝ";
            this.btn_QuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QuanLy.UseVisualStyleBackColor = false;
            this.btn_QuanLy.Click += new System.EventHandler(this.btn_QuanLy_Click);
            // 
            // btn_NhapHang
            // 
            this.btn_NhapHang.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_NhapHang.FlatAppearance.BorderSize = 0;
            this.btn_NhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhapHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapHang.ForeColor = System.Drawing.Color.White;
            this.btn_NhapHang.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.btn_NhapHang.IconColor = System.Drawing.Color.Black;
            this.btn_NhapHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_NhapHang.IconSize = 44;
            this.btn_NhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhapHang.Location = new System.Drawing.Point(0, 397);
            this.btn_NhapHang.Name = "btn_NhapHang";
            this.btn_NhapHang.Size = new System.Drawing.Size(195, 57);
            this.btn_NhapHang.TabIndex = 14;
            this.btn_NhapHang.Text = "NHẬP HÀNG";
            this.btn_NhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhapHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_NhapHang.UseVisualStyleBackColor = false;
            this.btn_NhapHang.Click += new System.EventHandler(this.btn_NhapHang_Click);
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_KhachHang.FlatAppearance.BorderSize = 0;
            this.btn_KhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KhachHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhachHang.ForeColor = System.Drawing.Color.White;
            this.btn_KhachHang.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btn_KhachHang.IconColor = System.Drawing.Color.Black;
            this.btn_KhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_KhachHang.IconSize = 44;
            this.btn_KhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KhachHang.Location = new System.Drawing.Point(0, 343);
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Size = new System.Drawing.Size(195, 57);
            this.btn_KhachHang.TabIndex = 13;
            this.btn_KhachHang.Text = "KHÁCH HÀNG";
            this.btn_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_KhachHang.UseVisualStyleBackColor = false;
            this.btn_KhachHang.Click += new System.EventHandler(this.btn_KhachHang_Click);
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_SanPham.FlatAppearance.BorderSize = 0;
            this.btn_SanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SanPham.ForeColor = System.Drawing.Color.White;
            this.btn_SanPham.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.btn_SanPham.IconColor = System.Drawing.Color.Black;
            this.btn_SanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_SanPham.IconSize = 44;
            this.btn_SanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SanPham.Location = new System.Drawing.Point(0, 291);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Size = new System.Drawing.Size(195, 57);
            this.btn_SanPham.TabIndex = 12;
            this.btn_SanPham.Text = "SẢN PHẨM";
            this.btn_SanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SanPham.UseVisualStyleBackColor = false;
            this.btn_SanPham.Click += new System.EventHandler(this.btn_SanPham_Click);
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_HoaDon.FlatAppearance.BorderSize = 0;
            this.btn_HoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HoaDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_HoaDon.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.btn_HoaDon.IconColor = System.Drawing.Color.Black;
            this.btn_HoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_HoaDon.IconSize = 44;
            this.btn_HoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HoaDon.Location = new System.Drawing.Point(0, 239);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(195, 57);
            this.btn_HoaDon.TabIndex = 11;
            this.btn_HoaDon.Text = "HÓA ĐƠN";
            this.btn_HoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_HoaDon.UseVisualStyleBackColor = false;
            this.btn_HoaDon.Click += new System.EventHandler(this.btn_DonHang_Click);
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_TrangChu.FlatAppearance.BorderSize = 0;
            this.btn_TrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrangChu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu.ForeColor = System.Drawing.Color.White;
            this.btn_TrangChu.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_TrangChu.IconColor = System.Drawing.Color.Black;
            this.btn_TrangChu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_TrangChu.IconSize = 44;
            this.btn_TrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TrangChu.Location = new System.Drawing.Point(0, 186);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.Size = new System.Drawing.Size(195, 57);
            this.btn_TrangChu.TabIndex = 10;
            this.btn_TrangChu.Text = "TRANG CHỦ";
            this.btn_TrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TrangChu.UseVisualStyleBackColor = false;
            this.btn_TrangChu.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // panelShow
            // 
            this.panelShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(216)))));
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelShow.Location = new System.Drawing.Point(195, 77);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1023, 664);
            this.panelShow.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1218, 741);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelLabel);
            this.Controls.Add(this.panelButton);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLy";
            this.Load += new System.EventHandler(this.FormQuanLy_Load);
            this.panelLabel.ResumeLayout(false);
            this.panelLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelShow;
        private FontAwesome.Sharp.IconButton btn_TrangChu;
        private FontAwesome.Sharp.IconButton btn_DangXuat;
        private FontAwesome.Sharp.IconButton btn_QuanLy;
        private FontAwesome.Sharp.IconButton btn_NhapHang;
        private FontAwesome.Sharp.IconButton btn_KhachHang;
        private FontAwesome.Sharp.IconButton btn_SanPham;
        private FontAwesome.Sharp.IconButton btn_HoaDon;
        private FontAwesome.Sharp.IconButton btn_Minimize;
        private FontAwesome.Sharp.IconButton btn_Exit;
    }
}