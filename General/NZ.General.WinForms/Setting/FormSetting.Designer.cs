namespace NZ.General.WinForms.Setting
{
	partial class FormSetting
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
			this.NzTab = new Janus.Windows.UI.Tab.UITab();
			this.Panel_Foother = new MS_Control.Controls.MS_Panel();
			this.ms_Save = new MS_Control.Controls.MS_Button_GridX();
			this.ms_Exit = new MS_Control.Controls.MS_Button_GridX();
			((System.ComponentModel.ISupportInitialize)(this.NzTab)).BeginInit();
			this.Panel_Foother.SuspendLayout();
			this.SuspendLayout();
			// 
			// NzTab
			// 
			this.NzTab.BackColor = System.Drawing.Color.Transparent;
			this.NzTab.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NzTab.FirstTabOffset = 20;
			this.NzTab.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzTab.Location = new System.Drawing.Point(0, 0);
			this.NzTab.MultiLine = true;
			this.NzTab.Name = "NzTab";
			this.NzTab.Office2007CustomColor = System.Drawing.Color.Transparent;
			this.NzTab.ShowFocusRectangle = false;
			this.NzTab.Size = new System.Drawing.Size(716, 385);
			this.NzTab.TabIndex = 7;
			this.NzTab.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzTab.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzTab.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.PowderBlue;
			this.NzTab.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
			this.NzTab.TabsStateStyles.SelectedFormatStyle.FontSize = 14F;
			this.NzTab.TabStripOffset = 10;
			this.NzTab.UseThemes = false;
			this.NzTab.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
			// 
			// Panel_Foother
			// 
			this.Panel_Foother.Controls.Add(this.ms_Save);
			this.Panel_Foother.Controls.Add(this.ms_Exit);
			this.Panel_Foother.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Panel_Foother.Location = new System.Drawing.Point(0, 385);
			this.Panel_Foother.MS_BorderColor = System.Drawing.Color.DarkGray;
			this.Panel_Foother.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.Panel_Foother.MS_Color_End = System.Drawing.Color.Gainsboro;
			this.Panel_Foother.MS_Color_Start = System.Drawing.Color.WhiteSmoke;
			this.Panel_Foother.Name = "Panel_Foother";
			this.Panel_Foother.Size = new System.Drawing.Size(716, 51);
			this.Panel_Foother.TabIndex = 8;
			// 
			// ms_Save
			// 
			this.ms_Save.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ms_Save.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ms_Save.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.ms_Save.Image = ((System.Drawing.Image)(resources.GetObject("ms_Save.Image")));
			this.ms_Save.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.ms_Save.Location = new System.Drawing.Point(601, 11);
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
			// ms_Exit
			// 
			this.ms_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ms_Exit.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ms_Exit.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.ms_Exit.Image = ((System.Drawing.Image)(resources.GetObject("ms_Exit.Image")));
			this.ms_Exit.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.ms_Exit.Location = new System.Drawing.Point(12, 11);
			this.ms_Exit.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.ms_Exit.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.ms_Exit.MS_Change_Border_Color_On_Enter = false;
			this.ms_Exit.MS_Change_Color_On_Enter = false;
			this.ms_Exit.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.ms_Exit.MS_Enter_Color = System.Drawing.Color.Empty;
			this.ms_Exit.Name = "ms_Exit";
			this.ms_Exit.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.ms_Exit.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.ms_Exit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ms_Exit.ShowFocusRectangle = false;
			this.ms_Exit.Size = new System.Drawing.Size(132, 30);
			this.ms_Exit.TabIndex = 1;
			this.ms_Exit.Text = "انــصــراف   [Esc]";
			this.ms_Exit.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.ms_Exit.UseThemes = false;
			this.ms_Exit.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.ms_Exit.WordWrap = false;
			// 
			// FormSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(716, 436);
			this.Controls.Add(this.NzTab);
			this.Controls.Add(this.Panel_Foother);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormSetting";
			this.Text = "تنظیمات";
			this.Load += new System.EventHandler(this.FormSetting_Load);
			((System.ComponentModel.ISupportInitialize)(this.NzTab)).EndInit();
			this.Panel_Foother.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Janus.Windows.UI.Tab.UITab NzTab;
		private MS_Control.Controls.MS_Panel Panel_Foother;
		private MS_Control.Controls.MS_Button_GridX ms_Save;
		private MS_Control.Controls.MS_Button_GridX ms_Exit;
	}
}