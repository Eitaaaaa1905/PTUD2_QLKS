using ET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Phong
    {
        // khai báo lớp kết nối
        private Connection connection = new Connection();
        // khai báo command
        SqlCommand cmdPhong;
        // khai báo chuỗi kết nối
        SqlConnection conn;
        // hàm lấy danh sách Phòng
        public DataTable LayDS()
        {
            DataTable dt = new DataTable();
            dt = connection.LayBang("sp_DSPhong");
            return dt;
        }
        // hàm thêm phòng
        public bool ThemPhong(ET_Phong p)
        {
            bool flag = false;
            try
            {
                if (check(p) == true)
                {
                    using (conn = connection.LayKetNoi())
                    {
                        conn.Open();
                        using (cmdPhong = new SqlCommand("sp_ThemPhong", conn))
                        {
                            cmdPhong.CommandType = CommandType.StoredProcedure;
                            // gắn tham số
                            cmdPhong.Parameters.Add("@maphong", SqlDbType.NVarChar).Value = p.MaPhong;
                            cmdPhong.Parameters.Add("@Sophong", SqlDbType.VarChar).Value = p.SoPhong;
                            cmdPhong.Parameters.Add("@kieuphong", SqlDbType.NVarChar).Value = p.KieuPhong;
                            cmdPhong.Parameters.Add("@loaiphong", SqlDbType.NVarChar).Value = p.LoaiPhong;
                            cmdPhong.Parameters.Add("@giaphong", SqlDbType.Int).Value = int.Parse(p.GiaPhong);
                            // Thêm tham số để nhận giá trị trả về từ thủ tục
                            SqlParameter returnValue = new SqlParameter();
                            returnValue.ParameterName = "@result"; // Tên tham số
                            returnValue.SqlDbType = SqlDbType.Int; // Kiểu dữ liệu
                            returnValue.Direction = ParameterDirection.ReturnValue; // Thiết lập là giá trị trả về
                            cmdPhong.Parameters.Add(returnValue);
                            // Thực hiện lệnh
                            cmdPhong.ExecuteNonQuery();
                            // Lấy giá trị trả về từ thủ tục
                            int result = (int)cmdPhong.Parameters["@result"].Value;

                            if (result == -1)
                            {
                                throw new Exception($"Mã {p.MaPhong} đã tồn tại, vui lòng nhập mã phòng khác!"); // trường hợp trùng mã phòng
                            }
                            else if (result == -2)
                            {
                                throw new Exception($"Phòng {p.SoPhong} đã tồn tại, vui lòng nhập phòng khác!"); // trường hợp trùng phòng

                            }
                            else 
                            {
                                flag = true; // thêm thành công
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return flag;
        }
        // hàm sửa phòng
        public bool SuaPhong(ET_Phong p)
        {
            bool flag = false;
            try
            {
                if (check(p) == true)
                {
                    using (conn = connection.LayKetNoi())
                    {
                        conn.Open();
                        using (cmdPhong = new SqlCommand("sp_SuaPhong", conn))
                        {
                            cmdPhong.CommandType = CommandType.StoredProcedure;
                            // gắn tham số
                            cmdPhong.Parameters.Add("@maphong", SqlDbType.NVarChar).Value = p.MaPhong;
                            cmdPhong.Parameters.Add("@Sophong", SqlDbType.VarChar).Value = p.SoPhong;
                            cmdPhong.Parameters.Add("@kieuphong", SqlDbType.NVarChar).Value = p.KieuPhong;
                            cmdPhong.Parameters.Add("@loaiphong", SqlDbType.NVarChar).Value = p.LoaiPhong;
                            cmdPhong.Parameters.Add("@giaphong", SqlDbType.Int).Value = int.Parse(p.GiaPhong);
                            // Thêm tham số để nhận giá trị trả về từ thủ tục
                            SqlParameter returnValue = new SqlParameter();
                            returnValue.ParameterName = "@result"; // Tên tham số
                            returnValue.SqlDbType = SqlDbType.Int; // Kiểu dữ liệu
                            returnValue.Direction = ParameterDirection.ReturnValue; // Thiết lập là giá trị trả về
                            cmdPhong.Parameters.Add(returnValue);
                            // Thực hiện lệnh
                            cmdPhong.ExecuteNonQuery();
                            // Lấy giá trị trả về từ thủ tục
                            int result = (int)cmdPhong.Parameters["@result"].Value;

                            if (result == -1)
                            {
                                throw new Exception($"Phòng {p.SoPhong} đã tồn tại, vui lòng nhập số phòng khác!"); // trường hợp trùng số phòng khi cập naht65
                            }
                            else
                            {
                                flag = true; // thêm thành công
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return flag;
        }
        // hàm xóa phòng
        public bool xoaPhong(string maphong)
        {
            bool flag = false;
            try
            {
                if (maphong == "")
                {
                    throw new Exception("Vui lòng chọn phòng để xóa!!");
                }
                using (conn = connection.LayKetNoi())
                {
                    conn.Open();
                    using (cmdPhong = new SqlCommand("sp_XoaPhong", conn))
                    {
                        cmdPhong.CommandType = CommandType.StoredProcedure;
                        // gắn tham số
                        cmdPhong.Parameters.Add("@maphong", SqlDbType.NVarChar).Value = maphong;
                        // Thực hiện lệnh
                        if (cmdPhong.ExecuteNonQuery() > 0)
                        {
                            flag = true;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return flag;
        }
        // hàm tìm kiếm phòng
        public DataTable TimKiemPhong(string sophong)
        {
            DataTable dt = null;
            SqlDataAdapter da;
            try
            {
                using (conn = connection.LayKetNoi())
                {
                    conn.Open();
                    dt = new DataTable();
                    using (cmdPhong = new SqlCommand("sp_TimPhong", conn))
                    {
                        cmdPhong.CommandType = CommandType.StoredProcedure;
                        // gắn tham số
                        cmdPhong.Parameters.Add("@sophong", SqlDbType.NVarChar).Value = sophong;
                        da = new SqlDataAdapter(cmdPhong);
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }
        bool check(ET_Phong p)
        {
            if (string.IsNullOrEmpty(p.MaPhong))
            {
                throw new Exception("Vui lòng nhập đầy đủ mã phòng!!");
            }
            if (string.IsNullOrEmpty(p.SoPhong))
            {
                throw new Exception("Vui lòng nhập đầy đủ số phòng!!");
            }
            if (string.IsNullOrEmpty(p.LoaiPhong))
            {
                throw new Exception("Vui lòng chọn loại phòng!!");
            }
            if (string.IsNullOrEmpty(p.KieuPhong))
            {
                throw new Exception("Vui lòng chọn Kiểu phòng!!");
            }
            if (string.IsNullOrEmpty(p.GiaPhong))
            {
                throw new Exception("Vui lòng nhập giá phòng!!");
            }
            if (!char.IsDigit(p.GiaPhong, p.GiaPhong.Length - 1))
            {
                throw new Exception("Vui lòng nhập ký tự số cho giá phòng!!");
            }
            if (!char.IsDigit(p.SoPhong, p.SoPhong.Length - 1))
            {
                throw new Exception("Vui lòng nhập ký tự số cho số phòng!!");
            }
            return true;
        }
        // hàm trả về danh sách phòng
        public string[] DanhSachPhong()
        {
            List<string> rooms = new List<string>(); // Danh sách lưu trữ kết quả
            try
            {
        
                using (conn = connection.LayKetNoi())
                {
                    conn.Open();
                    using (cmdPhong = new SqlCommand("sp_DanhSachPhong", conn))
                    {
                        cmdPhong.CommandType = CommandType.StoredProcedure;
               
                       using(SqlDataReader reader = cmdPhong.ExecuteReader())
                        {
                            // đọc dữ liệu từ SqlDataReader
                            while(reader.Read())
                            {
                                // lấy các trường về 1 chuỗi
                                string roomInfo = $"{reader["SoPhong"]},{reader["KieuPhong"]},{reader["LoaiPhong"]}";
                                rooms.Add(roomInfo); // Thêm vào danh sách
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return rooms.ToArray(); // Chuyển đổi danh sách thành mảng và trả về
        }
    }
}
