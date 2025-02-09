namespace NZ.Xazane.WinForms.Component
{
    partial class NzAccounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            //if (disposing && (components != null))
            //{
            //    components.Dispose();
            //}
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NzList = new NZ.Xazane.WinForms.Component.NzListAccount();
            this.SuspendLayout();
            // 
            // NzList
            // 
            this.NzList.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.NzList.Location = new System.Drawing.Point(0, 0);
            this.NzList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NzList.Name = "NzList";
            this.NzList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzList.Size = new System.Drawing.Size(400, 220);
            this.NzList.TabIndex = 0;
            this.NzList.MS_On_Row_Selected += new MS_Control.TSDD.Row_Seleced(this.NzList_Selected);
            // 
            // NzAccounts
            // 
            this.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.Office2007CustomColor = System.Drawing.Color.SkyBlue;
            this.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NzListAccount NzList;
    }
}
