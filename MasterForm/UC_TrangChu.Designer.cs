namespace MasterForm
{
    partial class UC_TrangChu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.export_SanPham = new System.Windows.Forms.Button();
            this.export_DoanhThu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_soSp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_doanhThu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_soDon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.export_SanPham);
            this.panel1.Controls.Add(this.export_DoanhThu);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 209);
            this.panel1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dateTimePicker2.Location = new System.Drawing.Point(629, 70);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dateTimePicker1.Location = new System.Drawing.Point(254, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(556, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Đến ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(193, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Từ ngày:";
            // 
            // export_SanPham
            // 
            this.export_SanPham.BackColor = System.Drawing.Color.DarkGreen;
            this.export_SanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export_SanPham.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export_SanPham.ForeColor = System.Drawing.Color.White;
            this.export_SanPham.Location = new System.Drawing.Point(623, 9);
            this.export_SanPham.Name = "export_SanPham";
            this.export_SanPham.Size = new System.Drawing.Size(206, 46);
            this.export_SanPham.TabIndex = 18;
            this.export_SanPham.Text = "Sản phẩm bán chạy";
            this.export_SanPham.UseVisualStyleBackColor = false;
            this.export_SanPham.Click += new System.EventHandler(this.export_SanPham_Click);
            // 
            // export_DoanhThu
            // 
            this.export_DoanhThu.BackColor = System.Drawing.Color.DarkGreen;
            this.export_DoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export_DoanhThu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export_DoanhThu.ForeColor = System.Drawing.Color.White;
            this.export_DoanhThu.Location = new System.Drawing.Point(254, 9);
            this.export_DoanhThu.Name = "export_DoanhThu";
            this.export_DoanhThu.Size = new System.Drawing.Size(200, 46);
            this.export_DoanhThu.TabIndex = 17;
            this.export_DoanhThu.Text = "Doanh thu";
            this.export_DoanhThu.UseVisualStyleBackColor = false;
            this.export_DoanhThu.Click += new System.EventHandler(this.export_DoanhThu_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            this.panel4.Controls.Add(this.lb_soSp);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(623, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(382, 100);
            this.panel4.TabIndex = 3;
            // 
            // lb_soSp
            // 
            this.lb_soSp.AutoSize = true;
            this.lb_soSp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soSp.ForeColor = System.Drawing.Color.Black;
            this.lb_soSp.Location = new System.Drawing.Point(179, 53);
            this.lb_soSp.Name = "lb_soSp";
            this.lb_soSp.Size = new System.Drawing.Size(20, 23);
            this.lb_soSp.TabIndex = 2;
            this.lb_soSp.Text = "0";
            this.lb_soSp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "SỐ SẢN PHẨM BÁN TRONG NGÀY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(197)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.lb_doanhThu);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(349, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 100);
            this.panel2.TabIndex = 2;
            // 
            // lb_doanhThu
            // 
            this.lb_doanhThu.AutoSize = true;
            this.lb_doanhThu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_doanhThu.ForeColor = System.Drawing.Color.Black;
            this.lb_doanhThu.Location = new System.Drawing.Point(54, 53);
            this.lb_doanhThu.Name = "lb_doanhThu";
            this.lb_doanhThu.Size = new System.Drawing.Size(20, 23);
            this.lb_doanhThu.TabIndex = 2;
            this.lb_doanhThu.Text = "0";
            this.lb_doanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "DOANH THU NGÀY";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(62)))), ((int)(((byte)(243)))));
            this.panel3.Controls.Add(this.lb_soDon);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(19, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 100);
            this.panel3.TabIndex = 1;
            // 
            // lb_soDon
            // 
            this.lb_soDon.AutoSize = true;
            this.lb_soDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soDon.ForeColor = System.Drawing.Color.Black;
            this.lb_soDon.Location = new System.Drawing.Point(138, 53);
            this.lb_soDon.Name = "lb_soDon";
            this.lb_soDon.Size = new System.Drawing.Size(20, 23);
            this.lb_soDon.TabIndex = 1;
            this.lb_soDon.Text = "0";
            this.lb_soDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "SỐ ĐƠN BÁN RA TRONG NGÀY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(19, 209);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sản phẩm";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(986, 455);
            this.chart.TabIndex = 3;
            this.chart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.DodgerBlue;
            title1.Name = "Biểu đồ";
            title1.Text = "Sản phẩm bán chạy trong tháng";
            this.chart.Titles.Add(title1);
            // 
            // UC_TrangChu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.chart);
            this.Controls.Add(this.panel1);
            this.Name = "UC_TrangChu";
            this.Size = new System.Drawing.Size(1023, 664);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label lb_soSp;
        private System.Windows.Forms.Label lb_doanhThu;
        private System.Windows.Forms.Label lb_soDon;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button export_SanPham;
        private System.Windows.Forms.Button export_DoanhThu;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}
