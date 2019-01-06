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
    public class DAL_HoaDon
    {
        private static MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=shop_dathao;UID=root;PASSWORD=trung;port=3306;");
        public static DataTable DAL_TaiDanhSachHoaDon()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                MySqlCommand Command = new MySqlCommand("call LayDanhSachHoaDon()", conn);
                // Command.ExecuteNonQuery();
                MySqlDataAdapter SDA = new MySqlDataAdapter(Command);
                SDA.Fill(dt);
                conn.Close();
            }
            catch (MySqlException ex)
            {

            }
            finally
            {
                conn.Dispose();
            }
            return dt;
        }
        public static void DAL_LapHoaDon(HoaDon hd, List<ChiTietHoaDon> cthd)
        {
            String newid = null;
            try
            {
                conn.Open();
                MySqlCommand Command = null;
                if (hd.CmndKhachHang == null)
                {
                    Command = new MySqlCommand("call KhoiTaoHoaDon('null','"
                       + hd.Tong_tien + "','"
                       + hd.Ngay_lap + "','"
                       + hd.Idnhan_vien + "',"
                       + hd.Hinh_thuc_thanh_toan + ")", conn);

                }
                else
                {
                    Command = new MySqlCommand("call KhoiTaoHoaDon('" + hd.CmndKhachHang + "','"
                  + hd.Tong_tien + "','"
                  + hd.Ngay_lap + "','"
                  + hd.Idnhan_vien + "',"
                  + hd.Hinh_thuc_thanh_toan + ")", conn);

                }
                MySqlDataReader myReader = Command.ExecuteReader();
                while (myReader.Read())
                {
                    newid = myReader.GetString("idhoa_don");
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
                    foreach (var item in cthd)
                    {
                        query += "call KhoiTaoChiTietHoaDon('" + newid + "','"
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
