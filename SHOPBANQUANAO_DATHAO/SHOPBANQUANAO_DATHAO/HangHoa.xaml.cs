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
    /// Interaction logic for HangHoa.xaml
    /// </summary>
    public partial class HangHoa : UserControl
    {
        public HangHoa()
        {
            InitializeComponent();
            TaiDanhSachHangHoa();

        }
        public void TaiDanhSachHangHoa()
        {
            DataTable dbDataSet = new System.Data.DataTable();
            dbDataSet = BLL_HangHoa.BLL_TaiDanhSachHangHoa();
            DanhSachHangHoa.DataContext = dbDataSet;
        }
        public void TimKiemHangHoa_TextChanged(object sender, TextChangedEventArgs e)
        {
            timkiemmahanghoa.Text = "";
            DanhSachHangHoa.DataContext = BLL_HangHoa.BLL_TimKiemTenHangHoa(timkiemtenhanghoa.Text);
        }
        public void TimKiemMaHangHoa_TextChanged(object sender, TextChangedEventArgs e)
        {
            timkiemtenhanghoa.Text = "";
            DanhSachHangHoa.DataContext = BLL_HangHoa.BLL_TimKiemMaHangHoa(timkiemmahanghoa.Text);
        }
    }
}
