namespace MasterForm
{
    partial class FormQuanLy
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
            this.pictureAnhNen = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_SanPham = new System.Windows.Forms.Button();
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.btn_ListNV = new System.Windows.Forms.Button();
            this.panelLabel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnhNen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panelButton.SuspendLayout();
            this.panelLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureAnhNen
            // 
            this.pictureAnhNen.Image = global::MasterForm.Properties.Resources.Ảnh_Nền_1;
            this.pictureAnhNen.Location = new System.Drawing.Point(289, 197);
            this.pictureAnhNen.Name = "pictureAnhNen";
            this.pictureAnhNen.Size = new System.Drawing.Size(922, 420);
            this.pictureAnhNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAnhNen.TabIndex = 10;
            this.pictureAnhNen.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(8, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::MasterForm.Properties.Resources.Logo_Shop1;
            this.pictureLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(277, 188);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 8;
            this.pictureLogo.TabStop = false;
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.Orange;
            this.panelButton.Controls.Add(this.btn_Thoat);
            this.panelButton.Controls.Add(this.btn_SanPham);
            this.panelButton.Controls.Add(this.btn_HoaDon);
            this.panelButton.Controls.Add(this.btn_ListNV);
            this.panelButton.Location = new System.Drawing.Point(1, 197);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(278, 420);
            this.panelButton.TabIndex = 7;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_Thoat.Location = new System.Drawing.Point(0, 216);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(278, 65);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "LogOut";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.BackColor = System.Drawing.Color.White;
            this.btn_SanPham.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_SanPham.Location = new System.Drawing.Point(0, 145);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Size = new System.Drawing.Size(279, 65);
            this.btn_SanPham.TabIndex = 7;
            this.btn_SanPham.Text = "Sản Phẩm";
            this.btn_SanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SanPham.UseVisualStyleBackColor = false;
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.BackColor = System.Drawing.Color.White;
            this.btn_HoaDon.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_HoaDon.Location = new System.Drawing.Point(0, 74);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(279, 65);
            this.btn_HoaDon.TabIndex = 6;
            this.btn_HoaDon.Text = "Hóa Đơn";
            this.btn_HoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_HoaDon.UseVisualStyleBackColor = false;
            // 
            // btn_ListNV
            // 
            this.btn_ListNV.BackColor = System.Drawing.Color.White;
            this.btn_ListNV.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_ListNV.Location = new System.Drawing.Point(0, 3);
            this.btn_ListNV.Name = "btn_ListNV";
            this.btn_ListNV.Size = new System.Drawing.Size(278, 65);
            this.btn_ListNV.TabIndex = 5;
            this.btn_ListNV.Text = "Check In//Out";
            this.btn_ListNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ListNV.UseVisualStyleBackColor = false;
            // 
            // panelLabel
            // 
            this.panelLabel.Controls.Add(this.label1);
            this.panelLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLabel.Location = new System.Drawing.Point(286, 5);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(925, 186);
            this.panelLabel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(94, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin Chào Chủ Shop Cầu Lông VNB Sports";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1222, 627);
            this.Controls.Add(this.pictureAnhNen);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelLabel);
            this.Name = "FormQuanLy";
            this.Text = "MainQuanLy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnhNen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panelLabel.ResumeLayout(false);
            this.panelLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureAnhNen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_SanPham;
        private System.Windows.Forms.Button btn_HoaDon;
        private System.Windows.Forms.Button btn_ListNV;
        private System.Windows.Forms.Panel panelLabel;
        private System.Windows.Forms.Label label1;
    }
}