namespace NZ.Xazane.WinForms.Component
{
    partial class NzListAccount
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
            Janus.Windows.GridEX.GridEXLayout ms_grid_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NzListAccount));
            Janus.Windows.GridEX.GridEXLayout ms_grid_Layout_1 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout ms_grid_Layout_2 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout ms_grid_Layout_3 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout ms_grid_Layout_4 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout ms_grid_Layout_5 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout ms_grid_Layout_6 = new Janus.Windows.GridEX.GridEXLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ms_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_grid
            // 
            this.ms_grid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.LightCyan;
            this.ms_grid.BackColor = System.Drawing.SystemColors.Window;
            this.ms_grid.BorderStyle = Janus.Windows.GridEX.BorderStyle.SunkenLight3D;
            this.ms_grid.BuiltInTextsData = "";
            this.ms_grid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Default;
            this.ms_grid.DefaultForeColorAlphaMode = Janus.Windows.GridEX.AlphaMode.Empty;
            this.ms_grid.DesignTimeLayout = null;
            this.ms_grid.DynamicFiltering = false;
            this.ms_grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextRow;
            this.ms_grid.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ClearButton;
            this.ms_grid.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.Default;
            this.ms_grid.FocusStyle = Janus.Windows.GridEX.FocusStyle.Dotted;
            this.ms_grid.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.ms_grid.GridLineColor = System.Drawing.SystemColors.ControlDark;
            this.ms_grid.GridLines = Janus.Windows.GridEX.GridLines.Both;
            this.ms_grid.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.SmallDots;
            ms_grid_Layout_0.Description = "صندوق";
            ms_grid_Layout_0.Key = "Cache";
            ms_grid_Layout_0.LayoutString = resources.GetString("ms_grid_Layout_0.LayoutString");
            ms_grid_Layout_1.Description = "هزینه و درآمد";
            ms_grid_Layout_1.Key = "Income";
            ms_grid_Layout_1.LayoutString = resources.GetString("ms_grid_Layout_1.LayoutString");
            ms_grid_Layout_2.Description = "تنخواه گردان";
            ms_grid_Layout_2.Key = "Deficit";
            ms_grid_Layout_2.LayoutString = resources.GetString("ms_grid_Layout_2.LayoutString");
            ms_grid_Layout_3.Description = "صندوق";
            ms_grid_Layout_3.Key = "BankAccount";
            ms_grid_Layout_3.LayoutString = resources.GetString("ms_grid_Layout_3.LayoutString");
            ms_grid_Layout_4.Description = "هزینه";
            ms_grid_Layout_4.Key = "Cost";
            ms_grid_Layout_4.LayoutString = resources.GetString("ms_grid_Layout_4.LayoutString");
            ms_grid_Layout_5.Description = "تنخواه گردان";
            ms_grid_Layout_5.Key = "Fund";
            ms_grid_Layout_5.LayoutString = resources.GetString("ms_grid_Layout_5.LayoutString");
            ms_grid_Layout_6.Description = "صندوق";
            ms_grid_Layout_6.IsCurrentLayout = true;
            ms_grid_Layout_6.Key = "Addition";
            ms_grid_Layout_6.LayoutString = resources.GetString("ms_grid_Layout_6.LayoutString");
            this.ms_grid.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            ms_grid_Layout_0,
            ms_grid_Layout_1,
            ms_grid_Layout_2,
            ms_grid_Layout_3,
            ms_grid_Layout_4,
            ms_grid_Layout_5,
            ms_grid_Layout_6});
            this.ms_grid.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowHeaderText;
            this.ms_grid.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ms_grid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ms_grid.SelectOnExpand = true;
            this.ms_grid.Size = new System.Drawing.Size(456, 291);
            this.ms_grid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomScrollable;
            this.ms_grid.TreeLineColor = System.Drawing.SystemColors.ControlDark;
            // 
            // NzListAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.Name = "NzListAccount";
            this.Size = new System.Drawing.Size(456, 316);
            ((System.ComponentModel.ISupportInitialize)(this.ms_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
