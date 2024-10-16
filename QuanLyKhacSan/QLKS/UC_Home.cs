using BUS;
using ET;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLKS
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }
        // khai báo các dữ liệu các lớp
        private BUS_Phong bus = new BUS_Phong();
        private ET_Phong et;
        // khai báo dữ liệu cho kiểu phòng
        List<string> listKieuPhong = new List<string> { "Giường đơn", "Giường đôi" };
        // khai báo biến loai phong
        string loaiphong = "";
        private void UC_Home_Load(object sender, EventArgs e)
        {
            LoadRoomsButton();
            cmbKieuPhong.DataSource = listKieuPhong;
            cmbKieuPhong.SelectedIndex = -1;
        }
        // hàm lấy danh sách phòng
        public void LoadRoomsButton()
        {
            // Xóa tất cả các nút hiện có trong layoutPanel
            fLpnDSPhong.Controls.Clear();

            // Gọi phương thức DanhSachPhong để lấy danh sách phòng
            string[] rooms = bus.danhSachPhong();

            // Tạo nút cho mỗi phòng
            foreach (var room in rooms)
            {
                string[] roomDetails = room.Split(',');
                // Tạo đối tượng Guna.UI2.WinForms.Guna2Button
                if (roomDetails.Length == 3) // Kiểm tra có đủ thông tin
                {
                    // Tạo đối tượng Guna.UI2.WinForms.Guna2Button
                    Guna2Button roomButton = new Guna2Button
                    {
                        Text = $"Phòng: {roomDetails[0]}\nKiểu phòng: {roomDetails[1]}\nLoại phòng: {roomDetails[2]}", // Định dạng hiển thị
                        Size = new System.Drawing.Size(291, 177), // Kích thước nút
                        Font = new System.Drawing.Font("Segoe UI", 12,FontStyle.Bold), // Kiểu chữ
                        Margin = new Padding(10), // Kích thước lề (tuỳ chọn)
                        TextAlign = HorizontalAlignment.Left, // Căn chỉnh chữ
                    };
                    // Thêm nút vào layoutPanel
                    fLpnDSPhong.Controls.Add(roomButton);
                }
            }
        }
        // hàm lấy danh sách phòng theo kiểu phòng, loại phòng
        public void LoadRoomsButtonKieuPhong(string filterKieuPhong, string filterLoaiPhong)
        {
            // Xóa tất cả các nút hiện có trong layoutPanel
            fLpnDSPhong.Controls.Clear();

            // Gọi phương thức DanhSachPhong để lấy danh sách phòng
            string[] rooms = bus.danhSachPhong();

            // Tạo nút cho mỗi phòng
            foreach (var room in rooms)
            {
                string[] roomDetails = room.Split(',');

                // Kiểm tra có đủ thông tin
                if (roomDetails.Length == 3)
                {
                    // Kiểm tra điều kiện để quyết định nếu cần lọc
                    bool shouldDisplay = true; // Mặc định là hiển thị

                    // Kiểm tra lọc theo kiểu phòng
                    if (!string.IsNullOrEmpty(filterKieuPhong) && roomDetails[1].Trim() != filterKieuPhong.Trim())
                    {
                        shouldDisplay = false; // Không hiển thị nếu không khớp
                    }

                    // Kiểm tra lọc theo loại phòng
                    if (!string.IsNullOrEmpty(filterLoaiPhong) && roomDetails[2].Trim() != filterLoaiPhong.Trim())
                    {
                        shouldDisplay = false; // Không hiển thị nếu không khớp
                    }

                    // Nếu thông qua tất cả các điều kiện lọc, thêm nút
                    if (shouldDisplay)
                    {
                        // Tạo đối tượng Guna.UI2.WinForms.Guna2Button
                        Guna2Button roomButton = new Guna2Button
                        {
                            Text = $"Phòng: {roomDetails[0]}\nKiểu phòng: {roomDetails[1]}\nLoại phòng: {roomDetails[2]}", // Định dạng hiển thị
                            Size = new System.Drawing.Size(291, 177), // Kích thước nút
                            Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold), // Kiểu chữ
                            Margin = new Padding(10), // Kích thước lề (tuỳ chọn)
                            TextAlign = HorizontalAlignment.Left, // Căn chỉnh chữ
                        };
                        // Thêm nút vào layoutPanel
                        fLpnDSPhong.Controls.Add(roomButton);
                    }
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
     
        }
        private void cmbKieuPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rdoThuongGia.Checked == true)
            {
                loaiphong = "Thương gia";
            }
            else if(rdoTieuChuan.Checked == true)
            {
                loaiphong = "Tiêu chuẩn";
            }
            else if(rdoTrungBinh.Checked == true)
            {
                loaiphong = "Trung bình";
            }
            else
            {
                loaiphong = null;
            }
            LoadRoomsButtonKieuPhong(cmbKieuPhong.Text,loaiphong);

        }

        private void rdoThuongGia_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThuongGia.Checked == true)
            {
                loaiphong = "Thương gia";
            }
            else if (rdoTieuChuan.Checked == true)
            {
                loaiphong = "Tiêu chuẩn";
            }
            else if (rdoTrungBinh.Checked == true)
            {
                loaiphong = "Trung bình";
            }
            else
            {
                loaiphong = null;
            }
            LoadRoomsButtonKieuPhong(cmbKieuPhong.Text, loaiphong);
        }

        private void rdoTrungBinh_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThuongGia.Checked == true)
            {
                loaiphong = "Thương gia";
            }
            else if (rdoTieuChuan.Checked == true)
            {
                loaiphong = "Tiêu chuẩn";
            }
            else if (rdoTrungBinh.Checked == true)
            {
                loaiphong = "Trung bình";
            }
            else
            {
                loaiphong = null;
            }
            LoadRoomsButtonKieuPhong(cmbKieuPhong.Text, loaiphong);
        }

        private void rdoTieuChuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThuongGia.Checked == true)
            {
                loaiphong = "Thương gia";
            }
            else if (rdoTieuChuan.Checked == true)
            {
                loaiphong = "Tiêu chuẩn";
            }
            else if (rdoTrungBinh.Checked == true)
            {
                loaiphong = "Trung bình";
            }
            else
            {
                loaiphong = null;
            }
            LoadRoomsButtonKieuPhong(cmbKieuPhong.Text, loaiphong);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // làm mới các control xử lý
            rdoTieuChuan.Checked = false;
            rdoTrungBinh.Checked = false;
            rdoThuongGia.Checked = false;
            cmbKieuPhong.SelectedIndex = -1;
        }
    }
}
