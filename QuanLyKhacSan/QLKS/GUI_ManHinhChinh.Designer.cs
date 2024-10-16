namespace QLKS
{
    partial class GUI_ManHinhChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timersidebar = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnSidebar = new System.Windows.Forms.PictureBox();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAbout = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.menuContainer1 = new System.Windows.Forms.Panel();
            this.btnQuanLyKM = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLHD = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLDV = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLP = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLyNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.timermenu = new System.Windows.Forms.Timer(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSidebar)).BeginInit();
            this.Sidebar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuContainer1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(98, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Khách Sạn";
            // 
            // timersidebar
            // 
            this.timersidebar.Interval = 10;
            this.timersidebar.Tick += new System.EventHandler(this.timersidebar_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.guna2ControlBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSidebar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1533, 65);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1476, 18);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // btnSidebar
            // 
            this.btnSidebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSidebar.Image = global::QLKS.Properties.Resources.menu_list__3_;
            this.btnSidebar.Location = new System.Drawing.Point(12, 0);
            this.btnSidebar.Name = "btnSidebar";
            this.btnSidebar.Size = new System.Drawing.Size(64, 62);
            this.btnSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSidebar.TabIndex = 0;
            this.btnSidebar.TabStop = false;
            this.btnSidebar.Click += new System.EventHandler(this.btnSidebar_Click);
            // 
            // Sidebar
            // 
            this.Sidebar.AutoScroll = true;
            this.Sidebar.BackColor = System.Drawing.Color.DodgerBlue;
            this.Sidebar.Controls.Add(this.panel3);
            this.Sidebar.Controls.Add(this.panel5);
            this.Sidebar.Controls.Add(this.panel4);
            this.Sidebar.Controls.Add(this.menuContainer1);
            this.Sidebar.Controls.Add(this.panel8);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 65);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(272, 696);
            this.Sidebar.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAbout);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 336);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 66);
            this.panel3.TabIndex = 3;
            // 
            // btnAbout
            // 
            this.btnAbout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAbout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAbout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAbout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAbout.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = global::QLKS.Properties.Resources.about1;
            this.btnAbout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAbout.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnAbout.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAbout.Location = new System.Drawing.Point(0, 0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(272, 66);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "            About";
            this.btnAbout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.guna2Button11);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 270);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(272, 66);
            this.panel5.TabIndex = 6;
            // 
            // guna2Button11
            // 
            this.guna2Button11.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button11.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button11.ForeColor = System.Drawing.Color.White;
            this.guna2Button11.Image = global::QLKS.Properties.Resources.settings__1_1;
            this.guna2Button11.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button11.ImageOffset = new System.Drawing.Point(15, 0);
            this.guna2Button11.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2Button11.Location = new System.Drawing.Point(0, 0);
            this.guna2Button11.Name = "guna2Button11";
            this.guna2Button11.Size = new System.Drawing.Size(272, 66);
            this.guna2Button11.TabIndex = 0;
            this.guna2Button11.Text = "            Setting";
            this.guna2Button11.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnThanhToan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 204);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(272, 66);
            this.panel4.TabIndex = 5;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Image = global::QLKS.Properties.Resources.pay_per_click1;
            this.btnThanhToan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThanhToan.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnThanhToan.ImageSize = new System.Drawing.Size(32, 32);
            this.btnThanhToan.Location = new System.Drawing.Point(0, 0);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(272, 66);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "            Pay";
            this.btnThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // menuContainer1
            // 
            this.menuContainer1.Controls.Add(this.btnQuanLyKM);
            this.menuContainer1.Controls.Add(this.btnQLHD);
            this.menuContainer1.Controls.Add(this.btnQLDV);
            this.menuContainer1.Controls.Add(this.btnQLP);
            this.menuContainer1.Controls.Add(this.btnQLKH);
            this.menuContainer1.Controls.Add(this.btnQuanLyNV);
            this.menuContainer1.Controls.Add(this.btnMenu);
            this.menuContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuContainer1.Location = new System.Drawing.Point(0, 138);
            this.menuContainer1.Name = "menuContainer1";
            this.menuContainer1.Size = new System.Drawing.Size(272, 66);
            this.menuContainer1.TabIndex = 4;
            // 
            // btnQuanLyKM
            // 
            this.btnQuanLyKM.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyKM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyKM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuanLyKM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuanLyKM.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnQuanLyKM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyKM.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyKM.Image = global::QLKS.Properties.Resources.dot__1_;
            this.btnQuanLyKM.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuanLyKM.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnQuanLyKM.ImageSize = new System.Drawing.Size(32, 32);
            this.btnQuanLyKM.Location = new System.Drawing.Point(0, 380);
            this.btnQuanLyKM.Name = "btnQuanLyKM";
            this.btnQuanLyKM.Size = new System.Drawing.Size(270, 66);
            this.btnQuanLyKM.TabIndex = 6;
            this.btnQuanLyKM.Text = "            Quản lý Khuyến mãi";
            this.btnQuanLyKM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuanLyKM.Click += new System.EventHandler(this.btnQuanLyKM_Click);
            // 
            // btnQLHD
            // 
            this.btnQLHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLHD.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnQLHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHD.ForeColor = System.Drawing.Color.White;
            this.btnQLHD.Image = global::QLKS.Properties.Resources.dot__1_;
            this.btnQLHD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLHD.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnQLHD.ImageSize = new System.Drawing.Size(32, 32);
            this.btnQLHD.Location = new System.Drawing.Point(0, 317);
            this.btnQLHD.Name = "btnQLHD";
            this.btnQLHD.Size = new System.Drawing.Size(270, 66);
            this.btnQLHD.TabIndex = 5;
            this.btnQLHD.Text = "            Quản lý hóa đơn";
            this.btnQLHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLHD.Click += new System.EventHandler(this.btnQLHD_Click);
            // 
            // btnQLDV
            // 
            this.btnQLDV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLDV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLDV.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnQLDV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDV.ForeColor = System.Drawing.Color.White;
            this.btnQLDV.Image = global::QLKS.Properties.Resources.dot__1_;
            this.btnQLDV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLDV.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnQLDV.ImageSize = new System.Drawing.Size(32, 32);
            this.btnQLDV.Location = new System.Drawing.Point(0, 254);
            this.btnQLDV.Name = "btnQLDV";
            this.btnQLDV.Size = new System.Drawing.Size(270, 66);
            this.btnQLDV.TabIndex = 4;
            this.btnQLDV.Text = "            Quản lý dịch vụ";
            this.btnQLDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLDV.Click += new System.EventHandler(this.btnQLDV_Click);
            // 
            // btnQLP
            // 
            this.btnQLP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLP.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnQLP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLP.ForeColor = System.Drawing.Color.White;
            this.btnQLP.Image = global::QLKS.Properties.Resources.dot__1_;
            this.btnQLP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLP.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnQLP.ImageSize = new System.Drawing.Size(32, 32);
            this.btnQLP.Location = new System.Drawing.Point(0, 191);
            this.btnQLP.Name = "btnQLP";
            this.btnQLP.Size = new System.Drawing.Size(270, 66);
            this.btnQLP.TabIndex = 3;
            this.btnQLP.Text = "            Quản lý phòng";
            this.btnQLP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLP.Click += new System.EventHandler(this.btnQLP_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLKH.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnQLKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKH.ForeColor = System.Drawing.Color.White;
            this.btnQLKH.Image = global::QLKS.Properties.Resources.dot__1_;
            this.btnQLKH.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLKH.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnQLKH.ImageSize = new System.Drawing.Size(32, 32);
            this.btnQLKH.Location = new System.Drawing.Point(0, 128);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(270, 66);
            this.btnQLKH.TabIndex = 2;
            this.btnQLKH.Text = "            Quản lý khách hàng";
            this.btnQLKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnQuanLyNV
            // 
            this.btnQuanLyNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(221)))));
            this.btnQuanLyNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuanLyNV.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnQuanLyNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNV.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyNV.Image = global::QLKS.Properties.Resources.dot__1_;
            this.btnQuanLyNV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuanLyNV.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnQuanLyNV.ImageSize = new System.Drawing.Size(32, 32);
            this.btnQuanLyNV.Location = new System.Drawing.Point(0, 65);
            this.btnQuanLyNV.Name = "btnQuanLyNV";
            this.btnQuanLyNV.Size = new System.Drawing.Size(270, 66);
            this.btnQuanLyNV.TabIndex = 1;
            this.btnQuanLyNV.Text = "            Quản lý nhân viên";
            this.btnQuanLyNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuanLyNV.Click += new System.EventHandler(this.btnQuanLyNV_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenu.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::QLKS.Properties.Resources.home_agreement;
            this.btnMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMenu.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnMenu.ImageSize = new System.Drawing.Size(32, 32);
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(270, 66);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "            Menu manage";
            this.btnMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.guna2Button7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(272, 138);
            this.panel8.TabIndex = 2;
            // 
            // guna2Button7
            // 
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.Image = global::QLKS.Properties.Resources.statistical_graphic;
            this.guna2Button7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.ImageOffset = new System.Drawing.Point(15, 0);
            this.guna2Button7.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2Button7.Location = new System.Drawing.Point(0, 72);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(272, 66);
            this.guna2Button7.TabIndex = 1;
            this.guna2Button7.Text = "            Dashboard";
            this.guna2Button7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // timermenu
            // 
            this.timermenu.Interval = 10;
            this.timermenu.Tick += new System.EventHandler(this.timermenu_Tick);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(272, 65);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1261, 696);
            this.panelContainer.TabIndex = 3;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 761);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSidebar)).EndInit();
            this.Sidebar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.menuContainer1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnSidebar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timersidebar;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private System.Windows.Forms.Timer timermenu;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private System.Windows.Forms.Panel menuContainer1;
        private Guna.UI2.WinForms.Guna2Button btnQLKH;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyNV;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnAbout;
        private Guna.UI2.WinForms.Guna2Button btnQLDV;
        private Guna.UI2.WinForms.Guna2Button btnQLP;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyKM;
        private Guna.UI2.WinForms.Guna2Button btnQLHD;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button guna2Button11;
        private System.Windows.Forms.Panel panelContainer;
    }
}

