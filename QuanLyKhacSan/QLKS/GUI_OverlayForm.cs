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
    public partial class GUI_OverlayForm : Form
    {
        public GUI_OverlayForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Không có viền
            this.StartPosition = FormStartPosition.CenterScreen; // Vị trí bắt đầu ở giữa màn hình
            this.BackColor = Color.Black; // Màu nền là đen
            this.Opacity = 0.5; // Độ trong suốt (0.0 đến 1.0)
            this.WindowState = FormWindowState.Maximized;
        }

        private void GUI_OverlayForm_Load(object sender, EventArgs e)
        {

        }
    }
}
