using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using CONTROLLER;
using System.Data;

namespace MODEL
{
    public class BLL_NhanVien
    {
        private static BLL_NhanVien _instance;

        public static BLL_NhanVien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BLL_NhanVien();
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }

        public NhanVien DangNhap(String ten_dang_nhap, String mat_khau)
        {
            NhanVien nv = new NhanVien(ten_dang_nhap, mat_khau);
            DataTable data = DAL_NhanVien.DangNhap(nv);       
            if(data.Rows.Count == 1)
            {
                NhanVien nev = new NhanVien(
                    data.Rows[0]["id_nhanvien"].ToString(),
                    data.Rows[0]["ten_nhanvien"].ToString(), 
                    data.Rows[0]["ngay_sinh"].ToString(), 
                    data.Rows[0]["gioi_tinh"].ToString(), 
                    data.Rows[0]["dia_chia"].ToString(), 
                    data.Rows[0]["ma_chuc_vu"].ToString(), 
                    data.Rows[0]["ten_dang_nhap"].ToString());
                return nev;
            }
            return null;
        }

        public DataTable LayBangChamCong(String id,String date)
        {
            return DAL_NhanVien.LayBangChamCong(id, date);
        }

        public int Themcong(String id,String date,int soGio)
        {
            return DAL_NhanVien.ThemCong(id, date, soGio);
        }
    }
}
