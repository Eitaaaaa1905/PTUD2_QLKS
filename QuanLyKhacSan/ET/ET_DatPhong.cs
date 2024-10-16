using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_DatPhong
    {
        private string maDP, maPhong, maKH;
        private DateTime ngayDatPhong, ngayNhanPhong,ngayTraPhong;
        public ET_DatPhong()
        {

        }
        public ET_DatPhong(string maDP, string maPhong, string maKH, DateTime ngayDatPhong, DateTime ngayNhanPhong, DateTime ngayTraPhong)
        {
            this.maDP = maDP;
            this.maPhong = maPhong;
            this.maKH = maKH;
            this.ngayDatPhong = ngayDatPhong;
            this.ngayNhanPhong = ngayNhanPhong;
            this.ngayTraPhong = ngayTraPhong;
        }

        public string MaDP { get => maDP; set => maDP = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public DateTime NgayDatPhong { get => ngayDatPhong; set => ngayDatPhong = value; }
        public DateTime NgayNhanPhong { get => ngayNhanPhong; set => ngayNhanPhong = value; }
        public DateTime NgayTraPhong { get => ngayTraPhong; set => ngayTraPhong = value; }
    }
}
