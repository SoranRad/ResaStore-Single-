namespace NZ.Xazane.WinForms.Component
{
    partial class NzAccontPopup
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
            Janus.Windows.GridEX.GridEXLayout NzGrid_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NzAccontPopup));
            Janus.Windows.GridEX.GridEXLayout NzGrid_Layout_1 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout NzGrid_Layout_2 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout NzGrid_Layout_3 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout NzGrid_Layout_4 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout NzGrid_Layout_5 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout NzGrid_Layout_6 = new Janus.Windows.GridEX.GridEXLayout();
            this.NzGrid = new MS_Control.Controls.MS_GridX();
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NzGrid
            // 
            this.NzGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.NzGrid.AlternatingColors = true;
            this.NzGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.LightBlue;
            this.NzGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NzGrid.ColumnAutoResize = true;
            this.NzGrid.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NzGrid.GroupByBoxVisible = false;
            this.NzGrid.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            NzGrid_Layout_0.Description = "صندوق";
            NzGrid_Layout_0.Key = "Cache";
            NzGrid_Layout_0.LayoutString = resources.GetString("NzGrid_Layout_0.LayoutString");
            NzGrid_Layout_1.Description = "هزینه و درآمد";
            NzGrid_Layout_1.Key = "IncomeCost";
            NzGrid_Layout_1.LayoutString = resources.GetString("NzGrid_Layout_1.LayoutString");
            NzGrid_Layout_2.Description = "تنخواه گردان";
            NzGrid_Layout_2.Key = "Deficit";
            NzGrid_Layout_2.LayoutString = resources.GetString("NzGrid_Layout_2.LayoutString");
            NzGrid_Layout_3.Description = "صندوق";
            NzGrid_Layout_3.IsCurrentLayout = true;
            NzGrid_Layout_3.Key = "BankAccount";
            NzGrid_Layout_3.LayoutString = resources.GetString("NzGrid_Layout_3.LayoutString");
            NzGrid_Layout_4.Description = "هزینه";
            NzGrid_Layout_4.Key = "Cost";
            NzGrid_Layout_4.LayoutString = resources.GetString("NzGrid_Layout_4.LayoutString");
            NzGrid_Layout_5.Description = "تنخواه گردان";
            NzGrid_Layout_5.Key = "Fund";
            NzGrid_Layout_5.LayoutString = resources.GetString("NzGrid_Layout_5.LayoutString");
            NzGrid_Layout_6.Description = "صندوق";
            NzGrid_Layout_6.Key = "Addition";
            NzGrid_Layout_6.LayoutString = resources.GetString("NzGrid_Layout_6.LayoutString");
            this.NzGrid.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            NzGrid_Layout_0,
            NzGrid_Layout_1,
            NzGrid_Layout_2,
            NzGrid_Layout_3,
            NzGrid_Layout_4,
            NzGrid_Layout_5,
            NzGrid_Layout_6});
            this.NzGrid.Location = new System.Drawing.Point(0, 0);
            this.NzGrid.Name = "NzGrid";
            this.NzGrid.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
            this.NzGrid.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
            this.NzGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzGrid.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NzGrid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NzGrid.Size = new System.Drawing.Size(400, 376);
            this.NzGrid.TabIndex = 0;
            this.NzGrid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.NzGrid.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.NzGrid_RowDoubleClick);
            this.NzGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NzGrid_KeyPress);
            // 
            // NzAccontPopup
            // 
            this.Font = new System.Drawing.Font("IRANSans(Small)", 12F);
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MS_Control.Controls.MS_GridX NzGrid;
    }
}
