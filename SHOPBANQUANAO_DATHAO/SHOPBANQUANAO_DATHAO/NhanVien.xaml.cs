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
using DTO;
namespace SHOPBANQUANAO_DATHAO
{
    /// <summary>
    /// Interaction logic for NhanVien.xaml
    /// </summary>
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
            DTO.Global.CurUser = "HỨA VĨ TRUNG";
            labelnhanvien.Content = "NHÂN VIÊN " + DTO.Global.CurUser;
        }
    }
}
