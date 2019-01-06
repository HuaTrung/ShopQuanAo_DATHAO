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
using MODEL;
using System.Data;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;
using System.Windows.Forms;

namespace SHOPBANQUANAO_DATHAO
{
    /// <summary>
    /// Interaction logic for DoanhThu.xaml
    /// </summary>
    public partial class DoanhThu : System.Windows.Controls.UserControl
    {
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void loadbaocaodoanhthutheongay_Click(object sender, RoutedEventArgs e)
        {
            System.Data.DataTable dt = BLL_BaoCao.BLL_BaoCaoDoanhThuTheoNgay(doanhthu_thang.Text.Substring(6), doanhthu_nam.Text);
            baocaodoanhthutheongay.DataContext = dt;

            List<KeyValuePair<string, double>> valueList = new List<KeyValuePair<string, double>>();

            foreach (DataRow row in dt.Rows)
            {
                valueList.Add(new KeyValuePair<string, double>(row["ngaylap"].ToString(), Convert.ToDouble(row["doanhthu"].ToString())));
            }
            pieChart.Title="Báo cáo doanh thu theo tháng" + doanhthu_thang.Text.Substring(doanhthu_thang.Text.Length - 1)+" năm " + doanhthu_nam.Text;
            pieChart.DataContext = valueList;
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
            Microsoft.Office.Interop.Excel.Application oExcel= new Microsoft.Office.Interop.Excel.Application();
            Workbook oBook= oExcel.Workbooks.Add(Type.Missing);
            Worksheet oSheet = oBook.Worksheets[1];
            int colIndex = 0;
            int rowIndex = 0;
            datatableMain = BLL_BaoCao.BLL_BaoCaoDoanhThuTheoNgay(doanhthu_thang.Text.Substring(6), doanhthu_nam.Text);
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

        private void xuatexcel_Click(object sender, RoutedEventArgs e)
        {
            xuatExcel();
        }
    }
}
