namespace NZ.Resaa.Store
{
	partial class FormUserLock
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserLock));
			this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
			this.NzPass = new MS_Control.Controls.MS_TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Panel_Foother = new MS_Control.Controls.MS_Panel();
			this.ms_Save = new MS_Control.Controls.MS_Button_GridX();
			this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
			this.uiGroupBox1.SuspendLayout();
			this.Panel_Foother.SuspendLayout();
			this.SuspendLayout();
			// 
			// uiGroupBox1
			// 
			this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uiGroupBox1.BorderColor = System.Drawing.Color.SteelBlue;
			this.uiGroupBox1.Controls.Add(this.label4);
			this.uiGroupBox1.Controls.Add(this.NzPass);
			this.uiGroupBox1.ImageAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.uiGroupBox1.ImageSize = new System.Drawing.Size(24, 24);
			this.uiGroupBox1.Location = new System.Drawing.Point(5, 2);
			this.uiGroupBox1.Name = "uiGroupBox1";
			this.uiGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uiGroupBox1.Size = new System.Drawing.Size(369, 69);
			this.uiGroupBox1.TabIndex = 2;
			this.uiGroupBox1.UseThemes = false;
			this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.VS2005;
			// 
			// NzPass
			// 
			this.NzPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzPass.ButtonImage = ((System.Drawing.Image)(resources.GetObject("NzPass.ButtonImage")));
			this.NzPass.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image;
			this.NzPass.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzPass.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NzPass.ImageHorizontalAlignment = Janus.Windows.GridEX.ImageHorizontalAlignment.Near;
			this.NzPass.Location = new System.Drawing.Point(5, 21);
			this.NzPass.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzPass.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzPass.MS_Change_Border_Color_On_Enter = true;
			this.NzPass.MS_Change_Color_On_Enter = true;
			this.NzPass.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.NzPass.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NzPass.MS_Exit_By_Down = true;
			this.NzPass.MS_Exit_By_Enter = true;
			this.NzPass.MS_Exit_By_Up = true;
			this.NzPass.Name = "NzPass";
			this.NzPass.PasswordChar = '*';
			this.NzPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzPass.Size = new System.Drawing.Size(287, 31);
			this.NzPass.TabIndex = 1;
			this.NzPass.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.label4.Location = new System.Drawing.Point(292, 25);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label4.Size = new System.Drawing.Size(66, 23);
			this.label4.TabIndex = 79;
			this.label4.Text = "کلمه عبور :";
			// 
			// Panel_Foother
			// 
			this.Panel_Foother.Controls.Add(this.ms_Save);
			this.Panel_Foother.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Panel_Foother.Location = new System.Drawing.Point(0, 81);
			this.Panel_Foother.MS_BorderColor = System.Drawing.Color.DarkGray;
			this.Panel_Foother.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.Panel_Foother.MS_Color_End = System.Drawing.Color.Gainsboro;
			this.Panel_Foother.MS_Color_Start = System.Drawing.Color.WhiteSmoke;
			this.Panel_Foother.Name = "Panel_Foother";
			this.Panel_Foother.Size = new System.Drawing.Size(379, 48);
			this.Panel_Foother.TabIndex = 3;
			// 
			// ms_Save
			// 
			this.ms_Save.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ms_Save.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ms_Save.Image = global::MS_Resource.GlobalResources._ms_Save;
			this.ms_Save.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.ms_Save.Location = new System.Drawing.Point(10, 10);
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
			// FormUserLock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 129);
			this.ControlBox = false;
			this.Controls.Add(this.Panel_Foother);
			this.Controls.Add(this.uiGroupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormUserLock";
			this.Text = "قفل صفحه کاری";
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
			this.uiGroupBox1.ResumeLayout(false);
			this.uiGroupBox1.PerformLayout();
			this.Panel_Foother.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
		private MS_Control.Controls.MS_TextBox NzPass;
		private System.Windows.Forms.Label label4;
		private MS_Control.Controls.MS_Panel Panel_Foother;
		private MS_Control.Controls.MS_Button_GridX ms_Save;
		private MS_Control.Controls.MS_Notify mS_Notify1;
	}
}