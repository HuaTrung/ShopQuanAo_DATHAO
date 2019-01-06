using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private String cmndKhachHang;
        private String tong_tien;
        private String ngay_lap;
        private String idnhan_vien;
        private String hinh_thuc_thanh_toan;
        private String dtl;
        public HoaDon( string cmndKhachHang, string tong_tien, string ngay_lap, string idnhan_vien, string hinh_thuc_thanh_toan, String dtl)
        {
            this.cmndKhachHang = cmndKhachHang;
            this.tong_tien = tong_tien;
            this.ngay_lap = ngay_lap;
            this.idnhan_vien = idnhan_vien;
            this.hinh_thuc_thanh_toan = hinh_thuc_thanh_toan;
            this.dtl = dtl;
        }
        
        public string CmndKhachHang { get => cmndKhachHang; set => cmndKhachHang = value; }
        public string Tong_tien { get => tong_tien; set => tong_tien = value; }
        public string Ngay_lap { get => ngay_lap; set => ngay_lap = value; }
        public string Idnhan_vien { get => idnhan_vien; set => idnhan_vien = value; }
        public string Hinh_thuc_thanh_toan { get => hinh_thuc_thanh_toan; set => hinh_thuc_thanh_toan = value; }
        public String Dtl { get => dtl; set => dtl = value; }
    }
}
