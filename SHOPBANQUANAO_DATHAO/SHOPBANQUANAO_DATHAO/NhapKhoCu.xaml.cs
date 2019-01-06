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
    /// Interaction logic for NhapKhoCu.xaml
    /// </summary>
    public partial class NhapKhoCu : UserControl
    {
        List<HangTrongKho> ListHangHoa;
        bool choPhepThemhang;
        public NhapKhoCu()
        {
            InitializeComponent();
            nhNguoiNhap.Text = "Người Nhập: Hứa Vĩ Trung";
            DanhSachHangHoa.DataContext = BLL_HangHoa.BLL_TaiDanhSachHangHoa();
            nhNgayNhap.Text = DateTime.Today.ToString("dd-MM-yyyy");
            ListHangHoa = new List<HangTrongKho>();
            HangTrongKho mathang = new HangTrongKho();
            mathang.stt = 0;
            mathang.UserControlButtonClicked += new
                               EventHandler(Button_Click);
            mathang.UserControlTextChanged += new
                         EventHandler(SLText_Changed);
            ListHangHoa.Add(mathang);
            hangNhapKho.Children.Add(mathang);
            choPhepThemhang = false;
        }


        private void frmhoadon_timkiemhanghoa_textchanged(object sender, TextChangedEventArgs e)
        {
            DanhSachHangHoa.DataContext = BLL_HangHoa.BLL_TimKiemTenHangHoa(frmhoadon_timkiemhanghoa.Text);
        }

        private void ThemHang_Click(object sender, RoutedEventArgs e)
        {
            if (choPhepThemhang)
            {
                HangTrongKho mathang = new HangTrongKho();
                ListHangHoa.Add(mathang);
                hangNhapKho.Children.Add(mathang);
                choPhepThemhang = false;
            }

        }

        private void DanhSachHangHoa_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataRowView row = (DataRowView)DanhSachHangHoa.SelectedItem;
            string tenhang = row[1].ToString();
            String id = row[0].ToString();
            string dongia = row[3].ToString();
            if (!choPhepThemhang)
            {
                if (ListHangHoa.Count > 0)
                {
                    ListHangHoa[ListHangHoa.Count - 1].IDHang.Text = id;
                    ListHangHoa[ListHangHoa.Count - 1].stt = ListHangHoa.Count-1;
                    ListHangHoa[ListHangHoa.Count - 1].tenHang.Text = tenhang;
                    ListHangHoa[ListHangHoa.Count - 1].SoLuongHang.Text = "1";
                    ListHangHoa[ListHangHoa.Count - 1].DonGia.Text = dongia ;
                    ListHangHoa[ListHangHoa.Count - 1].ThanhTien.Text = dongia;
                }
                else
                {
                    HangTrongKho mathang = new HangTrongKho();
                    mathang.IDHang.Text = id;
                    mathang.stt = ListHangHoa.Count;
                    mathang.tenHang.Text = tenhang;
                    mathang.SoLuongHang.Text = "1";
                    mathang.DonGia.Text = dongia ;
                    mathang.ThanhTien.Text = dongia ;
                    mathang.UserControlButtonClicked += new
                                       EventHandler(Button_Click);
                    mathang.UserControlTextChanged += new
                            EventHandler(SLText_Changed);
                    ListHangHoa.Add(mathang);
                    hangNhapKho.Children.Add(mathang);
                }
                choPhepThemhang = true;
            }
            else
            {
                HangTrongKho mathang = new HangTrongKho();
                mathang.IDHang.Text = id;
                mathang.stt = ListHangHoa.Count;
                mathang.tenHang.Text = tenhang;
                mathang.SoLuongHang.Text = "1";
                mathang.DonGia.Text = dongia ;
                mathang.UserControlButtonClicked += new
                                   EventHandler(Button_Click);
                mathang.UserControlTextChanged += new
                        EventHandler(SLText_Changed);
                mathang.ThanhTien.Text = dongia ; 
                ListHangHoa.Add(mathang);
                hangNhapKho.Children.Add(mathang);
            }
            int tongtien = 0;
            int tongsoluong = 0;
            foreach (var item in ListHangHoa)
            {
                try
                {
                    tongsoluong += Convert.ToInt32(item.SoLuongHang.Text);
                }
                catch (Exception ex)
                {
                    tongsoluong += 0;
                }

                try
                {
                    tongtien += Convert.ToInt32(item.ThanhTien.Text);
                }
                catch (Exception ex)
                {
                    tongtien += 0;
                }

            }

            tongsoluonghang.Text = tongsoluong.ToString();
            tinhtong.Text = tongtien.ToString() ;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            HangTrongKho temp = (HangTrongKho)sender;
            int stt = temp.stt;
            ListHangHoa.RemoveAt(stt);
            int stttemp = 0;
            int tongtien = 0;
            int tongsoluong=0;
            foreach (var item in ListHangHoa)
            {
                item.stt = stttemp;
                String a = item.tenHang.Text;
                stttemp++;
                tongtien += Convert.ToInt32(item.ThanhTien.Text);
                try
                {
                    tongsoluong += Convert.ToInt32(item.SoLuongHang.Text);
                }
                catch (Exception ex)
                {
                    tongsoluong += 0;
                }
            }
            tinhtong.Text = tongtien.ToString() ;

        }

        private void SLText_Changed(object sender, EventArgs e)
        {
            int tongtien = 0;
            int tongsoluong = 0;
            foreach (var item in ListHangHoa)
            {
                try
                {
                    tongsoluong += Convert.ToInt32(item.SoLuongHang.Text);
                }
                catch (Exception ex)
                {
                    tongsoluong += 0;
                }
               
                try
                {
                    tongtien += Convert.ToInt32(item.ThanhTien.Text);
                }
                catch (Exception ex)
                {
                    tongtien += 0;
                }
                
            }

            tongsoluonghang.Text = tongsoluong.ToString() ;
            tinhtong.Text = tongtien.ToString() ;
        }

        private void xacNhanHoaDon_Click(object sender, RoutedEventArgs e)
        {
            List<ChiTietPhieuNhap> listCTPN = new List<ChiTietPhieuNhap>();
            foreach (var item in ListHangHoa)
            {
                ChiTietPhieuNhap temp = new ChiTietPhieuNhap(item.IDHang.Text, item.SoLuongHang.Text, item.ThanhTien.Text);
                listCTPN.Add(temp);
            }
            DTO.PhieuNhap pn =new PhieuNhap(tinhtong.Text, DateTime.Today.ToString("dd,MM,yyyy"),"1", "0", tongsoluonghang.Text);
            BLL_KhoHang.BLL_LapPhieuNhap(pn, listCTPN);
        }

        private void huyHoaDon_Click(object sender, RoutedEventArgs e)
        {
            nhNguoiNhap.Text = "Người Nhập: Hứa Vĩ Trung";
            DanhSachHangHoa.DataContext = BLL_HangHoa.BLL_TaiDanhSachHangHoa();
            ListHangHoa = new List<HangTrongKho>();
            HangTrongKho mathang = new HangTrongKho();
            mathang.stt = 0;
            mathang.UserControlButtonClicked += new
                               EventHandler(Button_Click);
            mathang.UserControlTextChanged += new
                         EventHandler(SLText_Changed);
            ListHangHoa.Add(mathang);
            hangNhapKho.Children.Clear();
            hangNhapKho.Children.Add(mathang);
            choPhepThemhang = false;
        }
    }
}
