using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using MODEL;
using DTO;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;
using System.Windows.Forms;

namespace SHOPBANQUANAO_DATHAO
{
    /// <summary>
    /// Interaction logic for TonKho.xaml
    /// </summary>
    public partial class TonKho : System.Windows.Controls.UserControl
    {
        public TonKho()
        {
            InitializeComponent();
            loaiHang.Items.Add("Tất cả");
            foreach (string item in BLL_HangHoa.BLL_TaiLoaiHang())
                loaiHang.Items.Add(item.ToString());
        }

        private void loadbaocaotonthu_Click(object sender, RoutedEventArgs e)
        {
            System.Data.DataTable dt = BLL_BaoCao.BLL_BaoCaoTonKho(loaiHang.SelectedIndex.ToString());
            baocaodoanhthu.DataContext=dt;
            ketqua.Text = "Có : "+dt.Rows.Count.ToString() +" kết quả trả về";
        }
        private void xuatExcel()
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            try
            {
                if ((f.ShowDialog() == System.Windows.Forms.DialogResult.OK))
                {
                    luuExcel(f);
                }

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("error");
            }

        }
        private void luuExcel(FolderBrowserDialog f)
        {
            System.Data.DataTable datatableMain = new System.Data.DataTable();
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Workbook oBook = oExcel.Workbooks.Add(Type.Missing);
            Worksheet oSheet = oBook.Worksheets[1];
            int colIndex = 0;
            int rowIndex = 0;
            datatableMain = BLL_BaoCao.BLL_BaoCaoTonKho(loaiHang.SelectedValue.ToString());
            // Export the Columns to excel file

            foreach (DataColumn dc in datatableMain.Columns)
            {
                colIndex = (colIndex + 1);
                oSheet.Cells[1, colIndex] = dc.ColumnName;
            }

            // Export the rows to excel file
            foreach (DataRow dr in datatableMain.Rows)
            {
                rowIndex = (rowIndex + 1);
                colIndex = 0;
                foreach (DataColumn dc in datatableMain.Columns)
                {
                    colIndex = (colIndex + 1);
                    oSheet.Cells[(rowIndex + 1), colIndex] = dr[dc.ColumnName];
                }

            }

            string fileName = ("\\HoaDon"
                        + (DateTime.Now.ToString("dd-MM-yyyy") + ".xls"));
            object finalPath = (f.SelectedPath + fileName);
            oSheet.Columns.AutoFit();
            // Save file in final path
            oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Release the objects
            ReleaseObject(oSheet);
            oBook.Close(false, Type.Missing, Type.Missing);
            ReleaseObject(oBook);
            oExcel.Quit();
            ReleaseObject(oExcel);
            // Some time Office application does not quit after automation: 
            // so i am calling GC.Collect method.
            GC.Collect();
        }
        private void ReleaseObject(object o)
        {
            try
            {
                while ((System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0))
                {
                }
            }
            catch
            {
            }
            finally
            {
                o = null;
            }
        }

        private void xuatexcel_tonkho_Click(object sender, RoutedEventArgs e)
        {
            xuatExcel();
        }
    }
}
