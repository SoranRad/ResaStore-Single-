
namespace Nz.Anbar.WinForms.Component
{
    partial class NzLocationEx
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
            this.NzList = new Nz.Anbar.WinForms.Component.NzListLocation();
            this.SuspendLayout();
            // 
            // NzList
            // 
            this.NzList.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NzList.Location = new System.Drawing.Point(0, 0);
            this.NzList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NzList.Name = "NzList";
            this.NzList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzList.Size = new System.Drawing.Size(270, 150);
            this.NzList.TabIndex = 0;
            this.ResumeLayout(false);

        }

        #endregion

        private NzListLocation NzList;
    }
}
