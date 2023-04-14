namespace MasterForm
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel_DangNhap = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.panel_Lable = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_MatKhau = new System.Windows.Forms.Panel();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.panel_TenDangNhap = new System.Windows.Forms.Panel();
            this.textBox_TenDangNhap = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_DangNhap.SuspendLayout();
            this.panel_Lable.SuspendLayout();
            this.panel_MatKhau.SuspendLayout();
            this.panel_TenDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_DangNhap
            // 
            this.panel_DangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(216)))));
            this.panel_DangNhap.Controls.Add(this.label2);
            this.panel_DangNhap.Controls.Add(this.button_Login);
            this.panel_DangNhap.Controls.Add(this.panel_Lable);
            this.panel_DangNhap.Controls.Add(this.panel_MatKhau);
            this.panel_DangNhap.Controls.Add(this.panel_TenDangNhap);
            this.panel_DangNhap.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_DangNhap.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_DangNhap.Location = new System.Drawing.Point(412, 0);
            this.panel_DangNhap.Name = "panel_DangNhap";
            this.panel_DangNhap.Size = new System.Drawing.Size(345, 430);
            this.panel_DangNhap.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(314, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.ForeColor = System.Drawing.Color.White;
            this.button_Login.Location = new System.Drawing.Point(37, 336);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(269, 54);
            this.button_Login.TabIndex = 5;
            this.button_Login.Text = "ĐĂNG NHẬP";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // panel_Lable
            // 
            this.panel_Lable.Controls.Add(this.label1);
            this.panel_Lable.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Lable.Location = new System.Drawing.Point(3, 52);
            this.panel_Lable.Name = "panel_Lable";
            this.panel_Lable.Size = new System.Drawing.Size(339, 76);
            this.panel_Lable.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(63, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "VNB SPORTS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_MatKhau
            // 
            this.panel_MatKhau.Controls.Add(this.textBox_MatKhau);
            this.panel_MatKhau.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_MatKhau.Location = new System.Drawing.Point(3, 214);
            this.panel_MatKhau.Name = "panel_MatKhau";
            this.panel_MatKhau.Size = new System.Drawing.Size(339, 74);
            this.panel_MatKhau.TabIndex = 3;
            this.panel_MatKhau.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_MatKhau_Paint);
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MatKhau.ForeColor = System.Drawing.Color.Gray;
            this.textBox_MatKhau.Location = new System.Drawing.Point(34, 15);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(269, 41);
            this.textBox_MatKhau.TabIndex = 0;
            this.textBox_MatKhau.Text = "Mật Khẩu";
            this.textBox_MatKhau.Click += new System.EventHandler(this.textBox_MatKhau_Click);
            this.textBox_MatKhau.Enter += new System.EventHandler(this.textBox_MatKhau_Enter);
            this.textBox_MatKhau.Leave += new System.EventHandler(this.textBox_MatKhau_Leave);
            // 
            // panel_TenDangNhap
            // 
            this.panel_TenDangNhap.Controls.Add(this.textBox_TenDangNhap);
            this.panel_TenDangNhap.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_TenDangNhap.Location = new System.Drawing.Point(3, 134);
            this.panel_TenDangNhap.Name = "panel_TenDangNhap";
            this.panel_TenDangNhap.Size = new System.Drawing.Size(339, 74);
            this.panel_TenDangNhap.TabIndex = 2;
            // 
            // textBox_TenDangNhap
            // 
            this.textBox_TenDangNhap.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenDangNhap.ForeColor = System.Drawing.Color.Gray;
            this.textBox_TenDangNhap.Location = new System.Drawing.Point(34, 18);
            this.textBox_TenDangNhap.Name = "textBox_TenDangNhap";
            this.textBox_TenDangNhap.Size = new System.Drawing.Size(269, 41);
            this.textBox_TenDangNhap.TabIndex = 0;
            this.textBox_TenDangNhap.Text = "Tên Đăng Nhập";
            this.textBox_TenDangNhap.Enter += new System.EventHandler(this.textBox_TenDangNhap_Enter);
            this.textBox_TenDangNhap.Leave += new System.EventHandler(this.textBox_TenDangNhap_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(757, 430);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_DangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel_DangNhap.ResumeLayout(false);
            this.panel_DangNhap.PerformLayout();
            this.panel_Lable.ResumeLayout(false);
            this.panel_Lable.PerformLayout();
            this.panel_MatKhau.ResumeLayout(false);
            this.panel_MatKhau.PerformLayout();
            this.panel_TenDangNhap.ResumeLayout(false);
            this.panel_TenDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_DangNhap;
        private System.Windows.Forms.TextBox textBox_TenDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_MatKhau;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.Panel panel_TenDangNhap;
        private System.Windows.Forms.Panel panel_Lable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label2;
    }
}