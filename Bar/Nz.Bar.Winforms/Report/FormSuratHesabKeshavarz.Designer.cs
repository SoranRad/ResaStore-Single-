namespace Nz.Bar.Winforms.Report
{
	partial class FormSuratHesabKeshavarz
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuratHesabKeshavarz));
			this.stiViewerControl1 = new Stimulsoft.Report.Viewer.StiViewerControl();
			this.mS_Panel1 = new MS_Control.Controls.MS_Panel();
			this.NzCustomerRemain = new NZ.General.WinForms.Component.NzRemainCustomer();
			this.NzCustomer = new NZ.General.WinForms.Component.NzPeople();
			this.NzReport = new MS_Control.Controls.MS_Button_GridX();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.mS_Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// stiViewerControl1
			// 
			this.stiViewerControl1.AllowDrop = true;
			this.stiViewerControl1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.stiViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stiViewerControl1.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.stiViewerControl1.Location = new System.Drawing.Point(0, 74);
			this.stiViewerControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.stiViewerControl1.Name = "stiViewerControl1";
			this.stiViewerControl1.PageViewMode = Stimulsoft.Report.Viewer.StiPageViewMode.SinglePage;
			this.stiViewerControl1.Report = null;
			this.stiViewerControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.stiViewerControl1.ShowBookmarksPanel = false;
			this.stiViewerControl1.ShowCloseButton = false;
			this.stiViewerControl1.ShowEditor = false;
			this.stiViewerControl1.ShowFind = false;
			this.stiViewerControl1.ShowOpen = false;
			this.stiViewerControl1.ShowPageDelete = false;
			this.stiViewerControl1.ShowPageDesign = false;
			this.stiViewerControl1.ShowPageNew = false;
			this.stiViewerControl1.ShowPageSize = false;
			this.stiViewerControl1.ShowThumbsPanel = false;
			this.stiViewerControl1.ShowZoom = true;
			this.stiViewerControl1.Size = new System.Drawing.Size(1357, 641);
			this.stiViewerControl1.TabIndex = 3;
			this.stiViewerControl1.ThumbsPanelEnabled = false;
			// 
			// mS_Panel1
			// 
			this.mS_Panel1.Controls.Add(this.NzCustomerRemain);
			this.mS_Panel1.Controls.Add(this.NzCustomer);
			this.mS_Panel1.Controls.Add(this.NzReport);
			this.mS_Panel1.Controls.Add(this.label3);
			this.mS_Panel1.Controls.Add(this.label2);
			this.mS_Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.mS_Panel1.Location = new System.Drawing.Point(0, 0);
			this.mS_Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.mS_Panel1.MS_BorderColor = System.Drawing.Color.Teal;
			this.mS_Panel1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Panel1.MS_Color_End = System.Drawing.Color.SkyBlue;
			this.mS_Panel1.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.mS_Panel1.Name = "mS_Panel1";
			this.mS_Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.mS_Panel1.Size = new System.Drawing.Size(1357, 74);
			this.mS_Panel1.TabIndex = 723;
			// 
			// NzCustomerRemain
			// 
			this.NzCustomerRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzCustomerRemain.BackColor = System.Drawing.Color.White;
			this.NzCustomerRemain.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NzCustomerRemain.Location = new System.Drawing.Point(1087, 38);
			this.NzCustomerRemain.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzCustomerRemain.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzCustomerRemain.MS_Color_End = System.Drawing.Color.Empty;
			this.NzCustomerRemain.MS_Color_Start = System.Drawing.Color.Empty;
			this.NzCustomerRemain.Name = "NzCustomerRemain";
			this.NzCustomerRemain.Size = new System.Drawing.Size(180, 28);
			this.NzCustomerRemain.TabIndex = 768;
			this.NzCustomerRemain.Text = "0";
			this.NzCustomerRemain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NzCustomer
			// 
			this.NzCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzCustomer.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.NzCustomer.DropSize = new System.Drawing.Size(304, 27);
			this.NzCustomer.Font = new System.Drawing.Font("IRANSans(Small)", 12F);
			this.NzCustomer.Location = new System.Drawing.Point(963, 9);
			this.NzCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.NzCustomer.MS_Auto_Popup = false;
			this.NzCustomer.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzCustomer.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzCustomer.MS_CaptureFocus = false;
			this.NzCustomer.MS_Change_Border_Color_On_Enter = true;
			this.NzCustomer.MS_Change_Color_On_Enter = true;
			this.NzCustomer.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
			this.NzCustomer.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
			this.NzCustomer.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzCustomer.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzCustomer.MS_Exit_By_Down = true;
			this.NzCustomer.MS_Exit_By_Enter = true;
			this.NzCustomer.MS_Exit_By_Up = true;
			this.NzCustomer.MS_Last_Control = null;
			this.NzCustomer.MS_Next_Control = null;
			this.NzCustomer.Name = "NzCustomer";
			this.NzCustomer.Office2007CustomColor = System.Drawing.Color.SkyBlue;
			this.NzCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzCustomer.Size = new System.Drawing.Size(304, 27);
			this.NzCustomer.TabIndex = 764;
			this.NzCustomer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NzCustomer.MS_On_Row_Selected += new System.EventHandler<MS_Control.TSDD.On_Selected>(this.NzCustomer_MS_On_Row_Selected);
			// 
			// NzReport
			// 
			this.NzReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzReport.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzReport.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NzReport.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzReport.Image = ((System.Drawing.Image)(resources.GetObject("NzReport.Image")));
			this.NzReport.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NzReport.Location = new System.Drawing.Point(825, 8);
			this.NzReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.NzReport.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzReport.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzReport.MS_Change_Border_Color_On_Enter = false;
			this.NzReport.MS_Change_Color_On_Enter = false;
			this.NzReport.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NzReport.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NzReport.Name = "NzReport";
			this.NzReport.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NzReport.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NzReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzReport.ShowFocusRectangle = false;
			this.NzReport.Size = new System.Drawing.Size(122, 30);
			this.NzReport.TabIndex = 760;
			this.NzReport.Text = "مشـاهده گزارش";
			this.NzReport.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.NzReport.UseThemes = false;
			this.NzReport.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NzReport.WordWrap = false;
			this.NzReport.Click += new System.EventHandler(this.NzReport_Click);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label3.Location = new System.Drawing.Point(1268, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 23);
			this.label3.TabIndex = 761;
			this.label3.Text = "وضعیت فعلی :";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label2.Location = new System.Drawing.Point(1268, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 23);
			this.label2.TabIndex = 761;
			this.label2.Text = "شخص :";
			// 
			// FormSuratHesabKeshavarz
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1357, 715);
			this.Controls.Add(this.stiViewerControl1);
			this.Controls.Add(this.mS_Panel1);
			this.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormSuratHesabKeshavarz";
			this.Text = "صورت حساب جامع کشاورز";
			this.mS_Panel1.ResumeLayout(false);
			this.mS_Panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl1;
		private MS_Control.Controls.MS_Panel mS_Panel1;
		private NZ.General.WinForms.Component.NzRemainCustomer NzCustomerRemain;
		private NZ.General.WinForms.Component.NzPeople NzCustomer;
		private MS_Control.Controls.MS_Button_GridX NzReport;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}