using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
namespace WpfApplication
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow(int value)
        {
            InitializeComponent();
            if (value == 1)
            {
                menutabcontrol.RemoveFromSource(kiem_kho);
                menutabcontrol.RemoveFromSource(thiet_lap);
                menutabcontrol.RemoveFromSource(quan_li);
            }
            if (value == 2)
            {
                menutabcontrol.RemoveFromSource(hoa_don);
                menutabcontrol.RemoveFromSource(thiet_lap);
                menutabcontrol.RemoveFromSource(quan_li);
            }
            if (value == 3)
            {
                menutabcontrol.RemoveFromSource(nhan_vien);
            }
        }

        private void menutabcontrol_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (dang_xuat.IsSelected)
            {
                System.Environment.Exit(1);
            }
        }
    }
}