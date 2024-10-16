using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Phong
    {
        private DAL_Phong dal = new DAL_Phong();
        // hàm lấy danh sách phòng
        public DataTable layDS1()
        {
            return dal.LayDS();
        }
        // hàm thêm phòng
        public bool themPhong(ET_Phong p)
        {
            return dal.ThemPhong(p);
        }
        // hàm sửa phòng
        public bool suaPhong(ET_Phong p)
        {
            return dal.SuaPhong(p);
        }
        // hàm xóa phòng
        public bool xoaPhong(string maphong)
        {
            return dal.xoaPhong(maphong);
        }
        // hàm tìm kiếm phòng
        public DataTable timPhong(string sophong)
        {
            return dal.TimKiemPhong(sophong);
        }
        // hàm lấy danh sách phòng
        public string[] danhSachPhong()
        {
            return dal.DanhSachPhong();
        }
    }
}
