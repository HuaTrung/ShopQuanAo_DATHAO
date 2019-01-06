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
namespace SHOPBANQUANAO_DATHAO
{
    /// <summary>
    /// Interaction logic for DoanhThu.xaml
    /// </summary>
    public partial class DoanhThu : UserControl
    {
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void loadbaocaodoanhthutheongay_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = BLL_BaoCao.BLL_BaoCaoDoanhThuTheoNgay(doanhthu_thang.Text.Substring(doanhthu_thang.Text.Length - 1), doanhthu_nam.Text);
            baocaodoanhthutheongay.DataContext = dt;

            List<KeyValuePair<string, double>> valueList = new List<KeyValuePair<string, double>>();

            foreach (DataRow row in dt.Rows)
            {
                string a = row["ngaylap"].ToString();
                double b = Convert.ToDouble(row["doanhthu"].ToString());//.Substring(0, row["doanhthu"].ToString().Length - 1));
                valueList.Add(new KeyValuePair<string, double>(row["ngaylap"].ToString(), b));
            }
            pieChart.Title="Báo cáo doanh thu theo tháng" + doanhthu_thang.Text.Substring(doanhthu_thang.Text.Length - 1)+" năm " + doanhthu_nam.Text;
            pieChart.DataContext = valueList;
        }
    }
}
