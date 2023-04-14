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
    public partial class UC_QuanLyNhanVien : UserControl
    {
        private string nameHost = ConfigurationManager.AppSettings.Get("nameHost");
        private string userNamePss = ConfigurationManager.AppSettings.Get("userName");

        List<NhanVien> NhanViens = new List<NhanVien>();
        private int SoUser;
        private SqlConnection ketNoi()
        {
            String connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source = " + nameHost + " ;Initial Catalog=BanHang;"
            + userNamePss + ";";
            return cnn = new SqlConnection(connectionstring);
        }

        private void themNv(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "insert into nhanvien (Hoten, NgayVaolam, SDT) values('" + txt_HoTen.Text + "', '" + dTime_Ngayvaolam.Value.ToString("yyyy-MM-dd") + "', '" + txt_SDT.Text + "')";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }

        private void suaNv(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "update nhanvien set Hoten = '" + txt_HoTen.Text + "', NgayVaolam = '" + dTime_Ngayvaolam.Value.ToString("yyyy-MM-dd") + "',SDT = " + txt_SDT.Text + " where MaNV = '" + txt_MaNV.Text + "'";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }
        private void xoaNv(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "delete from nhanvien where MaNV = '" + txt_MaNV.Text + "'";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }

        private void getListNv(SqlConnection cnn)
        {
            List<NhanVien> NhanViens1 = new List<NhanVien>();

            cnn.Open();
            SqlCommand command;
            SqlDataReader datareader;
            string sql = "select manv, hoten, ngayvaolam, sdt from nhanvien";
            command = new SqlCommand(sql, cnn);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                NhanVien NhVien = new NhanVien();
                NhVien.MaNv = (int)datareader["MaNv"];
                NhVien.Hoten = (string)datareader["Hoten"];
                NhVien.NgayVaolam = (System.DateTime)datareader["NgayVaoLam"];
                NhVien.SDT = (string)datareader["SDT"];
                NhanViens1.Add(NhVien);


            }
            cnn.Close();

            dataGridView1.DataSource = NhanViens1;
            NhanViens = NhanViens1.GetRange(0, NhanViens1.Count);
        }
        public UC_QuanLyNhanVien(int soUser)
        {
            InitializeComponent();
            SqlConnection cnn = ketNoi();
            getListNv(cnn);
            disableBtt();
            SoUser = soUser;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                
                DataGridViewRow rowS = dataGridView1.Rows[e.RowIndex];
                txt_MaNV.Text = rowS.Cells[0].Value.ToString();
                txt_HoTen.Text = rowS.Cells[1].Value.ToString();
                dTime_Ngayvaolam.Text = rowS.Cells[2].Value.ToString();;
                txt_SDT.Text = rowS.Cells[3].Value.ToString();
                enAble();
            }
        }

        private int kiemTraThongTin()
        {
            if (txt_HoTen.Text.Length == 0 || txt_SDT.Text.Length == 0)
                return 0;
            return 1;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (kiemTraThongTin() == 1)
            {
                themNv(ketNoi());
                MessageBox.Show("Thêm thành công !", "Thông báo");
                getListNv(ketNoi());
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
                suaNv(ketNoi());
                MessageBox.Show("Sửa thông tin nhân viên thành công !", "Thông báo");
                getListNv(ketNoi());
                disableBtt();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin nhân viên muốn sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemTraThongTin() == 1)
                {
                    xoaNv(ketNoi());
                    MessageBox.Show("Xóa thông tin nhân viên thành công !", "Thông báo");
                    getListNv(ketNoi());
                    disableBtt();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin nhân viên muốn xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception loi)
            {
                MessageBox.Show("Không thể xóa thông tin nhân viên này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string vanBan = txt_TimKiem.Text;
            List<NhanVien> NhanViens2 = new List<NhanVien>();
            NhanViens2 = (List<NhanVien>)NhanViens.Where(x => x.Hoten.Contains(vanBan)).ToList();
            dataGridView1.DataSource = NhanViens2;
        }
        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void txt_DangNhap_Click(object sender, EventArgs e)
        {
            FormPassWord formPassWord = new FormPassWord(txt_MaNV.Text,SoUser);
            formPassWord.ShowDialog();
        }
        private void enAble()
        {
            btn_Xoa.Enabled = true;
            BTN_Sua.Enabled = true;
            txt_DangNhap.Enabled = true;
        }
        private void disableBtt()
        {
            btn_Xoa.Enabled = false;
            BTN_Sua.Enabled = false;
            txt_DangNhap.Enabled = false;
            txt_MaNV.Text = "";
            txt_HoTen.Text = "";
            txt_SDT.Text = "";
        }
    }
}
