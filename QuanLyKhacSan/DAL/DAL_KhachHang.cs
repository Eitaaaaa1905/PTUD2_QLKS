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
    public class DAL_KhachHang
    {
        // khai báo lớp kết nối
        private Connection connection = new Connection();
        // khai báo command
        SqlCommand cmdKH;
        // khai báo chuỗi kết nối
        SqlConnection conn;
        // hàm lấy danh sách khách hàng
        public DataTable LayDS()
        {
            DataTable dt = new DataTable();
            dt = connection.LayBang("sp_DSKH");
            return dt;
        }
        // hàm thêm khách hàng
        public bool ThemKH(ET_KhachHang kh)
        {
            bool flag = false;
            try
            {
                if (check(kh) == true)
                {
                    using (conn = connection.LayKetNoi())
                    {
                        conn.Open();
                        using (cmdKH = new SqlCommand("sp_ThemKH", conn))
                        {
                            cmdKH.CommandType = CommandType.StoredProcedure;
                            // gắn tham số
                            cmdKH.Parameters.Add("@makh", SqlDbType.NVarChar).Value = kh.MaKH;
                            cmdKH.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = kh.TenKH;
                            cmdKH.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = kh.GioiTinh;
                            cmdKH.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = kh.NgaySinh;
                            cmdKH.Parameters.Add("@cccd", SqlDbType.NVarChar).Value = kh.Cmnd;
                            cmdKH.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = kh.DiaChi;
                            cmdKH.Parameters.Add("@sdt", SqlDbType.VarChar).Value = kh.SoDT;
                            cmdKH.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = kh.GhiChu;
                            // Thực hiện lệnh và kiểm tra giá trị trả về
                            int result = cmdKH.ExecuteNonQuery();
                            if (result == -1)
                            {
                                throw new Exception($"Mã {kh.MaKH} đã tồn tại, vui lòng nhập mã khách hàng khác!"); // trường hợp trùng mã khách hàng
                            }
                            else if (result == 1)
                            {
                                flag = true; // thêm thành công
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return flag;
        }   
        // hàm sửa khách hàng
        public bool SuaKH(ET_KhachHang kh)
        {
            bool flag = false;
            try
            {
                if (check(kh) == true)
                {
                    using (conn = connection.LayKetNoi())
                    {
                        conn.Open();
                        using (cmdKH = new SqlCommand("sp_SuaKH", conn))
                        {
                            cmdKH.CommandType = CommandType.StoredProcedure;
                            // gắn tham số
                            cmdKH.Parameters.Add("@makh", SqlDbType.NVarChar).Value = kh.MaKH;
                            cmdKH.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = kh.TenKH;
                            cmdKH.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = kh.GioiTinh;
                            cmdKH.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = kh.NgaySinh;
                            cmdKH.Parameters.Add("@cccd", SqlDbType.NVarChar).Value = kh.Cmnd;
                            cmdKH.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = kh.DiaChi;
                            cmdKH.Parameters.Add("@sdt", SqlDbType.VarChar).Value = kh.SoDT;
                            cmdKH.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = kh.GhiChu;
                            // Thực hiện lệnh
                            if(cmdKH.ExecuteNonQuery()> 0)
                            {
                                flag = true;
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
        // hàm xóa khách hàng
        public bool XoaKH(ET_KhachHang kh)
        {
            bool flag = false;
            try
            {
                if(kh.MaKH =="")
                {
                    throw new Exception("Vui lòng chọn khách hàng để xóa!!");
                }
                using (conn = connection.LayKetNoi())
                {
                    conn.Open();
                    using (cmdKH = new SqlCommand("sp_XoaKH", conn))
                    {
                        cmdKH.CommandType = CommandType.StoredProcedure;
                        // gắn tham số
                        cmdKH.Parameters.Add("@makh", SqlDbType.NVarChar).Value = kh.MaKH;
                        // Thực hiện lệnh
                        if (cmdKH.ExecuteNonQuery() > 0)
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
        // hàm tìm kiếm khách hàng
        public DataTable TimKiemKH(string hoten)
        {
           DataTable dt = null;
           SqlDataAdapter da;
            try
            {
                using (conn = connection.LayKetNoi())
                {
                    conn.Open();
                    dt = new DataTable();
                    using (cmdKH = new SqlCommand("sp_TimKH", conn))
                    {
                        cmdKH.CommandType = CommandType.StoredProcedure;
                        // gắn tham số
                        cmdKH.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoten;
                        da = new SqlDataAdapter(cmdKH);
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
        // hàm kiểm tra điều kiện các dữ liệu nhập
        bool check(ET_KhachHang kh)
        {
            if (string.IsNullOrEmpty(kh.MaKH))
            {
                throw new Exception("Vui lòng nhập đầy đủ mã khách hàng!!");
            }
            if (string.IsNullOrEmpty(kh.TenKH))
            {
                throw new Exception("Vui lòng nhập đầy đủ tên khách hàng!!");
            }
            if (string.IsNullOrEmpty(kh.DiaChi))
            {
                throw new Exception("Vui lòng nhập đầy đủ địa chỉ!!");
            }
            if (string.IsNullOrEmpty(kh.SoDT))
            {
                throw new Exception("Vui lòng nhập đầy đủ số điện thoại!!");
            }
            if (!char.IsDigit(kh.SoDT, kh.SoDT.Length - 1))
            {
                throw new Exception("Vui lòng nhập ký tự số cho trường số điện thoại!!");
            }
            if (!char.IsDigit(kh.Cmnd, kh.Cmnd.Length - 1))
            {
                throw new Exception("Vui lòng nhập ký tự số cho trường căn cước công dân!!");
            }
            if (kh.Cmnd.Length != 12)
            {
                throw new Exception("Vui lòng nhập căn cước đúng 12 ký tự!!");
            }
            if (kh.SoDT.Length != 10)
            {
                throw new Exception("Vui lòng nhập số điện thoại đúng 10 ký tự!!");
            }
            int year = DateTime.Now.Year - kh.NgaySinh.Year;
            if (year < 18)
            {
                throw new Exception("Khách hàng phải đủ 18 tuổi để đăng ký khách sạn!!");
            }
            return true;
        }
    }
}
