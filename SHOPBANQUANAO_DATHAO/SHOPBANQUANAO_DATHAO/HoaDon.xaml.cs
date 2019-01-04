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
namespace SHOPBANQUANAO_DATHAO
{
    /// <summary>
    /// Interaction logic for HoaDon.xaml
    /// </summary>
    public partial class HoaDon : UserControl
    {
        public HoaDon()
        {
            InitializeComponent();
            TaiDanhSachHoaDon();
            hdThuNgan.Text= "Thu Ngân: Hứa Vĩ Trung";
            DanhSachHangHoa_HoaDon.DataContext = BLL_HangHoa.BLL_TaiDanhSachHangHoa();
        }
        public void TaiDanhSachHoaDon()
        {
            DataTable dbDataSet = new System.Data.DataTable();
            dbDataSet = BLL_HoaDon.BLL_TaiDanhSachHoaDon();
            DanhSachHoaDon.DataContext = dbDataSet;
        }

        private void thembenhnhan_Click(object sender, RoutedEventArgs e)
        {
            frmlaphoadon.IsOpen = true;
            DanhSachHangHoa_HoaDon.DataContext = BLL_HangHoa.BLL_TaiDanhSachHangHoa();
        }

        private void frmhoadon_timkiemhanghoa_textchanged(object sender, TextChangedEventArgs e)
        {
            DanhSachHangHoa_HoaDon.DataContext = BLL_HangHoa.BLL_TimKiemTenHangHoa(frmhoadon_timkiemhanghoa.Text);
        }
    }
}
