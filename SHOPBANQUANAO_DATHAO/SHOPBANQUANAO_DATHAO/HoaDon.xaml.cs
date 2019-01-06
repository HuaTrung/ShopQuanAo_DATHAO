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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace SHOPBANQUANAO_DATHAO
{
    /// <summary>
    /// Interaction logic for HoaDon.xaml
    /// </summary>
    public partial class HoaDon : UserControl
    {
        List<MatHang> ListHangHoa;
        bool choPhepThemhang;
        private KhachHang khachhang;
        private bool isDtl;
        public HoaDon()
        {
            InitializeComponent();
            TaiDanhSachHoaDon();
            hdThuNgan.Text= "Thu Ngân: Hứa Vĩ Trung";
            DanhSachHangHoa_HoaDon.DataContext = BLL_HangHoa.BLL_TaiDanhSachHangHoa();
            ListHangHoa = new List<MatHang>();
            MatHang mathang = new MatHang(ListHangHoa.Count + 1);
            mathang.UserControlButtonClicked += new
                               EventHandler(Button_Click);
            mathang.UserControlTextChanged += new
                         EventHandler(SLText_Changed);
            ListHangHoa.Add(mathang);
            hanghoadangmua.Children.Add(mathang);
            thong_tin_them1.Visibility = Visibility.Collapsed;
            thong_tin_them2.Visibility = Visibility.Collapsed;
            dtl.Visibility = Visibility.Collapsed;
            PanelCMND.Visibility = Visibility.Collapsed;
            khachhang = null;
            choPhepThemhang = false;
        }
        public void TaiDanhSachHoaDon()
        {
            DataTable dbDataSet = new System.Data.DataTable();
            dbDataSet = BLL_HoaDon.BLL_TaiDanhSachHoaDon();
            DanhSachHoaDon.DataContext = dbDataSet;

            foreach (string item in BLL_KhachHang.BLL_TaiCMNDDanhSachKhachHang())
                hdInputCMND.Items.Add(item.ToString());

        }

        private void themhoadon_Click(object sender, RoutedEventArgs e)
        {
            frmlaphoadon.IsOpen = true;
            DanhSachHangHoa_HoaDon.DataContext = BLL_HangHoa.BLL_TaiDanhSachHangHoa();
        }

        private void frmhoadon_timkiemhanghoa_textchanged(object sender, TextChangedEventArgs e)
        {
            DanhSachHangHoa_HoaDon.DataContext = BLL_HangHoa.BLL_TimKiemTenHangHoa(frmhoadon_timkiemhanghoa.Text);
        }

        private void ThemHang_Click(object sender, RoutedEventArgs e)
        {
            if (choPhepThemhang)
            {
                MatHang mathang = new MatHang(ListHangHoa.Count + 1);
                ListHangHoa.Add(mathang);
                hanghoadangmua.Children.Add(mathang);
                choPhepThemhang = false;
            }
          
        }

        private void DanhSachHangHoa_HoaDon_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataRowView row = (DataRowView)DanhSachHangHoa_HoaDon.SelectedItem;
            string tenhang = row[1].ToString();
            String id = row[0].ToString();
            string dongia = row[3].ToString();
            if (!choPhepThemhang) {
                if (ListHangHoa.Count > 0)
                {
                    ListHangHoa[ListHangHoa.Count - 1].id = id;
                    ListHangHoa[ListHangHoa.Count - 1].tenHang.Text = tenhang;
                    ListHangHoa[ListHangHoa.Count - 1].SoLuongHang.Text = "1";
                    ListHangHoa[ListHangHoa.Count - 1].DonGia.Text = dongia;
                    ListHangHoa[ListHangHoa.Count - 1].UserControlButtonClicked += new
                                       EventHandler(Button_Click);
                    ListHangHoa[ListHangHoa.Count - 1].UserControlTextChanged += new
                         EventHandler(SLText_Changed);
                    ListHangHoa[ListHangHoa.Count - 1].ThanhTien.Text = dongia;
                }
                else
                {
                    MatHang mathang = new MatHang(ListHangHoa.Count + 1);
                    mathang.id = id;
                    mathang.tenHang.Text = tenhang;
                    mathang.SoLuongHang.Text = "1";
                    mathang.DonGia.Text = dongia;
                    mathang.ThanhTien.Text = dongia;
                    mathang.UserControlButtonClicked += new
                                       EventHandler(Button_Click);
                    mathang.UserControlTextChanged+=new
                         EventHandler(SLText_Changed);
                    ListHangHoa.Add(mathang);
                    hanghoadangmua.Children.Add(mathang);
                }
                choPhepThemhang = true;
            }
            else
            {
                MatHang mathang = new MatHang(ListHangHoa.Count + 1);
                mathang.id = id;
                mathang.tenHang.Text = tenhang;
                mathang.SoLuongHang.Text = "1";
                mathang.DonGia.Text = dongia;
                mathang.ThanhTien.Text = dongia;
                mathang.UserControlButtonClicked += new
                                   EventHandler(Button_Click);
                mathang.UserControlTextChanged += new
                        EventHandler(SLText_Changed);
                ListHangHoa.Add(mathang);
                hanghoadangmua.Children.Add(mathang);
            }
            int tongtien = 0;
            foreach (var item in ListHangHoa)
            {
                tongtien += Convert.ToInt32(item.ThanhTien.Text);
            }
            tinhtong.Text = tongtien.ToString();
        }

        private void Button_Click(object sender,EventArgs e)
         {
            MatHang temp = (MatHang)sender;
            int stt = Convert.ToInt32(temp.STTHang.Text.Substring(0, temp.STTHang.Text.Length-1));
            ListHangHoa.RemoveAt(stt - 1);
            int tongtien = 0;
            int stttemp = 1;
            foreach (var item in ListHangHoa)
            {
                if (stttemp > 10)
                    item.STTHang.Text = stttemp + ".";
                else
                    item.STTHang.Text = "0" + stttemp + ".";
                stttemp++;
                tongtien += Convert.ToInt32(item.ThanhTien.Text);
            }
            tinhtong.Text = tongtien.ToString();
        }

        private void SLText_Changed(object sender, EventArgs e)
        {
            int tongtien = 0;
            foreach (var item in ListHangHoa)
            {
                tongtien += Convert.ToInt32(item.ThanhTien.Text);
            }
            tinhtong.Text = tongtien.ToString();
        }

        private void hdInputHoTen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (thong_tin_them1 != null && PanelCMND != null&& thong_tin_them2!=null)
            {
                if (hdInputHoTen.SelectedIndex == 1)
                {
                    thong_tin_them1.Visibility = Visibility.Visible;
                    thong_tin_them2.Visibility = Visibility.Visible;
                    PanelCMND.Visibility = Visibility.Visible;
                }
                else
                {
                    khachhang = null;
                    hdInputCMND.SelectedIndex = -1;
                    hdTen.Text = "Khách hàng: ";
                    hdSDT.Text = "SĐT: ";
                    hdGioiTinh.Text = "Giới tính: ";
                    thong_tin_them1.Visibility = Visibility.Collapsed;
                    thong_tin_them2.Visibility = Visibility.Collapsed;
                    dtl.Visibility = Visibility.Collapsed;
                    PanelCMND.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void hdInputCMND_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (thong_tin_them1 != null && PanelCMND != null && thong_tin_them2 != null && hdInputCMND.SelectedIndex!=-1)
            {
                khachhang = BLL_KhachHang.BLL_TimKhachHangTheoCMND(hdInputCMND.SelectedValue.ToString());
                hdTen.Text = "Khách hàng: " + khachhang.Ten;
                hdSDT.Text = "SĐT: "+khachhang.Sdt;
                hdGioiTinh.Text = "Giới tính: " + khachhang.Gioitinh;
                dtl.Visibility = Visibility.Visible;
            }
            else
            {
                dtl.Visibility = Visibility.Collapsed;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            int tongtien = 0;
            if (ListHangHoa.Count > 0)
            {
                if (isDtl)
                {
                    dtlText.Text = khachhang.Diem_tich_luy;
                    tongtien = 0;
                    foreach (var item in ListHangHoa)
                    {
                        try
                        {
                            tongtien += Convert.ToInt32(item.ThanhTien.Text);
                        }
                        catch (Exception ex)
                        {
                            return;
                        }
                    }
                    tinhtong.Text = tongtien.ToString();
                    tinhtong.Text = (Convert.ToInt32(tinhtong.Text.ToString()) - Convert.ToInt32(khachhang.Diem_tich_luy)*1000).ToString();
                }
                else
                {
                    dtlText.Text = "0";
                    tongtien = 0;
                    foreach (var item in ListHangHoa)
                    {
                        try
                        {
                            tongtien += Convert.ToInt32(item.ThanhTien.Text);
                        }
                        catch (Exception ex)
                        {
                            return;
                        }
                    }
                    tinhtong.Text = tongtien.ToString();
                }
            }
            tienthua.Text = (Convert.ToInt32(tienkhach.Text) - Convert.ToInt32(tinhtong.Text)).ToString();
        }

        private void xacNhanHoaDon_Click(object sender, RoutedEventArgs e)
        {
            List<ChiTietHoaDon> listCTHD = new List<ChiTietHoaDon>();
            foreach (var item in ListHangHoa)
            {
                ChiTietHoaDon temp = new ChiTietHoaDon(item.id, item.SoLuongHang.Text, item.ThanhTien.Text);
                listCTHD.Add(temp);
            }
            DTO.HoaDon hoadon = null;


            if (khachhang == null)
                hoadon = new DTO.HoaDon(null, tinhtong.Text, DateTime.Today.ToString("dd,MM,yyyy"), "1", hinhthucthanhtoan.SelectedIndex.ToString(), "0");
            else
            {
                String dtlkh = "";
                if(isDtl)
                {
                    dtlkh = khachhang.Diem_tich_luy;
                }
                else
                {
                    dtlkh = "0";
                }
                hoadon = new DTO.HoaDon(khachhang.Cmnd, tinhtong.Text, DateTime.Today.ToString("dd,MM,yyyy"), "1", hinhthucthanhtoan.SelectedIndex.ToString(), dtlkh);
            }

            BLL_HoaDon.BLL_LapHoaDon(hoadon, listCTHD);
            try
            {
                printHoaDon();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Không tìm thấy thiết bị in");
            }
        }
        private async Task printHoaDon()
        {
            System.Windows.Controls.PrintDialog printDlg = new System.Windows.Controls.PrintDialog();
            printDlg.PrintVisual(frmlaphoadon, "Hóa đơn");
        }
        private void huyHoaDon_Click(object sender, RoutedEventArgs e)
        {
            frmlaphoadon.IsOpen = false;
            ListHangHoa = new List<MatHang>();
            MatHang mathang = new MatHang(ListHangHoa.Count + 1);
            mathang.UserControlButtonClicked += new
                               EventHandler(Button_Click);
            ListHangHoa.Add(mathang);
            hanghoadangmua.Children.Clear();
            hanghoadangmua.Children.Add(mathang);
            thong_tin_them1.Visibility = Visibility.Collapsed;
            thong_tin_them2.Visibility = Visibility.Collapsed;
            PanelCMND.Visibility = Visibility.Collapsed;
            khachhang = null;
            choPhepThemhang = false;
            hdInputHoTen.SelectedIndex = 0;
            TaiDanhSachHoaDon();
        }

        private void dtl_Click(object sender, RoutedEventArgs e)
        {
            isDtl = !isDtl;
            if (isDtl)
                dtl.Content = "KHÔNG SỬ DỤNG ĐTL";
            else
                dtl.Content = "SỬ DỤNG ĐIỂM TÍCH LŨY";
            int tongtien = 0;
            if (ListHangHoa.Count > 0)
            {
                if (isDtl)
                {
                    dtlText.Text = khachhang.Diem_tich_luy;
                    tongtien = 0;
                    foreach (var item in ListHangHoa)
                    {
                        try
                        {
                            tongtien += Convert.ToInt32(item.ThanhTien.Text);
                        }
                        catch(Exception ex)
                        {
                            return;
                        }
                    }
                    tinhtong.Text = tongtien.ToString();
                    tinhtong.Text = (Convert.ToInt32(tinhtong.Text.ToString()) - Convert.ToInt32(khachhang.Diem_tich_luy)*1000).ToString();
                }
                else
                {
                    dtlText.Text = "0";
                    tongtien = 0;
                    foreach (var item in ListHangHoa)
                    {
                        try
                        {
                            tongtien += Convert.ToInt32(item.ThanhTien.Text);
                        }
                        catch (Exception ex)
                        {
                            return;
                        }
                    }
                    tinhtong.Text = tongtien.ToString();
                }
            }
        }
    }
}
