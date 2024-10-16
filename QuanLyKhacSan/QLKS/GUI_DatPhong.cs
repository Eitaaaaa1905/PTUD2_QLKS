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
    public partial class GUI_DatPhong : Form
    {
        public GUI_DatPhong()
        {
            InitializeComponent();
        }
        // khai báo các bus của khách hàng, phòng, đặt phòng
        BUS_KhachHang kh = new BUS_KhachHang();
        BUS_Phong p = new BUS_Phong(); 
        BUS_DatPhong dp = new BUS_DatPhong();
        // khai báo ET_DatPhong
        ET_DatPhong et = new ET_DatPhong();
        // khai báo biến chứa thời gian tạm

        private void GUI_DatPhong_Load(object sender, EventArgs e)
        {
            // gọi hàm lấy danh sách đặt phòng
            LayDSDP();
            // lấy dữ liệu cho combobox Khách hàng , phòng
            cmbMaKH.DataSource = kh.layDS();
            cmbMaPhong.DataSource = p.layDS();
            // hiển thị mã khách hàng cho combobox KH
            cmbMaKH.DisplayMember = "Mã khách hàng";
            // giá trị là tên khách hàng khi chọn
            cmbMaKH.ValueMember = "Tên khách hàng";
            // hiển thị mã phòng cho combobox Phòng
            cmbMaPhong.DisplayMember = "Mã phòng";
            // giá trị là số phòng khi chọn cmb
            cmbMaPhong.ValueMember = "Số phòng";
            // gọi hàm clear để xóa dữ liệu ban đầu
            clearcontrol();
        }
        // hàm lấy danh sách đặt phòng
        void LayDSDP()
        {
            try
            {
                DataTable dt = dp.layDSDP();
                dtgvDSDatPhong.DataSource = dt;
            }
            catch(Exception ex)
            {
                // bắt lỗi khi sai
                MessageBox.Show(ex.Message, "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            }
        }
        private void cmbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaKH.SelectedItem != null)
            {
                txtTenKH.Text = cmbMaKH.SelectedValue.ToString(); // Lấy tên khách hàng từ combobox
            }
            else
            {
                txtTenKH.Text = "";
            }
        }

        private void cmbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaPhong.SelectedItem != null)
            {
                txtTenPhong.Text = cmbMaPhong.SelectedValue.ToString(); // Lấy tên phòng từ combobox
            }
            else
            {
                txtTenPhong.Text = "";
            }
        }
        // hàm clear control
        void clearcontrol()
        {
            txtTenKH.Text = string.Empty; // Đặt giá trị mặc định bằng rỗng
            txtTenPhong.Text = string.Empty; // đặt giá trị tên phòng mặc định là rỗng
            cmbMaKH.SelectedIndex = -1; // đặt combobox thành rỗng
            cmbMaPhong.SelectedIndex = -1; // đặt combobox maphong thành rỗng
        }

        private void btnDatDichVu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtpkNgayDatPhong.Value.ToString("dd/MM/yyyy HH:mm"));
        }

        private void dtgvDSDatPhong_Click(object sender, EventArgs e)
        {

            try
            {
                int dong = dtgvDSDatPhong.CurrentRow.Index;
                txtMaDatPhong.Text = dtgvDSDatPhong.Rows[dong].Cells[0].Value.ToString();
                cmbMaKH.SelectedValue = dtgvDSDatPhong.Rows[dong].Cells[1].Value.ToString();
                cmbMaPhong.SelectedValue = dtgvDSDatPhong.Rows[dong].Cells[2].Value.ToString();
                dtpkNgayDatPhong.Text = dtgvDSDatPhong.Rows[dong].Cells[3].Value.ToString();
                dtpkNgayNhanPhong.Text = dtgvDSDatPhong.Rows[dong].Cells[4].Value.ToString();
                dtpkNgayTraPhong.Text = dtgvDSDatPhong.Rows[dong].Cells[5].Value.ToString();
                txtTongNgayO.Text = dtgvDSDatPhong.Rows[dong].Cells[6].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng chọn mã đặt phòng!!" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtpkNgayDatPhong_ValueChanged(object sender, EventArgs e)
        {
            if (dtpkNgayDatPhong.Value <= dtpkNgayNhanPhong.Value && dtpkNgayDatPhong.Value <= dtpkNgayTraPhong.Value && dtpkNgayNhanPhong.Value <= dtpkNgayTraPhong.Value)
            { // gán tình trạng theo thời gian
                txtTinhTrang.Text = dp.layTinhTrangPhong(cmbMaPhong.Text, dtpkNgayDatPhong.Value, dtpkNgayNhanPhong.Value, dtpkNgayTraPhong.Value);
            }
            // nếu không thỏa điều kiện thì tổng ngày ở là 0
            else
            {
                txtTongNgayO.Text = "0";
                // gán text Tình trạng là null
                txtTinhTrang.Text = null;
            }
        }

        private void dtpkNgayNhanPhong_ValueChanged(object sender, EventArgs e)
        {
            if (dtpkNgayDatPhong.Value <= dtpkNgayNhanPhong.Value && dtpkNgayDatPhong.Value <= dtpkNgayTraPhong.Value && dtpkNgayNhanPhong.Value <= dtpkNgayTraPhong.Value)
            { // gán tình trạng theo thời gian
                txtTinhTrang.Text = dp.layTinhTrangPhong(cmbMaPhong.Text, dtpkNgayDatPhong.Value, dtpkNgayNhanPhong.Value, dtpkNgayTraPhong.Value);
                // Tính toán độ chênh lệch giữa hai ngày
                TimeSpan difference = dtpkNgayTraPhong.Value.Date - dtpkNgayNhanPhong.Value.Date;
                // Lấy số ngày
                int totalDays = difference.Days;
                // Gán kết quả cho ô văn bản
                txtTongNgayO.Text = totalDays.ToString();
            }
            // nếu không thỏa điều kiện thì tổng ngày ở là 0
            else
            {
                txtTongNgayO.Text = "0";
                // gán text Tình trạng là null
                txtTinhTrang.Text = null;
            }
        }

        private void dtpkNgayTraPhong_ValueChanged(object sender, EventArgs e)
        {
            if (dtpkNgayDatPhong.Value <= dtpkNgayNhanPhong.Value && dtpkNgayDatPhong.Value <= dtpkNgayTraPhong.Value && dtpkNgayNhanPhong.Value <= dtpkNgayTraPhong.Value)
            { // gán tình trạng theo thời gian
                txtTinhTrang.Text = dp.layTinhTrangPhong(cmbMaPhong.Text, dtpkNgayDatPhong.Value, dtpkNgayNhanPhong.Value, dtpkNgayTraPhong.Value);
                // Tính toán độ chênh lệch giữa hai ngày
                TimeSpan difference = dtpkNgayTraPhong.Value.Date - dtpkNgayNhanPhong.Value.Date;
                // Lấy số ngày
                int totalDays = difference.Days;
                // Gán kết quả cho ô văn bản
                txtTongNgayO.Text = totalDays.ToString();
            }
            // nếu không thỏa điều kiện thì tổng ngày ở là 0
            else
            {
                // gán text Tình trạng là null
                txtTinhTrang.Text = null;
                txtTongNgayO.Text = "0";
            }

        }

    }
}
