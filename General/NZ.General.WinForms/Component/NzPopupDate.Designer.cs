namespace NZ.General.WinForms.Component
{
    partial class NzPopupDate
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
            this.NzGrid = new MS_Control.Tarikh.MS_Tatikh_View();
            this.SuspendLayout();
            // 
            // NzGrid
            // 
            this.NzGrid.BackColor = System.Drawing.Color.White;
            this.NzGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NzGrid.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzGrid.Location = new System.Drawing.Point(163, 366);
            this.NzGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NzGrid.Name = "NzGrid";
            this.NzGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzGrid.Size = new System.Drawing.Size(208, 252);
            this.NzGrid.TabIndex = 843;
            this.NzGrid.MS_On_OK_Clicked += new MS_Control.Tarikh.MS_Tatikh_View.MS_On_Button_Click(this.NzGrid_OKClicked);
            this.NzGrid.MS_On_Cancel_Clicked += new MS_Control.Tarikh.MS_Tatikh_View.MS_On_Button_Click(this.NzGrid_CancelClicked);
            this.ResumeLayout(false);

        }

        #endregion

        private MS_Control.Tarikh.MS_Tatikh_View NzGrid;
    }
}
