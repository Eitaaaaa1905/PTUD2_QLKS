using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_Phong
    {
        private string maPhong, soPhong, loaiPhong, kieuPhong, giaPhong;
        public ET_Phong()
        {
        }
        public ET_Phong(string maPhong, string soPhong, string loaiPhong, string kieuPhong, string giaPhong)
        {
            this.MaPhong = maPhong;
            this.SoPhong = soPhong;
            this.LoaiPhong = loaiPhong;
            this.KieuPhong = kieuPhong;
            this.GiaPhong = giaPhong;
        }

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string SoPhong { get => soPhong; set => soPhong = value; }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public string KieuPhong { get => kieuPhong; set => kieuPhong = value; }
        public string GiaPhong { get => giaPhong; set => giaPhong = value; }
    }
}
