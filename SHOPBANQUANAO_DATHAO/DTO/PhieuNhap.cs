﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhap
    {
        private String tong_tien;
        private String ngay_lap;
        private String idnhan_vien;
        private String hinh_thuc_nhap;
        private String so_luong;

        public PhieuNhap(string tong_tien, string ngay_lap, string idnhan_vien, string hinh_thuc_nhap, string so_luong)
        {
            this.tong_tien = tong_tien;
            this.ngay_lap = ngay_lap;
            this.idnhan_vien = idnhan_vien;
            this.hinh_thuc_nhap = hinh_thuc_nhap;
            this.so_luong = so_luong;
        }

        public string Tong_tien { get => tong_tien; set => tong_tien = value; }
        public string Ngay_lap { get => ngay_lap; set => ngay_lap = value; }
        public string Idnhan_vien { get => idnhan_vien; set => idnhan_vien = value; }
        public string Hinh_thuc_nhap { get => hinh_thuc_nhap; set => hinh_thuc_nhap = value; }
        public string So_luong { get => so_luong; set => so_luong = value; }
    }
}
