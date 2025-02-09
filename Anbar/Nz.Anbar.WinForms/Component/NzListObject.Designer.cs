namespace Nz.Anbar.WinForms.Component
{
    partial class NzListObject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NzListObject));
            ((System.ComponentModel.ISupportInitialize)(this.ms_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_grid
            // 
            this.ms_grid.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
            this.ms_grid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ms_grid.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
            this.ms_grid.ColumnAutoResize = false;
            this.ms_grid.DefaultForeColorAlphaMode = Janus.Windows.GridEX.AlphaMode.Empty;
            ms_grid_DesignTimeLayout.LayoutString = resources.GetString("ms_grid_DesignTimeLayout.LayoutString");
            this.ms_grid.DesignTimeLayout = ms_grid_DesignTimeLayout;
            this.ms_grid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.ms_grid.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ms_grid.FocusStyle = Janus.Windows.GridEX.FocusStyle.None;
            this.ms_grid.Font = new System.Drawing.Font("IRANSans(Small)", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_grid.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.SmallDots;
            this.ms_grid.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ms_grid.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.ms_grid.LinkFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.ms_grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ms_grid.RowHeaderFormatStyle.Font = new System.Drawing.Font("B Yekan", 9.5F, System.Drawing.FontStyle.Italic);
            this.ms_grid.RowHeaderFormatStyle.FontItalic = Janus.Windows.GridEX.TriState.True;
            this.ms_grid.RowHeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ms_grid.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ms_grid.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.ms_grid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ms_grid.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
            this.ms_grid.Size = new System.Drawing.Size(558, 247);
            this.ms_grid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // NzListObject
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Font = new System.Drawing.Font("IRANSans", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "NzListObject";
            this.Size = new System.Drawing.Size(528, 272);
            ((System.ComponentModel.ISupportInitialize)(this.ms_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
