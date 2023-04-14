using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterForm
{
    public partial class FormLogin : Form
    {
        private string nameHost = ConfigurationManager.AppSettings.Get("nameHost");
        private string userNamePss = ConfigurationManager.AppSettings.Get("userName");
        public int status = 0;
        public int quyen;
        public string MaNv;
        public  string accessMdf;
        private SqlConnection ketNoi()
        {
            String connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source = " + nameHost + " ;Initial Catalog=BanHang;"
            + userNamePss + ";";
            return cnn = new SqlConnection(connectionstring);
        }
        public string Decrypt(string cipher)
        {
            if (cipher == null) throw new ArgumentNullException("cipher");

            //parse base64 string
            byte[] data = Convert.FromBase64String(cipher);

            //decrypt data
            byte[] decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
            return Encoding.Unicode.GetString(decrypted);
        }
        private void check(SqlConnection cnn)
        {
            cnn.Open();

            string sql = @"select passWord, role,MaNv, access_modifier from nhanvien where userName=N'" + textBox_TenDangNhap.Text + @"'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read()== true)
            {
                string decode = Decrypt((string)reader["passWord"]);
                if(decode == textBox_MatKhau.Text)
                {
                    status = 1;
                    quyen = Convert.ToInt32(reader["role"]);
                    MaNv = Convert.ToString(reader["MaNv"]);
                    accessMdf = Convert.ToString(reader["access_modifier"]);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập !");
                }
              
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không tồn tại !");
            }
           
            cnn.Close();
        }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox_TenDangNhap_Leave(object sender, EventArgs e)
        {
            if (textBox_TenDangNhap.Text == "")
            {
                textBox_TenDangNhap.Text = "Tên Đăng Nhập";
                textBox_TenDangNhap.ForeColor = Color.Gray;
            }
        }

        private void textBox_TenDangNhap_Enter(object sender, EventArgs e)
        {
            if (textBox_TenDangNhap.Text == "Tên Đăng Nhập")
            {
                textBox_TenDangNhap.Text = "";
                textBox_TenDangNhap.ForeColor = Color.Black;
            }
        }

        private void textBox_MatKhau_Leave(object sender, EventArgs e)
        {
            if (textBox_MatKhau.Text == "")
            {
                textBox_MatKhau.Text = "Mật Khẩu";
                textBox_MatKhau.ForeColor = Color.Gray;
            }
        }

        private void textBox_MatKhau_Enter(object sender, EventArgs e)
        {
            if (textBox_MatKhau.Text == "Mật Khẩu")
            {
                textBox_MatKhau.Text = "";
                textBox_MatKhau.ForeColor = Color.Black;
            }
        }

        private void textBox_MatKhau_Click(object sender, EventArgs e)
        {
            textBox_MatKhau.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            check(ketNoi());
        }

        private void panel_MatKhau_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
