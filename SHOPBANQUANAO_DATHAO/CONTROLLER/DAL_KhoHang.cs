using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using DTO;
namespace CONTROLLER
{
   public class DAL_KhoHang
    {
        private static MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=shop_dathao;UID=root;PASSWORD=trung;port=3306;");
        public static void DAL_LapPhieuNhap(PhieuNhap pn, List<ChiTietPhieuNhap> ctpn)
        {
            String newid = null;
            try
            {
                conn.Open();
                MySqlCommand Command = null;
             
                    Command = new MySqlCommand("call KhoiTaoPhieuNhap('" + pn.Idnhan_vien + "','"
                  + pn.Ngay_lap + "','"
                  + pn.So_luong + "','"
                  + pn.Tong_tien + "',"
                  + pn.Hinh_thuc_nhap + ")", conn);
                MySqlDataReader myReader = Command.ExecuteReader();
                while (myReader.Read())
                {
                    newid = myReader.GetString("idphieu_nhap");
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {

            }
            finally
            {
                conn.Dispose();
            }
            try
            {
                conn.Open();
                if (newid != null)
                {
                    String query = "";
                    foreach (var item in ctpn)
                    {
                        query += "call KhoiTaoChiTietPhieuNhap('" + newid + "','"
                    + item.Idhang_hoa + "','"
                    + item.So_luong + "','"
                    + item.Thanh_tien + "');";

                    }
                    MySqlCommand Command = new MySqlCommand(query, conn);
                    Command.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (MySqlException ex)
            {

            }
            finally
            {
                conn.Dispose();
            }


        }
    }
}
