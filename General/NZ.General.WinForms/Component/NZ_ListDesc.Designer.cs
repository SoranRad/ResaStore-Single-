namespace NZ.General.WinForms.Component
{
    partial class NZ_ListDesc
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
            Janus.Windows.GridEX.GridEXLayout ms_grid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NZ_ListDesc));
            ((System.ComponentModel.ISupportInitialize)(this.ms_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_grid
            // 
            this.ms_grid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.PowderBlue;
            ms_grid_DesignTimeLayout.LayoutString = resources.GetString("ms_grid_DesignTimeLayout.LayoutString");
            this.ms_grid.DesignTimeLayout = ms_grid_DesignTimeLayout;
            this.ms_grid.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ms_grid.Font = new System.Drawing.Font("IRANSans(Small)", 11F);
            this.ms_grid.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ms_grid.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.ms_grid.LinkFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.ms_grid.RowHeaderFormatStyle.Font = new System.Drawing.Font("B Yekan", 9.5F, System.Drawing.FontStyle.Italic);
            this.ms_grid.RowHeaderFormatStyle.FontItalic = Janus.Windows.GridEX.TriState.True;
            this.ms_grid.RowHeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ms_grid.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ms_grid.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.ms_grid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ms_grid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // NZ_ListDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.Name = "NZ_ListDesc";
            ((System.ComponentModel.ISupportInitialize)(this.ms_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
