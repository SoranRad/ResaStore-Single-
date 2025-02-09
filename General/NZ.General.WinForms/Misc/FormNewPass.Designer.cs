namespace NZ.General.WinForms.Misc
{
    partial class FormNewPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewPass));
            this.NzSave = new MS_Control.Controls.MS_Button_GridX();
            this.grBox = new Janus.Windows.EditControls.UIGroupBox();
            this.NzPassConfirm = new MS_Control.Controls.MS_TextBox();
            this.NzPass = new MS_Control.Controls.MS_TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
            ((System.ComponentModel.ISupportInitialize)(this.grBox)).BeginInit();
            this.grBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NzSave
            // 
            this.NzSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NzSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzSave.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzSave.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzSave.Image = global::MS_Resource.GlobalResources.Negin__38_;
            this.NzSave.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzSave.Location = new System.Drawing.Point(7, 246);
            this.NzSave.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzSave.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzSave.MS_Change_Border_Color_On_Enter = false;
            this.NzSave.MS_Change_Color_On_Enter = false;
            this.NzSave.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.NzSave.MS_Enter_Color = System.Drawing.Color.Empty;
            this.NzSave.Name = "NzSave";
            this.NzSave.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzSave.Office2007CustomColor = System.Drawing.Color.LightBlue;
            this.NzSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzSave.ShowFocusRectangle = false;
            this.NzSave.Size = new System.Drawing.Size(139, 33);
            this.NzSave.TabIndex = 792;
            this.NzSave.Text = "تغییر کلمه عبور";
            this.NzSave.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.NzSave.UseThemes = false;
            this.NzSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzSave.WordWrap = false;
            this.NzSave.Click += new System.EventHandler(this.NzSave_Click);
            // 
            // grBox
            // 
            this.grBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBox.BackColor = System.Drawing.Color.Transparent;
            this.grBox.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.grBox.Controls.Add(this.NzPassConfirm);
            this.grBox.Controls.Add(this.NzPass);
            this.grBox.Controls.Add(this.label2);
            this.grBox.Controls.Add(this.label4);
            this.grBox.Font = new System.Drawing.Font("IRANSans(Small)", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grBox.Location = new System.Drawing.Point(7, 90);
            this.grBox.Name = "grBox";
            this.grBox.Size = new System.Drawing.Size(365, 143);
            this.grBox.TabIndex = 791;
            this.grBox.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.grBox.TextOffset = 0;
            // 
            // NzPassConfirm
            // 
            this.NzPassConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzPassConfirm.ButtonImage = ((System.Drawing.Image)(resources.GetObject("NzPassConfirm.ButtonImage")));
            this.NzPassConfirm.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image;
            this.NzPassConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzPassConfirm.ImageHorizontalAlignment = Janus.Windows.GridEX.ImageHorizontalAlignment.Near;
            this.NzPassConfirm.Location = new System.Drawing.Point(36, 88);
            this.NzPassConfirm.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzPassConfirm.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzPassConfirm.MS_Change_Border_Color_On_Enter = true;
            this.NzPassConfirm.MS_Change_Color_On_Enter = true;
            this.NzPassConfirm.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzPassConfirm.MS_Enter_Color = System.Drawing.Color.Yellow;
            this.NzPassConfirm.MS_Exit_By_Down = true;
            this.NzPassConfirm.MS_Exit_By_Enter = true;
            this.NzPassConfirm.MS_Exit_By_Up = true;
            this.NzPassConfirm.MS_Last_Control = this.NzPass;
            this.NzPassConfirm.MS_Next_Control = this.NzSave;
            this.NzPassConfirm.Multiline = true;
            this.NzPassConfirm.Name = "NzPassConfirm";
            this.NzPassConfirm.PasswordChar = '●';
            this.NzPassConfirm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzPassConfirm.Size = new System.Drawing.Size(185, 32);
            this.NzPassConfirm.TabIndex = 2;
            this.NzPassConfirm.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.NzPassConfirm.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzPass
            // 
            this.NzPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzPass.ButtonImage = ((System.Drawing.Image)(resources.GetObject("NzPass.ButtonImage")));
            this.NzPass.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image;
            this.NzPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzPass.ImageHorizontalAlignment = Janus.Windows.GridEX.ImageHorizontalAlignment.Near;
            this.NzPass.Location = new System.Drawing.Point(36, 32);
            this.NzPass.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzPass.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzPass.MS_Change_Border_Color_On_Enter = true;
            this.NzPass.MS_Change_Color_On_Enter = true;
            this.NzPass.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzPass.MS_Enter_Color = System.Drawing.Color.Yellow;
            this.NzPass.MS_Exit_By_Down = true;
            this.NzPass.MS_Exit_By_Enter = true;
            this.NzPass.MS_Exit_By_Up = true;
            this.NzPass.MS_Last_Control = null;
            this.NzPass.MS_Next_Control = this.NzPassConfirm;
            this.NzPass.Multiline = true;
            this.NzPass.Name = "NzPass";
            this.NzPass.PasswordChar = '●';
            this.NzPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzPass.Size = new System.Drawing.Size(185, 32);
            this.NzPass.TabIndex = 1;
            this.NzPass.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.NzPass.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(223, 89);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 78;
            this.label2.Text = "تکرار کلمه عبور :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Location = new System.Drawing.Point(223, 33);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 78;
            this.label4.Text = "کلمه عبور جدید :";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(383, 81);
            this.label1.TabIndex = 793;
            this.label1.Text = "کاربر گرامی !\r\nکلمه عبور شما ریست شده است \r\nباید کلمه عبور جدید خود را وارد کنید " +
    " تا مجددا بتوانید وارد سیستم شوید";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormNewPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 285);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NzSave);
            this.Controls.Add(this.grBox);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MS_Escap = false;
            this.Name = "FormNewPass";
            this.Text = "ورود کلمه عبور ";
            ((System.ComponentModel.ISupportInitialize)(this.grBox)).EndInit();
            this.grBox.ResumeLayout(false);
            this.grBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MS_Control.Controls.MS_Button_GridX NzSave;
        private Janus.Windows.EditControls.UIGroupBox grBox;
        private MS_Control.Controls.MS_TextBox NzPassConfirm;
        private MS_Control.Controls.MS_TextBox NzPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private MS_Control.Controls.MS_Notify mS_Notify1;
    }
}