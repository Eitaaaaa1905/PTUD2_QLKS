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
using TheArtOfDevHtmlRenderer.Adapters;

namespace QLKS
{
    public partial class UC_Quanlyphong : UserControl
    {
        public UC_Quanlyphong()
        {
            InitializeComponent();
        }
        // khai báo các item loại phòng và kiểu phòng
        List<string> listKieuPhong = new List<string> { "Giường đơn", "Giường đôi" };
        List<string> listLoaiPhong = new List<string> { "Tiêu chuẩn", "Trung bình", "Thương gia" };
        // khai báo các dữ liệu các lớp
        private BUS_Phong bus = new BUS_Phong();
        private ET_Phong et;
        private void btnBaoTri_Click(object sender, EventArgs e)
        {
            GUI_OverlayForm overlay = new GUI_OverlayForm();
            overlay.Show(); // Hiển thị overlay

            GUI_BaoTri frm = new GUI_BaoTri();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(); // Hiển thị Form chính
            overlay.Close();
        }
        // hàm lấy danh sách phòng
        void LayDSPhong()
        {
            try
            // khai báo DataTable để bỏ dữ liệu vào
            {
                DataTable dt = bus.layDS();
                // gắn dữ liệu từ DataTable vào danh sách khách hàng
                dtgvDSPhong.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            GUI_OverlayForm overlay = new GUI_OverlayForm();
            overlay.Show(); // Hiển thị overlay

            GUI_ChiTietPhong frm = new GUI_ChiTietPhong();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(); // Hiển thị Form chính

            overlay.Close();
        }

        private void UC_Quanlyphong_Load(object sender, EventArgs e)
        {
            // gán vào các combobox
            cmbKieuPhong.DataSource = listKieuPhong;
            cmbLoaiPhong.DataSource = listLoaiPhong;
            LayDSPhong();
        }
        //hàm lấy giá tiền theo kiểu phòng, loại phòng
        string giatien()
        {
            string giatien = "";
            // giá tiền khi loại phòng tiêu chuẩn, phòng đơn.
            if (cmbLoaiPhong.SelectedIndex == 0 && cmbKieuPhong.SelectedIndex == 0)
            {
                // gán giá trị
                giatien = "490000";
            }
            // giá tiền khi loại phòng tiêu chuẩn, phòng đôi.
            if (cmbLoaiPhong.SelectedIndex == 0 && cmbKieuPhong.SelectedIndex == 1)
            {
                // gán giá trị
                giatien = "590000";
            }
            // giá tiền khi loại phòng trung bình, phòng đơn.
            if (cmbLoaiPhong.SelectedIndex == 1 && cmbKieuPhong.SelectedIndex == 0)
            {
                // gán giá trị
                giatien = "650000";
            }
            // giá tiền khi loại phòng trung bình, phòng đôi.
            if (cmbLoaiPhong.SelectedIndex == 1 && cmbKieuPhong.SelectedIndex == 1)
            {
                // gán giá trị
                giatien = "800000";
            }
            // giá tiền khi loại phòng thương gia, phòng đơn.
            if (cmbLoaiPhong.SelectedIndex == 2 && cmbKieuPhong.SelectedIndex == 0)
            {
                // gán giá trị
                giatien = "1000000";
            }
            // giá tiền khi loại phòng thương gia, phòng đôi.
            if (cmbLoaiPhong.SelectedIndex == 2 && cmbKieuPhong.SelectedIndex == 1)
            {
                // gán giá trị
                giatien = "1500000";
            }
            return giatien;
        }

        private void cmbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGiaPhong.Text = giatien();
        }

        private void cmbKieuPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGiaPhong.Text = giatien();
        }

        private void dtgvDSPhong_Click(object sender, EventArgs e)
        {
            // lấy dòng
            try
            {
                int dong = dtgvDSPhong.CurrentCell.RowIndex;
                txtMaPhong.Text = dtgvDSPhong.Rows[dong].Cells[0].Value.ToString();
                txtSoPhong.Text = dtgvDSPhong.Rows[dong].Cells[1].Value.ToString();
                cmbKieuPhong.SelectedItem = dtgvDSPhong.Rows[dong].Cells[2].Value.ToString();
                cmbLoaiPhong.SelectedItem = dtgvDSPhong.Rows[dong].Cells[3].Value.ToString();
                txtGiaPhong.Text = dtgvDSPhong.Rows[dong].Cells[4].Value.ToString();
            }catch
            {
                MessageBox.Show("Không có thông tin !!", "Thông báo");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
               
                et = new ET_Phong(txtMaPhong.Text, txtSoPhong.Text, cmbLoaiPhong.Text,cmbKieuPhong.Text,txtGiaPhong.Text);
                if (bus.themPhong(et) == true)
                {
                    // Thông báo message
                    MessageBox.Show("Thêm phòng thành công!", "Thông báo");
                    // cập nhật lại danh sách khách hàng
                    LayDSPhong();
                    // clear các control
                    clearcontrol();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        //hàm clear các control
        void clearcontrol()
        {
            txtMaPhong.Clear();
            txtGiaPhong.Clear();
            txtSoPhong.Clear();
            cmbKieuPhong.SelectedIndex = 0;
            cmbLoaiPhong.SelectedIndex = 0;
            //cmbTinhTrang.SelectedIndex = -1;
            txtMaPhong.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                et = new ET_Phong(txtMaPhong.Text, txtSoPhong.Text, cmbLoaiPhong.Text, cmbKieuPhong.Text, txtGiaPhong.Text);
                if (bus.suaPhong(et) == true)
                {
                    // Thông báo message
                    MessageBox.Show("Sửa phòng thành công!", "Thông báo");
                    // cập nhật lại danh sách khách hàng
                    LayDSPhong();
                    // clear các control
                    clearcontrol();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phòng này hay không?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (bus.xoaPhong(txtMaPhong.Text) == true)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        LayDSPhong();
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
            // thực thi tìm danh sách
            dtgvDSPhong.DataSource = bus.timPhong(txtTimKiem.Text); ;
        }
    }
}
