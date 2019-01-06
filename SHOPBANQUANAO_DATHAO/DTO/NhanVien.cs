using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        String id_nhanvien;
        String ten_nhanvien;
        String ngay_sinh;
        String gioi_tinh;
        String dia_chia;
        String ma_chuc_vu;
        String mat_khau;
        String ten_dang_nhap;

        public NhanVien(String ten_dang_nhap, String mat_khau)
        {
            Mat_khau = mat_khau;
            Ten_dang_nhap = ten_dang_nhap;
        }

        public NhanVien(String id_nhanvien, String ten_nhanvien, String ngay_sinh, String gioi_tinh, String dia_chia, String ma_chuc_vu, String mat_khau, String ten_dang_nhap)
        {
            this.id_nhanvien = id_nhanvien;
            this.ten_nhanvien = ten_nhanvien;
            this.ngay_sinh = ngay_sinh;
            this.gioi_tinh = gioi_tinh;
            this.dia_chia = dia_chia;
            this.ma_chuc_vu = ma_chuc_vu;
            this.mat_khau = mat_khau;
            this.ten_dang_nhap = ten_dang_nhap;
        }

         public NhanVien(String id_nhanvien, String ten_nhanvien, String ngay_sinh, String gioi_tinh, String dia_chia, String ma_chuc_vu, String ten_dang_nhap)
         {
            this.id_nhanvien = id_nhanvien;
            this.ten_nhanvien = ten_nhanvien;
            this.ngay_sinh = ngay_sinh;
            this.gioi_tinh = gioi_tinh;
            this.dia_chia = dia_chia;
            this.ma_chuc_vu = ma_chuc_vu;
            this.ten_dang_nhap = ten_dang_nhap;
         }

        public String Id_nhanvien { get => id_nhanvien; set => id_nhanvien = value; }
        public String Ten_nhanvien { get => ten_nhanvien; set => ten_nhanvien = value; }
        public String Ngay_sinh { get => ngay_sinh; set => ngay_sinh = value; }
        public String Gioi_tinh { get => gioi_tinh; set => gioi_tinh = value; }
        public String Dia_chia { get => dia_chia; set => dia_chia = value; }
        public String Ma_chuc_vu { get => ma_chuc_vu; set => ma_chuc_vu = value; }
        public String Mat_khau { get => mat_khau; set => mat_khau = value; }
        public String Ten_dang_nhap { get => ten_dang_nhap; set => ten_dang_nhap = value; }
    }
}
