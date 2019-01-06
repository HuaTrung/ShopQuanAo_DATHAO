using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace CONTROLLER
{
    public class DAL_QuanLy
    {
        public static int DangNhap(DTO.NhanVien nv)
        {
            String q = "SELECT count(*) FROM nhan_vien INNER JOIN bang_chuc_vu ON  bang_chuc_vu.chuc_vu = @ADMIN where ten_dang_nhap = @tdn and mat_khau = @mk";
            List<MySqlParameter> DanhSachParameters = new List<MySqlParameter>();
            DanhSachParameters.Add(new MySqlParameter("@ADMIN", "ADMIN"));
            DanhSachParameters.Add(new MySqlParameter("@tdn", nv.Ten_dang_nhap));
            DanhSachParameters.Add(new MySqlParameter("@mk", nv.Mat_khau));
            return DataTransfer.Instance.ExecuteScalar(q, DanhSachParameters.ToArray());
        }

        public static DataTable LoadNhanVien()
        {
            String q = 
                "select nhan_vien.id_nhanvien as id, ten_nhanvien as ten, ngay_sinh as ngaysinh, gioi_tinh as gioitinh, dia_chia as diachi, ten_dang_nhap as tendangnhap, bang_chuc_vu.chuc_vu as chucvu "
                + "from nhan_vien, bang_chuc_vu"
                + " where nhan_vien.ma_chuc_vu = bang_chuc_vu.idbang_chuc_vu and tinh_trang=0;";
            return DataTransfer.Instance.ExecuteQuerry(q);
        }

        public static DataTable SearchNhanVien(NhanVien nv)
        {

            String q =
                "select nhan_vien.id_nhanvien as id, ten_nhanvien as ten, ngay_sinh as ngaysinh, gioi_tinh as gioitinh, dia_chia as diachi, ten_dang_nhap as tendangnhap, bang_chuc_vu.chuc_vu as chucvu "+ 
                "from nhan_vien,bang_chuc_vu " + 
                "where bang_chuc_vu.chuc_vu like concat('%',@chucvu,'%') and " +
                "bang_chuc_vu.idbang_chuc_vu = nhan_vien.ma_chuc_vu and " +
                "ten_nhanvien like concat('%',@ten,'%') " +
                "and ngay_sinh like concat('%',@ngaysinh,'%') " +
                "and gioi_tinh like concat('%',@gioitinh,'%') " +
                "and dia_chia like concat('%',@diachi,'%') " +
                "and ten_dang_nhap like concat('%',@tendangnhap,'%') " +
                "and tinh_trang=0;";

            List<MySqlParameter> DanhSachParameters = new List<MySqlParameter>();
            DanhSachParameters.Add(new MySqlParameter("@chucvu", nv.Ma_chuc_vu));
            DanhSachParameters.Add(new MySqlParameter("@tendangnhap", nv.Ten_dang_nhap));
            DanhSachParameters.Add(new MySqlParameter("@ten", nv.Ten_nhanvien));
            DanhSachParameters.Add(new MySqlParameter("@ngaysinh", nv.Ngay_sinh));
            DanhSachParameters.Add(new MySqlParameter("@gioitinh", nv.Gioi_tinh));
            DanhSachParameters.Add(new MySqlParameter("@diachi", nv.Dia_chia));

            return DataTransfer.Instance.ExecuteQuerry(q, DanhSachParameters.ToArray());
        }

        public static int CapNhatNhanVien(NhanVien nv)
        {
            string qq = 
                "select idbang_chuc_vu " +
                "from bang_chuc_vu " +
                "where bang_chuc_vu.chuc_vu like @mcv";

            List<MySqlParameter> DanhSachParameters1 = new List<MySqlParameter>();
            DanhSachParameters1.Add(new MySqlParameter("@mcv", nv.Ma_chuc_vu));

            DataTable data = DataTransfer.Instance.ExecuteQuerry(qq, DanhSachParameters1.ToArray());

            if(data.Rows.Count == 1)
            {
                String macv = data.Rows[0][0].ToString();

                String q =
                    "update nhan_vien " +
                    "set ten_nhanvien=@ten, ma_chuc_vu = @cv, ngay_sinh = @ngaysinh, gioi_tinh=@gioitinh, dia_chia=@diachi, ten_dang_nhap=@tendangnhap " +
                    "where id_nhanvien=@id";

                List<MySqlParameter> DanhSachParameters = new List<MySqlParameter>();
                DanhSachParameters.Add(new MySqlParameter("@id", nv.Id_nhanvien));
                DanhSachParameters.Add(new MySqlParameter("@tendangnhap", nv.Ten_dang_nhap));
                DanhSachParameters.Add(new MySqlParameter("@ten", nv.Ten_nhanvien));
                DanhSachParameters.Add(new MySqlParameter("@ngaysinh", nv.Ngay_sinh));
                DanhSachParameters.Add(new MySqlParameter("@gioitinh", nv.Gioi_tinh));
                DanhSachParameters.Add(new MySqlParameter("@diachi", nv.Dia_chia));
                DanhSachParameters.Add(new MySqlParameter("@cv", macv));

                return DataTransfer.Instance.ExecuteNonQuerry(q, DanhSachParameters.ToArray());

            } else
            {
                return -1;
            }
        }

        public static int XoaNhanVien(String id)
        {

            String q =
                "update nhan_vien " +
                "set tinh_trang=1 " +
                "where id_nhanvien=@id";

            List<MySqlParameter> DanhSachParameters = new List<MySqlParameter>();
            DanhSachParameters.Add(new MySqlParameter("@id", id));

            return DataTransfer.Instance.ExecuteNonQuerry(q, DanhSachParameters.ToArray());
        }

        public static int CapNhatCong(String id,int hour, String ngay)
        {
            String q =
                    "update bang_cham_cong " +
                    "set so_gio=@gio " +
                    "where id_nhanvien=@id and ngay=@ngay";

            List<MySqlParameter> DanhSachParameters = new List<MySqlParameter>();
            DanhSachParameters.Add(new MySqlParameter("@id", id));
            DanhSachParameters.Add(new MySqlParameter("@gio", hour));
            DanhSachParameters.Add(new MySqlParameter("@ngay", ngay));
            return DataTransfer.Instance.ExecuteNonQuerry(q, DanhSachParameters.ToArray());
        }

        public static int CapNhatMatKhau(String id,String mk)
        {
            String q =
                    "update nhan_vien " +
                    "set mat_khau=@mk " +
                    "where id_nhanvien=@id";

            List<MySqlParameter> DanhSachParameters = new List<MySqlParameter>();
            DanhSachParameters.Add(new MySqlParameter("@id", id));
            DanhSachParameters.Add(new MySqlParameter("@mk", mk));
            return DataTransfer.Instance.ExecuteNonQuerry(q, DanhSachParameters.ToArray());
        }

        public static int ThemNhanVien(NhanVien nv)
        {
            String q = "call ThemNhanVien ('" + nv.Ten_nhanvien + "','" + nv.Ngay_sinh + "','" + nv.Gioi_tinh + "','" + nv.Dia_chia + "','" + nv.Ma_chuc_vu + "','" + nv.Mat_khau + "','" + nv.Ten_dang_nhap + "')";
            return DataTransfer.Instance.ExecuteNonQuerrypRO(q);
        }

        public static DataTable LoadYeuCau()
        {
            String q = "select id, id_nv, noi_dung_query, tinh_trang from yeu_cau where tinh_trang = 0";
            return DataTransfer.Instance.ExecuteQuerry(q);
        }

        public static int ThucHienYeuCau(String id)
        {
            String q = "call ThucHienYeuCau( '"+ id +"')";
            return DataTransfer.Instance.ExecuteNonQuerrypRO(q);
        }

        public static int XoaYeuCau(String id)
        {
            String q = "call XoaYeuCau( '" + id + "')";
            return DataTransfer.Instance.ExecuteNonQuerrypRO(q);
        }
    }
}
