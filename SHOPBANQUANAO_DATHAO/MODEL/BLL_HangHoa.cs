using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CONTROLLER;
namespace MODEL
{
    public class BLL_HangHoa
    {
        public static DataTable BLL_TaiDanhSachHangHoa()
        {
            return DAL_HangHoa.DAL_TaiDanhSachHangHoa();
        }
        public static DataTable BLL_TimKiemTenHangHoa(String text)
        {
            return DAL_HangHoa.DAL_TimKiemTenHangHoa(text);
        }
        public static DataTable BLL_TimKiemMaHangHoa(String text)
        {
            return DAL_HangHoa.DAL_TimKiemMaHangHoa(text);
        }
    }
}
