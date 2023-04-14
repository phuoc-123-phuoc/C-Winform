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
    public partial class FormNhapHang : Form
    {
        private string nameHost = ConfigurationManager.AppSettings.Get("nameHost");
        private string userNamePss = ConfigurationManager.AppSettings.Get("userName");
        private string mahd;
       

       
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
            List<ChiTietDonHang> chiTietDonHang1s = new List<ChiTietDonHang>();

            cnn.Open();
            SqlCommand command;
            SqlDataReader datareader;
            string sql = "select sp.Tensp, SoLuong, GiaNhap, GiaBan, dm.TenDm from ChiTietDonHang ct, SanPham sp, DanhMucHang dm where ct.Masp=sp.Masp and sp.MaDM=dm.MaDm  and ct.MaDh="+ mahd;
            command = new SqlCommand(sql, cnn);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                ChiTietDonHang ct = new ChiTietDonHang();
                ct.Ten = (string)datareader["Tensp"];
                ct.SoLuong = (int)datareader["SoLuong"];
                ct.GiaNhap = (decimal)datareader["GiaNhap"];
                ct.GiaBan = (decimal)datareader["GiaBan"];
                ct.Loai = (string)datareader["TenDm"];
              
                chiTietDonHang1s.Add(ct);


            }
            cnn.Close();
            dataGridView1.DataSource = chiTietDonHang1s;
          
            decimal total = (decimal)chiTietDonHang1s.Sum(x => x.GiaNhap*x.SoLuong);
            tienNhap.Text = total.ToString();
        }
        public FormNhapHang(string tenNv, string ncc, string ngayNhap, string maHd)
        {
            InitializeComponent();
            textBox_NV.Text = tenNv;
            text_NCC.Text = ncc;
            textBox_Ngay.Text = ngayNhap;
            textBox_maHd.Text = maHd;
            mahd = maHd;
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            getListDh(ketNoi());
            getListSp(ketNoi());
            disableBtt();
        }

        private void textBox_SoLuong_Leave(object sender, EventArgs e)
        {
            if(textBox_SoLuong.Text == "")
            {
                textBox_SoLuong.Text = "Thêm Số Lượng";
                textBox_SoLuong.ForeColor = Color.Gray;
            }
        }

        private void textBox_SoLuong_Enter(object sender, EventArgs e)
        {
            if (textBox_SoLuong.Text == "Thêm Số Lượng")
            {
                textBox_SoLuong.Text = "";
                textBox_SoLuong.ForeColor = Color.Black;
            }
        }

        private void textBox_SoLuong_TextChanged(object sender, EventArgs e)
        {

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
               
                textBox_SoLuong.Text = rowS.Cells[1].Value.ToString();
                textBox_GiaN.Text = rowS.Cells[2].Value.ToString();
                textBox_GiaB.Text = rowS.Cells[3].Value.ToString();
               
                textBox_LoaiHang.Text=rowS.Cells[4].Value.ToString();
                foreach (SanPham item in sanPhams)
                {
                    if (rowS.Cells[0].Value.ToString().Equals(item.Tensp))
                    {
                        comboBox_TenSP.SelectedValue = item.Masp;
                        
                        break;
                    }
                }
                enableBtt();

            }
        }
        private void getListSp(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "select Masp, Tensp from SanPham ";
            SqlCommand command2 = new SqlCommand(sql, cnn);
            SqlDataReader datareader2 = command2.ExecuteReader();
            while (datareader2.Read())
            {
                SanPham sp = new SanPham();
                sp.Masp = (int)datareader2["Masp"];
                sp.Tensp = (string)datareader2["Tensp"];
                sanPhams.Add(sp);
            }
            cnn.Close();
            comboBox_TenSP.DataSource = sanPhams;
            comboBox_TenSP.ValueMember = "Masp";
            comboBox_TenSP.DisplayMember = "Tensp";

        }
        private void themCt(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "insert into ChiTietDonHang values( "+mahd+","+comboBox_TenSP.SelectedValue.ToString()+","+textBox_SoLuong.Text+","+ textBox_GiaN.Text+","+ textBox_GiaB.Text+");";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }
        private void xoaCt(SqlConnection cnn)
        {
            cnn.Open();

            string sql = "delete ChiTietDonHang where MaDh=" + mahd + " and Masp=" + comboBox_TenSP.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        private void button_Them_Click(object sender, EventArgs e)
        {
            try {

                if (KiemTra() == 1)
                {
                    themCt(ketNoi());
                    MessageBox.Show("Thêm thành công !");
                    getListDh(ketNoi());
                    disableBtt();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                }

            } catch {

                MessageBox.Show("Thêm thất bại !");
            
            }
            
        }

        private void comboBox_TenSP_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_TenSP.SelectedValue.ToString().Equals("MasterForm.SanPham") == false)
            {
                SqlConnection cnn = ketNoi();
                cnn.Open();
                string sql = "select dm.TenDm from SanPham sp, DanhMucHang dm where sp.MaDM=dm.MaDm and sp.Masp=" + comboBox_TenSP.SelectedValue;
               
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                textBox_LoaiHang.Text = (string)reader["TenDm"];
                cnn.Close();
            }
         
        }
        private void suaCt(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "update ChiTietDonHang \r\nset SoLuong=" + textBox_SoLuong.Text + ",GiaNhap=" + textBox_GiaN.Text + ",GiaBan= " + textBox_GiaB.Text + "\r\nwhere MaDh=" + mahd + "and Masp=" + comboBox_TenSP.SelectedValue + ";";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try {

                xoaCt(ketNoi());
                MessageBox.Show("Xóa thành công !");
                getListDh(ketNoi());
                disableBtt();


            } catch
            {
                MessageBox.Show("Xóa thất bại !");

            }
          
        }

        private void button_ThanhToan_Click(object sender, EventArgs e)
        {
            try {

                suaCt(ketNoi());
                MessageBox.Show("Sửa thành công !");
                getListDh(ketNoi());
                disableBtt();


            } catch
            {


                MessageBox.Show("Sửa thất bại !");

            }
           
        }
        private int KiemTra()
        {
            int x = textBox_SoLuong.Text.Length;
            int y = textBox_GiaN.Text.Length;
            int z = textBox_GiaB.Text.Length;   
            if (x ==0 || y==0|| z==0)
                return 0;
            return 1;
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

            cl11.Value2 = "Mã hóa đơn: " + hoaDon[0];

            cl11.ColumnWidth = 12;
            ////
            Microsoft.Office.Interop.Excel.Range cl12 = oSheet.get_Range("A4", "A4");

            cl12.Value2 = "Tên nhà cung cấp: " + hoaDon[1];

            cl12.ColumnWidth = 12;
            /////
            Microsoft.Office.Interop.Excel.Range cl13 = oSheet.get_Range("A5", "A5");

            cl13.Value2 = "Tên nhân viên: " + hoaDon[2];

            cl13.ColumnWidth = 12;
            //////
            Microsoft.Office.Interop.Excel.Range cl14 = oSheet.get_Range("A6", "A6");

            cl14.Value2 = "Ngày lập: " + hoaDon[3];

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

            cl1.Value2 = "Tên sản phẩm";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B9", "B9");

            cl2.Value2 = "Số lượng";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C9", "C9");

            cl3.Value2 = "Giá Nhập";
            cl3.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D9", "D9");

            cl4.Value2 = "Giá Bán";

            cl4.ColumnWidth = 10.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E9", "E9");

            cl5.Value2 = "Loại hàng";

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
            Microsoft.Office.Interop.Excel.Range total = oSheet.get_Range(oBd, oKt);

            total.MergeCells = true;

            total.Value2 = "Tổng tiền: " + tong + " VND";

            total.Font.Bold = true;

            total.Font.Name = "Times New Roman";

            total.Font.Size = "15";

            total.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
        private void btn_Excel_Click(object sender, EventArgs e)
        {
            string[] hoaDon = { textBox_maHd.Text, text_NCC.Text, textBox_NV.Text, textBox_Ngay.Text };
            DataTable dataTable = new DataTable();
            DataColumn col1 = new DataColumn("Ten");
            DataColumn col2 = new DataColumn("SoLuong");
            DataColumn col3 = new DataColumn("GiaN");
            DataColumn col4 = new DataColumn("GiaB");
            DataColumn col5 = new DataColumn("Loai");
             dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
             foreach(DataGridViewRow dtgvRow in dataGridView1.Rows)
            {
                DataRow dtrow= dataTable.NewRow();
                dtrow[0] = dtgvRow.Cells[0].Value;
                dtrow[1] = dtgvRow.Cells[1].Value;
                dtrow[2] = dtgvRow.Cells[2].Value;
                dtrow[3] = dtgvRow.Cells[3].Value;
                dtrow[4] = dtgvRow.Cells[4].Value;
                dataTable.Rows.Add(dtrow);

            }
            ExportFile(dataTable, "Danh sanh", "Danh sach mat hang", hoaDon, tienNhap.Text);
        }
        private void disableBtt()
        {
            button_Xoa.Enabled = false;
            button_Sua.Enabled = false;
            textBox_GiaN.Text = "";
            textBox_GiaB.Text = "";
            textBox_LoaiHang.Text = "";
            textBox_SoLuong.Text = "";
        }
        private void enableBtt()
        {
            button_Xoa.Enabled = true;
            button_Sua.Enabled = true;
           
        }
    }
}
