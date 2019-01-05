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
using WpfApplication;
namespace SHOPBANQUANAO_DATHAO
{
    /// <summary>
    /// Interaction logic for MatHang.xaml
    /// </summary>
    public partial class MatHang : UserControl
    {
        public String id;
        public MatHang(int STT)
        {
            InitializeComponent();
            if (STT >= 10)
                STTHang.Text = STT.ToString() + '.';
            else
                STTHang.Text = '0' + STT.ToString() + '.';
        }
        public event EventHandler UserControlButtonClicked;

        private void OnUserControlButtonClick()
        {
            if (UserControlButtonClicked != null)
            {
                UserControlButtonClicked(this, EventArgs.Empty);
            }
        }

 

        //raise the relevant event in an appropriate method. Button_Click is just an example
        private void XoaThuoc_Click(object sender, RoutedEventArgs e)
        {
            OnUserControlButtonClick();
            ((Panel)this.Parent).Children.Remove(this);
        }

    }
}
