using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace CONTROLLER
{
    public class DAL_NhanVien
    {
        private static MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=shop_dathao;UID=root;PASSWORD=trung;port=3306;");
        public static DataTable DangNhap(NhanVien nv)
        {
           // nv.Mat_khau = BCrypt.Net.BCrypt.HashPassword(nv.Mat_khau, 10);
            String query = "call DangNhap( '" + nv.Ten_dang_nhap +"', '" + nv.Mat_khau +"' )";
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
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

        public static DataTable LayBangChamCong(String id_nv, String date)
        {
            // nv.Mat_khau = BCrypt.Net.BCrypt.HashPassword(nv.Mat_khau, 10);
            String query = "call LayBangChamCong( '" + id_nv +"', '"+ date + "')";
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
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

        public static int ThemCong(String id_nv, String date, int soGio)
        {
            int data = 0;
            String query = "call ThemCong( '" + id_nv + "', '" + date + "','" + soGio + "')";
            try
            {
                conn.Open();
                MySqlCommand Command = new MySqlCommand(query, conn);
                // Command.ExecuteNonQuery();
                data = Command.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException ex)
            {

            }
            finally
            {
                conn.Dispose();
            }
            return data;
        }

        public static int YeuCauThemCong(String id,String ngay, int soGio)
        {
            String query = "call ThemCong('" + id +"','"+ ngay +"', '"+ soGio +"')";

            String q = "insert into yeu_cau(`id_nv`,`noi_dung_query`) values(@id,@q)";

            List<MySqlParameter> DanhSachParameters = new List<MySqlParameter>();
            DanhSachParameters.Add(new MySqlParameter("@id", id));
            DanhSachParameters.Add(new MySqlParameter("@q", query));
            DataTransfer.Instance.ExecuteNonQuerrypRO("call ThemThamSo('" + id + "')");
            return DataTransfer.Instance.ExecuteNonQuerry(q, DanhSachParameters.ToArray());
        }
    }
}
