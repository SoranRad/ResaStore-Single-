namespace Nz.Anbar.WinForms.App
{
	partial class FormCopyToYear
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCopyToYear));
			this.Panel_Foother = new MS_Control.Controls.MS_Panel();
			this.ms_Save = new MS_Control.Controls.MS_Button_GridX();
			this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
			this.NsSerial = new MS_Control.Controls.MS_NumericTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.NsYear = new NZ.General.WinForms.Component.NzYearComboBox();
			this.Panel_Foother.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
			this.uiGroupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// Panel_Foother
			// 
			this.Panel_Foother.Controls.Add(this.ms_Save);
			this.Panel_Foother.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Panel_Foother.Location = new System.Drawing.Point(0, 145);
			this.Panel_Foother.MS_BorderColor = System.Drawing.Color.DarkGray;
			this.Panel_Foother.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.Panel_Foother.MS_Color_End = System.Drawing.Color.Gainsboro;
			this.Panel_Foother.MS_Color_Start = System.Drawing.Color.WhiteSmoke;
			this.Panel_Foother.Name = "Panel_Foother";
			this.Panel_Foother.Size = new System.Drawing.Size(250, 44);
			this.Panel_Foother.TabIndex = 2;
			// 
			// ms_Save
			// 
			this.ms_Save.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ms_Save.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ms_Save.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.ms_Save.Image = ((System.Drawing.Image)(resources.GetObject("ms_Save.Image")));
			this.ms_Save.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.ms_Save.Location = new System.Drawing.Point(8, 7);
			this.ms_Save.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.ms_Save.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.ms_Save.MS_Change_Border_Color_On_Enter = false;
			this.ms_Save.MS_Change_Color_On_Enter = false;
			this.ms_Save.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.ms_Save.MS_Enter_Color = System.Drawing.Color.Empty;
			this.ms_Save.Name = "ms_Save";
			this.ms_Save.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.ms_Save.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.ms_Save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ms_Save.ShowFocusRectangle = false;
			this.ms_Save.Size = new System.Drawing.Size(103, 30);
			this.ms_Save.TabIndex = 0;
			this.ms_Save.Text = "ثـبــت   [F2]";
			this.ms_Save.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.ms_Save.UseThemes = false;
			this.ms_Save.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.ms_Save.WordWrap = false;
			this.ms_Save.Click += new System.EventHandler(this.ms_Save_Click);
			// 
			// uiGroupBox2
			// 
			this.uiGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uiGroupBox2.BackColor = System.Drawing.Color.Transparent;
			this.uiGroupBox2.BorderColor = System.Drawing.Color.LightBlue;
			this.uiGroupBox2.Controls.Add(this.NsSerial);
			this.uiGroupBox2.Controls.Add(this.label1);
			this.uiGroupBox2.Controls.Add(this.label2);
			this.uiGroupBox2.Controls.Add(this.NsYear);
			this.uiGroupBox2.Location = new System.Drawing.Point(6, 4);
			this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.uiGroupBox2.Name = "uiGroupBox2";
			this.uiGroupBox2.Size = new System.Drawing.Size(237, 132);
			this.uiGroupBox2.TabIndex = 3;
			// 
			// NsSerial
			// 
			this.NsSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsSerial.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NsSerial.ButtonText = "000";
			this.NsSerial.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsSerial.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
			this.NsSerial.Location = new System.Drawing.Point(22, 83);
			this.NsSerial.MaxLength = 0;
			this.NsSerial.Mode = MS_Control.Controls.MS_NumericTextBox.TextBoxMode.IntNumber;
			this.NsSerial.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsSerial.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsSerial.MS_Change_Border_Color_On_Enter = true;
			this.NsSerial.MS_Change_Color_On_Enter = true;
			this.NsSerial.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsSerial.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsSerial.MS_Exit_By_Down = true;
			this.NsSerial.MS_Exit_By_Enter = true;
			this.NsSerial.MS_Exit_By_Up = true;
			this.NsSerial.MS_Is_Negative = false;
			this.NsSerial.MS_Last_Control = null;
			this.NsSerial.MS_Next_Control = null;
			this.NsSerial.Name = "NsSerial";
			this.NsSerial.ReadOnly = true;
			this.NsSerial.Size = new System.Drawing.Size(109, 30);
			this.NsSerial.TabIndex = 163;
			this.NsSerial.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
			this.NsSerial.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label1.Location = new System.Drawing.Point(145, 72);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(83, 46);
			this.label1.TabIndex = 162;
			this.label1.Text = "شماره سریال\r\n در سال مالی :";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label2.Location = new System.Drawing.Point(145, 26);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.Size = new System.Drawing.Size(65, 23);
			this.label2.TabIndex = 162;
			this.label2.Text = "سال مالی :";
			// 
			// NsYear
			// 
			this.NsYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsYear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsYear.Location = new System.Drawing.Point(22, 23);
			this.NsYear.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsYear.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsYear.MS_Change_Border_Color_On_Enter = false;
			this.NsYear.MS_Change_Color_On_Enter = false;
			this.NsYear.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NsYear.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NsYear.MS_Exit_By_Down = false;
			this.NsYear.MS_Exit_By_Enter = false;
			this.NsYear.MS_Exit_By_Up = false;
			this.NsYear.MS_Last_Control = null;
			this.NsYear.MS_Next_Control = null;
			this.NsYear.Name = "NsYear";
			this.NsYear.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Blue;
			this.NsYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsYear.Size = new System.Drawing.Size(109, 29);
			this.NsYear.TabIndex = 0;
			this.NsYear.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			// 
			// FormCopyToYear
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(250, 189);
			this.Controls.Add(this.uiGroupBox2);
			this.Controls.Add(this.Panel_Foother);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCopyToYear";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "کپی به سال دیگر";
			this.Shown += new System.EventHandler(this.FormCopyToYear_Shown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormCopyToYear_KeyUp);
			this.Panel_Foother.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
			this.uiGroupBox2.ResumeLayout(false);
			this.uiGroupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private MS_Control.Controls.MS_Panel Panel_Foother;
		private MS_Control.Controls.MS_Button_GridX ms_Save;
		private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
		private NZ.General.WinForms.Component.NzYearComboBox NsYear;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private MS_Control.Controls.MS_NumericTextBox NsSerial;
	}
}