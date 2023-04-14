using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterForm
{
    public partial class FormNhaCungCap : Form
    {
        private string nameHost = ConfigurationManager.AppSettings.Get("nameHost");
        private string userNamePss = ConfigurationManager.AppSettings.Get("userName");
        private string maNcc;
        public FormNhaCungCap()
        {
            InitializeComponent();
            getListNcc(ketNoi());
            disableBtt();
        }
      
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        private SqlConnection ketNoi()
        {
            String connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source = " + nameHost + " ;Initial Catalog=BanHang;"
            + userNamePss + ";";
            return cnn = new SqlConnection(connectionstring);
        }
        private void getListNcc(SqlConnection cnn)
        {

            List<NhaCungCap> nhaCungCaps = new List<NhaCungCap>();

            cnn.Open();
            SqlCommand command;
            SqlDataReader datareader;
            string sql = "select * from NhaCungCap";
            command = new SqlCommand(sql, cnn);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                NhaCungCap cap = new NhaCungCap();
                cap.MaNhaCungCap = (int)datareader["MaNhaCungCap"];
                cap.TenNhaCungCap = (string)datareader["TenNhaCungCap"];
                cap.DiaCHi = (string)datareader["DiaCHi"];
                cap.SDT = (string)datareader["SDT"];
                nhaCungCaps.Add(cap);   
            }
            dataGridView1.DataSource = nhaCungCaps;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                DataGridViewRow rowS = dataGridView1.Rows[e.RowIndex];
                maNcc = rowS.Cells[0].Value.ToString();
                txt_TenNCC.Text = rowS.Cells[1].Value.ToString();
                txt_DiaChi.Text = rowS.Cells[2].Value.ToString();
                txt_SDT.Text = rowS.Cells[3].Value.ToString();
                
             
                if (btn_Xoa.Enabled  == false && btn_Sua.Enabled == false)
                {
                    btn_Xoa.Enabled = true;
                    btn_Sua.Enabled = true;
                }
                enableBtt();
            }
        }
        private int kiemTra()
        {
            int x = txt_TenNCC.Text.Length;
            int y = txt_DiaChi.Text.Length;
            int z= txt_SDT.Text.Length;
            if(x==0||y==0||z!=10)
                return 0;
            return 1;
        }
        private void Them(SqlConnection cnn)
        {
            cnn.Open();          
            string sql = @"insert into NhaCungCap(TenNhaCungCap,DiaCHi, SDT) values(N'"+txt_TenNCC.Text+@"',N'"+ txt_DiaChi.Text+@"',N'"+txt_SDT.Text+@"')";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        private void Xoa(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "delete NhaCungCap where MaNhaCungCap=" + maNcc;
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        private void Sua(SqlConnection cnn)
        {
            cnn.Open();
            string sql = @"update NhaCungCap set TenNhaCungCap = N'" + txt_TenNCC.Text + @"', DiaCHi =N'" + txt_DiaChi.Text + @"', SDT= N'" + txt_SDT.Text + @"' where MaNhaCungCap=" + maNcc;
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        private void button_Them_Click(object sender, EventArgs e)
        {
            try {

                if (kiemTra() == 1)
                {
                    Them(ketNoi());
                    MessageBox.Show("Thêm thành công !");
                    getListNcc(ketNoi());
                    disableBtt();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin !");
                }

            }
            catch { MessageBox.Show("Thêm thất bại !"); }
          
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
           try
            {
                Xoa(ketNoi());
                MessageBox.Show("Xóa thành công !");
                getListNcc(ketNoi());
                disableBtt();
            }
           catch
            {
                MessageBox.Show("Xóa thất bại !");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
           try
            {
                Sua(ketNoi());
                MessageBox.Show("Sửa thành công !");
                getListNcc(ketNoi());
                disableBtt();
            }
           catch
            {
                MessageBox.Show("Sửa thất bại !");
            }
        }
        private void enableBtt()
        {
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
        }
        private void disableBtt()
        {
            btn_Xoa.Enabled = false;
            btn_Sua.Enabled = false;
            txt_DiaChi.Text = "";
            txt_SDT.Text = "";
            txt_TenNCC.Text = "";
        }
    }
}
