using BUS;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class UC_Quanlykhachhang : UserControl
    {
        public UC_Quanlykhachhang()
        {
            InitializeComponent();
        }
        // khai báo các dữ liệu các lớp
        private BUS_KhachHang bus = new BUS_KhachHang();
        private ET_KhachHang et;
        // khai báo biến gioi tinh tạm
        string gioitinh = "";
        private void UC_Quanlykhachhang_Load(object sender, EventArgs e)
        {
            //gọi hàm lấy danh sách khách hàng
            LayDSKH();
        }
        // hàm lấy danh sách khách hàng
        void LayDSKH()
        {
            try
            // khai báo DataTable để bỏ dữ liệu vào
            {
                DataTable dt = bus.layDS();
                // gắn dữ liệu từ DataTable vào danh sách khách hàng
                dtgv_DSKH.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
               // kiểm tra các nút radio giới tính và gắn cho biến giới tính tạm
                if (rdoNam.Checked== true)
                {
                    gioitinh = "Nam";
                }
                if (rdoNu.Checked== true)
                {
                    gioitinh = "Nữ";
                }
                et = new ET_KhachHang(txtMaKH.Text, txtHoTen.Text,gioitinh,txtCCCD.Text,txtDiaChi.Text,txtSDT.Text,txtGhiChu.Text,dtpkNgaySinh.Value);
                if(bus.ThemKH(et) == true)
                {
                    // Thông báo message
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo");
                    // cập nhật lại danh sách khách hàng
                    LayDSKH();
                    // clear các control
                    clearcontrol();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void dtgv_DSKH_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dtgv_DSKH.CurrentCell.RowIndex;
                txtMaKH.Text = dtgv_DSKH.Rows[dong].Cells[0].Value.ToString();
                txtHoTen.Text = dtgv_DSKH.Rows[dong].Cells[1].Value.ToString();
                txtCCCD.Text = dtgv_DSKH.Rows[dong].Cells[2].Value.ToString();
                txtSDT.Text = dtgv_DSKH.Rows[dong].Cells[3].Value.ToString();
                dtpkNgaySinh.Text = dtgv_DSKH.Rows[dong].Cells[4].Value.ToString();
                txtDiaChi.Text = dtgv_DSKH.Rows[dong].Cells[5].Value.ToString();
                if (dtgv_DSKH.Rows[dong].Cells[6].Value.ToString() == "Nam")
                {
                    rdoNam.Checked = true;
                }
                if (dtgv_DSKH.Rows[dong].Cells[6].Value.ToString() == "Nữ")
                {
                    rdoNu.Checked = true;
                }
                txtGhiChu.Text = dtgv_DSKH.Rows[dong].Cells[7].Value.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Không có thông tin!!");
            }
        }
        //hàm clear các control
        void clearcontrol()
        {
            txtCCCD.Clear();
            txtDiaChi.Clear();
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtGhiChu.Clear();
            dtpkNgaySinh.Value.ToShortDateString();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            txtMaKH.Focus();
        }
        // khai báo số lần nhấn nút Sửa
        int dem = 1;
        private void btnSua_Click(object sender, EventArgs e)
        {
           
            if(dem == 1)
            {
                // tắt nhập control MAKH
                txtMaKH.ReadOnly = true;
                dem += 1;
            }
            else if(dem == 2)
            {
                try
                {
                    // kiểm tra các nút radio giới tính và gắn cho biến giới tính tạm
                    if (rdoNam.Checked == true)
                    {
                        gioitinh = "Nam";
                    }
                    if (rdoNu.Checked == true)
                    {
                        gioitinh = "Nữ";
                    }
                    et = new ET_KhachHang(txtMaKH.Text, txtHoTen.Text, gioitinh, txtCCCD.Text, txtDiaChi.Text, txtSDT.Text, txtGhiChu.Text, dtpkNgaySinh.Value);
                    if (bus.SuaKH(et) == true)
                    {
                        // Thông báo message
                        MessageBox.Show("Sửa khách hàng thành công!", "Thông báo");
                        // cập nhật lại danh sách khách hàng
                        LayDSKH();
                        // clear các control
                        clearcontrol();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo");
                }
                // trả lại biến đếm về ban đầu
                txtMaKH.ReadOnly = false;
                dem = 1;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa khách hàng này hay không?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    // kiểm tra các nút radio giới tính và gắn cho biến giới tính tạm
                    if (rdoNam.Checked == true)
                    {
                        gioitinh = "Nam";
                    }
                    if (rdoNu.Checked == true)
                    {
                        gioitinh = "Nữ";
                    }
                    et = new ET_KhachHang(txtMaKH.Text, txtHoTen.Text, gioitinh, txtCCCD.Text, txtDiaChi.Text, txtSDT.Text, txtGhiChu.Text, dtpkNgaySinh.Value); 
                    if (bus.XoaKH(et) == true)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        LayDSKH();
                        clearcontrol();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo");
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = bus.TimKH(txtTimKiem.Text);
            // thực thi tìm danh sách
            dtgv_DSKH.DataSource = dt;
        }
    }
}
