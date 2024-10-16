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
    public partial class GUI_ManHinhChinh : Form
    {
        bool sidebarExpand = true;
        bool menuExpand = false;
        public GUI_ManHinhChinh()
        {
            InitializeComponent();
            UC_Home uc = new UC_Home();
            addUserControl(uc);

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
            
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timersidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width <= 83)
                {
                    sidebarExpand = false;
                    timersidebar.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width >= 272)
                {
                    sidebarExpand = true;
                    timersidebar.Stop();
                }
            }
        }

        

        private void timermenu_Tick(object sender, EventArgs e)
        {
            if (menuExpand==false)
            {
                menuContainer1.Height += 10;
                if (menuContainer1.Height >= 448)
                {
                    timermenu.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer1.Height -= 10;
                if (menuContainer1.Height <= 66)
                {
                    timermenu.Stop();
                    menuExpand=false;
                }
            }
        }

        

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            timersidebar.Start();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timermenu.Start();
        }

        private void btnQuanLyNV_Click(object sender, EventArgs e)
        {
            UC_Quanlynhanvien uc = new UC_Quanlynhanvien();
            addUserControl(uc);
        }

        private void btnQuanLyKM_Click(object sender, EventArgs e)
        {
            UC_Quanlykhuyenmai uc = new UC_Quanlykhuyenmai();
            addUserControl(uc);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            GUI_OverlayForm overlay = new GUI_OverlayForm();
            overlay.Show(); // Hiển thị overlay
            GUI_About frm = new GUI_About();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(); // Hiển thị Form chính

            overlay.Close();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            UC_Quanlykhachhang uc = new UC_Quanlykhachhang();
            addUserControl(uc);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.Black; 
            int borderWidth = 1; 

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawLine(pen, 0, panel2.Height - borderWidth / 1, panel2.Width, panel2.Height - borderWidth / 1);
            }
        }

        private void btnQLP_Click(object sender, EventArgs e)
        {
            UC_Quanlyphong uc = new UC_Quanlyphong();
            addUserControl(uc);
        }

        private void btnQLDV_Click(object sender, EventArgs e)
        {
            UC_Quanlydichvu uc = new UC_Quanlydichvu();
            addUserControl(uc);
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            UC_Quanlyhoadon uc = new UC_Quanlyhoadon();
            addUserControl(uc);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            GUI_OverlayForm overlay = new GUI_OverlayForm();
            overlay.Show(); // Hiển thị overlay
            GUI_ThanhToan frm = new GUI_ThanhToan();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(); // Hiển thị Form chính

            overlay.Close();
        }
    }
}
