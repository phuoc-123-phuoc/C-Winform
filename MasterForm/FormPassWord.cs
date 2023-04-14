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
    public partial class FormPassWord : Form
    {
        private string nameHost = ConfigurationManager.AppSettings.Get("nameHost");
        private string userNamePss = ConfigurationManager.AppSettings.Get("userName");
        private string manv;
        private int daCott = 0;
        private int Id;
        public string Encrypt(string plainText)
        {
            if (plainText == null) throw new ArgumentNullException("plainText");


            var data = Encoding.Unicode.GetBytes(plainText);
            byte[] encrypted = ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);


            return Convert.ToBase64String(encrypted);
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
        private void Role()
        {
            List<Role> roles = new List<Role>();
            roles.Add(new Role(1, "admin"));
            roles.Add(new Role(0, "Nhân viên"));
            comboBox1.DataSource = roles;
            comboBox1.ValueMember = "value";
            comboBox1.DisplayMember = "display";

        }
        private SqlConnection ketNoi()
        {
            String connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source = " + nameHost + " ;Initial Catalog=BanHang;"
            + userNamePss + ";";
            return cnn = new SqlConnection(connectionstring);

        }
        private void them(SqlConnection cnn)
        {
            string mdf;
            cnn.Open();
            string encode = Encrypt(txt_PassWord.Text);
            if(Convert.ToInt32(comboBox1.SelectedValue) == 1)
            {
                mdf = "NULL";
            }
            else
            {
                mdf = accessModf();
            }
            string sql = @"update NhanVien set access_modifier=N'"+mdf+@"', userName =N'" + txt_UserName.Text + @"', passWord=N'" + encode + @"', role=N'" + comboBox1.SelectedValue + @"' where MaNv=" + manv;
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        private void sua(SqlConnection cnn)
        {
            string mdf;
            if (Convert.ToInt32(comboBox1.SelectedValue) == 1)
            {
                mdf = "NULL";
            }
            else
            {
                mdf = accessModf();
            }
            cnn.Open();
            string encode = Encrypt(txt_PassWord.Text);
            string sql = @"update nhanvien set access_modifier=N'"+mdf+@"', userName=N'" + txt_UserName.Text + @"', passWord= N'" + encode + @"', role=N'" + comboBox1.SelectedValue + @"' where manv=" + manv + ";";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        private void xoa(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "update NhanVien\r\nset userName =NULL, passWord=NULL,access_modifier=NULL ,role=NULL\r\nwhere MaNv=" + manv;
            MessageBox.Show(sql);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        private void getInfo(SqlConnection cnn)
        {
            string acM;
            cnn.Open();
            string sql = " select userName, passWord,role,access_modifier from nhanvien where manv=" + manv;
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() && reader["userName"].ToString() != "" && reader["passWord"].ToString() != "" && reader["role"].ToString() != "")
            {

                txt_UserName.Text = (string)reader["userName"];
                string decode = Decrypt((string)reader["passWord"]);
                txt_PassWord.Text = decode;
                comboBox1.SelectedValue = Convert.ToInt32(reader["role"]);
                Id = Convert.ToInt32(reader["role"]);
                daCott = 1;
                acM = Convert.ToString(reader["access_modifier"]);
                if(acM != "")
                {
                    char[] ch = acM.ToCharArray();
                    foreach (char c in ch)
                    {


                        if (c == '1') checkBoxTc.Checked= true;
                        else
                        if (c == '2') checkBoxHd.Checked=true;
                        else
                        if (c == '3') checkBoxSp.Checked=true ;
                        else
                        if (c == '4')checkBoxKh.Checked=true ;
                        else
                        if (c == '5') checkBoxNh.Checked=true;
                    }
                }
                

            }

            cnn.Close();
            if (daCott == 1)
            {
                button_Them.Enabled = false;
                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;
            }
            else if (daCott == 0)
            {
                button_Them.Enabled = true;
                btn_Xoa.Enabled = false;
                btn_Sua.Enabled = false;
            }

        }
        public FormPassWord(string maNv, int soUser)
        {
            InitializeComponent();
            manv = maNv;
            Role();
            getInfo(ketNoi());
            if (Id == 1 || soUser == 0)
            {
                comboBox1.Enabled = false;
                comboBox1.SelectedValue = 1;
            }


        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int checkTt()
        {
            if (txt_UserName.Text == "" || txt_PassWord.Text == "")
                return 0;
            return 1;
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            if (checkAcm() == true)
            {
                try
                {
                    if (checkTt() == 1)
                    {
                        if (checkUseName(ketNoi()) == true)
                        {
                            them(ketNoi());
                            MessageBox.Show("Thêm thành công !");
                            getInfo(ketNoi());
                            disableBtt();
                        }
                        else
                        {
                            MessageBox.Show("UserName đã tồn tại");
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin !");
                    }


                }
                catch
                {

                    MessageBox.Show("Thêm thất bại !");
                }
            }
            else
            {
                MessageBox.Show("Chọn ít nhất một mục truy cập cho nhân viên !");
            }


        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(Id ==1 && soNv(ketNoi()) > 0 && soQl(ketNoi())==1)
            {
                MessageBox.Show("Không thể xóa tài khoản đăng nhập");
            }
            else
            try
            {
                xoa(ketNoi());
                MessageBox.Show("Xóa thành công !");
                daCott = 0;
                getInfo(ketNoi());
                disableBtt();

            }
            catch
            {


                MessageBox.Show("Xóa thất bại !");
            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (checkAcm() == true)
            {

                try
                {
                    if (checkTt() == 1)
                    {

                        if (checkUseName(ketNoi()) == true)
                    {
                        sua(ketNoi());
                        MessageBox.Show("Sửa thành công !");
                        getInfo(ketNoi());
                        disableBtt();
                    }
                    else
                    {
                        MessageBox.Show("UserName đã tồn tại");
                    }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin !");
                    }

                }
                catch
                {


                    MessageBox.Show("Sửa thất bại !");
                }
            }
            else
            {
                MessageBox.Show("Chọn ít nhất một mục truy cập cho nhân viên !");
            }

        }
        private void disableBtt()
        {

            txt_PassWord.Text = "";
            txt_UserName.Text = "";
        }
        private string accessModf()
        {
            string acM = "";
            if (checkBoxTc.Checked == true)
            {
                acM += "1";
            }
            if (checkBoxHd.Checked == true)
            {
                acM += "2";
            }
            if (checkBoxSp.Checked == true)
            {
                acM += "3";
            }
            if (checkBoxKh.Checked == true)
            {
                acM += "4";
            }
            if (checkBoxNh.Checked == true)
            {
                acM += "5";
            }
            return acM;
        }
        private Boolean checkAcm()
        {
            if (Convert.ToInt32(comboBox1.SelectedValue) == 0 && checkBoxTc.Checked == false && checkBoxHd.Checked == false && checkBoxKh.Checked == false && checkBoxSp.Checked == false && checkBoxNh.Checked == false)
                return false;
            return true;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue.ToString()!="MasterForm.Role" )
            if(Convert.ToInt32(comboBox1.SelectedValue) == 1)
            {
                checkBoxTc.Enabled = false;
                checkBoxHd.Enabled = false;
                checkBoxSp.Enabled = false;
                checkBoxKh.Enabled = false;
                checkBoxNh.Enabled = false;

                checkBoxTc.Checked = false;
                checkBoxHd.Checked = false;
                checkBoxSp.Checked = false;
                checkBoxKh.Checked = false;
                checkBoxNh.Checked = false;

            }
            else
            {
                checkBoxTc.Enabled = true;
                checkBoxHd.Enabled = true;
                checkBoxSp.Enabled = true;
                checkBoxKh.Enabled = true;
                checkBoxNh.Enabled = true;
            }
        }
        private int soNv(SqlConnection cnn)
        {
            cnn.Open();
            int soNv=0;
            string sql = "select count(role) as nv from nhanvien where role=0";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read() && Convert.ToString(rdr["nv"]) !="")
            {
                soNv = Convert.ToInt32(rdr["nv"]);
            }
            cnn.Close();
            return soNv;
        }
        private int soQl(SqlConnection cnn)
        {
            cnn.Open();
            int soQl = 0;
            string sql = "select count(role) as ql from nhanvien where role=1";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read() && Convert.ToString(rdr["ql"]) != "")
            {
                soQl = Convert.ToInt32(rdr["ql"]);
            }
            cnn.Close();
            return soQl;
        }
       
        private Boolean checkUseName(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "select Username from nhanvien where userName=N'" + txt_UserName.Text + @"' and manv<>"+manv;
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                cnn.Close();
                return false;
            }
            cnn.Close();
            return true;
        }
    }

    
}
