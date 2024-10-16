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
    public partial class UC_Quanlynhanvien : UserControl
    {
        public UC_Quanlynhanvien()
        {
            InitializeComponent();

        }
        
        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            GUI_OverlayForm overlay = new GUI_OverlayForm();
            overlay.Show(); // Hiển thị overlay

            GUI_Phanquyen frm = new GUI_Phanquyen();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(); // Hiển thị Form chính

            overlay.Close();
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            GUI_OverlayForm overlay = new GUI_OverlayForm();
            overlay.Show(); // Hiển thị overlay

            GUI_TinhLuong frm = new GUI_TinhLuong();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(); // Hiển thị Form chính

            overlay.Close();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            GUI_OverlayForm overlay = new GUI_OverlayForm();
            overlay.Show(); // Hiển thị overlay

            GUI_Chamcong frm = new GUI_Chamcong();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(); // Hiển thị Form chính

            overlay.Close();
        }
    }
}
