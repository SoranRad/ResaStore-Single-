namespace NZ.General.WinForms.Misc
{
    partial class FormExit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExit));
            this.NzDataAddress = new MS_Control.Controls.MS_TextBox();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.NzBackRadio = new MS_Control.Controls.MS_CheckBox();
            this.NzCancel = new MS_Control.Controls.MS_Button_GridX();
            this.NzExit = new MS_Control.Controls.MS_Button_GridX();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NzDataAddress
            // 
            this.NzDataAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NzDataAddress.ButtonImage = ((System.Drawing.Image)(resources.GetObject("NzDataAddress.ButtonImage")));
            this.NzDataAddress.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image;
            this.NzDataAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzDataAddress.Location = new System.Drawing.Point(6, 54);
            this.NzDataAddress.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzDataAddress.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzDataAddress.MS_Change_Border_Color_On_Enter = true;
            this.NzDataAddress.MS_Change_Color_On_Enter = true;
            this.NzDataAddress.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzDataAddress.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzDataAddress.MS_Exit_By_Down = true;
            this.NzDataAddress.MS_Exit_By_Enter = true;
            this.NzDataAddress.MS_Exit_By_Up = true;
            this.NzDataAddress.MS_Last_Control = null;
            this.NzDataAddress.MS_Next_Control = null;
            this.NzDataAddress.Multiline = true;
            this.NzDataAddress.Name = "NzDataAddress";
            this.NzDataAddress.ReadOnly = true;
            this.NzDataAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NzDataAddress.Size = new System.Drawing.Size(518, 24);
            this.NzDataAddress.TabIndex = 1;
            this.NzDataAddress.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.NzDataAddress.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.NzDataAddress.ButtonClick += new System.EventHandler(this.NzDataAddress_ButtonClick);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.uiGroupBox1.Controls.Add(this.NzBackRadio);
            this.uiGroupBox1.Controls.Add(this.NzDataAddress);
            this.uiGroupBox1.Location = new System.Drawing.Point(8, 6);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiGroupBox1.Size = new System.Drawing.Size(539, 99);
            this.uiGroupBox1.TabIndex = 69;
            // 
            // NzBackRadio
            // 
            this.NzBackRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzBackRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzBackRadio.Checked = true;
            this.NzBackRadio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NzBackRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzBackRadio.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzBackRadio.Image = global::MS_Resource.GlobalResources.Negin__51_;
            this.NzBackRadio.ImageAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzBackRadio.Location = new System.Drawing.Point(253, 12);
            this.NzBackRadio.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzBackRadio.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzBackRadio.MS_Change_Border_Color_On_Enter = true;
            this.NzBackRadio.MS_Change_Color_On_Checked = true;
            this.NzBackRadio.MS_Change_Color_On_Enter = true;
            this.NzBackRadio.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzBackRadio.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzBackRadio.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzBackRadio.MS_Exit_By_Down = true;
            this.NzBackRadio.MS_Exit_By_Enter = true;
            this.NzBackRadio.MS_Exit_By_Up = true;
            this.NzBackRadio.MS_Last_Control = null;
            this.NzBackRadio.MS_Next_Control = null;
            this.NzBackRadio.MS_UnChecked_Color = System.Drawing.Color.Transparent;
            this.NzBackRadio.Name = "NzBackRadio";
            this.NzBackRadio.ShowFocusRectangle = false;
            this.NzBackRadio.Size = new System.Drawing.Size(280, 29);
            this.NzBackRadio.TabIndex = 6;
            this.NzBackRadio.Text = "  ایجاد فایل پشـتیبان از بانک اطلاعاتی";
            this.NzBackRadio.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            this.NzBackRadio.CheckedChanged += new System.EventHandler(this.NzBackRadio_CheckedChanged);
            // 
            // NzCancel
            // 
            this.NzCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NzCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzCancel.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzCancel.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzCancel.Image = global::MS_Resource.GlobalResources._ms_Back;
            this.NzCancel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzCancel.Location = new System.Drawing.Point(8, 111);
            this.NzCancel.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzCancel.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzCancel.MS_Change_Border_Color_On_Enter = false;
            this.NzCancel.MS_Change_Color_On_Enter = false;
            this.NzCancel.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.NzCancel.MS_Enter_Color = System.Drawing.Color.Empty;
            this.NzCancel.Name = "NzCancel";
            this.NzCancel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzCancel.Office2007CustomColor = System.Drawing.Color.LightBlue;
            this.NzCancel.ShowFocusRectangle = false;
            this.NzCancel.Size = new System.Drawing.Size(100, 33);
            this.NzCancel.TabIndex = 3;
            this.NzCancel.Text = "انـصـراف";
            this.NzCancel.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.NzCancel.UseThemes = false;
            this.NzCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzCancel.WordWrap = false;
            this.NzCancel.Click += new System.EventHandler(this.NzCancel_Click);
            // 
            // NzExit
            // 
            this.NzExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NzExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzExit.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzExit.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzExit.Image = global::MS_Resource.GlobalResources._ms_Save;
            this.NzExit.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzExit.Location = new System.Drawing.Point(114, 111);
            this.NzExit.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzExit.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzExit.MS_Change_Border_Color_On_Enter = false;
            this.NzExit.MS_Change_Color_On_Enter = false;
            this.NzExit.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.NzExit.MS_Enter_Color = System.Drawing.Color.Empty;
            this.NzExit.Name = "NzExit";
            this.NzExit.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzExit.Office2007CustomColor = System.Drawing.Color.LightBlue;
            this.NzExit.ShowFocusRectangle = false;
            this.NzExit.Size = new System.Drawing.Size(128, 33);
            this.NzExit.TabIndex = 3;
            this.NzExit.Text = "خروج از برنامه ";
            this.NzExit.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.NzExit.UseThemes = false;
            this.NzExit.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzExit.WordWrap = false;
            this.NzExit.Click += new System.EventHandler(this.NzExit_Click);
            // 
            // FormExit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(556, 149);
            this.ControlBox = false;
            this.Controls.Add(this.NzExit);
            this.Controls.Add(this.NzCancel);
            this.Controls.Add(this.uiGroupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "";
            this.Shown += new System.EventHandler(this.FormExit_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MS_Control.Controls.MS_TextBox NzDataAddress;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private MS_Control.Controls.MS_Button_GridX NzCancel;
        private MS_Control.Controls.MS_Button_GridX NzExit;
        private MS_Control.Controls.MS_CheckBox NzBackRadio;
    }
}