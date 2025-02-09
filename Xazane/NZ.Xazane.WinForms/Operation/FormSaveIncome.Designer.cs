using NZ.Xazane.WinForms.Component;

namespace NZ.Xazane.WinForms.Operation
{
    partial class FormSaveIncome
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
            this.nzAccounts3 = new NZ.Xazane.WinForms.Component.NzAccounts();
            this.nzAccounts1 = new NZ.Xazane.WinForms.Component.NzAccounts();
            this.nzAccount4 = new NZ.Xazane.WinForms.Component.NzAccounts();
            this.nzAccounts2 = new NZ.Xazane.WinForms.Component.NzAccounts();
            this.SuspendLayout();
            // 
            // nzAccounts3
            // 
            this.nzAccounts3.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
            this.nzAccounts3.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.nzAccounts3.Location = new System.Drawing.Point(74, 13);
            this.nzAccounts3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nzAccounts3.Name = "nzAccounts3";
            this.nzAccounts3.Office2007CustomColor = System.Drawing.Color.SkyBlue;
            this.nzAccounts3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nzAccounts3.Size = new System.Drawing.Size(288, 29);
            this.nzAccounts3.TabIndex = 3;
            this.nzAccounts3.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nzAccounts1
            // 
            this.nzAccounts1.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
            this.nzAccounts1.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.nzAccounts1.Location = new System.Drawing.Point(201, 294);
            this.nzAccounts1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nzAccounts1.Name = "nzAccounts1";
            this.nzAccounts1.Office2007CustomColor = System.Drawing.Color.SkyBlue;
            this.nzAccounts1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nzAccounts1.Size = new System.Drawing.Size(288, 29);
            this.nzAccounts1.TabIndex = 4;
            this.nzAccounts1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nzAccount4
            // 
            this.nzAccount4.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
            this.nzAccount4.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.nzAccount4.Location = new System.Drawing.Point(201, 191);
            this.nzAccount4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nzAccount4.Name = "nzAccount4";
            this.nzAccount4.Office2007CustomColor = System.Drawing.Color.SkyBlue;
            this.nzAccount4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nzAccount4.Size = new System.Drawing.Size(288, 29);
            this.nzAccount4.TabIndex = 3;
            this.nzAccount4.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nzAccounts2
            // 
            this.nzAccounts2.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
            this.nzAccounts2.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.nzAccounts2.Location = new System.Drawing.Point(148, 296);
            this.nzAccounts2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nzAccounts2.Name = "nzAccounts2";
            this.nzAccounts2.Office2007CustomColor = System.Drawing.Color.SkyBlue;
            this.nzAccounts2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nzAccounts2.Size = new System.Drawing.Size(288, 29);
            this.nzAccounts2.TabIndex = 5;
            this.nzAccounts2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // FormSaveIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 374);
            this.Controls.Add(this.nzAccounts2);
            this.Controls.Add(this.nzAccounts1);
            this.Controls.Add(this.nzAccounts3);
            this.Controls.Add(this.nzAccount4);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "FormSaveIncome";
            this.Text = "FormIncomeCost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NzAccounts nzAccounts3;
        private NzAccounts nzAccounts1;
        private NzAccounts nzAccount4;
        private NzAccounts nzAccounts2;
    }
}