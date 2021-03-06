﻿using System;
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

namespace SHOPBANQUANAO_DATHAO
{
    /// <summary>
    /// Interaction logic for HangTrongKho.xaml
    /// </summary>
    public partial class HangTrongKho : UserControl
    {
        public int stt;
        public HangTrongKho()
        {
            InitializeComponent();
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
        private void XoaHang_Click(object sender, RoutedEventArgs e)
        {
            OnUserControlButtonClick();
            ((Panel)this.Parent).Children.Remove(this);
        }
        public event EventHandler UserControlTextChanged;

        private void UserControlTextChange()
        {
            if (UserControlTextChanged != null)
            {
                UserControlTextChanged(this, EventArgs.Empty);
            }
        }

        private void SoLuongHang_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                ThanhTien.Text = (Convert.ToInt32(SoLuongHang.Text) * Convert.ToInt32(DonGia.Text)).ToString();
            }
            catch (Exception ex)
            {
                ThanhTien.Text = "0";
            }
            UserControlTextChange();
           
        }
    }
}
