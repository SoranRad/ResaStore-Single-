namespace Nz.Machine.Winforms.Provider
{
    partial class MachineMenuBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MachineMenuBar));
            this.mS_Menu1 = new MS_Control.Controls.MS_Menu();
            this.ms_baseinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MachineMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NzNewMachine = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NzListMachine = new System.Windows.Forms.ToolStripMenuItem();
            this.NzReport = new System.Windows.Forms.ToolStripMenuItem();
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
            this.MachineMenu,
            this.NzReport});
            this.mS_Menu1.Location = new System.Drawing.Point(0, 0);
            this.mS_Menu1.MS_BorderColor = System.Drawing.Color.DodgerBlue;
            this.mS_Menu1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Menu1.MS_Color_End = System.Drawing.Color.PowderBlue;
            this.mS_Menu1.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.mS_Menu1.Name = "mS_Menu1";
            this.mS_Menu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_Menu1.Size = new System.Drawing.Size(776, 32);
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
            // MachineMenu
            // 
            this.MachineMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NzNewMachine,
            this.toolStripSeparator1,
            this.NzListMachine});
            this.MachineMenu.Font = new System.Drawing.Font("IRANSans(Small) Medium", 15F);
            this.MachineMenu.Image = ((System.Drawing.Image)(resources.GetObject("MachineMenu.Image")));
            this.MachineMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MachineMenu.Name = "MachineMenu";
            this.MachineMenu.Size = new System.Drawing.Size(136, 28);
            this.MachineMenu.Text = "پذیرش خودرو";
            // 
            // NzNewMachine
            // 
            this.NzNewMachine.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
            this.NzNewMachine.Image = ((System.Drawing.Image)(resources.GetObject("NzNewMachine.Image")));
            this.NzNewMachine.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NzNewMachine.Name = "NzNewMachine";
            this.NzNewMachine.Size = new System.Drawing.Size(253, 28);
            this.NzNewMachine.Text = "پذیرش خودرو جدید";
            this.NzNewMachine.Click += new System.EventHandler(this.NzNewMachine_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(250, 6);
            // 
            // NzListMachine
            // 
            this.NzListMachine.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
            this.NzListMachine.Image = ((System.Drawing.Image)(resources.GetObject("NzListMachine.Image")));
            this.NzListMachine.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NzListMachine.Name = "NzListMachine";
            this.NzListMachine.Size = new System.Drawing.Size(253, 28);
            this.NzListMachine.Text = "لیسـت خودرو های پذیرش شده";
            this.NzListMachine.Click += new System.EventHandler(this.NzListMachine_Click);
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
            // MachineMenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mS_Menu1);
            this.Name = "MachineMenuBar";
            this.Size = new System.Drawing.Size(776, 150);
            this.mS_Menu1.ResumeLayout(false);
            this.mS_Menu1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MS_Control.Controls.MS_Menu mS_Menu1;
        public System.Windows.Forms.ToolStripMenuItem ms_baseinfo;
        public System.Windows.Forms.ToolStripMenuItem MachineMenu;
        private System.Windows.Forms.ToolStripMenuItem NzNewMachine;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem NzListMachine;
        public System.Windows.Forms.ToolStripMenuItem NzReport;
    }
}
