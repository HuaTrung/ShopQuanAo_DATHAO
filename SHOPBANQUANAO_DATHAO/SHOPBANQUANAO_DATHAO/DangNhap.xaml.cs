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
using System.Windows.Shapes;
using WpfApplication;
using MODEL;
namespace SHOPBANQUANAO_DATHAO
{
    /// <summary>
    /// Interaction logic for DangNhap.xaml
    /// </summary>
    public partial class DangNhap : Window
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int kqua = BLL_NhanVien.BLL_KiemtraDangNhap(tendangnhap.Text, matkhau.Password);
            if (kqua > 0)
            {
                MainWindow win2 = new MainWindow(kqua);
                win2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập");
            }
        }
    }
}
