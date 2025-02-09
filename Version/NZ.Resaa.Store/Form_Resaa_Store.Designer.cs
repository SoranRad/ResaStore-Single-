using MS_Control;

namespace NZ.Resaa.Store
{
    partial class Form_Resaa_Store
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
            this.mS_Menu1 = new MS_Control.Controls.MS_Menu();
            this.ms_baseinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.NzReports = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.NzAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_MdiTab = new MdiTabStrip.MdiTabStrip();
            this.mS_Tool_Strip1 = new MS_Control.Controls.MS_Tool_Strip();
            this.NzCompanyTitle = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.NzDate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NzChangeUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.NzChangeYear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.NzChangePass = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.NzVersion = new System.Windows.Forms.ToolStripLabel();
            this.Pic_Back_Main = new System.Windows.Forms.PictureBox();
            this.NzSidebar = new MS_Control.Controls.MS_Menu();
            this.mS_Menu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ms_MdiTab)).BeginInit();
            this.mS_Tool_Strip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Back_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // mS_Menu1
            // 
            this.mS_Menu1.AutoSize = false;
            this.mS_Menu1.Font = new System.Drawing.Font("IRANSans(Small) Medium", 12F);
            this.mS_Menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_baseinfo,
            this.NzReports,
            this.ms_settings,
            this.NzAbout});
            this.mS_Menu1.Location = new System.Drawing.Point(0, 0);
            this.mS_Menu1.MS_BorderColor = System.Drawing.Color.CornflowerBlue;
            this.mS_Menu1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Menu1.MS_Color_End = System.Drawing.Color.LightSteelBlue;
            this.mS_Menu1.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.mS_Menu1.Name = "mS_Menu1";
            this.mS_Menu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_Menu1.Size = new System.Drawing.Size(972, 32);
            this.mS_Menu1.TabIndex = 4;
            this.mS_Menu1.Text = "mS_Menu1";
            // 
            // ms_baseinfo
            // 
            this.ms_baseinfo.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_baseinfo.Image = global::MS_Resource.GlobalResources.Base;
            this.ms_baseinfo.Name = "ms_baseinfo";
            this.ms_baseinfo.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ms_baseinfo.Size = new System.Drawing.Size(118, 28);
            this.ms_baseinfo.Tag = "1";
            this.ms_baseinfo.Text = "اطـلاعـات پـایه";
            // 
            // NzReports
            // 
            this.NzReports.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzReports.Image = global::MS_Resource.GlobalResources.chart_bar;
            this.NzReports.Name = "NzReports";
            this.NzReports.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.NzReports.Size = new System.Drawing.Size(90, 28);
            this.NzReports.Tag = "180";
            this.NzReports.Text = "گـزارشـات";
            // 
            // ms_settings
            // 
            this.ms_settings.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_settings.Image = global::MS_Resource.GlobalResources.Toolbar2;
            this.ms_settings.Name = "ms_settings";
            this.ms_settings.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ms_settings.Size = new System.Drawing.Size(87, 28);
            this.ms_settings.Tag = "180";
            this.ms_settings.Text = "امـکانـات";
            // 
            // NzAbout
            // 
            this.NzAbout.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14.25F);
            this.NzAbout.Image = global::MS_Resource.GlobalResources.Logo_Resaa_Final_Blue;
            this.NzAbout.Name = "NzAbout";
            this.NzAbout.Size = new System.Drawing.Size(87, 28);
            this.NzAbout.Text = "درباره مـا";
            this.NzAbout.Click += new System.EventHandler(this.NzAbout_Click);
            // 
            // ms_MdiTab
            // 
            this.ms_MdiTab.ActiveTabBorderColor = System.Drawing.Color.RoyalBlue;
            this.ms_MdiTab.ActiveTabFont = new System.Drawing.Font("IRANSans(Small) Medium", 12F);
            this.ms_MdiTab.ActiveTabForeColor = System.Drawing.Color.MidnightBlue;
            this.ms_MdiTab.AllowDrop = true;
            this.ms_MdiTab.Animate = false;
            this.ms_MdiTab.DisplayFormIcon = false;
            this.ms_MdiTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.ms_MdiTab.Font = new System.Drawing.Font("IRANSans(Small) Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_MdiTab.InactiveTabBorderColor = System.Drawing.Color.LightSteelBlue;
            this.ms_MdiTab.InactiveTabColor = System.Drawing.Color.Lavender;
            this.ms_MdiTab.InactiveTabFont = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_MdiTab.InactiveTabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ms_MdiTab.Location = new System.Drawing.Point(0, 32);
            this.ms_MdiTab.MaxTabWidth = 300;
            this.ms_MdiTab.MdiNewTabImage = null;
            this.ms_MdiTab.MdiWindowState = MdiTabStrip.MdiChildWindowState.Maximized;
            this.ms_MdiTab.MinimumSize = new System.Drawing.Size(50, 33);
            this.ms_MdiTab.MinTabWidth = 50;
            this.ms_MdiTab.MouseOverTabColor = System.Drawing.Color.SteelBlue;
            this.ms_MdiTab.MouseOverTabFont = new System.Drawing.Font("IRANSans(Small)", 12F);
            this.ms_MdiTab.MouseOverTabForeColor = System.Drawing.Color.White;
            this.ms_MdiTab.Name = "ms_MdiTab";
            this.ms_MdiTab.NewTabToolTipText = "";
            this.ms_MdiTab.Padding = new System.Windows.Forms.Padding(2, 3, 10, 2);
            this.ms_MdiTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_MdiTab.ShowTabToolTip = false;
            this.ms_MdiTab.Size = new System.Drawing.Size(972, 33);
            this.ms_MdiTab.TabIndex = 5;
            this.ms_MdiTab.Visible = false;
            this.ms_MdiTab.CurrentMdiTabChanged += new MdiTabStrip.MdiTabStrip.CurrentMdiTabChangedEventHandler(this.ms_MdiTab_CurrentMdiTabChanged);
            this.ms_MdiTab.MdiTabAdded += new MdiTabStrip.MdiTabStrip.MdiTabAddedEventHandler(this.ms_MdiTab_MdiTabAdded);
            this.ms_MdiTab.MdiTabRemoved += new MdiTabStrip.MdiTabStrip.MdiTabRemovedEventHandler(this.ms_MdiTab_MdiTabRemoved);
            this.ms_MdiTab.VisibleChanged += new System.EventHandler(this.ms_MdiTab_VisibleChanged);
            // 
            // mS_Tool_Strip1
            // 
            this.mS_Tool_Strip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mS_Tool_Strip1.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.mS_Tool_Strip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mS_Tool_Strip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NzCompanyTitle,
            this.toolStripSeparator5,
            this.toolStripLabel1,
            this.NzDate,
            this.toolStripSeparator1,
            this.NzChangeUser,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.NzChangeYear,
            this.toolStripSeparator3,
            this.NzChangePass,
            this.toolStripSeparator4,
            this.NzVersion});
            this.mS_Tool_Strip1.Location = new System.Drawing.Point(0, 383);
            this.mS_Tool_Strip1.MS_BorderColor = System.Drawing.Color.CornflowerBlue;
            this.mS_Tool_Strip1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Tool_Strip1.MS_Color_End = System.Drawing.Color.LightSteelBlue;
            this.mS_Tool_Strip1.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.mS_Tool_Strip1.Name = "mS_Tool_Strip1";
            this.mS_Tool_Strip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_Tool_Strip1.Size = new System.Drawing.Size(972, 30);
            this.mS_Tool_Strip1.TabIndex = 7;
            this.mS_Tool_Strip1.Text = "mS_Tool_Strip1";
            // 
            // NzCompanyTitle
            // 
            this.NzCompanyTitle.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Bold);
            this.NzCompanyTitle.Image = global::MS_Resource.GlobalResources.Logo_Resaa_Final_Blue;
            this.NzCompanyTitle.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.NzCompanyTitle.Name = "NzCompanyTitle";
            this.NzCompanyTitle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NzCompanyTitle.Size = new System.Drawing.Size(52, 27);
            this.NzCompanyTitle.Text = "....";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::MS_Resource.GlobalResources.Negin__26_;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(99, 27);
            this.toolStripLabel1.Text = "تاریخ امروز : ";
            // 
            // NzDate
            // 
            this.NzDate.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
            this.NzDate.Name = "NzDate";
            this.NzDate.Size = new System.Drawing.Size(68, 27);
            this.NzDate.Text = "1396/01/01";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // NzChangeUser
            // 
            this.NzChangeUser.Image = global::MS_Resource.GlobalResources.userActive;
            this.NzChangeUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NzChangeUser.Name = "NzChangeUser";
            this.NzChangeUser.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NzChangeUser.Size = new System.Drawing.Size(125, 27);
            this.NzChangeUser.Text = "تغییر کاربر جاری";
            this.NzChangeUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.NzChangeUser.Click += new System.EventHandler(this.NzChangeUser_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(69, 27);
            this.toolStripLabel2.Text = "سال مالی : ";
            // 
            // NzChangeYear
            // 
            this.NzChangeYear.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
            this.NzChangeYear.Image = global::MS_Resource.GlobalResources.Negin__26_;
            this.NzChangeYear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NzChangeYear.Name = "NzChangeYear";
            this.NzChangeYear.Size = new System.Drawing.Size(111, 27);
            this.NzChangeYear.Text = "تغـییر سال مالی";
            this.NzChangeYear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.NzChangeYear.Click += new System.EventHandler(this.NzChangeYear_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 30);
            // 
            // NzChangePass
            // 
            this.NzChangePass.Image = global::MS_Resource.GlobalResources.Negin__39_;
            this.NzChangePass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NzChangePass.Name = "NzChangePass";
            this.NzChangePass.Size = new System.Drawing.Size(116, 27);
            this.NzChangePass.Text = "تغـییر کلمه عبور ";
            this.NzChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.NzChangePass.Click += new System.EventHandler(this.NzChangePass_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 30);
            // 
            // NzVersion
            // 
            this.NzVersion.Name = "NzVersion";
            this.NzVersion.Size = new System.Drawing.Size(26, 27);
            this.NzVersion.Text = "....";
            // 
            // Pic_Back_Main
            // 
            this.Pic_Back_Main.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Back_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pic_Back_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pic_Back_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic_Back_Main.Location = new System.Drawing.Point(0, 65);
            this.Pic_Back_Main.Name = "Pic_Back_Main";
            this.Pic_Back_Main.Size = new System.Drawing.Size(972, 318);
            this.Pic_Back_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Back_Main.TabIndex = 16;
            this.Pic_Back_Main.TabStop = false;
            // 
            // NzSidebar
            // 
            this.NzSidebar.AutoSize = false;
            this.NzSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.NzSidebar.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
            this.NzSidebar.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.NzSidebar.Location = new System.Drawing.Point(892, 32);
            this.NzSidebar.MS_BorderColor = System.Drawing.Color.CornflowerBlue;
            this.NzSidebar.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzSidebar.MS_Color_End = System.Drawing.Color.LightSteelBlue;
            this.NzSidebar.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.NzSidebar.Name = "NzSidebar";
            this.NzSidebar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzSidebar.Size = new System.Drawing.Size(80, 351);
            this.NzSidebar.TabIndex = 18;
            this.NzSidebar.Text = "mS_Menu2";
            this.NzSidebar.Visible = false;
            // 
            // Form_Resaa_Store
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(972, 413);
            this.Controls.Add(this.Pic_Back_Main);
            this.Controls.Add(this.ms_MdiTab);
            this.Controls.Add(this.NzSidebar);
            this.Controls.Add(this.mS_Menu1);
            this.Controls.Add(this.mS_Tool_Strip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mS_Menu1;
            this.Name = "Form_Resaa_Store";
            this.Text = "نرم افزار فروشگاهی رسـا";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Resaa_Store_FormClosing);
            this.Load += new System.EventHandler(this.Form_Resaa_Store_Load);
            this.Shown += new System.EventHandler(this.Form_Resaa_Store_Shown);
            this.mS_Menu1.ResumeLayout(false);
            this.mS_Menu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ms_MdiTab)).EndInit();
            this.mS_Tool_Strip1.ResumeLayout(false);
            this.mS_Tool_Strip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Back_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MS_Control.Controls.MS_Menu mS_Menu1;
        private System.Windows.Forms.ToolStripMenuItem ms_baseinfo;
        private System.Windows.Forms.ToolStripMenuItem ms_settings;
        private MdiTabStrip.MdiTabStrip ms_MdiTab;
        private MS_Control.Controls.MS_Tool_Strip mS_Tool_Strip1;
        private System.Windows.Forms.PictureBox Pic_Back_Main;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel NzDate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton NzChangeUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton NzChangeYear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
       
        private System.Windows.Forms.ToolStripButton NzChangePass;
        private System.Windows.Forms.ToolStripMenuItem NzReports;
        private System.Windows.Forms.ToolStripLabel NzCompanyTitle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem NzAbout;
        private MS_Control.Controls.MS_Menu NzSidebar;
        private System.Windows.Forms.ToolStripLabel NzVersion;
    }
}

