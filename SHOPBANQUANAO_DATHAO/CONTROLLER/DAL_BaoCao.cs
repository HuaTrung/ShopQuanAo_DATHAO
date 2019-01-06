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
     public class DAL_BaoCao
    {
        private static MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=shop_dathao;UID=root;PASSWORD=trung;port=3306;");
        public static DataTable DAL_BaoCaoDoanhThuTheoNgay(String m, String y)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                MySqlCommand Command = new MySqlCommand("call BaoCaoDoanhThuTheoNgay(" + m+","+y+")", conn);
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

        public static DataTable DAL_BaoCaoTonKho(String loai)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                MySqlCommand Command = new MySqlCommand("call BaoCaoTonKho("+loai+")", conn);
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
