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
        public static DataTable DAL_TimKiemThuoc(String text)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                String query = "call TimKiemHangHoa('" + text + "')"; ;
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
    }
}

