namespace Nz.Order.Winforms.Provider
{
	partial class OrderMenuItems
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderMenuItems));
			this.mS_Menu1 = new MS_Control.Controls.MS_Menu();
			this.ms_baseinfo = new System.Windows.Forms.ToolStripMenuItem();
			this.StorageMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.NsCategories = new System.Windows.Forms.ToolStripMenuItem();
			this.NsProducts = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.NsListOrders = new System.Windows.Forms.ToolStripMenuItem();
			this.NzReport = new System.Windows.Forms.ToolStripMenuItem();
			this.NsTest = new System.Windows.Forms.ToolStripMenuItem();
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
			this.mS_Menu1.Size = new System.Drawing.Size(738, 32);
			this.mS_Menu1.TabIndex = 6;
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
            this.NsCategories,
            this.NsProducts,
            this.toolStripSeparator2,
            this.NsListOrders,
            this.NsTest});
			this.StorageMenu.Font = new System.Drawing.Font("IRANSans(Small) Medium", 15F);
			this.StorageMenu.Image = ((System.Drawing.Image)(resources.GetObject("StorageMenu.Image")));
			this.StorageMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.StorageMenu.Name = "StorageMenu";
			this.StorageMenu.Size = new System.Drawing.Size(91, 28);
			this.StorageMenu.Text = "سفارشات";
			// 
			// NsCategories
			// 
			this.NsCategories.Name = "NsCategories";
			this.NsCategories.Size = new System.Drawing.Size(213, 30);
			this.NsCategories.Text = "گروه کالا";
			this.NsCategories.Click += new System.EventHandler(this.NsCategories_Click);
			// 
			// NsProducts
			// 
			this.NsProducts.Name = "NsProducts";
			this.NsProducts.Size = new System.Drawing.Size(213, 30);
			this.NsProducts.Text = "کالا و خدمات";
			this.NsProducts.Click += new System.EventHandler(this.NsProducts_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
			// 
			// NsListOrders
			// 
			this.NsListOrders.Name = "NsListOrders";
			this.NsListOrders.Size = new System.Drawing.Size(213, 30);
			this.NsListOrders.Text = "لیست سفارشات سامانه";
			this.NsListOrders.Click += new System.EventHandler(this.NsListOrders_Click);
			// 
			// NzReport
			// 
			this.NzReport.Font = new System.Drawing.Font("IRANSans(Small) Medium", 15F);
			this.NzReport.Image = ((System.Drawing.Image)(resources.GetObject("NzReport.Image")));
			this.NzReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.NzReport.Name = "NzReport";
			this.NzReport.Size = new System.Drawing.Size(96, 28);
			this.NzReport.Text = "گـزارشـات";
			// 
			// NsTest
			// 
			this.NsTest.Name = "NsTest";
			this.NsTest.Size = new System.Drawing.Size(213, 30);
			this.NsTest.Text = "آزمایش سامانه ";
			this.NsTest.Click += new System.EventHandler(this.NsTest_Click);
			// 
			// OrderMenuItems
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.mS_Menu1);
			this.Name = "OrderMenuItems";
			this.Size = new System.Drawing.Size(738, 336);
			this.mS_Menu1.ResumeLayout(false);
			this.mS_Menu1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		public MS_Control.Controls.MS_Menu mS_Menu1;
		public System.Windows.Forms.ToolStripMenuItem ms_baseinfo;
		public System.Windows.Forms.ToolStripMenuItem StorageMenu;
		private System.Windows.Forms.ToolStripMenuItem NsCategories;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem NsProducts;
		private System.Windows.Forms.ToolStripMenuItem NsListOrders;
		public System.Windows.Forms.ToolStripMenuItem NzReport;
		private System.Windows.Forms.ToolStripMenuItem NsTest;
	}
}
