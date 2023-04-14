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
    public partial class UC_SanPham : UserControl
    {
        private string nameHost = ConfigurationManager.AppSettings.Get("nameHost");
        private string userNamePss = ConfigurationManager.AppSettings.Get("userName");

        List<SanPham> SanPhams = new List<SanPham>();
 
        List<DanhMucHang> DanhMucs = new List<DanhMucHang>();
        string maSpSelected;
        private SqlConnection ketNoi()
        {
            String connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source = " + nameHost + " ;Initial Catalog=BanHang;"
            + userNamePss + ";";
            return cnn = new SqlConnection(connectionstring);
        }
        private void themSp(SqlConnection cnn)
        {
            cnn.Open();
            string sql = @"insert into SanPham(Tensp,DonViTinh,MaDm) values(N'" + txt_TenSP.Text + @"',N'" + txt_DVT.Text + @"'," + comboBoxDanhMuc.SelectedValue + ")";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }

        private void suaSp(SqlConnection cnn)
        {
            cnn.Open();
            string sql = @"update SanPham set Tensp=N'" + txt_TenSP.Text + @"',DonViTinh=N'" + txt_DVT.Text + @"',MaDm=" + comboBoxDanhMuc.SelectedValue + " where Masp=" + maSpSelected+";";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }
        private void xoaSq(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "delete from SanPham where Masp=" + maSpSelected;
            SqlCommand command = new SqlCommand(sql,cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }
        private void getListDm(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "select * from danhmuchang";
            SqlCommand command2 = new SqlCommand(sql, cnn);
            SqlDataReader datareader2 = command2.ExecuteReader();
            while (datareader2.Read())
            {
                DanhMucHang DanhMuc = new DanhMucHang();
                DanhMuc.MaDm = (int)datareader2["MaDm"];
                DanhMuc.TenDm = (string)datareader2["TenDm"];
                DanhMucs.Add(DanhMuc);
            }
            cnn.Close();
            comboBoxDanhMuc.DataSource = DanhMucs;
            comboBoxDanhMuc.ValueMember = "MaDm";
            comboBoxDanhMuc.DisplayMember = "TenDm";

        }
      
        private void getListSp(SqlConnection cnn)
        {
            List<SanPham> SanPhams1 = new List<SanPham>();

            cnn.Open();
            SqlCommand command;
            SqlDataReader datareader;
            string sql = "select masp, tensp,dbo.giaban(masp) as gia, donvitinh,tendm, dbo.ktsoluong(masp) as soluong from sanpham sp, danhmuchang dm where sp.madm = dm.madm";
            command = new SqlCommand(sql, cnn);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                SanPham sanp = new SanPham();
                sanp.Masp = (int)datareader["masp"];
                sanp.Tensp = (string)datareader["tensp"];
                sanp.Gia = (decimal)datareader["gia"];
                sanp.DonViTinh = (string)datareader["donvitinh"];
                sanp.TenDM = (string)datareader["tendm"];
                if (datareader["soluong"].ToString() != "")
                  
                  sanp.SoLuong = (int)datareader["soluong"];
                else sanp.SoLuong = 0;
                SanPhams1.Add(sanp);


            }
            cnn.Close();
            dataGridView1.DataSource = SanPhams1;
            SanPhams = SanPhams1.GetRange(0, SanPhams1.Count);
        }
        private int kiemTraThongTin()
        {
            if(txt_TenSP.Text.Length==0 || txt_DVT.Text.Length==0)
                return 0;
            return 1;
        }
        public UC_SanPham()
        {
            InitializeComponent();
            SqlConnection cnn = ketNoi();
            getListSp(cnn);
            getListDm(cnn);
            disableBtt();

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (kiemTraThongTin()==1)
            {
                themSp(ketNoi());
                MessageBox.Show("Thêm thành công !");
                getListSp(ketNoi());
                disableBtt();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow rowS = dataGridView1.Rows[e.RowIndex];
                maSpSelected = rowS.Cells[0].Value.ToString();
                txt_TenSP.Text= rowS.Cells[1].Value.ToString();
                txt_DVT.Text= rowS.Cells[3].Value.ToString();
                foreach (DanhMucHang item in DanhMucs)
                {
                    if (rowS.Cells[4].Value.ToString().Equals(item.TenDm))
                    {
                        comboBoxDanhMuc.SelectedValue = item.MaDm;
                        break;
                    }
                } 
                enableBtt();
            }
        }

        private void BTN_Sua_Click(object sender, EventArgs e)
        {
            if (kiemTraThongTin() == 1)
            {
                suaSp(ketNoi());
                MessageBox.Show("Sửa mặt hàng thành công !");
                getListSp(ketNoi());
                disableBtt();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mặt hàng muốn sửa !");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemTraThongTin() == 1)
                {
                    xoaSq(ketNoi());
                    MessageBox.Show("Xóa mặt hàng thành công !");
                    getListSp(ketNoi());
                    disableBtt();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn mặt hàng muốn xóa !");
                }

            }
            catch (Exception loi)
            {
                MessageBox.Show("Không thể xóa mặt hàng này !");
            }
          
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string vanBan=txt_TimKiem.Text;
            List<SanPham> SanPhams3 = new List<SanPham>();
            SanPhams3 = (List<SanPham>)SanPhams.Where(x => x.Tensp.Contains(vanBan)).ToList();
            dataGridView1.DataSource = SanPhams3;

        }

        private void danhMuc_Click(object sender, EventArgs e)
        {
            FormDanhMuc frmDanhMuc = new FormDanhMuc();
            frmDanhMuc.ShowDialog();
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
            txt_TenSP.Text = "";
            txt_DVT.Text = "";
        }

        private void export_Ex_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            DataColumn col1 = new DataColumn("Masp");
            DataColumn col2 = new DataColumn("Tensp");
            DataColumn col3 = new DataColumn("Gia");
            DataColumn col4 = new DataColumn("Donvi");
            DataColumn col5 = new DataColumn("Loai");
            DataColumn col6 = new DataColumn("Slcon");
            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            foreach (DataGridViewRow dtgvRow in dataGridView1.Rows)
            {
                DataRow dtrow = dataTable.NewRow();
               
               dtrow[0] = dtgvRow.Cells[0].Value;
                dtrow[1] = dtgvRow.Cells[1].Value;
                dtrow[2] = dtgvRow.Cells[2].Value;
                dtrow[3] = dtgvRow.Cells[3].Value;
                dtrow[4] = dtgvRow.Cells[4].Value;
                dtrow[5] = dtgvRow.Cells[5].Value;
                dataTable.Rows.Add(dtrow);

            }
            ExportFile(dataTable, "Danh sanh", "Danh sách sản phẩm");
        }
        public void ExportFile(DataTable dataTable, string sheetName, string title)
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
         
            

          
         
           
            // Tạo phần Tiêu đề danh sách hàng
            Microsoft.Office.Interop.Excel.Range head1 = oSheet.get_Range("A7", "F7");

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

            cl4.Value2 = "Đơn vị";

            cl4.ColumnWidth = 10.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E9", "E9");

            cl5.Value2 = "Danh mục";

            cl5.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F9", "F9");

            cl6.Value2 = "Số lượng còn";

            cl6.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A9", "F9");

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

            int rowEnd = rowStart + dataTable.Rows.Count - 2;

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
