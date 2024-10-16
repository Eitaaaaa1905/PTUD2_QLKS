using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DatPhong
    {
        //khai báo dal Đặt phòng
        DAL_DatPhong dal = new DAL_DatPhong();
        // hàm lấy danh sách đặt phòng
        public DataTable layDSDP()
        {
            return dal.layDSDP();
        }
        // hàm lấy tình trạng phòng
        public string layTinhTrangPhong(string maphong, DateTime ngaydatphong,DateTime ngaynhanphong,DateTime ngaytraphong)
        {
            return dal.layTinhTrang(maphong,ngaydatphong,ngaynhanphong,ngaytraphong);
        }
    }
}
