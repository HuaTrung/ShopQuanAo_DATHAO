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
 public class BLL_KhoHang
    {
        public static void BLL_LapPhieuNhap(PhieuNhap pn, List<ChiTietPhieuNhap> ctpn)
        {
            DAL_KhoHang.DAL_LapPhieuNhap(pn, ctpn);
        }
    }
}
