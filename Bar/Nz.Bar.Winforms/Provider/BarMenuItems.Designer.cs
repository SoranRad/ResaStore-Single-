
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
            this.NzXarid = new System.Windows.Forms.ToolStripMenuItem();
            this.NzFrosh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NzListFactor = new System.Windows.Forms.ToolStripMenuItem();
            this.NzReport = new System.Windows.Forms.ToolStripMenuItem();
            this.NzRizTarakonesh = new System.Windows.Forms.ToolStripMenuItem();
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
            this.NzXarid,
            this.NzFrosh,
            this.toolStripSeparator1,
            this.NzListFactor});
            this.StorageMenu.Font = new System.Drawing.Font("IRANSans(Small) Medium", 15F);
            this.StorageMenu.Image = ((System.Drawing.Image)(resources.GetObject("StorageMenu.Image")));
            this.StorageMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.StorageMenu.Name = "StorageMenu";
            this.StorageMenu.Size = new System.Drawing.Size(151, 28);
            this.StorageMenu.Text = "میکس و بسته بندی";
            // 
            // NzXarid
            // 
            this.NzXarid.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
            this.NzXarid.Image = ((System.Drawing.Image)(resources.GetObject("NzXarid.Image")));
            this.NzXarid.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NzXarid.Name = "NzXarid";
            this.NzXarid.Size = new System.Drawing.Size(204, 28);
            this.NzXarid.Text = "ارسال به خط تولید";
            this.NzXarid.Click += new System.EventHandler(this.NzXarid_Click);
            // 
            // NzFrosh
            // 
            this.NzFrosh.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
            this.NzFrosh.Image = ((System.Drawing.Image)(resources.GetObject("NzFrosh.Image")));
            this.NzFrosh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NzFrosh.Name = "NzFrosh";
            this.NzFrosh.Size = new System.Drawing.Size(204, 28);
            this.NzFrosh.Text = "دریافت از خط تولید";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // NzListFactor
            // 
            this.NzListFactor.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
            this.NzListFactor.Image = ((System.Drawing.Image)(resources.GetObject("NzListFactor.Image")));
            this.NzListFactor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NzListFactor.Name = "NzListFactor";
            this.NzListFactor.Size = new System.Drawing.Size(204, 28);
            this.NzListFactor.Text = "لیسـت خواله و رسیدها";
            this.NzListFactor.Click += new System.EventHandler(this.NzListFactor_Click);
            // 
            // NzReport
            // 
            this.NzReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NzRizTarakonesh});
            this.NzReport.Font = new System.Drawing.Font("IRANSans(Small) Medium", 15F);
            this.NzReport.Image = ((System.Drawing.Image)(resources.GetObject("NzReport.Image")));
            this.NzReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NzReport.Name = "NzReport";
            this.NzReport.Size = new System.Drawing.Size(96, 28);
            this.NzReport.Text = "گـزارشـات";
            // 
            // NzRizTarakonesh
            // 
            this.NzRizTarakonesh.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
            this.NzRizTarakonesh.Image = ((System.Drawing.Image)(resources.GetObject("NzRizTarakonesh.Image")));
            this.NzRizTarakonesh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NzRizTarakonesh.Name = "NzRizTarakonesh";
            this.NzRizTarakonesh.Size = new System.Drawing.Size(187, 28);
            this.NzRizTarakonesh.Text = "ریز بارهای  اشخاص ";
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
        private System.Windows.Forms.ToolStripMenuItem NzXarid;
        private System.Windows.Forms.ToolStripMenuItem NzFrosh;
        private System.Windows.Forms.ToolStripMenuItem NzListFactor;
        public System.Windows.Forms.ToolStripMenuItem NzReport;
        private System.Windows.Forms.ToolStripMenuItem NzRizTarakonesh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
