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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MasterForm
{
    public partial class UC_KhachHang : UserControl
    {
        private string nameHost = ConfigurationManager.AppSettings.Get("nameHost");
        private string userNamePss = ConfigurationManager.AppSettings.Get("userName");

        List<KhachHang> KhachHangs = new List<KhachHang>();

        private SqlConnection ketNoi()
        {
            String connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source = " + nameHost + " ;Initial Catalog=BanHang;"
            + userNamePss + ";";
            return cnn = new SqlConnection(connectionstring);
        }

        private void themKh(SqlConnection cnn)
        {
            cnn.Open();
            string sql = @"insert into KhachHang(HoTen, SDT, DiaChi) values('" + txt_HoTen.Text + @"','" + txt_SDT.Text + "', '" + txt_DiaChi.Text + "')";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }

        private void suaKh(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "update KhachHang set HoTen = '" + txt_HoTen.Text + "',DiaChi = '" + txt_DiaChi.Text + "',SDT = '" + txt_SDT.Text + "' where MaKh = '" + txt_MaKH.Text + "'";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();   
            cnn.Close();
        }
        private void xoaKh(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "delete from KhachHang where MaKh = '" + txt_MaKH.Text + "'";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }

        private void getListKh(SqlConnection cnn)
        {
            List<KhachHang> KhachHangs1 = new List<KhachHang>();

            cnn.Open();
            SqlCommand command;
            SqlDataReader datareader;
            string sql = "select makh, hoten, diachi, sdt from khachhang ";
            command = new SqlCommand(sql, cnn);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                KhachHang KhHang = new KhachHang();
                KhHang.MaKh = (int)datareader["makh"];
                KhHang.HoTen = (string)datareader["hoten"];
                KhHang.DiaChi = (string)datareader["diachi"];
                KhHang.SDT = (string)datareader["sdt"];
                KhachHangs1.Add(KhHang);


            }
            cnn.Close();

            dataGridView1.DataSource = KhachHangs1;
            KhachHangs = KhachHangs1.GetRange(0, KhachHangs1.Count);
        }
        public UC_KhachHang()
        {
            InitializeComponent();
            SqlConnection cnn = ketNoi();
            getListKh(cnn);
            disableBtt();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow rowS = dataGridView1.Rows[e.RowIndex];
                txt_MaKH.Text = rowS.Cells[0].Value.ToString();
                txt_HoTen.Text = rowS.Cells[1].Value.ToString();
                txt_DiaChi.Text = rowS.Cells[2].Value.ToString();
                txt_SDT.Text = rowS.Cells[3].Value.ToString();
                enableBtt();
            }
        }
        private int kiemTraThongTin()
        {
            if (txt_HoTen.Text.Length == 0 || txt_DiaChi.Text.Length == 0)
                return 0;
            return 1;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (kiemTraThongTin() == 1)
            {
                themKh(ketNoi());
                MessageBox.Show("Thêm thành công !", "Thông báo");
                getListKh(ketNoi());
                disableBtt();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_Sua_Click(object sender, EventArgs e)
        {
            if (kiemTraThongTin() == 1)
            {
                suaKh(ketNoi());
                MessageBox.Show("Sửa khách hàng thành công !", "Thông báo");
                getListKh(ketNoi());
                disableBtt();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin khách hàng muốn sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);              
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemTraThongTin() == 1)
                {
                    xoaKh(ketNoi());
                    MessageBox.Show("Xóa khách hàng thành công !", "Thông báo");
                    getListKh(ketNoi());
                    disableBtt();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin khách hàng muốn xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception loi)
            {
                MessageBox.Show("Không thể xóa thông tin khách hàng này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string vanBan = txt_TimKiem.Text;
            List<KhachHang> KhachHangs2 = new List<KhachHang>();
            KhachHangs2 = (List<KhachHang>)KhachHangs.Where(x => x.HoTen.Contains(vanBan)).ToList();
            dataGridView1.DataSource = KhachHangs2;
        }
        private void enableBtt()
        {
            btn_Xoa.Enabled = true;
            BTN_Sua.Enabled = true;
        }
        private void disableBtt()
        {
            btn_Xoa.Enabled = false;
            BTN_Sua.Enabled = false;
            txt_MaKH.Text = "";
            txt_HoTen.Text = "";
            txt_DiaChi.Text = "";
            txt_SDT.Text = "";
        }
    }
}
