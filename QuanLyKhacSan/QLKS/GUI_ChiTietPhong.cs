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
    public partial class GUI_ChiTietPhong : Form
    {
        public GUI_ChiTietPhong()
        {
            InitializeComponent();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            GUI_OverlayForm overlay = new GUI_OverlayForm();
            overlay.Show(); // Hiển thị overlay

            GUI_DatPhong frm = new GUI_DatPhong();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(); // Hiển thị Form chính

            overlay.Close();
        }
    }
}
