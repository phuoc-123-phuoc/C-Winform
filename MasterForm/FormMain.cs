using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Drawing;
using System.Configuration;

namespace MasterForm
{

    public partial class FormMain : Form
    {
        private string nameHost = ConfigurationManager.AppSettings.Get("nameHost");
        private string userNamePss = ConfigurationManager.AppSettings.Get("userName");
        private int status=0;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private string MaNv;
        private string aMdf;
        private void Dn()
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            status=formLogin.status;
            MaNv = formLogin.MaNv;
            aMdf = formLogin.accessMdf;
            if (aMdf == null)
                aMdf = "rong";
            char[] ch = aMdf.ToCharArray(); 
            
           
          
           
            btn_QuanLy.Enabled = false;
            btn_TrangChu.Enabled = false;
            btn_HoaDon.Enabled = false;
            btn_SanPham.Enabled = false;
            btn_KhachHang.Enabled = false;
            btn_NhapHang.Enabled = false;

            if (formLogin.quyen == 0)
            {
               
                foreach (char c in ch)
                {
                   
                   
                    if (c== '1')btn_TrangChu.Enabled = true;
                    else
                    if (c == '2') btn_HoaDon.Enabled = true;
                    else
                    if (c == '3') btn_SanPham.Enabled = true;
                    else
                    if (c == '4') btn_KhachHang.Enabled = true;
                    else
                    if (c == '5') btn_NhapHang.Enabled = true;
                }

            }

            else
            {
                btn_QuanLy.Enabled = true;
                btn_TrangChu.Enabled = true;
                btn_HoaDon.Enabled = true;
                btn_SanPham.Enabled = true;
                btn_KhachHang.Enabled = true;
                btn_NhapHang.Enabled = true;
            }

            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_TrangChu());

        }
        private SqlConnection ketNoi()
        {
            String connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source = " + nameHost + " ;Initial Catalog=BanHang;"
            + userNamePss + ";";
            return cnn = new SqlConnection(connectionstring);
        }
        private int ApplyLogin()
        {
            int x;
            SqlConnection cnn = ketNoi();
            cnn.Open();
            string sql = "select count(userName) as total from nhanvien\r\n";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            x = (int)reader["total"];
            cnn.Close();
           
            return x ;
        }
        public FormMain()
        {
           
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 57);
            panelButton.Controls.Add(leftBorderBtn);
           
            if (ApplyLogin() != 0)
            {
                Dn();
                btn_DangXuat.Enabled = true;
            }
            else
            {
                btn_DangXuat.Enabled = false;
            }
            
            this.ControlBox = false;

        }

        //Màu cho button
        private struct RGBColors
        {
            public static Color color = Color.FromArgb(24, 161, 251);
        }

        //Khi chọn Button sẽ hiện
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(249,240,241);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        // Trả về button khi không chọn
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.DodgerBlue;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            // add các controll vào panelShow
            
        }


        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_TrangChu());
            ActivateButton(sender, RGBColors.color);
        }

        private void btn_DonHang_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_HoaDon(MaNv));
            ActivateButton(sender, RGBColors.color);
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_SanPham());
            ActivateButton(sender, RGBColors.color);
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_KhachHang());
            ActivateButton(sender, RGBColors.color);
        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_NhapHang(MaNv));
            ActivateButton(sender, RGBColors.color);
        }

        private void btn_QuanLy_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_QuanLyNhanVien(ApplyLogin()));
            ActivateButton(sender, RGBColors.color);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;    
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
                Dn();
            if(status == 1)
            this.Visible = true;
            
        }
    }
}
