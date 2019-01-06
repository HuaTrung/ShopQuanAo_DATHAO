using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class HangHoa
    {
        private String ten_hang_hoa;
        private String gia_tien;
        private String loai_hang_hoa;
        private String size;
        private String nha_cung_cap;

        public HangHoa(string ten_hang_hoa, string gia_tien, string loai_hang_hoa, string size, string nha_cung_cap)
        {
            this.ten_hang_hoa = ten_hang_hoa;
            this.gia_tien = gia_tien;
            this.loai_hang_hoa = loai_hang_hoa;
            this.size = size;
            this.nha_cung_cap = nha_cung_cap;
        }

        public string Ten_hang_hoa { get => ten_hang_hoa; set => ten_hang_hoa = value; }
        public string Gia_tien { get => gia_tien; set => gia_tien = value; }
        public string Loai_hang_hoa { get => loai_hang_hoa; set => loai_hang_hoa = value; }
        public string Size { get => size; set => size = value; }
        public string Nha_cung_cap { get => nha_cung_cap; set => nha_cung_cap = value; }
    }
}
