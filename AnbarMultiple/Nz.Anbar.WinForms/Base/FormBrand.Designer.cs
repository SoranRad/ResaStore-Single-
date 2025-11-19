
namespace Nz.Anbar.WinForms.Base
{
    partial class FormBrand
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBrand));
            Janus.Windows.GridEX.GridEXLayout NzGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_DesignTimeLayout_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_DesignTimeLayout_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.HeaderImage");
            this.NzGrid = new MS_Control.Controls.MS_GridX();
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NzGrid
            // 
            this.NzGrid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGrid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGrid.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGrid.AlternatingColors = true;
            this.NzGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.NzGrid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzGrid.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.NzGrid.BuiltInTextsData = resources.GetString("NzGrid.BuiltInTextsData");
            this.NzGrid.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell;
            this.NzGrid.ColumnAutoResize = true;
            this.NzGrid.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
            this.NzGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NzGrid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            NzGrid_DesignTimeLayout_Reference_0.Instance = ((object)(resources.GetObject("NzGrid_DesignTimeLayout_Reference_0.Instance")));
            NzGrid_DesignTimeLayout_Reference_1.Instance = ((object)(resources.GetObject("NzGrid_DesignTimeLayout_Reference_1.Instance")));
            NzGrid_DesignTimeLayout.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            NzGrid_DesignTimeLayout_Reference_0,
            NzGrid_DesignTimeLayout_Reference_1});
            NzGrid_DesignTimeLayout.LayoutString = resources.GetString("NzGrid_DesignTimeLayout.LayoutString");
            this.NzGrid.DesignTimeLayout = NzGrid_DesignTimeLayout;
            this.NzGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NzGrid.DynamicFiltering = true;
            this.NzGrid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell;
            this.NzGrid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.NzGrid.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.NzGrid.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGrid.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.NzGrid.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
            this.NzGrid.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
            this.NzGrid.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.NzGrid.FrozenColumns = 2;
            this.NzGrid.GridLineColor = System.Drawing.Color.Black;
            this.NzGrid.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
            this.NzGrid.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.NzGrid.GroupByBoxVisible = false;
            this.NzGrid.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NzGrid.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.NzGrid.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.NzGrid.Location = new System.Drawing.Point(0, 0);
            this.NzGrid.Name = "NzGrid";
            this.NzGrid.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            this.NzGrid.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
            this.NzGrid.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
            this.NzGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzGrid.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.NzGrid.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NzGrid.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.NzGrid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.White;
            this.NzGrid.SelectOnExpand = false;
            this.NzGrid.Size = new System.Drawing.Size(420, 417);
            this.NzGrid.TabIndex = 730;
            this.NzGrid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGrid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.NzGrid.TreeLineColor = System.Drawing.Color.Black;
            this.NzGrid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            this.NzGrid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.NzGrid.CellUpdated += new Janus.Windows.GridEX.ColumnActionEventHandler(this.NzGrid_CellUpdated);
            this.NzGrid.AddingRecord += new System.ComponentModel.CancelEventHandler(this.NzGrid_AddingRecord);
            this.NzGrid.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.mS_GridX1_ColumnButtonClick);
            // 
            // FormBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 417);
            this.Controls.Add(this.NzGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBrand";
            this.Text = "تعریف برنـدهای کالا/خدمات";
            this.Load += new System.EventHandler(this.FormBrand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MS_Control.Controls.MS_GridX NzGrid;
    }
}