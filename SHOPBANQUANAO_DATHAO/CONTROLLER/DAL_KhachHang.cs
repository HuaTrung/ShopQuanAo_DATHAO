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
    public class DAL_KhachHang
    {
        private static MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=shop_dathao;UID=root;PASSWORD=trung;port=3306;");
        public static List<string> DAL_TaiDanhSachTenKhachHang()
        {
            List<string> list = new List<string>();
            try
            {
                conn.Open();
                MySqlCommand Command = new MySqlCommand("call LayDanhSachKhacHang()", conn);
                MySqlDataReader myReader = Command.ExecuteReader();
                while (myReader.Read())
                {
                    list.Add(myReader.GetString("ten_khach_hang"));
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
            return list;
        }
        public static List<string> DAL_TaiDanhSachCMNDKhachHang()
        {
            List<string> list = new List<string>();
            try
            {
                conn.Open();
                MySqlCommand Command = new MySqlCommand("call LayDanhSachKhacHang()", conn);
                MySqlDataReader myReader = Command.ExecuteReader();
                while (myReader.Read())
                {
                    list.Add(myReader.GetString("cmnd"));
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
            return list;
        }

        public static DTO.KhachHang DAL_TimKhachHangTheoCMND(String cmnd)
        {
            DTO.KhachHang khachhang = null;
            try
            {
                conn.Open();
                MySqlCommand Command = new MySqlCommand("call LayKhachHangTheoCMND('" + cmnd + "')", conn);
                MySqlDataReader myReader = Command.ExecuteReader();
                while (myReader.Read())
                {
                    khachhang = new KhachHang(myReader.GetString("idkhach_hang"), myReader.GetString("ten_khach_hang"),
                        myReader.GetString("sdt"), myReader.GetString("gioi_tinh"), myReader.GetString("diem_tich_luy")
                        , myReader.GetString("cmnd"));
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
            return khachhang;
        }
    }
}
