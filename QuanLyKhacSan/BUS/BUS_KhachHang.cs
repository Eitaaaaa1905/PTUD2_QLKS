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
    public class BUS_KhachHang
    {
        private DAL_KhachHang dal = new DAL_KhachHang();
        // hàm lấy danh sách khách hàng
        public DataTable layDS()
        {
            return dal.LayDS();
        }
        // hàm thêm khách hàng
        public bool ThemKH(ET_KhachHang kh)
        {
            return dal.ThemKH(kh);
        }
        // hàm sửa khách hàng
        public bool SuaKH(ET_KhachHang kh)
        {
            return dal.SuaKH(kh);
        }
        // hàm xóa khách hàng
        public bool XoaKH(ET_KhachHang kh)
        {
            return dal.XoaKH(kh);
        }
        // hàm tìm kiếm khách hàng
        public DataTable TimKH(string hoten)
        {
            return dal.TimKiemKH(hoten);
        }
    }
}
