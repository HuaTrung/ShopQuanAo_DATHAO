using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTROLLER;
using DTO;
using System.Data;
namespace MODEL
{
    public class BLL_KhachHang
    {
        public static List<string> BLL_TaiTenDanhSachKhachHang()
        {
            return DAL_KhachHang.DAL_TaiDanhSachTenKhachHang();
        }
        public static List<string> BLL_TaiCMNDDanhSachKhachHang()
        {
            return DAL_KhachHang.DAL_TaiDanhSachCMNDKhachHang();
        }
        public static DTO.KhachHang BLL_TimKhachHangTheoCMND(String cmnd)
        {
            return DAL_KhachHang.DAL_TimKhachHangTheoCMND(cmnd);

        }

    }
}
