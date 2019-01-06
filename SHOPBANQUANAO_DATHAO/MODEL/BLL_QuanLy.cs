using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTROLLER;
using DTO;
namespace MODEL
{
    public class BLL_QuanLy
    {
        public static int DangNhap(String tdn, String mk)
        {
            DTO.NhanVien nv = new DTO.NhanVien(tdn, mk);
            return DAL_QuanLy.DangNhap(nv);
        }

        public static DataTable LoadNhanVien()
        {
            return DAL_QuanLy.LoadNhanVien();
        }

        public static DataTable SearchNhanVien(String ten,String tdn, String ngaysinh, String gioitinh, String diachi, String chucvu)
        {
            NhanVien nv = new NhanVien(null, ten, ngaysinh, gioitinh, diachi, chucvu, tdn);
            return DAL_QuanLy.SearchNhanVien(nv);
        }


        public static int CapNhatNhanVien(String id,String ten, String tdn, String ngaysinh, String gioitinh, String diachi)
        {
            NhanVien nv = new NhanVien(id, ten, ngaysinh, gioitinh, diachi, null, tdn);
            return DAL_QuanLy.CapNhatNhanVien(nv);
        }

        public static int XoaNhanVien(String id)
        {
            return DAL_QuanLy.XoaNhanVien(id);
        }

        public static int CapNhatCong(String id,int hour,String ngay)
        {
            return DAL_QuanLy.CapNhatCong(id,hour,ngay);
        }

        public static int CapNhatMatKhau(String id,String mk)
        {
            return DAL_QuanLy.CapNhatMatKhau(id, mk);
        }

        public static int ThemNhanVien(String ten, String ngaysinh, String gioitinh, String diachi,String chucvu, String mk, String tdn)
        {
            NhanVien nv = new NhanVien(null,ten,ngaysinh,gioitinh,diachi, chucvu,mk,tdn); 
            return DAL_QuanLy.ThemNhanVien(nv);
        }

        public static DataTable LoadYeuCau()
        {
            return DAL_QuanLy.LoadYeuCau();
        }

        public static int ThucHienYeuCau(String id)
        {
            return DAL_QuanLy.ThucHienYeuCau(id);
        }

        public static int XoaYeuCau(String id)
        {
            return DAL_QuanLy.XoaYeuCau(id);
        }

    }
}

// sửa sp: thủ kho
// vô tab kiểm kho
// => kiểm duyệt sp
// gửi request cho admin
