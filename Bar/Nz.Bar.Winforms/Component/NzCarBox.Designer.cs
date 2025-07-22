namespace Nz.Bar.Winforms.Component
{
	partial class NzCarBox
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
			this.NsGrid = new Nz.Bar.Winforms.Component.NzCarGrid();
			this.SuspendLayout();
			// 
			// NsGrid
			// 
			this.NsGrid.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NsGrid.Location = new System.Drawing.Point(0, 0);
			this.NsGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NsGrid.Name = "NsGrid";
			this.NsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsGrid.Size = new System.Drawing.Size(378, 316);
			this.NsGrid.TabIndex = 0;
			this.NsGrid.MS_On_Row_Selected += new MS_Control.TSDD.Row_Seleced(this.NzList_Selected);
			this.ResumeLayout(false);

		}

		#endregion

		private NzCarGrid NsGrid;
	}
}
