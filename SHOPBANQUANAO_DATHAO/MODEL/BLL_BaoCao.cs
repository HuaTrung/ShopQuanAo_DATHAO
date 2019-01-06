using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CONTROLLER;
namespace MODEL
{
   public class BLL_BaoCao
    {
        public static DataTable BLL_BaoCaoDoanhThuTheoNgay(String m, String y)
        {
            return DAL_BaoCao.DAL_BaoCaoDoanhThuTheoNgay(m,y);
        }

        public static DataTable BLL_BaoCaoTonKho(String loai)
        {
            return DAL_BaoCao.DAL_BaoCaoTonKho(loai);
        }
    }
}
