namespace NZ.Xazane.WinForms.Component
{
	partial class NsPeopleChequePopup
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
			this.NsList = new NZ.Xazane.WinForms.Component.NsPeopleChequeList();
			this.SuspendLayout();
			// 
			// NsList
			// 
			this.NsList.Font = new System.Drawing.Font("IRANSans(Small)", 12F);
			this.NsList.Location = new System.Drawing.Point(0, 0);
			this.NsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NsList.Name = "NsList";
			this.NsList.Popup = null;
			this.NsList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsList.Size = new System.Drawing.Size(823, 288);
			this.NsList.TabIndex = 0;
			this.NsList.MS_On_Row_Selected += new MS_Control.TSDD.Row_Seleced(this.NzList_Selected);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private NsPeopleChequeList NsList;
	}
}
