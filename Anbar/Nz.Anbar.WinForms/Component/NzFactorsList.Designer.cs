
namespace Nz.Anbar.WinForms.Component
{
    partial class NzFactorsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NzFactorsList));
            ((System.ComponentModel.ISupportInitialize)(this.ms_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_grid
            // 
            this.ms_grid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.PowderBlue;
            this.ms_grid.ColumnAutoResize = false;
            ms_grid_DesignTimeLayout.LayoutString = resources.GetString("ms_grid_DesignTimeLayout.LayoutString");
            this.ms_grid.DesignTimeLayout = ms_grid_DesignTimeLayout;
            this.ms_grid.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ms_grid.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.ms_grid.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ms_grid.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.ms_grid.LinkFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.ms_grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ms_grid.RowHeaderFormatStyle.Font = new System.Drawing.Font("B Yekan", 9.5F, System.Drawing.FontStyle.Italic);
            this.ms_grid.RowHeaderFormatStyle.FontItalic = Janus.Windows.GridEX.TriState.True;
            this.ms_grid.RowHeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ms_grid.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ms_grid.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.ms_grid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ms_grid.Size = new System.Drawing.Size(411, 171);
            this.ms_grid.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.ms_grid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // NzFactorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "NzFactorsList";
            this.Size = new System.Drawing.Size(411, 196);
            ((System.ComponentModel.ISupportInitialize)(this.ms_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
