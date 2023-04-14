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
    public partial class UC_NhapHang : UserControl

    {
        private string nameHost = ConfigurationManager.AppSettings.Get("nameHost");
        private string userNamePss = ConfigurationManager.AppSettings.Get("userName");
        List<DonHang> DonHangs = new List<DonHang>();
        List<NhanVien> NhanViens= new List<NhanVien>();
        List<NhaCungCap> NhaCungCaps = new List<NhaCungCap>();
        string maNccSelected;
        string maNvSelected;
        string maDhSelected;
        string MaNv;
        public UC_NhapHang(string maNv)
        {
            InitializeComponent();
            getListDh(ketNoi());
            getListNv(ketNoi());
            getListNcc(ketNoi());
            disableBtt();
            MaNv = maNv;
            cbxNhanVien.Enabled = false;
            cbxNhanVien.SelectedValue = Convert.ToInt32(MaNv);
        }

        private void btn_CTHD_Click(object sender, EventArgs e)
        {
            FormNhapHang frmNhapHang = new FormNhapHang(cbxNhanVien.Text,cbxNhaCC.Text,dateTimePicker1.Value.ToString("yyyy-MM-dd"),maDhSelected);
            frmNhapHang.ShowDialog();
        }

        private void btn_CapNhap_Click(object sender, EventArgs e)
        {
            FormNhaCungCap frmNhaCungCap = new FormNhaCungCap();
            frmNhaCungCap.ShowDialog();
        }
        private SqlConnection ketNoi()
        {
            String connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source = " + nameHost + " ;Initial Catalog=BanHang;"
            + userNamePss + ";";
            return cnn = new SqlConnection(connectionstring);
        }
        private void getListDh(SqlConnection cnn)
        {
            List<DonHang> DonHangs1 = new List<DonHang>();

            cnn.Open();
            SqlCommand command;
            SqlDataReader datareader;
            string sql = "select MaDh, nv.Hoten, ncc.TenNhaCungCap ,NgayLap from DonHang dh, NhanVien nv, NhaCungCap ncc where dh.Manv=nv.MaNv and dh.MaNhaCungCap= ncc.MaNhaCungCap\r\n";
            command = new SqlCommand(sql, cnn);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                DonHang dh = new DonHang();
                dh.MaDh = (int)datareader["MaDh"];
                dh.TenNv = (string)datareader["Hoten"];
                dh.TenNcc = (string)datareader["TenNhaCungCap"];
                dh.NgayLap = (System.DateTime)datareader["NgayLap"];
                DonHangs1.Add(dh);


            }
            cnn.Close();
            dataGridView1.DataSource = DonHangs1;
            DonHangs = DonHangs1.GetRange(0, DonHangs1.Count);
        }
        private void getListNv(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "select MaNv, Hoten from NhanVien";
            SqlCommand command2 = new SqlCommand(sql, cnn);
            SqlDataReader datareader2 = command2.ExecuteReader();
            while (datareader2.Read())
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.MaNv = (int)datareader2["MaNv"];
                nhanVien.Hoten = (string)datareader2["Hoten"];
                NhanViens.Add(nhanVien);
            }
            cnn.Close();
            cbxNhanVien.DataSource = NhanViens;
            cbxNhanVien.ValueMember = "MaNv";
            cbxNhanVien.DisplayMember = "Hoten";
            
        }
      
        private void getListNcc(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "select MaNhaCungCap as Mcc, TenNhaCungCap as Tencc from NhaCungCap\r\n";
            SqlCommand command2 = new SqlCommand(sql, cnn);
            SqlDataReader datareader2 = command2.ExecuteReader();
            while (datareader2.Read())
            {
                NhaCungCap NCC = new NhaCungCap();
                NCC.MaNhaCungCap = (int)datareader2["Mcc"];
                NCC.TenNhaCungCap = (string)datareader2["Tencc"];

                NhaCungCaps.Add(NCC);
            }
            cnn.Close();
            cbxNhaCC.DataSource = NhaCungCaps;
            cbxNhaCC.ValueMember = "MaNhaCungCap";
            cbxNhaCC.DisplayMember = "TenNhaCungCap";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if(btn_CTHD.Enabled == false)
                    btn_CTHD.Enabled = true;
                DataGridViewRow rowS = dataGridView1.Rows[e.RowIndex];
                maDhSelected = rowS.Cells[0].Value.ToString();
             
                foreach (NhanVien item in NhanViens)
                {
                    if (rowS.Cells[3].Value.ToString().Equals(item.Hoten))
                    {
                        cbxNhanVien.SelectedValue = item.MaNv;
                        maNvSelected = item.MaNv.ToString();
                        break;
                    }
                }
                dateTimePicker1.Value = (System.DateTime)rowS.Cells[1].Value;
                foreach (NhaCungCap item in NhaCungCaps)
                {
                    if (rowS.Cells[2].Value.ToString().Equals(item.TenNhaCungCap))
                    {
                        cbxNhaCC.SelectedValue = item.MaNhaCungCap;
                        maNccSelected = item.MaNhaCungCap.ToString();
                        break;
                    }
                }
                enableBtt();


            }
        }
       
        private void btn_Them_Click(object sender, EventArgs e)
        {
            cbxNhanVien.SelectedValue = Convert.ToInt32(MaNv);
            themDonHang(ketNoi());
            MessageBox.Show("Thêm thành công !");
            getListDh(ketNoi());
            disableBtt();

        }

        private void BTN_Sua_Click(object sender, EventArgs e)
        {
            if (maDhSelected != null)
            {
                cbxNhanVien.SelectedValue = Convert.ToInt32(MaNv);
                suaDh(ketNoi());
                MessageBox.Show("Sửa đơn hàng thành công !");
                getListDh(ketNoi());
                disableBtt();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn hàng muốn sửa !");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                    xoaDh(ketNoi());
                    MessageBox.Show("Xóa mặt hàng thành công !");
                    getListDh(ketNoi());
                    disableBtt();

            }
            catch (Exception loi)
            {
                MessageBox.Show("Không thể xóa đơn hàng này !");
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txt_TimKiem.Text.Length > 0)
            {
                int ma = Convert.ToInt32(txt_TimKiem.Text);
                List<DonHang> DonHangs3 = new List<DonHang>();
                DonHangs3 = (List<DonHang>)DonHangs.Where(x => x.MaDh == ma).ToList();
                dataGridView1.DataSource = DonHangs3;
            }
            else
            {
                dataGridView1.DataSource = DonHangs;
            }
          
        }
        private void themDonHang(SqlConnection cnn)
        {
            cnn.Open();
            string sql = @"insert into DonHang(NgayLap,Manv,MaNhaCungCap) values(N'"+ dateTimePicker1.Value.ToString("yyyy-MM-dd") + @"',"+cbxNhanVien.SelectedValue+","+cbxNhaCC.SelectedValue+");";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
           
            cnn.Close();
        }
        private void xoaDh(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "delete from DonHang where MaDh=" + maDhSelected;
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }
        private void suaDh(SqlConnection cnn)
        {
            cnn.Open();
            string sql = @"update DonHang set NgayLap=N'"+dateTimePicker1.Value.ToString("yyyy-MM-dd")+@"',Manv="+cbxNhanVien.SelectedValue+ ",MaNhaCungCap=" + cbxNhaCC.SelectedValue+ " where MaDh="+maDhSelected;
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }
        private void enableBtt() {
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
    }
}
