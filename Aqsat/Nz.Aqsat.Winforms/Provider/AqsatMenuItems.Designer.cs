
namespace Nz.Bar.Winforms.Provider
{
    partial class AqsatMenuItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AqsatMenuItems));
			this.mS_Menu1 = new MS_Control.Controls.MS_Menu();
			this.ms_baseinfo = new System.Windows.Forms.ToolStripMenuItem();
			this.StorageMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.تعریفانواعقسطToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.NsCreateAqsat = new System.Windows.Forms.ToolStripMenuItem();
			this.لیستاقساطToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NzReport = new System.Windows.Forms.ToolStripMenuItem();
			this.داشبوردماهانهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.گزارشاقساطبهتفکیکوضعیتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mS_Menu1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mS_Menu1
			// 
			this.mS_Menu1.AutoSize = false;
			this.mS_Menu1.Font = new System.Drawing.Font("Tahoma", 10.5F);
			this.mS_Menu1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mS_Menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_baseinfo,
            this.StorageMenu,
            this.NzReport});
			this.mS_Menu1.Location = new System.Drawing.Point(0, 0);
			this.mS_Menu1.MS_BorderColor = System.Drawing.Color.DodgerBlue;
			this.mS_Menu1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Menu1.MS_Color_End = System.Drawing.Color.PowderBlue;
			this.mS_Menu1.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.mS_Menu1.Name = "mS_Menu1";
			this.mS_Menu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.mS_Menu1.Size = new System.Drawing.Size(687, 32);
			this.mS_Menu1.TabIndex = 5;
			this.mS_Menu1.Text = "mS_Menu1";
			// 
			// ms_baseinfo
			// 
			this.ms_baseinfo.Font = new System.Drawing.Font("IRANSans(Small) Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.ms_baseinfo.Image = ((System.Drawing.Image)(resources.GetObject("ms_baseinfo.Image")));
			this.ms_baseinfo.Name = "ms_baseinfo";
			this.ms_baseinfo.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.ms_baseinfo.Size = new System.Drawing.Size(144, 28);
			this.ms_baseinfo.Tag = "1";
			this.ms_baseinfo.Text = "اطـلاعـات پـایه";
			// 
			// StorageMenu
			// 
			this.StorageMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعریفانواعقسطToolStripMenuItem,
            this.toolStripSeparator2,
            this.NsCreateAqsat,
            this.لیستاقساطToolStripMenuItem});
			this.StorageMenu.Font = new System.Drawing.Font("IRANSans(Small) Medium", 15F);
			this.StorageMenu.Image = ((System.Drawing.Image)(resources.GetObject("StorageMenu.Image")));
			this.StorageMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.StorageMenu.Name = "StorageMenu";
			this.StorageMenu.Size = new System.Drawing.Size(76, 28);
			this.StorageMenu.Text = "اقساط";
			// 
			// تعریفانواعقسطToolStripMenuItem
			// 
			this.تعریفانواعقسطToolStripMenuItem.Name = "تعریفانواعقسطToolStripMenuItem";
			this.تعریفانواعقسطToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
			this.تعریفانواعقسطToolStripMenuItem.Text = "تعریف انواع قسط";
			this.تعریفانواعقسطToolStripMenuItem.Click += new System.EventHandler(this.تعریفانواعقسطToolStripMenuItem_Click_1);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
			// 
			// NsCreateAqsat
			// 
			this.NsCreateAqsat.Name = "NsCreateAqsat";
			this.NsCreateAqsat.Size = new System.Drawing.Size(185, 30);
			this.NsCreateAqsat.Text = "ایجاد قسط جدید";
			this.NsCreateAqsat.Click += new System.EventHandler(this.NsCreateAqsat_Click);
			// 
			// لیستاقساطToolStripMenuItem
			// 
			this.لیستاقساطToolStripMenuItem.Name = "لیستاقساطToolStripMenuItem";
			this.لیستاقساطToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
			this.لیستاقساطToolStripMenuItem.Text = "لیست اقساط";
			// 
			// NzReport
			// 
			this.NzReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.داشبوردماهانهToolStripMenuItem,
            this.toolStripSeparator1,
            this.گزارشاقساطبهتفکیکوضعیتToolStripMenuItem});
			this.NzReport.Font = new System.Drawing.Font("IRANSans(Small) Medium", 15F);
			this.NzReport.Image = ((System.Drawing.Image)(resources.GetObject("NzReport.Image")));
			this.NzReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.NzReport.Name = "NzReport";
			this.NzReport.Size = new System.Drawing.Size(96, 28);
			this.NzReport.Text = "گـزارشـات";
			// 
			// داشبوردماهانهToolStripMenuItem
			// 
			this.داشبوردماهانهToolStripMenuItem.Name = "داشبوردماهانهToolStripMenuItem";
			this.داشبوردماهانهToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
			this.داشبوردماهانهToolStripMenuItem.Text = "داشبورد ماهانه";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(263, 6);
			// 
			// گزارشاقساطبهتفکیکوضعیتToolStripMenuItem
			// 
			this.گزارشاقساطبهتفکیکوضعیتToolStripMenuItem.Name = "گزارشاقساطبهتفکیکوضعیتToolStripMenuItem";
			this.گزارشاقساطبهتفکیکوضعیتToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
			this.گزارشاقساطبهتفکیکوضعیتToolStripMenuItem.Text = "گزارش اقساط به تفکیک وضعیت";
			// 
			// AqsatMenuItems
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mS_Menu1);
			this.Name = "AqsatMenuItems";
			this.Size = new System.Drawing.Size(687, 385);
			this.mS_Menu1.ResumeLayout(false);
			this.mS_Menu1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        public MS_Control.Controls.MS_Menu mS_Menu1;
        public System.Windows.Forms.ToolStripMenuItem ms_baseinfo;
        public System.Windows.Forms.ToolStripMenuItem StorageMenu;
        public System.Windows.Forms.ToolStripMenuItem NzReport;
		private System.Windows.Forms.ToolStripMenuItem NsCreateAqsat;
		private System.Windows.Forms.ToolStripMenuItem لیستاقساطToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem داشبوردماهانهToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem گزارشاقساطبهتفکیکوضعیتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعریفانواعقسطToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
