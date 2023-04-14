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
using System.Windows.Forms.DataVisualization.Charting;

namespace MasterForm
{
    public partial class UC_TrangChu : UserControl
    {
        private string nameHost = ConfigurationManager.AppSettings.Get("nameHost");
        private string userNamePss = ConfigurationManager.AppSettings.Get("userName");
        public UC_TrangChu()
        {
            InitializeComponent();
            doanhThu_Sodon();
            tongSp();
            fillChart();
           
           
        }
        private SqlConnection ketNoi()
        {
            String connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source = " + nameHost + " ;Initial Catalog=BanHang;"
            + userNamePss + ";";
            return cnn = new SqlConnection(connectionstring);
        }
        private void doanhThu_Sodon()
        {
            SqlConnection cnn = ketNoi();
            cnn.Open();
            string sql = "select count(Mahd) as SoDon, sum(dbo.GetTotal(Mahd)-dbo.GetTotalNhap(Mahd)) as DoanhThu   \r\nfrom HoaDon\r\nwhere ngayghi=CAST( GETDATE() AS Date ) ";
            SqlCommand command2 = new SqlCommand(sql, cnn);
            SqlDataReader datareader2 = command2.ExecuteReader();
         
            datareader2.Read();
            lb_soDon.Text = datareader2["SoDon"].ToString();
            lb_doanhThu.Text = datareader2["DoanhThu"].ToString();
            cnn.Close();
        }
        private void tongSp()
        {
            SqlConnection cnn = ketNoi();
            cnn.Open();
            string sql = "select sum(ct.SoLuong) as TongSp from ChiTietHoaDon ct, HoaDon hd where hd.Mahd=ct.MaHd and hd.ngayghi=CAST( GETDATE() AS Date )  ";
            SqlCommand command2 = new SqlCommand(sql, cnn);
            SqlDataReader datareader2 = command2.ExecuteReader();
            datareader2.Read();
            lb_soSp.Text = datareader2["TongSp"].ToString();
            cnn.Close();
        }
        private void fillChart()
        {
            SqlConnection cnn = ketNoi();
            DataSet ds = new DataSet();
            cnn.Open();
            DateTime aDate = DateTime.Now;
            string sql = @"select top(10) sp.Tensp Ten, sum(ct.SoLuong) SoLuong from SanPham sp, HoaDon hd, ChiTietHoaDon ct where sp.Masp=ct.Masp and ct.MaHd=hd.Mahd and hd.ngayghi<= CAST( GETDATE() AS Date ) and hd.ngayghi >= N'"+aDate.ToString("yyyy-MM-01")+ @"' group by sp.Tensp, sp.Masp, SoLuong";
            SqlDataAdapter adapt = new SqlDataAdapter(sql, cnn);
            adapt.Fill(ds);
            chart.DataSource = ds;
            chart.Series["Sản phẩm"].XValueMember = "Ten";
            chart.Series["Sản phẩm"].YValueMembers = "SoLuong";
            cnn.Close();
        }

       

        private void export_DoanhThu_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value <= dateTimePicker2.Value || dateTimePicker1.Value.ToString("dd-MM-yyyy") == dateTimePicker2.Value.ToString("dd-MM-yyyy"))
            {
               

                DataTable dataTable = new DataTable();
                DataColumn col1 = new DataColumn("Ngay");
                DataColumn col2 = new DataColumn("SpDaBan");
                DataColumn col3 = new DataColumn("Doanh thu");
                DataColumn col4 = new DataColumn("LoiNhuan");

                dataTable.Columns.Add(col1);
                dataTable.Columns.Add(col2);
                dataTable.Columns.Add(col3);
                dataTable.Columns.Add(col4);
                ////
                string from = dateTimePicker1.Value.ToString("yyyy-MM-dd");
               
                string to = dateTimePicker2.Value.ToString("yyyy-MM-dd");
               // MessageBox.Show(from + " ==" + to);
                SqlConnection cnn = ketNoi();
                cnn.Open();
                string sql = "select hd.ngayghi, sum(ct.SoLuong) as SoSpDaBan,sum(dbo.GetTotal(hd.Mahd)) as DoanhThu, sum(dbo.GetTotal(hd.Mahd)-dbo.GetTotalNhap(hd.Mahd)) as LoiNhuan from HoaDon hd, ChiTietHoaDon ct where hd.Mahd= ct.MaHd and hd.ngayghi >=N'"+from+@"' and hd.ngayghi<=N'"+to+@"' group by hd.ngayghi";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   
                    DataRow dtrow = dataTable.NewRow();
                    dtrow[0] = Convert.ToDateTime(reader["ngayghi"]).ToString("dd/MM/yyyy");
                   // MessageBox.Show(Convert.ToDateTime(reader["ngayghi"]).ToString("dd-MM-yyyy"));
                    dtrow[1] = (int)reader["SoSpDaBan"];
                    dtrow[2] = (decimal)reader["DoanhThu"];
                    dtrow[3] = (decimal)reader["LoiNhuan"];   
                    dataTable.Rows.Add(dtrow);
                  
                }
                cnn.Close();

                ExportFile(dataTable, "Doanh thu", "Thống kê doanh thu"/*, hoaDon, textBoxTong.Text*/);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khoảng thời gian hợp lệ");
            }
            
         
        }
        public void ExportFile(DataTable dataTable, string sheetName, string title/*, string[] hoaDon, string tong*/)
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
            //Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "E1");

            //head.MergeCells = true;

            //head.Value2 = "THÔNG TIN HÓA ĐƠN";

            //head.Font.Bold = true;

            //head.Font.Name = "Times New Roman";

            //head.Font.Size = "20";

            //head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //Cột thông tin  hóa đơn
            //Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("A3", "A3");

            //cl11.Value2 = "Mã hóa đơn: " + hoaDon[3];

            //cl11.ColumnWidth = 12;
            //////
            //Microsoft.Office.Interop.Excel.Range cl12 = oSheet.get_Range("A4", "A4");

            //cl12.Value2 = "Tên khách hàng: " + hoaDon[1];

            //cl12.ColumnWidth = 12;
            ///////
            //Microsoft.Office.Interop.Excel.Range cl13 = oSheet.get_Range("A5", "A5");

            //cl13.Value2 = "Tên nhân viên: " + hoaDon[0];

            //cl13.ColumnWidth = 12;
            ////////
            //Microsoft.Office.Interop.Excel.Range cl14 = oSheet.get_Range("A6", "A6");

            //cl14.Value2 = "Ngày lập: " + hoaDon[2];

            //cl14.ColumnWidth = 12;
            // Tạo phần Tiêu đề danh sách hàng
            Microsoft.Office.Interop.Excel.Range head1 = oSheet.get_Range("A7", "D7");

            head1.MergeCells = true;

            head1.Value2 = title;

            head1.Font.Bold = true;

            head1.Font.Name = "Times New Roman";

            head1.Font.Size = "20";

            head1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A9", "A9");

            cl1.Value2 = "Ngày";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B9", "B9");

            cl2.Value2 = "Số sản phẩm đã bán";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C9", "C9");

            cl3.Value2 = "Doanh thu";
            cl3.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D9", "D9");

            cl4.Value2 = "Lợi nhuận";

            cl4.ColumnWidth = 10.5;

            //Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E9", "E9");

            //cl5.Value2 = "Danh mục";

            //cl5.ColumnWidth = 20.5;


            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A9", "D9");

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

           
        }

        private void export_SanPham_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value <= dateTimePicker2.Value || dateTimePicker1.Value.ToString("dd-MM-yyyy") == dateTimePicker2.Value.ToString("dd-MM-yyyy"))
            {


                DataTable dataTable = new DataTable();
                DataColumn col1 = new DataColumn("Ma");
                DataColumn col2 = new DataColumn("Ten");
                DataColumn col3 = new DataColumn("Soluog");
               

                dataTable.Columns.Add(col1);
                dataTable.Columns.Add(col2);
                dataTable.Columns.Add(col3);
             
                ////
                string from = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                string to = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                // MessageBox.Show(from + " ==" + to);
                SqlConnection cnn = ketNoi();
                cnn.Open();
                string sql = "select top(10)sp.Masp, sp.Tensp Ten, sum(ct.SoLuong) SoLuong from SanPham sp, HoaDon hd, ChiTietHoaDon ct where sp.Masp=ct.Masp and ct.MaHd=hd.Mahd and hd.ngayghi<=N'" + to + @"' and hd.ngayghi >=N'" + from + @"' group by sp.Tensp, sp.Masp order by SoLuong desc";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    DataRow dtrow = dataTable.NewRow();
                    dtrow[0] = reader["Masp"];
                    dtrow[1] = reader["Ten"];
                    dtrow[2] = reader["SoLuong"];
                  
                    dataTable.Rows.Add(dtrow);

                }
                cnn.Close();

                ExportFile1(dataTable, "Sản phẩm", "Sản phẩm bán chạy "/*, hoaDon, textBoxTong.Text*/);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khoảng thời gian hợp lệ");
            }
        }
        public void ExportFile1(DataTable dataTable, string sheetName, string title/*, string[] hoaDon, string tong*/)
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
            //Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "E1");

            //head.MergeCells = true;

            //head.Value2 = "THÔNG TIN HÓA ĐƠN";

            //head.Font.Bold = true;

            //head.Font.Name = "Times New Roman";

            //head.Font.Size = "20";

            //head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //Cột thông tin  hóa đơn
            //Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("A3", "A3");

            //cl11.Value2 = "Mã hóa đơn: " + hoaDon[3];

            //cl11.ColumnWidth = 12;
            //////
            //Microsoft.Office.Interop.Excel.Range cl12 = oSheet.get_Range("A4", "A4");

            //cl12.Value2 = "Tên khách hàng: " + hoaDon[1];

            //cl12.ColumnWidth = 12;
            ///////
            //Microsoft.Office.Interop.Excel.Range cl13 = oSheet.get_Range("A5", "A5");

            //cl13.Value2 = "Tên nhân viên: " + hoaDon[0];

            //cl13.ColumnWidth = 12;
            ////////
            //Microsoft.Office.Interop.Excel.Range cl14 = oSheet.get_Range("A6", "A6");

            //cl14.Value2 = "Ngày lập: " + hoaDon[2];

            //cl14.ColumnWidth = 12;
            // Tạo phần Tiêu đề danh sách hàng
            Microsoft.Office.Interop.Excel.Range head1 = oSheet.get_Range("A7", "C7");

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

            cl3.Value2 = "Số lượng đã bán";
            cl3.ColumnWidth = 12.0;

            //Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D9", "D9");

            //cl4.Value2 = "Lợi nhuận";

            //cl4.ColumnWidth = 10.5;

            //Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E9", "E9");

            //cl5.Value2 = "Danh mục";

            //cl5.ColumnWidth = 20.5;


            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A9", "C9");

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


        }
    }
}
