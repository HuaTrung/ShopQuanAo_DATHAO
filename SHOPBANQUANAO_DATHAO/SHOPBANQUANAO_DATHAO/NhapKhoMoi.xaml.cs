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
    /// Interaction logic for NhapKhoMoi.xaml
    /// </summary>
    public partial class NhapKhoMoi : UserControl
    {
        public NhapKhoMoi()
        {
            InitializeComponent();
            loadLoaiHang();
            loadNhaCungCap();
        }
        private void loadLoaiHang()
        {
            foreach (string item in BLL_HangHoa.BLL_TaiLoaiHang())
                loaihang.Items.Add(item.ToString());
           
        }
        private void loadNhaCungCap()
        {
            foreach (string item in BLL_HangHoa.BLL_TaiNhaCungCap())
                nhacungcap.Items.Add(item.ToString());
        }

        private void themloaihangBTN_Click(object sender, RoutedEventArgs e)
        {
            if (themloaihang.Text.Length == 0)
            {
                themloaihang.Focus();
            }
            else
            {
                BLL_HangHoa.BLL_ThemLoaiHangHoa(themloaihang.Text);
                loadLoaiHang();
                themloaihang.Text = "";
                loaihang.SelectedIndex = loaihang.Items.Count - 1;
                MessageBox.Show("Thành Công");
            }
        }

        private void themnhacungcapBTN_Click(object sender, RoutedEventArgs e)
        {

            if (themnhacungcap.Text.Length == 0)
            {
                themnhacungcap.Focus();
            }
            else
            {
                BLL_HangHoa.BLL_ThemNhaCungCap(themnhacungcap.Text);
                loadNhaCungCap();
                themnhacungcap.Text = "";
                nhacungcap.SelectedIndex = nhacungcap.Items.Count - 1;
                MessageBox.Show("Thành Công");
            }
        }

        private void themHangHoa_Click(object sender, RoutedEventArgs e)
        {
            DTO.HangHoa hanghoa = new DTO.HangHoa(ten.Text, giatien.Text, loaihang.SelectedValue.ToString(), size.Text, nhacungcap.SelectedValue.ToString());
            BLL_HangHoa.BLL_ThemHangHoa(hanghoa);
        }
    }
}
