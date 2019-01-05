using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private String id;
        private String ten;
        private String sdt;
        private String gioitinh;
        private String diem_tich_luy;
        private String cmnd;
        public KhachHang(string id, string ten, string sdt, string gioitinh, string diem_tich_luy, string cmnd)
        {
            this.Id = id;
            this.Ten = ten;
            this.Sdt = sdt;
            this.Gioitinh = gioitinh;
            this.Diem_tich_luy = diem_tich_luy;
            this.Cmnd = cmnd;
        }

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diem_tich_luy { get => diem_tich_luy; set => diem_tich_luy = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
    }
}
