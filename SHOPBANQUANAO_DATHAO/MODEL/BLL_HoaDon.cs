using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTROLLER;
using System.Data;
using DTO;
namespace MODEL
{
    public class BLL_HoaDon
    {
        public static DataTable BLL_TaiDanhSachHoaDon()
        {
            return DAL_HoaDon.DAL_TaiDanhSachHoaDon();
        }

        public static void BLL_LapHoaDon(HoaDon hoadon,List<ChiTietHoaDon> cthd)
        {
            DAL_HoaDon.DAL_LapHoaDon(hoadon,cthd);
        }
    }
}
