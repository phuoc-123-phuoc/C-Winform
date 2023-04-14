using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterForm
{
    public partial class UC_HoaDon : UserControl
    {
        private string nameHost = ConfigurationManager.AppSettings.Get("nameHost");
        private string userNamePss = ConfigurationManager.AppSettings.Get("userName");
        List<HoaDon> hoaDons = new List<HoaDon>();
        List<NhanVien> nhanViens = new List<NhanVien>();
        List<KhachHang> khachHangs = new List<KhachHang>();
        List<NhaCungCap> NCCs=new List<NhaCungCap>();
        string maSelected;
        string tenNvSelected;
        string tenKSelected;
        string ngayGhi;
        string MaNv;

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
            cnn.Open();
            
            string sql = @"insert into HoaDon(ngayghi,makh,manv) values(N'"+dateTimePicker1.Value.ToString("yyyy-MM-dd")+@"',"+comboBox2.SelectedValue+","+comboBox1.SelectedValue+");";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        private void sua(SqlConnection cnn)
        {
            cnn.Open();
           
            string sql = @"update HoaDon set ngayghi = N'"+dateTimePicker1.Value.ToString("yyyy-MM-dd")+@"', makh ="+comboBox2.SelectedValue+", manv ="+comboBox1.SelectedValue+" where Mahd= "+ maSelected;
          
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        private void xoa(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "delete HoaDon where Mahd="+ maSelected;
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
       
        private void loadKh(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "select MaKh, HoTen from KhachHang";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                KhachHang kh = new KhachHang();
                kh.MaKh= (int)reader["MaKh"];
                kh.HoTen = (string)reader["Hoten"];
                khachHangs.Add(kh);
            }
            comboBox2.DataSource = khachHangs;
            comboBox2.ValueMember = "MaKh";
            comboBox2.DisplayMember = "HoTen";
            cnn.Close();
        }
        private void loadNv(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "select Manv, Hoten from NhanVien";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                NhanVien nv = new NhanVien();
                nv.MaNv = (int)rdr["Manv"];
                nv.Hoten = (string)rdr["Hoten"];
                nhanViens.Add(nv);
            }
            comboBox1.DataSource = nhanViens;
            comboBox1.ValueMember = "MaNv";
            comboBox1.DisplayMember = "Hoten";
            cnn.Close();
        }
        private void loadHoaDon(SqlConnection cnn)
        {
            List<HoaDon> hoaDon1s = new List<HoaDon>();
            cnn.Open();
            string sql = "select Mahd, ngayghi, kh.HoTen as TenK, nv.Hoten as TenNv from HoaDon hd, NhanVien nv, KhachHang kh where hd.makh= kh.makh and hd.manv=nv.manv ";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                HoaDon hd = new HoaDon();
                hd.Mahd = (int)rdr["Mahd"];
                hd.ngayghi = (System.DateTime)rdr["ngayghi"];
                hd.tenKhach = (string)rdr["TenK"];
                hd.tenNhanVien = (string)rdr["TenNv"];
                hoaDon1s.Add(hd);
            }
            dataGridView1.DataSource = hoaDon1s;
            hoaDons = hoaDon1s.GetRange(0,hoaDon1s.Count);
            cnn.Close();
        }
        public UC_HoaDon(string maNv)
        {
            InitializeComponent();
            loadHoaDon(ketNoi());
            loadNv(ketNoi());
            loadKh(ketNoi());
            MaNv = maNv;
            comboBox1.Enabled = false;
            comboBox1.SelectedValue = Convert.ToInt32(MaNv);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UC_HoaDon_Load(object sender, EventArgs e)
        {
            disableBtt();
        }

        private void btn_CTHD_Click(object sender, EventArgs e)
        {
            FormHoaDon frmHoaDon = new FormHoaDon(tenNvSelected,tenKSelected,ngayGhi,maSelected);
            frmHoaDon.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow rowS = dataGridView1.Rows[e.RowIndex];

                txt_SoHoaDon.Text = rowS.Cells[0].Value.ToString();
                maSelected = txt_SoHoaDon.Text;
                dateTimePicker1.Value = (System.DateTime)rowS.Cells[1].Value;
                ngayGhi = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                foreach (NhanVien item in nhanViens)
                {
                    if (rowS.Cells[2].Value.ToString().Equals(item.Hoten))
                    {
                        comboBox1.SelectedValue=item.MaNv;
                    }
                }
                tenNvSelected = rowS.Cells[2].Value.ToString();
                foreach (KhachHang item in khachHangs)
                {
                    if (rowS.Cells[3].Value.ToString().Equals(item.HoTen))
                    {
                        comboBox2.SelectedValue = item.MaKh;
                    }
                }
                tenKSelected= rowS.Cells[3].Value.ToString();
                enableBtt();
            }
        }

        private void txt_Tk_TextChanged(object sender, EventArgs e)
        {
            if (txt_Tk.Text.Length > 0)
            {
                int ma = Convert.ToInt32(txt_Tk.Text);
                List<HoaDon> HoaDons3 = new List<HoaDon>();
                HoaDons3 = (List<HoaDon>)hoaDons.Where(x => x.Mahd == ma).ToList();
                dataGridView1.DataSource = HoaDons3;
            }
            else
            {
                dataGridView1.DataSource = hoaDons;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try {
                comboBox1.SelectedValue = Convert.ToInt32(MaNv);

                them(ketNoi());
                txt_SoHoaDon.Text = "";
                maSelected = txt_SoHoaDon.Text;
                MessageBox.Show("Thêm thành công !");
                loadHoaDon(ketNoi());
                disableBtt();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại !");
            }
           
        }

        private void BTN_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.SelectedValue = Convert.ToInt32(MaNv);

                sua(ketNoi());
                txt_SoHoaDon.Text = "";
                maSelected = txt_SoHoaDon.Text;
                MessageBox.Show("Sửa thành công !");
                loadHoaDon(ketNoi());
                disableBtt();
            }
            catch
            {
                MessageBox.Show("Sửa thất bại !");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {

                xoa(ketNoi());
                txt_SoHoaDon.Text = "";
                maSelected = txt_SoHoaDon.Text;
                MessageBox.Show("Xóa thành công !");
                loadHoaDon(ketNoi());
                disableBtt();
            }
            catch
            {
                MessageBox.Show("Xóa thất bại !");
            }
        }
        private void enableBtt()
        {

            btn_Xoa.Enabled = true;
            BTN_Sua.Enabled = true;
            btn_CTHD.Enabled = true;
        }
        private void disableBtt()
        {
           
            btn_Xoa.Enabled = false;
            BTN_Sua.Enabled = false;
            btn_CTHD.Enabled = false;
        }

        private void txt_Tk_Leave(object sender, EventArgs e)
        {

        }

        private void txt_Tk_Enter(object sender, EventArgs e)
        {

        }
    }
}
