using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhap
    {
        private String idhang_hoa;
        private String so_luong;
        private String thanh_tien;

        public ChiTietPhieuNhap(string idhang_hoa, string so_luong, string thanh_tien)
        {
            this.idhang_hoa = idhang_hoa;
            this.so_luong = so_luong;
            this.thanh_tien = thanh_tien;
        }

        public string Idhang_hoa { get => idhang_hoa; set => idhang_hoa = value; }
        public string So_luong { get => so_luong; set => so_luong = value; }
        public string Thanh_tien { get => thanh_tien; set => thanh_tien = value; }
    }
}
