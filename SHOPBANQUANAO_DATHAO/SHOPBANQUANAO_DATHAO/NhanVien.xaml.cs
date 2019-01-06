using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using MODEL;

namespace SHOPBANQUANAO_DATHAO
{
    /// <summary>
    /// Interaction logic for NhanVien.xaml
    /// </summary>
    public partial class NhanVien : UserControl
    {
        DTO.NhanVien nv;
        public NhanVien()
        {
            InitializeComponent();
            dpicker.SelectedDate = DateTime.Now;
            labelnhanvien.Content = "NHÂN VIÊN";
            tbHour.Text = "0";
            btnDangXuat.IsEnabled = false;
            stackDn.Visibility = Visibility.Hidden;
        }

        public bool CheckErrorDangNhap(String ten_dang_nhap, String mat_khau)
        {
            return (
                    (Regex.IsMatch(ten_dang_nhap, "^[0-9]+$", RegexOptions.Compiled)
                    || ten_dang_nhap.Trim() == "") || mat_khau.Trim() == ""
                ) ? false : true;
        }

        public bool CheckErrorThemCong(String soGio)
        {
            return (
                   (Regex.IsMatch(soGio, "^[a-zA-Z]+$", RegexOptions.Compiled)
                   || soGio.Trim() == "" || Int32.Parse(soGio.Trim()) > 24)
               ) ? true : false;
        }

        private void btnDangXuat_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có muốn đăng xuất",
                                          "Confirmation",
                                          MessageBoxButton.YesNo,
                                          MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {

                tbTenDangNhap.IsEnabled = true;
                tbMatKhau.IsEnabled = true;
                btnDangNhap.IsEnabled = true;
                btnDangXuat.IsEnabled = false;
                labelnhanvien.Content = "NHÂN VIÊN";
                tbMatKhau.Password = tbTenDangNhap.Text = "";
                nv = null;
                tbHour.Text = "0";
                tbHour.IsEnabled = true;
                stackDn.Visibility = Visibility.Hidden;
                MessageBox.Show("Đăng xuất thành công", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            }
        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            if (CheckErrorDangNhap(tbTenDangNhap.Text, tbMatKhau.Password.ToString()))
            {
                nv = BLL_NhanVien.Instance.DangNhap(tbTenDangNhap.Text.Trim(), tbMatKhau.Password.ToString().Trim());
                if (nv == null)
                {
                    MessageBox.Show("Đăng nhập thất bại !!");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    btnDangXuat.IsEnabled = true;

                    tbTenDangNhap.IsEnabled = false;
                    tbMatKhau.IsEnabled = false;
                    btnDangNhap.IsEnabled = false;

                    tbTen.Content = nv.Ten_nhanvien;
                    tbNgaySinh.Content = nv.Ngay_sinh;
                    tbGioiTinh.Content = nv.Gioi_tinh;
                    tbTDNhap.Content = nv.Ten_dang_nhap;
                    tbMaChucVu.Content = nv.Ma_chuc_vu;
                    tbDiaChia.Content = nv.Dia_chia;
                    stackDn.Visibility = Visibility.Visible;
                    labelnhanvien.Content = nv.Ten_nhanvien.ToUpper();
                    // lay bảng chấm công theo tuần
                    DataTable data = BLL_NhanVien.Instance.LayBangChamCong(nv.Id_nhanvien, dpicker.Text);
                    if (data.Rows.Count == 0)
                    {
                        tbHour.IsEnabled = true;
                        tbHour.Text = "0";
                    }
                    else
                    {
                        tbHour.Text = data.Rows[0]["so_gio"].ToString();
                        tbHour.IsEnabled = false;
                    }

                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại Tên đăng nhập và Mật khẩu !!");
            }
        }

        private void dpicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (nv != null)
            {
                DataTable data = BLL_NhanVien.Instance.LayBangChamCong(nv.Id_nhanvien, dpicker.Text);
                if (data.Rows.Count == 0)
                {
                    tbHour.IsEnabled = true;
                    tbHour.Text = "0";
                }
                else
                {
                    tbHour.Text = data.Rows[0]["so_gio"].ToString();
                    tbHour.IsEnabled = false;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (nv != null)
            {
                if (CheckErrorThemCong(tbHour.Text))
                {
                    MessageBox.Show("Số giờ bị lỗi", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                }
                else
                {
                    DateTime dt1 = DateTime.Parse(dpicker.Text);
                    DateTime dt2 = DateTime.Now;
                    if (dt1 > dt2)
                    {
                        MessageBox.Show("Không được thêm công lớn hơn ngày hiện tại", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    }
                    else if(dt1 == dt2)
                    {
                        if (tbHour.IsEnabled == false)
                        {
                            MessageBox.Show("Công đã được thêm trước đó, liên hệ admin để chỉnh sửa", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                        }
                        else
                        {
                            int i = BLL_NhanVien.Instance.Themcong(nv.Id_nhanvien, dpicker.Text, Int32.Parse(tbHour.Text));
                            if (i == 1)
                            {
                                tbHour.IsEnabled = false;
                                MessageBox.Show("Thêm thành công", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                            }
                            else
                            {
                                MessageBox.Show("Thêm thất bại", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                            }
                        }
                    }
                    else // create request and send to admin eccept to change data
                    {
                        // we need iduser 
                        // query = "call procedure(parametter)"
                        int i = BLL_NhanVien.YeuCauThemCong(nv.Id_nhanvien, dpicker.Text, Int32.Parse(tbHour.Text));
                        if(i == 1)
                        {
                            MessageBox.Show("ĐÃ gửi yêu cầu thêm công trong quá khứ cho quản lý", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                        } 
                        else
                        {
                            MessageBox.Show("Gửi yêu cầu thêm công thất bại", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn phải đăng nhập để thêm công", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            }
        }

        // cập nhật mk:
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (nv != null)
            {
                MessageBoxResult result = MessageBox.Show("Bạn có muốn cập nhật mật khẩu mới ?",
                                        "Confirmation",
                                        MessageBoxButton.YesNo,
                                        MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    int i = BLL_QuanLy.CapNhatMatKhau(nv.Id_nhanvien, tbmk.Text);
                    if (i == 1)
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật mật khẩu thất bại", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    }
                }
            }
        }
    }
}
