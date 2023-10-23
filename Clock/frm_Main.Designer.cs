namespace Clock
{
    partial class frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_SmallSideMenu = new Panel();
            pnl_SmallSideMenuHeader = new Panel();
            pnl_SideMenu = new Panel();
            pnl_SideMenuHeader = new Panel();
            pnl_MainContant = new Panel();
            pnl_MainContantHeader = new Panel();
            btn_Minimize = new Button();
            btn_Maximize = new Button();
            btn_Close = new Button();
            pnl_SmallSideMenu.SuspendLayout();
            pnl_SideMenu.SuspendLayout();
            pnl_MainContant.SuspendLayout();
            pnl_MainContantHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_SmallSideMenu
            // 
            pnl_SmallSideMenu.BackColor = Color.FromArgb(32, 32, 32);
            pnl_SmallSideMenu.Controls.Add(pnl_SmallSideMenuHeader);
            pnl_SmallSideMenu.Dock = DockStyle.Left;
            pnl_SmallSideMenu.Location = new Point(4, 4);
            pnl_SmallSideMenu.Name = "pnl_SmallSideMenu";
            pnl_SmallSideMenu.Size = new Size(10, 625);
            pnl_SmallSideMenu.TabIndex = 0;
            // 
            // pnl_SmallSideMenuHeader
            // 
            pnl_SmallSideMenuHeader.Dock = DockStyle.Top;
            pnl_SmallSideMenuHeader.Location = new Point(0, 0);
            pnl_SmallSideMenuHeader.Name = "pnl_SmallSideMenuHeader";
            pnl_SmallSideMenuHeader.Size = new Size(10, 45);
            pnl_SmallSideMenuHeader.TabIndex = 0;
            pnl_SmallSideMenuHeader.MouseDown += pnl_MainContantHeader_MouseDown;
            // 
            // pnl_SideMenu
            // 
            pnl_SideMenu.BackColor = Color.FromArgb(32, 32, 32);
            pnl_SideMenu.Controls.Add(pnl_SideMenuHeader);
            pnl_SideMenu.Dock = DockStyle.Left;
            pnl_SideMenu.Location = new Point(14, 4);
            pnl_SideMenu.Name = "pnl_SideMenu";
            pnl_SideMenu.Size = new Size(172, 625);
            pnl_SideMenu.TabIndex = 1;
            // 
            // pnl_SideMenuHeader
            // 
            pnl_SideMenuHeader.Dock = DockStyle.Top;
            pnl_SideMenuHeader.Location = new Point(0, 0);
            pnl_SideMenuHeader.Name = "pnl_SideMenuHeader";
            pnl_SideMenuHeader.Size = new Size(172, 45);
            pnl_SideMenuHeader.TabIndex = 1;
            pnl_SideMenuHeader.MouseDown += pnl_MainContantHeader_MouseDown;
            // 
            // pnl_MainContant
            // 
            pnl_MainContant.BackColor = Color.FromArgb(39, 39, 39);
            pnl_MainContant.Controls.Add(pnl_MainContantHeader);
            pnl_MainContant.Dock = DockStyle.Fill;
            pnl_MainContant.Location = new Point(186, 4);
            pnl_MainContant.Name = "pnl_MainContant";
            pnl_MainContant.Size = new Size(810, 625);
            pnl_MainContant.TabIndex = 2;
            // 
            // pnl_MainContantHeader
            // 
            pnl_MainContantHeader.Controls.Add(btn_Minimize);
            pnl_MainContantHeader.Controls.Add(btn_Maximize);
            pnl_MainContantHeader.Controls.Add(btn_Close);
            pnl_MainContantHeader.Dock = DockStyle.Top;
            pnl_MainContantHeader.Location = new Point(0, 0);
            pnl_MainContantHeader.Name = "pnl_MainContantHeader";
            pnl_MainContantHeader.Size = new Size(810, 45);
            pnl_MainContantHeader.TabIndex = 1;
            pnl_MainContantHeader.MouseDown += pnl_MainContantHeader_MouseDown;
            // 
            // btn_Minimize
            // 
            btn_Minimize.BackColor = Color.FromArgb(39, 39, 39);
            btn_Minimize.BackgroundImage = Properties.Resources.img_Minimize1;
            btn_Minimize.BackgroundImageLayout = ImageLayout.Center;
            btn_Minimize.Dock = DockStyle.Right;
            btn_Minimize.FlatAppearance.BorderSize = 0;
            btn_Minimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 207, 207);
            btn_Minimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 255);
            btn_Minimize.FlatStyle = FlatStyle.Flat;
            btn_Minimize.ForeColor = Color.FromArgb(255, 255, 255);
            btn_Minimize.Location = new Point(600, 0);
            btn_Minimize.Name = "btn_Minimize";
            btn_Minimize.Size = new Size(70, 45);
            btn_Minimize.TabIndex = 2;
            btn_Minimize.UseVisualStyleBackColor = false;
            btn_Minimize.Click += btn_Minimize_Click;
            btn_Minimize.MouseEnter += btn_Minimize_MouseEnter;
            btn_Minimize.MouseLeave += btn_Minimize_MouseLeave;
            // 
            // btn_Maximize
            // 
            btn_Maximize.BackColor = Color.FromArgb(39, 39, 39);
            btn_Maximize.BackgroundImage = Properties.Resources.img_Maximize3;
            btn_Maximize.BackgroundImageLayout = ImageLayout.Center;
            btn_Maximize.Dock = DockStyle.Right;
            btn_Maximize.FlatAppearance.BorderSize = 0;
            btn_Maximize.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 207, 207);
            btn_Maximize.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 255);
            btn_Maximize.FlatStyle = FlatStyle.Flat;
            btn_Maximize.ForeColor = Color.FromArgb(255, 255, 255);
            btn_Maximize.Location = new Point(670, 0);
            btn_Maximize.Name = "btn_Maximize";
            btn_Maximize.Size = new Size(70, 45);
            btn_Maximize.TabIndex = 1;
            btn_Maximize.UseVisualStyleBackColor = false;
            btn_Maximize.Click += btn_Maximize_Click;
            btn_Maximize.MouseEnter += btn_Maximize_MouseEnter;
            btn_Maximize.MouseLeave += btn_Maximize_MouseLeave;
            // 
            // btn_Close
            // 
            btn_Close.BackgroundImage = Properties.Resources.img_Close1;
            btn_Close.BackgroundImageLayout = ImageLayout.Center;
            btn_Close.Dock = DockStyle.Right;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatAppearance.MouseDownBackColor = Color.FromArgb(232, 17, 35);
            btn_Close.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 17, 35);
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Location = new Point(740, 0);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(70, 45);
            btn_Close.TabIndex = 0;
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            btn_Close.MouseEnter += btn_Close_MouseEnter;
            btn_Close.MouseLeave += btn_Close_MouseLeave;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 633);
            Controls.Add(pnl_MainContant);
            Controls.Add(pnl_SideMenu);
            Controls.Add(pnl_SmallSideMenu);
            Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Main";
            Padding = new Padding(4);
            Text = "Form1";
            pnl_SmallSideMenu.ResumeLayout(false);
            pnl_SideMenu.ResumeLayout(false);
            pnl_MainContant.ResumeLayout(false);
            pnl_MainContantHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_SmallSideMenu;
        private Panel pnl_SmallSideMenuHeader;
        private Panel pnl_SideMenu;
        private Panel pnl_SideMenuHeader;
        private Panel pnl_MainContant;
        private Panel pnl_MainContantHeader;
        private Button btn_Maximize;
        private Button btn_Close;
        private Button btn_Minimize;
    }
}