
namespace Nz.Bar.Winforms.Provider
{
    partial class BarMenuItems
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarMenuItems));
			this.mS_Menu1 = new MS_Control.Controls.MS_Menu();
			this.ms_baseinfo = new System.Windows.Forms.ToolStripMenuItem();
			this.NsCar = new System.Windows.Forms.ToolStripMenuItem();
			this.StorageMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.NzXaridBar = new System.Windows.Forms.ToolStripMenuItem();
			this.NsListBar = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.NsFactory = new System.Windows.Forms.ToolStripMenuItem();
			this.NsFactoryList = new System.Windows.Forms.ToolStripMenuItem();
			this.NzReport = new System.Windows.Forms.ToolStripMenuItem();
			this.NzRizTarakonesh = new System.Windows.Forms.ToolStripMenuItem();
			this.صورتحسابحامعکشاورزToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ریزبـارهاییککشاورزخاصToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.صورتحسـابکارخـانهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			this.ms_baseinfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NsCar});
			this.ms_baseinfo.Font = new System.Drawing.Font("IRANSans(Small) Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.ms_baseinfo.Image = ((System.Drawing.Image)(resources.GetObject("ms_baseinfo.Image")));
			this.ms_baseinfo.Name = "ms_baseinfo";
			this.ms_baseinfo.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.ms_baseinfo.Size = new System.Drawing.Size(144, 28);
			this.ms_baseinfo.Tag = "1";
			this.ms_baseinfo.Text = "اطـلاعـات پـایه";
			// 
			// NsCar
			// 
			this.NsCar.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsCar.Image = ((System.Drawing.Image)(resources.GetObject("NsCar.Image")));
			this.NsCar.Name = "NsCar";
			this.NsCar.Size = new System.Drawing.Size(196, 28);
			this.NsCar.Text = "تعریف ماشین و راننده";
			this.NsCar.Click += new System.EventHandler(this.NsCar_Click);
			// 
			// StorageMenu
			// 
			this.StorageMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NzXaridBar,
            this.NsListBar,
            this.toolStripSeparator1,
            this.NsFactory,
            this.NsFactoryList});
			this.StorageMenu.Font = new System.Drawing.Font("IRANSans(Small) Medium", 15F);
			this.StorageMenu.Image = ((System.Drawing.Image)(resources.GetObject("StorageMenu.Image")));
			this.StorageMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.StorageMenu.Name = "StorageMenu";
			this.StorageMenu.Size = new System.Drawing.Size(141, 28);
			this.StorageMenu.Text = "خرید و فروش بـار";
			// 
			// NzXaridBar
			// 
			this.NzXaridBar.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzXaridBar.Image = ((System.Drawing.Image)(resources.GetObject("NzXaridBar.Image")));
			this.NzXaridBar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.NzXaridBar.Name = "NzXaridBar";
			this.NzXaridBar.Size = new System.Drawing.Size(226, 28);
			this.NzXaridBar.Text = "خـرید بـار";
			this.NzXaridBar.Click += new System.EventHandler(this.NzXarid_Click);
			// 
			// NsListBar
			// 
			this.NsListBar.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsListBar.Image = ((System.Drawing.Image)(resources.GetObject("NsListBar.Image")));
			this.NsListBar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.NsListBar.Name = "NsListBar";
			this.NsListBar.Size = new System.Drawing.Size(226, 28);
			this.NsListBar.Text = "لیست بارهای خریداری شده";
			this.NsListBar.Click += new System.EventHandler(this.NzListFactor_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
			// 
			// NsFactory
			// 
			this.NsFactory.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsFactory.Image = ((System.Drawing.Image)(resources.GetObject("NsFactory.Image")));
			this.NsFactory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.NsFactory.Name = "NsFactory";
			this.NsFactory.Size = new System.Drawing.Size(226, 28);
			this.NsFactory.Text = "ارسـال به کارخـانه";
			this.NsFactory.Click += new System.EventHandler(this.NsFactory_Click);
			// 
			// NsFactoryList
			// 
			this.NsFactoryList.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsFactoryList.Image = ((System.Drawing.Image)(resources.GetObject("NsFactoryList.Image")));
			this.NsFactoryList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.NsFactoryList.Name = "NsFactoryList";
			this.NsFactoryList.Size = new System.Drawing.Size(226, 28);
			this.NsFactoryList.Text = "لیست ارسالی ها به کارخانه";
			this.NsFactoryList.Click += new System.EventHandler(this.NsFactoryList_Click);
			// 
			// NzReport
			// 
			this.NzReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NzRizTarakonesh,
            this.صورتحسابحامعکشاورزToolStripMenuItem,
            this.ریزبـارهاییککشاورزخاصToolStripMenuItem,
            this.toolStripMenuItem3,
            this.صورتحسـابکارخـانهToolStripMenuItem});
			this.NzReport.Font = new System.Drawing.Font("IRANSans(Small) Medium", 15F);
			this.NzReport.Image = ((System.Drawing.Image)(resources.GetObject("NzReport.Image")));
			this.NzReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.NzReport.Name = "NzReport";
			this.NzReport.Size = new System.Drawing.Size(96, 28);
			this.NzReport.Text = "گـزارشـات";
			// 
			// NzRizTarakonesh
			// 
			this.NzRizTarakonesh.BackColor = System.Drawing.Color.Gainsboro;
			this.NzRizTarakonesh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.NzRizTarakonesh.Font = new System.Drawing.Font("IRANSans(Small) Medium", 17F);
			this.NzRizTarakonesh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.NzRizTarakonesh.Name = "NzRizTarakonesh";
			this.NzRizTarakonesh.Size = new System.Drawing.Size(234, 34);
			this.NzRizTarakonesh.Text = "         کـشـاورز";
			this.NzRizTarakonesh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			// 
			// صورتحسابحامعکشاورزToolStripMenuItem
			// 
			this.صورتحسابحامعکشاورزToolStripMenuItem.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.صورتحسابحامعکشاورزToolStripMenuItem.Name = "صورتحسابحامعکشاورزToolStripMenuItem";
			this.صورتحسابحامعکشاورزToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
			this.صورتحسابحامعکشاورزToolStripMenuItem.Text = "صورت حساب جامع کشاورز";
			this.صورتحسابحامعکشاورزToolStripMenuItem.Click += new System.EventHandler(this.صورتحسابحامعکشاورزToolStripMenuItem_Click);
			// 
			// ریزبـارهاییککشاورزخاصToolStripMenuItem
			// 
			this.ریزبـارهاییککشاورزخاصToolStripMenuItem.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.ریزبـارهاییککشاورزخاصToolStripMenuItem.Name = "ریزبـارهاییککشاورزخاصToolStripMenuItem";
			this.ریزبـارهاییککشاورزخاصToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
			this.ریزبـارهاییککشاورزخاصToolStripMenuItem.Text = "ریز بـارهای یک کشاورز خاص";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.BackColor = System.Drawing.Color.Gainsboro;
			this.toolStripMenuItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripMenuItem3.Font = new System.Drawing.Font("IRANSans(Small) Medium", 17F);
			this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(234, 34);
			this.toolStripMenuItem3.Text = "       کـارخـانه";
			this.toolStripMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			// 
			// صورتحسـابکارخـانهToolStripMenuItem
			// 
			this.صورتحسـابکارخـانهToolStripMenuItem.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.صورتحسـابکارخـانهToolStripMenuItem.Name = "صورتحسـابکارخـانهToolStripMenuItem";
			this.صورتحسـابکارخـانهToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
			this.صورتحسـابکارخـانهToolStripMenuItem.Text = "خلاصه وضعیت کارخانجات";
			this.صورتحسـابکارخـانهToolStripMenuItem.Click += new System.EventHandler(this.صورتحسـابکارخـانهToolStripMenuItem_Click);
			// 
			// BarMenuItems
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mS_Menu1);
			this.Name = "BarMenuItems";
			this.Size = new System.Drawing.Size(687, 385);
			this.mS_Menu1.ResumeLayout(false);
			this.mS_Menu1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        public MS_Control.Controls.MS_Menu mS_Menu1;
        public System.Windows.Forms.ToolStripMenuItem ms_baseinfo;
        public System.Windows.Forms.ToolStripMenuItem StorageMenu;
        private System.Windows.Forms.ToolStripMenuItem NzXaridBar;
        private System.Windows.Forms.ToolStripMenuItem NsFactory;
        private System.Windows.Forms.ToolStripMenuItem NsListBar;
        public System.Windows.Forms.ToolStripMenuItem NzReport;
        private System.Windows.Forms.ToolStripMenuItem NzRizTarakonesh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem NsCar;
		private System.Windows.Forms.ToolStripMenuItem NsFactoryList;
		private System.Windows.Forms.ToolStripMenuItem صورتحسابحامعکشاورزToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ریزبـارهاییککشاورزخاصToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem صورتحسـابکارخـانهToolStripMenuItem;
	}
}
