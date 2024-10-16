using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_KhachHang
    {
        private string maKH, tenKH, gioiTinh, cmnd, diaChi, soDT, ghiChu;
        private DateTime ngaySinh;
        public ET_KhachHang() { 
        }
        public ET_KhachHang(string maKH, string tenKH, string gioiTinh, string cmnd, string diaChi, string soDT, string ghiChu, DateTime ngaySinh)
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.GioiTinh = gioiTinh;
            this.Cmnd = cmnd;
            this.DiaChi = diaChi;
            this.SoDT = soDT;
            this.GhiChu = ghiChu;
            this.NgaySinh = ngaySinh;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
    }
}
