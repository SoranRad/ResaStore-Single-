
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
			this.StorageMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.InitialStock = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.NzWaste = new System.Windows.Forms.ToolStripMenuItem();
			this.NzConsum = new System.Windows.Forms.ToolStripMenuItem();
			this.NzResid = new System.Windows.Forms.ToolStripMenuItem();
			this.NzHavale = new System.Windows.Forms.ToolStripMenuItem();
			this.NzEnteqalAnbarHa = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.NzListResidHavale = new System.Windows.Forms.ToolStripMenuItem();
			this.NzReport = new System.Windows.Forms.ToolStripMenuItem();
			this.NzObjectCircular = new System.Windows.Forms.ToolStripMenuItem();
			this.NzAnalyze = new System.Windows.Forms.ToolStripMenuItem();
			this.موجودیکالاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CircularKala = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.PointOrder = new System.Windows.Forms.ToolStripMenuItem();
			this.NzAllCircular = new System.Windows.Forms.ToolStripMenuItem();
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
            this.InitialStock,
            this.toolStripSeparator2,
            this.NzWaste,
            this.NzConsum,
            this.NzResid,
            this.NzHavale,
            this.NzEnteqalAnbarHa,
            this.toolStripSeparator1,
            this.NzListResidHavale});
			this.StorageMenu.Font = new System.Drawing.Font("IRANSans(Small) Medium", 15F);
			this.StorageMenu.Image = ((System.Drawing.Image)(resources.GetObject("StorageMenu.Image")));
			this.StorageMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.StorageMenu.Name = "StorageMenu";
			this.StorageMenu.Size = new System.Drawing.Size(59, 28);
			this.StorageMenu.Text = "انبار";
			// 
			// InitialStock
			// 
			this.InitialStock.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.InitialStock.Image = ((System.Drawing.Image)(resources.GetObject("InitialStock.Image")));
			this.InitialStock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.InitialStock.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.InitialStock.Name = "InitialStock";
			this.InitialStock.Size = new System.Drawing.Size(214, 28);
			this.InitialStock.Text = " ثـبت موجودی اولیه کالا";
			this.InitialStock.Click += new System.EventHandler(this.InitialStock_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(211, 6);
			// 
			// NzWaste
			// 
			this.NzWaste.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzWaste.Image = ((System.Drawing.Image)(resources.GetObject("NzWaste.Image")));
			this.NzWaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.NzWaste.Name = "NzWaste";
			this.NzWaste.Padding = new System.Windows.Forms.Padding(0);
			this.NzWaste.Size = new System.Drawing.Size(214, 26);
			this.NzWaste.Text = "حواله ضایعات کالا";
			this.NzWaste.Click += new System.EventHandler(this.NzWaste_Click);
			// 
			// NzConsum
			// 
			this.NzConsum.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzConsum.Name = "NzConsum";
			this.NzConsum.Padding = new System.Windows.Forms.Padding(0);
			this.NzConsum.Size = new System.Drawing.Size(214, 26);
			this.NzConsum.Text = "حواله مصرف کالا";
			this.NzConsum.Click += new System.EventHandler(this.NzConsum_Click);
			// 
			// NzResid
			// 
			this.NzResid.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NzResid.Image = ((System.Drawing.Image)(resources.GetObject("NzResid.Image")));
			this.NzResid.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.NzResid.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.NzResid.Name = "NzResid";
			this.NzResid.Size = new System.Drawing.Size(214, 28);
			this.NzResid.Text = "رسیـد ورود کالا";
			this.NzResid.Click += new System.EventHandler(this.NzResid_Click);
			// 
			// NzHavale
			// 
			this.NzHavale.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NzHavale.Image = ((System.Drawing.Image)(resources.GetObject("NzHavale.Image")));
			this.NzHavale.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.NzHavale.Name = "NzHavale";
			this.NzHavale.Size = new System.Drawing.Size(214, 28);
			this.NzHavale.Text = "حواله خـروج کالا";
			this.NzHavale.Click += new System.EventHandler(this.NzHavale_Click);
			// 
			// NzEnteqalAnbarHa
			// 
			this.NzEnteqalAnbarHa.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
			this.NzEnteqalAnbarHa.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.NzEnteqalAnbarHa.Name = "NzEnteqalAnbarHa";
			this.NzEnteqalAnbarHa.Size = new System.Drawing.Size(214, 28);
			this.NzEnteqalAnbarHa.Text = "نقل و انتقال بین انبـارها";
			this.NzEnteqalAnbarHa.Click += new System.EventHandler(this.NzEnteqalAnbarHa_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
			// 
			// NzListResidHavale
			// 
			this.NzListResidHavale.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
			this.NzListResidHavale.Image = ((System.Drawing.Image)(resources.GetObject("NzListResidHavale.Image")));
			this.NzListResidHavale.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.NzListResidHavale.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.NzListResidHavale.Name = "NzListResidHavale";
			this.NzListResidHavale.Size = new System.Drawing.Size(214, 28);
			this.NzListResidHavale.Text = "لیسـت حـواله و رسیـدها";
			this.NzListResidHavale.Click += new System.EventHandler(this.NzListHavale_Click);
			// 
			// NzReport
			// 
			this.NzReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NzObjectCircular,
            this.NzAnalyze,
            this.موجودیکالاToolStripMenuItem,
            this.CircularKala,
            this.toolStripSeparator3,
            this.PointOrder,
            this.NzAllCircular});
			this.NzReport.Font = new System.Drawing.Font("IRANSans(Small) Medium", 15F);
			this.NzReport.Image = ((System.Drawing.Image)(resources.GetObject("NzReport.Image")));
			this.NzReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.NzReport.Name = "NzReport";
			this.NzReport.Size = new System.Drawing.Size(96, 28);
			this.NzReport.Text = "گـزارشـات";
			// 
			// NzObjectCircular
			// 
			this.NzObjectCircular.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzObjectCircular.Name = "NzObjectCircular";
			this.NzObjectCircular.Size = new System.Drawing.Size(266, 28);
			this.NzObjectCircular.Text = "گـردش کالا/خدمات خـاص";
			this.NzObjectCircular.Click += new System.EventHandler(this.NzObjectCircular_Click);
			// 
			// NzAnalyze
			// 
			this.NzAnalyze.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzAnalyze.Name = "NzAnalyze";
			this.NzAnalyze.Size = new System.Drawing.Size(266, 28);
			this.NzAnalyze.Text = "تحلـیل انبـارهـا";
			this.NzAnalyze.Click += new System.EventHandler(this.NzAnalyze_Click);
			// 
			// موجودیکالاToolStripMenuItem
			// 
			this.موجودیکالاToolStripMenuItem.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.موجودیکالاToolStripMenuItem.Name = "موجودیکالاToolStripMenuItem";
			this.موجودیکالاToolStripMenuItem.Size = new System.Drawing.Size(266, 28);
			this.موجودیکالاToolStripMenuItem.Text = "موجودی کالا";
			this.موجودیکالاToolStripMenuItem.Click += new System.EventHandler(this.موجودیکالاToolStripMenuItem_Click);
			// 
			// CircularKala
			// 
			this.CircularKala.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.CircularKala.Name = "CircularKala";
			this.CircularKala.Size = new System.Drawing.Size(266, 28);
			this.CircularKala.Text = "گردش کلیه کالا/خدمات ";
			this.CircularKala.Click += new System.EventHandler(this.CircularKala_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(263, 6);
			// 
			// PointOrder
			// 
			this.PointOrder.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.PointOrder.Name = "PointOrder";
			this.PointOrder.Size = new System.Drawing.Size(266, 28);
			this.PointOrder.Text = "گزارش نقطه سفارش کالا";
			this.PointOrder.Click += new System.EventHandler(this.PointOrder_Click);
			// 
			// NzAllCircular
			// 
			this.NzAllCircular.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzAllCircular.Name = "NzAllCircular";
			this.NzAllCircular.Size = new System.Drawing.Size(266, 28);
			this.NzAllCircular.Text = "گزارش جامع ریز گردش کالا/خدمات";
			this.NzAllCircular.Click += new System.EventHandler(this.NzAllCircular_Click);
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
        private System.Windows.Forms.ToolStripMenuItem NzResid;
        private System.Windows.Forms.ToolStripMenuItem NzHavale;
        private System.Windows.Forms.ToolStripMenuItem NzListResidHavale;
        public System.Windows.Forms.ToolStripMenuItem NzReport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem NzEnteqalAnbarHa;
		private System.Windows.Forms.ToolStripMenuItem InitialStock;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem NzWaste;
		private System.Windows.Forms.ToolStripMenuItem NzConsum;
		private System.Windows.Forms.ToolStripMenuItem NzObjectCircular;
		private System.Windows.Forms.ToolStripMenuItem NzAnalyze;
		private System.Windows.Forms.ToolStripMenuItem موجودیکالاToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CircularKala;
		private System.Windows.Forms.ToolStripMenuItem PointOrder;
		private System.Windows.Forms.ToolStripMenuItem NzAllCircular;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
	}
}
