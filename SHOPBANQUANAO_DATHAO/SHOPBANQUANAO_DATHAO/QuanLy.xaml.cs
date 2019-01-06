using MODEL;
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

namespace SHOPBANQUANAO_DATHAO
{
    /// <summary>
    /// Interaction logic for QuanLy.xaml
    /// </summary>
    public partial class QuanLy : UserControl
    {
        String gioitinh = "";
        String chucvu = "";
        String idUpdate = "";
        public QuanLy()
        {
            InitializeComponent();
            ckbNgaySinh.IsChecked = false;
            dpNgaySinh.SelectedDate = DateTime.Now;
            loadNhanVien();
//            dpuNgaySinh.SelectedDate = DateTime.Now;
            gNa.Checked += btngGenderCheck;
            gNo.Checked += btngGenderCheck;
            gNu.Checked += btngGenderCheck;
            rAd.Checked += btngGenderCheck;
            rTk.Checked += btngGenderCheck;
            rNo.Checked += btngGenderCheck;
            rNvbh.Checked += btngGenderCheck;
            dpNgaySinh.SelectedDateChanged += dpNgaySinh_SelectedDateChanged;

            btncapnhat.IsEnabled = false;
            btnxoa.IsEnabled = false;
            stkhl.IsEnabled = stknc.IsEnabled = stktdn.IsEnabled = false;

        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ckbNgaySinh.IsChecked == true)
                dgNhanvien.DataContext = BLL_QuanLy.SearchNhanVien(tbTenNv.Text, tbTenDN.Text, dpNgaySinh.Text, "", tbDiaChi.Text, "");
            else
                dgNhanvien.DataContext = BLL_QuanLy.SearchNhanVien(tbTenNv.Text, tbTenDN.Text, "", "", tbDiaChi.Text, "");
        }

        private void btngGenderCheck(object sender, RoutedEventArgs e)
        {
            string tag = (sender as RadioButton).Name as string;
            switch (tag)
            {
                case "gNo":
                    {
                        gioitinh = "";
                    }
                    break;
                case "gNa":
                    {
                        gioitinh = "NAM";
                    }
                    break;
                case "gNu":
                    {
                        gioitinh = "NU";
                    }
                    break;
                case "rNo":
                    {
                        chucvu = "";
                    }
                    break;
                case "rNvbh":
                    {
                        chucvu = "NHÂN VIÊN BÁN HÀNG";
                    }
                    break;
                case "rTk":
                    {
                        chucvu = "THỦ KHO";
                    }
                    break;
                case "rAd":
                    {
                        chucvu = "QUẢN LÍ";
                    }
                    break;
            }
            if (tag != "")
            {
                if (ckbNgaySinh.IsChecked == true)
                    dgNhanvien.DataContext = BLL_QuanLy.SearchNhanVien(tbTenNv.Text, tbTenDN.Text, dpNgaySinh.Text, gioitinh, tbDiaChi.Text, chucvu);
                else
                    dgNhanvien.DataContext = BLL_QuanLy.SearchNhanVien(tbTenNv.Text, tbTenDN.Text, "", gioitinh, tbDiaChi.Text, chucvu);
            }
        }

        bool CheckErrorCapnhatNhanVien()
        {
            return false;
        }


        void loadNhanVien()
        {
            DataTable data = BLL_QuanLy.LoadNhanVien();
            dgNhanvien.DataContext = data;
        }

        private void dpNgaySinh_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ckbNgaySinh.IsChecked == true)
                dgNhanvien.DataContext = BLL_QuanLy.SearchNhanVien(tbTenNv.Text, tbTenDN.Text, dpNgaySinh.Text, "", tbDiaChi.Text, "");
            else
                dgNhanvien.DataContext = BLL_QuanLy.SearchNhanVien(tbTenNv.Text, tbTenDN.Text, "", "", tbDiaChi.Text, "");
        }

        private void btnCapNhatNhanVien(object sender, RoutedEventArgs e)
        {
            if(!CheckErrorCapnhatNhanVien())
            {
                MessageBoxResult result = MessageBox.Show("Bạn có muốn cập nhật nhân viên ?",
                                         "Confirmation",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);

                if(result == MessageBoxResult.Yes)
                {
                    int i = BLL_QuanLy.CapNhatNhanVien(idUpdate, tbuTenNv.Text.Trim(), tbuTenDN.Text.Trim(), dpuNgaySinh.Text, rbNam.IsChecked == true ? "NAM" : "NỮ", tbuDiaChi.Text.Trim());
                    if (i == 1)
                    {
                        loadNhanVien();
                        MessageBox.Show("Cập nhật thành công", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                        tbuDiaChi.Text = tbuTenNv.Text = tbuTenDN.Text = "";
                        btncapnhat.IsEnabled = false;
                        btnxoa.IsEnabled = false;
                        stkhl.IsEnabled = stknc.IsEnabled = stktdn.IsEnabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    }
                }
            } else
            {
                MessageBox.Show("Coi lại thông tin nhân viên trước khi cập nhật", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            }
        }

        private void btnXoaNhanvien(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có muốn xóa nhân viên ?",
                                        "Confirmation",
                                        MessageBoxButton.YesNo,
                                        MessageBoxImage.Question);
            if(result == MessageBoxResult.Yes)
            {
                int i = BLL_QuanLy.XoaNhanVien(idUpdate);
                if(i == 1)
                {
                    loadNhanVien();
                    MessageBox.Show("Xóa thành công", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    tbuDiaChi.Text = tbuTenNv.Text = tbuTenDN.Text = "";
                    idUpdate = "";
                    btncapnhat.IsEnabled = false;
                    btnxoa.IsEnabled = false;
                    stkhl.IsEnabled = stknc.IsEnabled = stktdn.IsEnabled = false;
                } else
                {
                    MessageBox.Show("Xóa thất bại", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                }
            }
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataRowView row = (DataRowView)dgNhanvien.SelectedItems[0];
            idUpdate = row["id"].ToString();
            tbuTenNv.Text = row["ten"].ToString();
            if(row["gioitinh"].ToString().ToLower() == "nam")
                rbNam.IsChecked = true;
            else
                rbNu.IsChecked = true;
            dpuNgaySinh.Text = row["ngaysinh"].ToString();
            if (row["chucvu"].ToString() == "NHÂN VIÊN BÁN HÀNG")
                rbnvbh.IsChecked = true;
            else if(row["chucvu"].ToString() == "QUẢN LÍ")
                rbad.IsChecked = true;
            else
                rbtk.IsChecked = true;
            tbuDiaChi.Text = row["diachi"].ToString();
            tbuTenDN.Text = row["tendangnhap"].ToString();
            dupicker.SelectedDate = DateTime.Now;
            stkhl.IsEnabled = stknc.IsEnabled = stktdn.IsEnabled = true;
            btncapnhat.IsEnabled = true;
            btnxoa.IsEnabled = true;

        }

        // cập nhật công
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           int i = BLL_QuanLy.CapNhatCong(idUpdate, Int32.Parse(tbuHour.Text), dupicker.Text);
            if (i == 1)
            {
                MessageBox.Show("Cập nhật công thành công", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            }
            else
            {
                MessageBox.Show("Cập nhật công thất bại", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            }
        }

        // select date change:
        private void dupicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if(idUpdate != "")
            {
                DataTable data = BLL_NhanVien.Instance.LayBangChamCong(idUpdate, dupicker.Text);
                if (data.Rows.Count == 0)
                {
                    tbuHour.Text = "0";
                }
                else
                {
                    tbuHour.Text = data.Rows[0]["so_gio"].ToString();
                    MessageBox.Show("Lấy công thành công", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                }
            }
        }
        // Cập nhật mật khẩu mới
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (idUpdate != "")
            {
                MessageBoxResult result = MessageBox.Show("Bạn có muốn cập nhật mật khẩu mới ?",
                                        "Confirmation",
                                        MessageBoxButton.YesNo,
                                        MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    int i = BLL_QuanLy.CapNhatMatKhau(idUpdate, tbumk.Text);
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
