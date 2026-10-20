namespace Nz.Bar.WinForms.Sms
{
	partial class SmsTemplateContainer
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
			this.NzTabs = new Janus.Windows.UI.Tab.UITab();
			this.NsProductBarSmsTemplate = new ShareLib.Component.NsSmsTemplateTabPage();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.NsMobile = new MS_Control.Controls.MS_Button_GridX();
			this.NsName = new MS_Control.Controls.MS_Button_GridX();
			this.NsOrderId = new MS_Control.Controls.MS_Button_GridX();
			this.NsMablaq = new MS_Control.Controls.MS_Button_GridX();
			this.NsTarikh = new MS_Control.Controls.MS_Button_GridX();
			this.NsMande = new MS_Control.Controls.MS_Button_GridX();
			this.NsMohlat = new MS_Control.Controls.MS_Button_GridX();
			this.mS_Lable_Ex1 = new MS_Control.Controls.MS_Lable_Ex();
			this.mS_Lable_Ex2 = new MS_Control.Controls.MS_Lable_Ex();
			this.NsMessage = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.NzTabs)).BeginInit();
			this.NzTabs.SuspendLayout();
			this.NsProductBarSmsTemplate.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// NzTabs
			// 
			this.NzTabs.BackColor = System.Drawing.Color.Transparent;
			this.NzTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NzTabs.FirstTabOffset = 10;
			this.NzTabs.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzTabs.Location = new System.Drawing.Point(0, 0);
			this.NzTabs.Name = "NzTabs";
			this.NzTabs.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NzTabs.Office2007CustomColor = System.Drawing.Color.AntiqueWhite;
			this.NzTabs.PageBorder = Janus.Windows.UI.Tab.PageBorder.None;
			this.NzTabs.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzTabs.ShowFocusRectangle = false;
			this.NzTabs.Size = new System.Drawing.Size(654, 502);
			this.NzTabs.TabIndex = 711;
			this.NzTabs.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.NsProductBarSmsTemplate});
			this.NzTabs.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzTabs.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzTabs.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.LightBlue;
			this.NzTabs.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.NzTabs.UseThemes = false;
			this.NzTabs.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
			// 
			// NsProductBarSmsTemplate
			// 
			this.NsProductBarSmsTemplate.AutoScroll = true;
			this.NsProductBarSmsTemplate.Controls.Add(this.flowLayoutPanel1);
			this.NsProductBarSmsTemplate.Controls.Add(this.mS_Lable_Ex1);
			this.NsProductBarSmsTemplate.Controls.Add(this.mS_Lable_Ex2);
			this.NsProductBarSmsTemplate.Controls.Add(this.NsMessage);
			this.NsProductBarSmsTemplate.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsProductBarSmsTemplate.Location = new System.Drawing.Point(0, 27);
			this.NsProductBarSmsTemplate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NsProductBarSmsTemplate.Name = "NsProductBarSmsTemplate";
			this.NsProductBarSmsTemplate.PanelFormatStyle.Alpha = 70;
			this.NsProductBarSmsTemplate.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.NsProductBarSmsTemplate.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.NsProductBarSmsTemplate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsProductBarSmsTemplate.Size = new System.Drawing.Size(654, 475);
			this.NsProductBarSmsTemplate.TabStop = true;
			this.NsProductBarSmsTemplate.Text = "محصولات";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			this.flowLayoutPanel1.Controls.Add(this.NsMobile);
			this.flowLayoutPanel1.Controls.Add(this.NsName);
			this.flowLayoutPanel1.Controls.Add(this.NsOrderId);
			this.flowLayoutPanel1.Controls.Add(this.NsMablaq);
			this.flowLayoutPanel1.Controls.Add(this.NsTarikh);
			this.flowLayoutPanel1.Controls.Add(this.NsMande);
			this.flowLayoutPanel1.Controls.Add(this.NsMohlat);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 267);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(649, 206);
			this.flowLayoutPanel1.TabIndex = 825;
			// 
			// NsMobile
			// 
			this.NsMobile.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsMobile.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsMobile.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsMobile.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NsMobile.Location = new System.Drawing.Point(543, 8);
			this.NsMobile.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsMobile.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsMobile.MS_Change_Border_Color_On_Enter = false;
			this.NsMobile.MS_Change_Color_On_Enter = false;
			this.NsMobile.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NsMobile.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NsMobile.Name = "NsMobile";
			this.NsMobile.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver;
			this.NsMobile.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NsMobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsMobile.ShowFocusRectangle = false;
			this.NsMobile.Size = new System.Drawing.Size(93, 30);
			this.NsMobile.TabIndex = 823;
			this.NsMobile.Tag = "PhoneNumber";
			this.NsMobile.Text = "شماره مشتری";
			this.NsMobile.UseThemes = false;
			this.NsMobile.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NsMobile.WordWrap = false;
			this.NsMobile.Click += new System.EventHandler(this.ButtonVariables_Click);
			// 
			// NsName
			// 
			this.NsName.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsName.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsName.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsName.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NsName.Location = new System.Drawing.Point(416, 8);
			this.NsName.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsName.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsName.MS_Change_Border_Color_On_Enter = false;
			this.NsName.MS_Change_Color_On_Enter = false;
			this.NsName.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NsName.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NsName.Name = "NsName";
			this.NsName.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver;
			this.NsName.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NsName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsName.ShowFocusRectangle = false;
			this.NsName.Size = new System.Drawing.Size(121, 30);
			this.NsName.TabIndex = 823;
			this.NsName.Tag = "NAME";
			this.NsName.Text = "نام و نام خانوادگی";
			this.NsName.UseThemes = false;
			this.NsName.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NsName.WordWrap = false;
			this.NsName.Click += new System.EventHandler(this.ButtonVariables_Click);
			// 
			// NsOrderId
			// 
			this.NsOrderId.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsOrderId.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsOrderId.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsOrderId.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NsOrderId.Location = new System.Drawing.Point(316, 8);
			this.NsOrderId.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsOrderId.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsOrderId.MS_Change_Border_Color_On_Enter = false;
			this.NsOrderId.MS_Change_Color_On_Enter = false;
			this.NsOrderId.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NsOrderId.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NsOrderId.Name = "NsOrderId";
			this.NsOrderId.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver;
			this.NsOrderId.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NsOrderId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsOrderId.ShowFocusRectangle = false;
			this.NsOrderId.Size = new System.Drawing.Size(94, 30);
			this.NsOrderId.TabIndex = 823;
			this.NsOrderId.Tag = "SERIAL";
			this.NsOrderId.Text = "شماره سفارش";
			this.NsOrderId.UseThemes = false;
			this.NsOrderId.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NsOrderId.WordWrap = false;
			this.NsOrderId.Click += new System.EventHandler(this.ButtonVariables_Click);
			// 
			// NsMablaq
			// 
			this.NsMablaq.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsMablaq.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsMablaq.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsMablaq.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NsMablaq.Location = new System.Drawing.Point(208, 8);
			this.NsMablaq.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsMablaq.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsMablaq.MS_Change_Border_Color_On_Enter = false;
			this.NsMablaq.MS_Change_Color_On_Enter = false;
			this.NsMablaq.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NsMablaq.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NsMablaq.Name = "NsMablaq";
			this.NsMablaq.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver;
			this.NsMablaq.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NsMablaq.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsMablaq.ShowFocusRectangle = false;
			this.NsMablaq.Size = new System.Drawing.Size(102, 30);
			this.NsMablaq.TabIndex = 823;
			this.NsMablaq.Tag = "PRICE";
			this.NsMablaq.Text = "مبلغ کل سفارش";
			this.NsMablaq.UseThemes = false;
			this.NsMablaq.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NsMablaq.WordWrap = false;
			this.NsMablaq.Click += new System.EventHandler(this.ButtonVariables_Click);
			// 
			// NsTarikh
			// 
			this.NsTarikh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsTarikh.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsTarikh.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsTarikh.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NsTarikh.Location = new System.Drawing.Point(105, 8);
			this.NsTarikh.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsTarikh.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsTarikh.MS_Change_Border_Color_On_Enter = false;
			this.NsTarikh.MS_Change_Color_On_Enter = false;
			this.NsTarikh.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NsTarikh.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NsTarikh.Name = "NsTarikh";
			this.NsTarikh.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver;
			this.NsTarikh.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NsTarikh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsTarikh.ShowFocusRectangle = false;
			this.NsTarikh.Size = new System.Drawing.Size(97, 30);
			this.NsTarikh.TabIndex = 824;
			this.NsTarikh.Tag = "DATE";
			this.NsTarikh.Text = "تاریخ سفارش";
			this.NsTarikh.UseThemes = false;
			this.NsTarikh.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NsTarikh.WordWrap = false;
			this.NsTarikh.Click += new System.EventHandler(this.ButtonVariables_Click);
			// 
			// NsMande
			// 
			this.NsMande.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsMande.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsMande.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsMande.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NsMande.Location = new System.Drawing.Point(500, 44);
			this.NsMande.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsMande.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsMande.MS_Change_Border_Color_On_Enter = false;
			this.NsMande.MS_Change_Color_On_Enter = false;
			this.NsMande.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NsMande.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NsMande.Name = "NsMande";
			this.NsMande.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver;
			this.NsMande.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NsMande.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsMande.ShowFocusRectangle = false;
			this.NsMande.Size = new System.Drawing.Size(136, 30);
			this.NsMande.TabIndex = 825;
			this.NsMande.Tag = "MANDE_HESAB";
			this.NsMande.Text = "مانده حساب مشتری";
			this.NsMande.UseThemes = false;
			this.NsMande.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NsMande.WordWrap = false;
			this.NsMande.Click += new System.EventHandler(this.ButtonVariables_Click);
			// 
			// NsMohlat
			// 
			this.NsMohlat.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsMohlat.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsMohlat.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsMohlat.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NsMohlat.Location = new System.Drawing.Point(402, 44);
			this.NsMohlat.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsMohlat.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsMohlat.MS_Change_Border_Color_On_Enter = false;
			this.NsMohlat.MS_Change_Color_On_Enter = false;
			this.NsMohlat.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NsMohlat.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NsMohlat.Name = "NsMohlat";
			this.NsMohlat.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver;
			this.NsMohlat.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NsMohlat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsMohlat.ShowFocusRectangle = false;
			this.NsMohlat.Size = new System.Drawing.Size(92, 30);
			this.NsMohlat.TabIndex = 826;
			this.NsMohlat.Tag = "TARIKH_TASVIEH";
			this.NsMohlat.Text = "مهلت تسویه";
			this.NsMohlat.UseThemes = false;
			this.NsMohlat.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NsMohlat.WordWrap = false;
			this.NsMohlat.Click += new System.EventHandler(this.ButtonVariables_Click);
			// 
			// mS_Lable_Ex1
			// 
			this.mS_Lable_Ex1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Lable_Ex1.AutoSize = true;
			this.mS_Lable_Ex1.BackColor = System.Drawing.Color.Transparent;
			this.mS_Lable_Ex1.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.mS_Lable_Ex1.Location = new System.Drawing.Point(352, 237);
			this.mS_Lable_Ex1.MS_BorderColor = System.Drawing.Color.Tan;
			this.mS_Lable_Ex1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
			this.mS_Lable_Ex1.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex1.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex1.Name = "mS_Lable_Ex1";
			this.mS_Lable_Ex1.Size = new System.Drawing.Size(293, 23);
			this.mS_Lable_Ex1.TabIndex = 824;
			this.mS_Lable_Ex1.Text = "متغیرهایی که در  متن پیامک می توانید استفاده کنید :";
			this.mS_Lable_Ex1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// mS_Lable_Ex2
			// 
			this.mS_Lable_Ex2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Lable_Ex2.AutoSize = true;
			this.mS_Lable_Ex2.BackColor = System.Drawing.Color.Transparent;
			this.mS_Lable_Ex2.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.mS_Lable_Ex2.Location = new System.Drawing.Point(471, 24);
			this.mS_Lable_Ex2.MS_BorderColor = System.Drawing.Color.Tan;
			this.mS_Lable_Ex2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
			this.mS_Lable_Ex2.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex2.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex2.Name = "mS_Lable_Ex2";
			this.mS_Lable_Ex2.Size = new System.Drawing.Size(161, 23);
			this.mS_Lable_Ex2.TabIndex = 822;
			this.mS_Lable_Ex2.Text = "قالب پیامک برای محصولات :";
			this.mS_Lable_Ex2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NsMessage
			// 
			this.NsMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsMessage.Location = new System.Drawing.Point(7, 50);
			this.NsMessage.Name = "NsMessage";
			this.NsMessage.Size = new System.Drawing.Size(634, 181);
			this.NsMessage.TabIndex = 0;
			this.NsMessage.Text = "";
			// 
			// SmsTemplateContainer
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.NzTabs);
			this.Name = "SmsTemplateContainer";
			this.Size = new System.Drawing.Size(654, 502);
			((System.ComponentModel.ISupportInitialize)(this.NzTabs)).EndInit();
			this.NzTabs.ResumeLayout(false);
			this.NsProductBarSmsTemplate.ResumeLayout(false);
			this.NsProductBarSmsTemplate.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Janus.Windows.UI.Tab.UITab NzTabs;
		private ShareLib.Component.NsSmsTemplateTabPage NsProductBarSmsTemplate;
		private System.Windows.Forms.RichTextBox NsMessage;
		private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex2;
		private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex1;
		private MS_Control.Controls.MS_Button_GridX NsMobile;
		private MS_Control.Controls.MS_Button_GridX NsName;
		private MS_Control.Controls.MS_Button_GridX NsOrderId;
		private MS_Control.Controls.MS_Button_GridX NsMablaq;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private MS_Control.Controls.MS_Button_GridX NsTarikh;
		private MS_Control.Controls.MS_Button_GridX NsMande;
		private MS_Control.Controls.MS_Button_GridX NsMohlat;
	}
}
