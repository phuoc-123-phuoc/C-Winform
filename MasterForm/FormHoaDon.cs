using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MasterForm
{
    public partial class FormHoaDon : Form
    {
        private string nameHost = ConfigurationManager.AppSettings.Get("nameHost");
        private string userNamePss = ConfigurationManager.AppSettings.Get("userName");
        private string mahd;
        private string maSp;
        List<ChiTietHoaDon> chiTietHoaDons = new List<ChiTietHoaDon>();
        List<SanPham> sanPhams = new List<SanPham>();
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
            List<ChiTietHoaDon> chiTietHoaDon1s = new List<ChiTietHoaDon>();
           

            cnn.Open();
            SqlCommand command;
            SqlDataReader datareader;
            string sql = "select ct.Masp, sp.Tensp,dbo.GetPrice(hd.Mahd,sp.Masp) as gia, ct.SoLuong, dm.TenDm  from ChiTietHoaDon ct, HoaDon hd, SanPham sp, DanhMucHang dm\r\nwhere ct.MaHd=hd.Mahd and ct.Masp=sp.Masp and dm.MaDm=sp.MaDM and hd.Mahd=" + mahd;
            command = new SqlCommand(sql, cnn);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {

                ChiTietHoaDon ct = new ChiTietHoaDon();
                ct.Masp = (int)datareader["Masp"];
                ct.tenSanPham = (string)datareader["Tensp"];
                ct.gia = (decimal)datareader["gia"];
                ct.SoLuong = (int)datareader["SoLuong"];

                ct.danhMuc = (string)datareader["TenDm"];
                chiTietHoaDon1s.Add(ct);


            }
            
            cnn.Close();
            dataGridView1.DataSource = chiTietHoaDon1s;

            decimal total = (decimal)chiTietHoaDon1s.Sum(x => x.gia * x.SoLuong);
            textBoxTong.Text = total.ToString();
        }
        private void loadSp(SqlConnection cnn)
        {

            cnn.Open();
            string sql = "select Masp, Tensp from SanPham";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader datareader= cmd.ExecuteReader();
            while (datareader.Read())
            {
                SanPham sp = new SanPham();
                sp.Masp = (int)datareader["Masp"];
                sp.Tensp = (string)datareader["Tensp"];
                sanPhams.Add(sp);
            }
            comboBox_TenSP.DataSource=sanPhams;
            comboBox_TenSP.ValueMember = "Masp";
            comboBox_TenSP.DisplayMember = "Tensp";
            cnn.Close();
        }
        public FormHoaDon(string tenNv, string tenK, string ngayGhi, string maHd)
        {
            InitializeComponent();

            mahd = maHd;
            txt_MaNV.Text = tenNv;
            textBox1.Text = tenK;
            textBox2.Text = ngayGhi;
            txt_SoHoaDon.Text = mahd;
            getListDh(ketNoi());
            loadSp(ketNoi());

            if (button_Sua.Enabled == true || button_Xoa.Enabled == true)
            {
                button_Sua.Enabled = false;
                button_Xoa.Enabled = false;
            }

        }


        private void textBox_DonGia_Leave(object sender, EventArgs e)
        {

        }

        private void textBox_DonGia_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_SoLuong_Leave(object sender, EventArgs e)
        {
            if (txt_SoLuong.Text == "")
            {
                txt_SoLuong.Text = "Thêm Số Lượng";
                txt_SoLuong.ForeColor = Color.Gray;
            }
        }

        private void textBox_SoLuong_Enter(object sender, EventArgs e)
        {
            if (txt_SoLuong.Text == "Thêm Số Lượng")
            {
                txt_SoLuong.Text = "";
                txt_SoLuong.ForeColor = Color.Black;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow rowS = dataGridView1.Rows[e.RowIndex];
                maSp= rowS.Cells[0].Value.ToString();
                foreach (SanPham item in sanPhams)
                {
                    if (rowS.Cells[1].Value.ToString().Equals(item.Tensp))
                    {
                        comboBox_TenSP.SelectedValue = item.Masp;
                    }
                }
                txt_DonGia.Text = rowS.Cells[2].Value.ToString();
                txt_SoLuong.Text=rowS.Cells[3].Value.ToString();
                textBoxDm.Text=rowS.Cells[4].Value.ToString();
                if (button_Sua.Enabled == false || button_Xoa.Enabled == false)
                {
                    button_Sua.Enabled = true;
                    button_Xoa.Enabled = true;
                }

            }
        }
        private void them(SqlConnection cnn)
        {
            cnn.Open(); 
            string sql= @"insert  into ChiTietHoaDon(MaHd,Masp,SoLuong) values("+mahd+","+comboBox_TenSP.SelectedValue+","+txt_SoLuong.Text+") ";
            
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        private void xoa(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "delete ChiTietHoaDon where MaHd="+mahd+" and Masp="+maSp;
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        private void sua(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "update ChiTietHoaDon set SoLuong= " + txt_SoLuong.Text + " where MaHd=" + mahd + " and Masp= " + maSp;
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        private void button_Them_Click(object sender, EventArgs e)
        {
            try {
                them(ketNoi());
                MessageBox.Show("Thêm thành công !");
                getListDh(ketNoi());
                reset();
            } catch
            {
                MessageBox.Show("Thêm thất bại !");
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                xoa(ketNoi());
                MessageBox.Show("Xóa thành công !");
                getListDh(ketNoi());
                reset();
            }
            catch
            {
                MessageBox.Show("Xóa thất bại !");
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                sua(ketNoi());
                MessageBox.Show("Sửa thành công !");
                getListDh(ketNoi());
                reset();
            }
            catch
            {
                MessageBox.Show("Sửa thất bại !");
            }
        }
        private void getGiaDm(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "select dbo.GiaBan(ct.Masp) as gia, dm.TenDm as ten \r\nfrom ChiTietHoaDon ct, SanPham sp, DanhMucHang dm\r\nwhere ct.Masp= sp.Masp\r\nand sp.MaDM= dm.MaDm\r\nand ct.Masp=" + comboBox_TenSP.SelectedValue;
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                txt_DonGia.Text = reader["gia"].ToString();
                textBoxDm.Text= (string)reader["ten"];
            } 
            cnn.Close();
        }
        private void comboBox_TenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if(comboBox_TenSP.SelectedValue.ToString().Equals("MasterForm.SanPham")==false)
           getGiaDm(ketNoi());
        }
        private void reset()
        {
            if(button_Sua.Enabled == true|| button_Xoa.Enabled == true)
            {
                button_Sua.Enabled = false;
                button_Xoa.Enabled = false;
            }
            txt_DonGia.Text = "";
            textBoxDm.Text = "";
            txt_SoLuong.Text = "";
        }
        public void ExportFile(DataTable dataTable, string sheetName, string title, string[] hoaDon, string tong)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;
            //Tạo phần tiêu đề hóa đơn
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "E1");

            head.MergeCells = true;

            head.Value2 = "THÔNG TIN HÓA ĐƠN";

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //Cột thông tin  hóa đơn
            Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("A3", "A3");

            cl11.Value2 = "Mã hóa đơn: " + hoaDon[3];

            cl11.ColumnWidth = 12;
            ////
            Microsoft.Office.Interop.Excel.Range cl12 = oSheet.get_Range("A4", "A4");

            cl12.Value2 = "Tên khách hàng: " + hoaDon[1];

            cl12.ColumnWidth = 12;
            /////
            Microsoft.Office.Interop.Excel.Range cl13 = oSheet.get_Range("A5", "A5");

            cl13.Value2 = "Tên nhân viên: " + hoaDon[0];

            cl13.ColumnWidth = 12;
            //////
            Microsoft.Office.Interop.Excel.Range cl14 = oSheet.get_Range("A6", "A6");

            cl14.Value2 = "Ngày lập: " + hoaDon[2];

            cl14.ColumnWidth = 12;
            // Tạo phần Tiêu đề danh sách hàng
            Microsoft.Office.Interop.Excel.Range head1 = oSheet.get_Range("A7", "E7");

            head1.MergeCells = true;

            head1.Value2 = title;

            head1.Font.Bold = true;

            head1.Font.Name = "Times New Roman";

            head1.Font.Size = "20";

            head1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A9", "A9");

            cl1.Value2 = "Mã sản phẩm";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B9", "B9");

            cl2.Value2 = "Tên sản phẩm";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C9", "C9");

            cl3.Value2 = "Giá";
            cl3.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D9", "D9");

            cl4.Value2 = "Số lượng";

            cl4.ColumnWidth = 10.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E9", "E9");

            cl5.Value2 = "Danh mục";

            cl5.ColumnWidth = 20.5;


            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A9", "E9");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 10;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 1;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;


            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            string oBd = "C" + (rowEnd + 1);
            string oKt = "E" + (rowEnd + 1);
            //Tạo phần tổng tiền 
            Microsoft.Office.Interop.Excel.Range total = oSheet.get_Range(oBd,oKt);

            total.MergeCells = true;

            total.Value2 = "Tổng tiền: "+tong+" VND";

            total.Font.Bold = true;

            total.Font.Name = "Times New Roman";

            total.Font.Size = "15";

            total.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
        private void export_Excel_Click(object sender, EventArgs e)
        {
            string[] hoaDon = { txt_MaNV.Text, textBox1.Text, textBox2.Text, txt_SoHoaDon.Text };
            DataTable dataTable = new DataTable();
            DataColumn col1 = new DataColumn("Masp");
            DataColumn col2 = new DataColumn("Tensp");
            DataColumn col3 = new DataColumn("Gia");
            DataColumn col4 = new DataColumn("SoLuong");
            DataColumn col5 = new DataColumn("Loai");
            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            foreach (DataGridViewRow dtgvRow in dataGridView1.Rows)
            {
                DataRow dtrow = dataTable.NewRow();
                dtrow[0] = dtgvRow.Cells[0].Value;
                dtrow[1] = dtgvRow.Cells[1].Value;
                dtrow[2] = dtgvRow.Cells[2].Value.ToString().Substring(0, dtgvRow.Cells[2].Value.ToString().Length-5);
                dtrow[3] = dtgvRow.Cells[3].Value;
                dtrow[4] = dtgvRow.Cells[4].Value;
                dataTable.Rows.Add(dtrow);

            }
            ExportFile(dataTable, "Danh sanh", "Danh sach mat hang", hoaDon,textBoxTong.Text.ToString().Substring(0, textBoxTong.Text.ToString().Length-5));
        }
    }
}
