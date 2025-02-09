namespace NZ.General.WinForms.Misc
{
    partial class ChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            this.NzSave = new MS_Control.Controls.MS_Button_GridX();
            this.grBox = new Janus.Windows.EditControls.UIGroupBox();
            this.mS_Lable_Ex1 = new MS_Control.Controls.MS_Lable_Ex();
            this.NzPassConfirm = new MS_Control.Controls.MS_TextBox();
            this.NzPass = new MS_Control.Controls.MS_TextBox();
            this.NzCurrentPass = new MS_Control.Controls.MS_TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.NzSave.Location = new System.Drawing.Point(6, 201);
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
            this.NzSave.TabIndex = 790;
            this.NzSave.Text = "تغییر کلمه عبور";
            this.NzSave.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.NzSave.UseThemes = false;
            this.NzSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzSave.WordWrap = false;
            this.NzSave.Click += new System.EventHandler(this.ms_save_Click);
            // 
            // grBox
            // 
            this.grBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBox.BackColor = System.Drawing.Color.Transparent;
            this.grBox.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.grBox.Controls.Add(this.mS_Lable_Ex1);
            this.grBox.Controls.Add(this.NzPassConfirm);
            this.grBox.Controls.Add(this.NzPass);
            this.grBox.Controls.Add(this.NzCurrentPass);
            this.grBox.Controls.Add(this.label2);
            this.grBox.Controls.Add(this.label1);
            this.grBox.Controls.Add(this.label4);
            this.grBox.Font = new System.Drawing.Font("IRANSans(Small)", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grBox.Location = new System.Drawing.Point(6, 12);
            this.grBox.Name = "grBox";
            this.grBox.Size = new System.Drawing.Size(349, 183);
            this.grBox.TabIndex = 789;
            this.grBox.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.grBox.TextOffset = 0;
            // 
            // mS_Lable_Ex1
            // 
            this.mS_Lable_Ex1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mS_Lable_Ex1.BackColor = System.Drawing.Color.LightBlue;
            this.mS_Lable_Ex1.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold);
            this.mS_Lable_Ex1.Location = new System.Drawing.Point(0, 65);
            this.mS_Lable_Ex1.MS_BorderColor = System.Drawing.Color.Empty;
            this.mS_Lable_Ex1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.mS_Lable_Ex1.MS_Color_End = System.Drawing.Color.Empty;
            this.mS_Lable_Ex1.MS_Color_Start = System.Drawing.Color.Empty;
            this.mS_Lable_Ex1.Name = "mS_Lable_Ex1";
            this.mS_Lable_Ex1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_Lable_Ex1.Size = new System.Drawing.Size(349, 1);
            this.mS_Lable_Ex1.TabIndex = 786;
            this.mS_Lable_Ex1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NzPassConfirm
            // 
            this.NzPassConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzPassConfirm.ButtonImage = ((System.Drawing.Image)(resources.GetObject("NzPassConfirm.ButtonImage")));
            this.NzPassConfirm.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image;
            this.NzPassConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzPassConfirm.ImageHorizontalAlignment = Janus.Windows.GridEX.ImageHorizontalAlignment.Near;
            this.NzPassConfirm.Location = new System.Drawing.Point(44, 136);
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
            this.NzPassConfirm.PasswordChar = '*';
            this.NzPassConfirm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzPassConfirm.Size = new System.Drawing.Size(185, 24);
            this.NzPassConfirm.TabIndex = 2;
            this.NzPassConfirm.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzPass
            // 
            this.NzPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzPass.ButtonImage = ((System.Drawing.Image)(resources.GetObject("NzPass.ButtonImage")));
            this.NzPass.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image;
            this.NzPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzPass.ImageHorizontalAlignment = Janus.Windows.GridEX.ImageHorizontalAlignment.Near;
            this.NzPass.Location = new System.Drawing.Point(44, 104);
            this.NzPass.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzPass.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzPass.MS_Change_Border_Color_On_Enter = true;
            this.NzPass.MS_Change_Color_On_Enter = true;
            this.NzPass.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzPass.MS_Enter_Color = System.Drawing.Color.Yellow;
            this.NzPass.MS_Exit_By_Down = true;
            this.NzPass.MS_Exit_By_Enter = true;
            this.NzPass.MS_Exit_By_Up = true;
            this.NzPass.MS_Last_Control = this.NzCurrentPass;
            this.NzPass.MS_Next_Control = this.NzPassConfirm;
            this.NzPass.Multiline = true;
            this.NzPass.Name = "NzPass";
            this.NzPass.PasswordChar = '*';
            this.NzPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzPass.Size = new System.Drawing.Size(185, 24);
            this.NzPass.TabIndex = 1;
            this.NzPass.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzCurrentPass
            // 
            this.NzCurrentPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzCurrentPass.ButtonImage = ((System.Drawing.Image)(resources.GetObject("NzCurrentPass.ButtonImage")));
            this.NzCurrentPass.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image;
            this.NzCurrentPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzCurrentPass.ImageHorizontalAlignment = Janus.Windows.GridEX.ImageHorizontalAlignment.Near;
            this.NzCurrentPass.Location = new System.Drawing.Point(44, 25);
            this.NzCurrentPass.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzCurrentPass.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzCurrentPass.MS_Change_Border_Color_On_Enter = true;
            this.NzCurrentPass.MS_Change_Color_On_Enter = true;
            this.NzCurrentPass.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzCurrentPass.MS_Enter_Color = System.Drawing.Color.Yellow;
            this.NzCurrentPass.MS_Exit_By_Down = true;
            this.NzCurrentPass.MS_Exit_By_Enter = true;
            this.NzCurrentPass.MS_Exit_By_Up = true;
            this.NzCurrentPass.MS_Last_Control = null;
            this.NzCurrentPass.MS_Next_Control = this.NzPass;
            this.NzCurrentPass.Multiline = true;
            this.NzCurrentPass.Name = "NzCurrentPass";
            this.NzCurrentPass.PasswordChar = '*';
            this.NzCurrentPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzCurrentPass.Size = new System.Drawing.Size(185, 24);
            this.NzCurrentPass.TabIndex = 0;
            this.NzCurrentPass.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(231, 137);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 78;
            this.label2.Text = "تکرار کلمه عبور :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(231, 26);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 78;
            this.label1.Text = "کلمه عبور فـعـلی :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Location = new System.Drawing.Point(231, 105);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 78;
            this.label4.Text = "کلمه عبور جدید :";
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 240);
            this.Controls.Add(this.NzSave);
            this.Controls.Add(this.grBox);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePass";
            this.Text = "تغـییر کلمه عبور";
            ((System.ComponentModel.ISupportInitialize)(this.grBox)).EndInit();
            this.grBox.ResumeLayout(false);
            this.grBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MS_Control.Controls.MS_Button_GridX NzSave;
        private Janus.Windows.EditControls.UIGroupBox grBox;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex1;
        private MS_Control.Controls.MS_TextBox NzPassConfirm;
        private MS_Control.Controls.MS_TextBox NzPass;
        private MS_Control.Controls.MS_TextBox NzCurrentPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private MS_Control.Controls.MS_Notify mS_Notify1;
    }
}