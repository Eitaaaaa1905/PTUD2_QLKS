using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DatPhong
    {
        // khai báo lớp kết nối
        private Connection connection = new Connection();
        // khai báo command
        SqlCommand cmdDP;
        // khai báo chuỗi kết nối
        SqlConnection conn;
        // hàm lấy danh sách đặt phòng
        public DataTable layDSDP()
        {
            DataTable dt = new DataTable();
            dt = connection.LayBang("sp_DanhSachDatPhong");
            return dt;
        }
        // hàm lấy tình trạng
        public string layTinhTrang(string maphong, DateTime datphong, DateTime nhanphong, DateTime traphong)
        {
            string tinhtrang = null;
            try
            {
                using (conn = connection.LayKetNoi())
                {
                    conn.Open();
                    using (cmdDP = new SqlCommand("SP_ThayDoiTinhTrangPhong", conn))
                    {
                        cmdDP.CommandType = CommandType.StoredProcedure;
                        // gắn tham số
                        cmdDP.Parameters.Add("@maphong", SqlDbType.NVarChar).Value = maphong;
                        cmdDP.Parameters.Add("@ngaydatphong", SqlDbType.DateTime).Value = datphong;
                        cmdDP.Parameters.Add("@ngaynhanphong", SqlDbType.DateTime).Value = nhanphong;
                        cmdDP.Parameters.Add("@ngaytraphong", SqlDbType.DateTime).Value = traphong;
                        // Thêm tham số để nhận giá trị trả về từ thủ tục
                        SqlParameter returnValue = new SqlParameter();
                        returnValue.ParameterName = "@result"; // Tên tham số
                        returnValue.SqlDbType = SqlDbType.Int; // Kiểu dữ liệu
                        returnValue.Direction = ParameterDirection.ReturnValue; // Thiết lập là giá trị trả về
                        cmdDP.Parameters.Add(returnValue);
                        // Thực hiện lệnh
                        cmdDP.ExecuteNonQuery();
                        // Lấy giá trị trả về từ thủ tục
                        int result = (int)cmdDP.Parameters["@result"].Value;
                        if (result == 1)
                        {
                            tinhtrang = "Đã đặt phòng";
                        }
                        else if(result ==2)
                        {
                            tinhtrang = "Đang nhận phòng";
                        }
                        else
                        {
                            tinhtrang = "Trống";
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tinhtrang;
        }
    }
}
