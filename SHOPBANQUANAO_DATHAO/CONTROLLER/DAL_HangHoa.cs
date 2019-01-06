using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
namespace CONTROLLER
{
    public class DAL_HangHoa
    {// Khởi tạo các biến cần thiết để kết nối với database
        private static MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=shop_dathao;UID=root;PASSWORD=trung;port=3306;");
        public static DataTable DAL_TaiDanhSachHangHoa()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                MySqlCommand Command = new MySqlCommand("call LayDanhSachHangHoa()", conn);
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
        public static DataTable DAL_TimKiemTenHangHoa(String text)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                String query = "call TimKiemTenHangHoa('" + text + "')"; ;
                if (text.Length == 0)
                {
                    query = "call LayDanhSachHangHoa()";
                }
                MySqlCommand Command = new MySqlCommand(query, conn);
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

        public static DataTable DAL_TimKiemMaHangHoa(String text)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                String query = "call TimKiemMaHangHoa('" + text + "')"; ;
                if (text.Length == 0)
                {
                    query = "call LayDanhSachHangHoa()";
                }
                MySqlCommand Command = new MySqlCommand(query, conn);
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

        public static List<string> DAL_TaiLoaiHang()
        {
            List<string> list = new List<string>();
            try
            {
                conn.Open();
                MySqlCommand Command = new MySqlCommand("call LayDanhSachLoaiHang()", conn);
                MySqlDataReader myReader = Command.ExecuteReader();
                while (myReader.Read())
                {
                    list.Add(myReader.GetString("ten_loai_hang_hoa"));
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

        public static List<string> DAL_TaiNhaCungCap()
        {
            List<string> list = new List<string>();
            try
            {
                conn.Open();
                MySqlCommand Command = new MySqlCommand("call LayDanhSachNhaCungCap()", conn);
                MySqlDataReader myReader = Command.ExecuteReader();
                while (myReader.Read())
                {
                    list.Add(myReader.GetString("ten_nha_cung_cap"));
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

        public static void DAL_ThemNhaCungCap(String text)
        {
            try
            {
                conn.Open();
                MySqlCommand Command = new MySqlCommand("insert into nha_cung_cap (ten_nha_cung_cap) values ('" + text + "');", conn);
                MySqlDataReader myReader = Command.ExecuteReader();
                
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
        public static void DAL_ThemLoaiHangHoa(String text)
        {
            try
            {
                conn.Open();
                MySqlCommand Command = new MySqlCommand("insert into loai_hang_hoa (ten_loai_hang_hoa) values ('" + text + "');", conn);
                MySqlDataReader myReader = Command.ExecuteReader();

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
        public static void DAL_ThemHangHoa(DTO.HangHoa text)
        {
            try
            {
                conn.Open();
                MySqlCommand Command = new MySqlCommand("call ThemHangHoa('" 
                    + text.Ten_hang_hoa + 
                    "'," + text.Gia_tien +
                     ",'" + text.Size+
                      "','" + text.Loai_hang_hoa +
                       "','" + text.Nha_cung_cap +"');", conn);
                MySqlDataReader myReader = Command.ExecuteReader();

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

