namespace MasterForm
{
    partial class FormPassWord
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
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.button_Them = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxTc = new System.Windows.Forms.CheckBox();
            this.checkBoxHd = new System.Windows.Forms.CheckBox();
            this.checkBoxSp = new System.Windows.Forms.CheckBox();
            this.checkBoxNh = new System.Windows.Forms.CheckBox();
            this.checkBoxKh = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Sua.Location = new System.Drawing.Point(255, 340);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(102, 48);
            this.btn_Sua.TabIndex = 23;
            this.btn_Sua.Text = "SỬA";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Xoa.Location = new System.Drawing.Point(147, 340);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(102, 48);
            this.btn_Xoa.TabIndex = 22;
            this.btn_Xoa.Text = "XÓA";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PassWord.Location = new System.Drawing.Point(39, 188);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(308, 29);
            this.txt_PassWord.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "PassWord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(67, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "THÔNG TIN PASSWORD";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(39, 102);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(308, 29);
            this.txt_UserName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "UserName";
            // 
            // btn_Exit
            // 
            this.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btn_Exit.IconColor = System.Drawing.Color.Red;
            this.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit.IconSize = 24;
            this.btn_Exit.Location = new System.Drawing.Point(525, -2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(31, 25);
            this.btn_Exit.TabIndex = 45;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Them.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_Them.Location = new System.Drawing.Point(39, 340);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(102, 48);
            this.button_Them.TabIndex = 21;
            this.button_Them.Text = "THÊM";
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 273);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 36);
            this.comboBox1.TabIndex = 46;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 19);
            this.label11.TabIndex = 47;
            this.label11.Text = "Role";
            // 
            // checkBoxTc
            // 
            this.checkBoxTc.AutoSize = true;
            this.checkBoxTc.Location = new System.Drawing.Point(403, 102);
            this.checkBoxTc.Name = "checkBoxTc";
            this.checkBoxTc.Size = new System.Drawing.Size(77, 17);
            this.checkBoxTc.TabIndex = 48;
            this.checkBoxTc.Text = "Trang chủ";
            this.checkBoxTc.UseVisualStyleBackColor = true;
            // 
            // checkBoxHd
            // 
            this.checkBoxHd.AutoSize = true;
            this.checkBoxHd.Location = new System.Drawing.Point(403, 145);
            this.checkBoxHd.Name = "checkBoxHd";
            this.checkBoxHd.Size = new System.Drawing.Size(71, 17);
            this.checkBoxHd.TabIndex = 49;
            this.checkBoxHd.Text = "Hóa đơn";
            this.checkBoxHd.UseVisualStyleBackColor = true;
            // 
            // checkBoxSp
            // 
            this.checkBoxSp.AutoSize = true;
            this.checkBoxSp.Location = new System.Drawing.Point(403, 188);
            this.checkBoxSp.Name = "checkBoxSp";
            this.checkBoxSp.Size = new System.Drawing.Size(77, 17);
            this.checkBoxSp.TabIndex = 50;
            this.checkBoxSp.Text = "Sản phẩm";
            this.checkBoxSp.UseVisualStyleBackColor = true;
            // 
            // checkBoxNh
            // 
            this.checkBoxNh.AutoSize = true;
            this.checkBoxNh.Location = new System.Drawing.Point(403, 231);
            this.checkBoxNh.Name = "checkBoxNh";
            this.checkBoxNh.Size = new System.Drawing.Size(84, 17);
            this.checkBoxNh.TabIndex = 51;
            this.checkBoxNh.Text = "Nhập hàng";
            this.checkBoxNh.UseVisualStyleBackColor = true;
            // 
            // checkBoxKh
            // 
            this.checkBoxKh.AutoSize = true;
            this.checkBoxKh.Location = new System.Drawing.Point(403, 273);
            this.checkBoxKh.Name = "checkBoxKh";
            this.checkBoxKh.Size = new System.Drawing.Size(87, 17);
            this.checkBoxKh.TabIndex = 52;
            this.checkBoxKh.Text = "Khách hàng";
            this.checkBoxKh.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 53;
            this.label4.Text = "Phạm vi truy cập";
            // 
            // FormPassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(556, 415);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxKh);
            this.Controls.Add(this.checkBoxNh);
            this.Controls.Add(this.checkBoxSp);
            this.Controls.Add(this.checkBoxHd);
            this.Controls.Add(this.checkBoxTc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPassWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPassWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxTc;
        private System.Windows.Forms.CheckBox checkBoxHd;
        private System.Windows.Forms.CheckBox checkBoxSp;
        private System.Windows.Forms.CheckBox checkBoxNh;
        private System.Windows.Forms.CheckBox checkBoxKh;
        private System.Windows.Forms.Label label4;
    }
}