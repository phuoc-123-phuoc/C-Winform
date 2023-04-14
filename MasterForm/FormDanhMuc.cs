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
    public partial class FormDanhMuc : Form
    {
        private string nameHost = ConfigurationManager.AppSettings.Get("nameHost");
        private string userNamePss = ConfigurationManager.AppSettings.Get("userName");
        List<DanhMucHang> DanhMucs = new List<DanhMucHang>();
        string maDmSelected = "";
        public FormDanhMuc()
        {
            InitializeComponent();
        }

        private void FormDanhMuc_Load(object sender, EventArgs e)
        {
            getListDm(ketNoi());
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenDanhMuc.Text.Length != 0)
            {

                themDm(ketNoi());
                MessageBox.Show("Thêm danh mục thành công !");
                getListDm(ketNoi());


            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_TenDanhMuc.Text.Length != 0)
                {

                    xoaDm(ketNoi());
                    MessageBox.Show("Xóa danh mục thành công !");
                    getListDm(ketNoi());

                }
                else
                {


                    MessageBox.Show("Vui lòng chọn thông tin muốn xóa !");
                }


            }
            catch
            {

                MessageBox.Show("Xóa danh mục thất bại !");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_TenDanhMuc.Text.Length != 0)
                {
                    suaDm(ketNoi());
                    MessageBox.Show("Sửa danh mục thành công !");
                    getListDm(ketNoi());


                }
                else
                {


                    MessageBox.Show("Vui lòng chọn thông tin muốn sửa !");
                }

            }
            catch
            {

                MessageBox.Show("Sửa danh mục thất bại !");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow rowS = dataGridView1.Rows[e.RowIndex];
                maDmSelected = rowS.Cells[0].Value.ToString();

                txt_TenDanhMuc.Text = rowS.Cells[1].Value.ToString();
            }
        }
        private SqlConnection ketNoi()
        {
            String connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source = " + nameHost + " ;Initial Catalog=BanHang;"
            + userNamePss + ";";
            return cnn = new SqlConnection(connectionstring);
        }
        private void getListDm(SqlConnection cnn)
        {
            List<DanhMucHang> DanhMucs1 = new List<DanhMucHang>();
            cnn.Open();
            string sql = "select * from danhmuchang";
            SqlCommand command2 = new SqlCommand(sql, cnn);
            SqlDataReader datareader2 = command2.ExecuteReader();
            while (datareader2.Read())
            {
                DanhMucHang DanhMuc = new DanhMucHang();
                DanhMuc.MaDm = (int)datareader2["MaDm"];
                DanhMuc.TenDm = (string)datareader2["TenDm"];
                DanhMucs1.Add(DanhMuc);
            }
            cnn.Close();

            dataGridView1.DataSource = DanhMucs1;
            DanhMucs = DanhMucs1.GetRange(0, DanhMucs1.Count);


        }
        private void themDm(SqlConnection cnn)
        {
            cnn.Open();
            string sql = @"insert into DanhMucHang(TenDm) values(N'" + txt_TenDanhMuc.Text + @"')";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }
        private void xoaDm(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "delete DanhMucHang where MaDm=" + maDmSelected;
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }
        private void suaDm(SqlConnection cnn)
        {
            cnn.Open();
            string sql = @"update DanhMucHang set TenDm=N'" + txt_TenDanhMuc.Text + @"' where MaDm=" + maDmSelected;
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }

        private void txt_TenDanhMuc_Leave(object sender, EventArgs e)
        {

        }
    }
}
