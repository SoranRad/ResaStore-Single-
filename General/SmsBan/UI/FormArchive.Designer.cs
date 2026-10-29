namespace SmsBan.UI
{
	partial class FormArchive
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArchive));
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem1 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem2 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem3 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem4 = new Janus.Windows.EditControls.UIComboBoxItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.NsUsersPanel = new System.Windows.Forms.Panel();
			this.NsRefresh = new MS_Control.Controls.MS_Button_GridX();
			this.NsSearch = new MS_Control.Controls.MS_TextBox();
			this.Splitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
			this.NsMessagesContainer = new System.Windows.Forms.Panel();
			this.NsMessages = new System.Windows.Forms.Panel();
			this.NsMessagesSender = new System.Windows.Forms.Panel();
			this.NsMessageText = new MS_Control.Controls.MS_TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.NsNumbers = new MS_Control.Controls.MS_ComboBox_Janus();
			this.NsProirity = new MS_Control.Controls.MS_ComboBox_Janus();
			this.NsSend = new MS_Control.Controls.MS_Button_GridX();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.NsMnuCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.NsMnuDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this.NsMessagesContainer.SuspendLayout();
			this.NsMessagesSender.SuspendLayout();
			this.panel2.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.NsUsersPanel);
			this.panel1.Controls.Add(this.NsRefresh);
			this.panel1.Controls.Add(this.NsSearch);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(794, 0);
			this.panel1.MinimumSize = new System.Drawing.Size(228, 46);
			this.panel1.Name = "panel1";
			this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.panel1.Size = new System.Drawing.Size(284, 629);
			this.panel1.TabIndex = 0;
			// 
			// NsUsersPanel
			// 
			this.NsUsersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsUsersPanel.AutoScroll = true;
			this.NsUsersPanel.Location = new System.Drawing.Point(1, 32);
			this.NsUsersPanel.Name = "NsUsersPanel";
			this.NsUsersPanel.Size = new System.Drawing.Size(283, 596);
			this.NsUsersPanel.TabIndex = 7;
			// 
			// NsRefresh
			// 
			this.NsRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsRefresh.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsRefresh.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsRefresh.Image = ((System.Drawing.Image)(resources.GetObject("NsRefresh.Image")));
			this.NsRefresh.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center;
			this.NsRefresh.ImageSize = new System.Drawing.Size(26, 26);
			this.NsRefresh.Location = new System.Drawing.Point(3, 2);
			this.NsRefresh.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsRefresh.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsRefresh.MS_Change_Border_Color_On_Enter = false;
			this.NsRefresh.MS_Change_Color_On_Enter = false;
			this.NsRefresh.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NsRefresh.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NsRefresh.Name = "NsRefresh";
			this.NsRefresh.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NsRefresh.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NsRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsRefresh.ShowFocusRectangle = false;
			this.NsRefresh.Size = new System.Drawing.Size(31, 29);
			this.NsRefresh.TabIndex = 1;
			this.NsRefresh.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.NsRefresh.UseThemes = false;
			this.NsRefresh.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NsRefresh.WordWrap = false;
			this.NsRefresh.Click += new System.EventHandler(this.NsRefresh_Click);
			// 
			// NsSearch
			// 
			this.NsSearch.AcceptsReturn = true;
			this.NsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsSearch.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
			this.NsSearch.ButtonImage = ((System.Drawing.Image)(resources.GetObject("NsSearch.ButtonImage")));
			this.NsSearch.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image;
			this.NsSearch.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.NsSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsSearch.ImageHorizontalAlignment = Janus.Windows.GridEX.ImageHorizontalAlignment.Center;
			this.NsSearch.Location = new System.Drawing.Point(35, 2);
			this.NsSearch.MaxLength = 500;
			this.NsSearch.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsSearch.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsSearch.MS_Change_Border_Color_On_Enter = true;
			this.NsSearch.MS_Change_Color_On_Enter = true;
			this.NsSearch.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsSearch.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsSearch.MS_Exit_By_Down = false;
			this.NsSearch.MS_Exit_By_Enter = false;
			this.NsSearch.MS_Exit_By_Up = false;
			this.NsSearch.MS_Last_Control = null;
			this.NsSearch.MS_Next_Control = null;
			this.NsSearch.Name = "NsSearch";
			this.NsSearch.Size = new System.Drawing.Size(245, 29);
			this.NsSearch.TabIndex = 0;
			this.NsSearch.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NsSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NsSearch_KeyPress);
			this.NsSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NsSearch_KeyUp);
			// 
			// Splitter1
			// 
			this.Splitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
			this.Splitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.Splitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.Splitter1.Dock = System.Windows.Forms.DockStyle.Right;
			this.Splitter1.ExpandActionClick = false;
			this.Splitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
			this.Splitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.Splitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Splitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.Splitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Splitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.Splitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
			this.Splitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.Splitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(96)))));
			this.Splitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(139)))));
			this.Splitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
			this.Splitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
			this.Splitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
			this.Splitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.Splitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Splitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.Splitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
			this.Splitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.Splitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
			this.Splitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.Splitter1.Location = new System.Drawing.Point(786, 0);
			this.Splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Splitter1.Name = "Splitter1";
			this.Splitter1.Size = new System.Drawing.Size(8, 629);
			this.Splitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
			this.Splitter1.TabIndex = 0;
			this.Splitter1.TabStop = false;
			// 
			// NsMessagesContainer
			// 
			this.NsMessagesContainer.AutoScroll = true;
			this.NsMessagesContainer.Controls.Add(this.NsMessages);
			this.NsMessagesContainer.Controls.Add(this.NsMessagesSender);
			this.NsMessagesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NsMessagesContainer.Location = new System.Drawing.Point(0, 0);
			this.NsMessagesContainer.Name = "NsMessagesContainer";
			this.NsMessagesContainer.Size = new System.Drawing.Size(786, 629);
			this.NsMessagesContainer.TabIndex = 750;
			// 
			// NsMessages
			// 
			this.NsMessages.AutoScroll = true;
			this.NsMessages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NsMessages.Location = new System.Drawing.Point(0, 0);
			this.NsMessages.Name = "NsMessages";
			this.NsMessages.Size = new System.Drawing.Size(786, 559);
			this.NsMessages.TabIndex = 751;
			// 
			// NsMessagesSender
			// 
			this.NsMessagesSender.Controls.Add(this.NsMessageText);
			this.NsMessagesSender.Controls.Add(this.panel2);
			this.NsMessagesSender.Controls.Add(this.NsSend);
			this.NsMessagesSender.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.NsMessagesSender.Location = new System.Drawing.Point(0, 559);
			this.NsMessagesSender.Name = "NsMessagesSender";
			this.NsMessagesSender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsMessagesSender.Size = new System.Drawing.Size(786, 70);
			this.NsMessagesSender.TabIndex = 0;
			// 
			// NsMessageText
			// 
			this.NsMessageText.AcceptsReturn = true;
			this.NsMessageText.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
			this.NsMessageText.ButtonImage = ((System.Drawing.Image)(resources.GetObject("NsMessageText.ButtonImage")));
			this.NsMessageText.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.NsMessageText.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsMessageText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NsMessageText.ImageHorizontalAlignment = Janus.Windows.GridEX.ImageHorizontalAlignment.Center;
			this.NsMessageText.Location = new System.Drawing.Point(253, 0);
			this.NsMessageText.MaxLength = 500;
			this.NsMessageText.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsMessageText.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsMessageText.MS_Change_Border_Color_On_Enter = true;
			this.NsMessageText.MS_Change_Color_On_Enter = true;
			this.NsMessageText.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsMessageText.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsMessageText.MS_Exit_By_Down = false;
			this.NsMessageText.MS_Exit_By_Enter = false;
			this.NsMessageText.MS_Exit_By_Up = false;
			this.NsMessageText.MS_Last_Control = null;
			this.NsMessageText.MS_Next_Control = null;
			this.NsMessageText.Multiline = true;
			this.NsMessageText.Name = "NsMessageText";
			this.NsMessageText.Size = new System.Drawing.Size(533, 70);
			this.NsMessageText.TabIndex = 0;
			this.NsMessageText.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.NsNumbers);
			this.panel2.Controls.Add(this.NsProirity);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(103, 0);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.panel2.Size = new System.Drawing.Size(150, 70);
			this.panel2.TabIndex = 10;
			// 
			// NsNumbers
			// 
			this.NsNumbers.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.NsNumbers.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsNumbers.Dock = System.Windows.Forms.DockStyle.Top;
			uiComboBoxItem1.FormatStyle.Alpha = 0;
			uiComboBoxItem1.Image = ((System.Drawing.Image)(resources.GetObject("uiComboBoxItem1.Image")));
			uiComboBoxItem1.IsSeparator = false;
			uiComboBoxItem1.Text = "فعال";
			uiComboBoxItem2.FormatStyle.Alpha = 0;
			uiComboBoxItem2.Image = ((System.Drawing.Image)(resources.GetObject("uiComboBoxItem2.Image")));
			uiComboBoxItem2.IsSeparator = false;
			uiComboBoxItem2.Text = "غیر فعال";
			this.NsNumbers.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem1,
            uiComboBoxItem2});
			this.NsNumbers.Location = new System.Drawing.Point(4, 0);
			this.NsNumbers.Margin = new System.Windows.Forms.Padding(5);
			this.NsNumbers.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsNumbers.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsNumbers.MS_Change_Border_Color_On_Enter = true;
			this.NsNumbers.MS_Change_Color_On_Enter = true;
			this.NsNumbers.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsNumbers.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsNumbers.MS_Exit_By_Down = true;
			this.NsNumbers.MS_Exit_By_Enter = true;
			this.NsNumbers.MS_Exit_By_Up = true;
			this.NsNumbers.MS_Last_Control = null;
			this.NsNumbers.MS_Next_Control = null;
			this.NsNumbers.Name = "NsNumbers";
			this.NsNumbers.Size = new System.Drawing.Size(142, 29);
			this.NsNumbers.TabIndex = 0;
			this.NsNumbers.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
			this.NsNumbers.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			// 
			// NsProirity
			// 
			this.NsProirity.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.NsProirity.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsProirity.Dock = System.Windows.Forms.DockStyle.Bottom;
			uiComboBoxItem3.FormatStyle.Alpha = 0;
			uiComboBoxItem3.IsSeparator = false;
			uiComboBoxItem3.Text = "ارسال عادی";
			uiComboBoxItem3.Value = ((byte)(0));
			uiComboBoxItem4.FormatStyle.Alpha = 0;
			uiComboBoxItem4.IsSeparator = false;
			uiComboBoxItem4.Text = "ارسال فوری";
			uiComboBoxItem4.Value = ((byte)(3));
			this.NsProirity.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem3,
            uiComboBoxItem4});
			this.NsProirity.Location = new System.Drawing.Point(4, 41);
			this.NsProirity.Margin = new System.Windows.Forms.Padding(5);
			this.NsProirity.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsProirity.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsProirity.MS_Change_Border_Color_On_Enter = true;
			this.NsProirity.MS_Change_Color_On_Enter = true;
			this.NsProirity.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsProirity.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsProirity.MS_Exit_By_Down = true;
			this.NsProirity.MS_Exit_By_Enter = true;
			this.NsProirity.MS_Exit_By_Up = true;
			this.NsProirity.MS_Last_Control = null;
			this.NsProirity.MS_Next_Control = null;
			this.NsProirity.Name = "NsProirity";
			this.NsProirity.Size = new System.Drawing.Size(142, 29);
			this.NsProirity.TabIndex = 1;
			this.NsProirity.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			// 
			// NsSend
			// 
			this.NsSend.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsSend.Dock = System.Windows.Forms.DockStyle.Left;
			this.NsSend.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsSend.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsSend.Image = global::SmsBan.Properties.Resources.Send_Mail;
			this.NsSend.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center;
			this.NsSend.ImageSize = new System.Drawing.Size(32, 32);
			this.NsSend.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText;
			this.NsSend.Location = new System.Drawing.Point(0, 0);
			this.NsSend.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsSend.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsSend.MS_Change_Border_Color_On_Enter = false;
			this.NsSend.MS_Change_Color_On_Enter = false;
			this.NsSend.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NsSend.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NsSend.Name = "NsSend";
			this.NsSend.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NsSend.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NsSend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsSend.ShowFocusRectangle = false;
			this.NsSend.Size = new System.Drawing.Size(103, 70);
			this.NsSend.TabIndex = 1;
			this.NsSend.Text = "ارسال پیامک";
			this.NsSend.UseThemes = false;
			this.NsSend.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NsSend.WordWrap = false;
			this.NsSend.Click += new System.EventHandler(this.NsSend_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NsMnuCopy,
            this.NsMnuDelete});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(145, 70);
			// 
			// NsMnuCopy
			// 
			this.NsMnuCopy.Image = global::SmsBan.Properties.Resources.copy;
			this.NsMnuCopy.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.NsMnuCopy.Name = "NsMnuCopy";
			this.NsMnuCopy.Size = new System.Drawing.Size(144, 28);
			this.NsMnuCopy.Text = "کپی متن";
			this.NsMnuCopy.Click += new System.EventHandler(this.NsMnuCopy_Click);
			// 
			// NsMnuDelete
			// 
			this.NsMnuDelete.Image = global::SmsBan.Properties.Resources.outlook_clean_up;
			this.NsMnuDelete.Name = "NsMnuDelete";
			this.NsMnuDelete.Size = new System.Drawing.Size(144, 28);
			this.NsMnuDelete.Text = "حذف پیامک";
			this.NsMnuDelete.Click += new System.EventHandler(this.NsMnuDelete_Click);
			// 
			// FormArchive
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1078, 629);
			this.Controls.Add(this.NsMessagesContainer);
			this.Controls.Add(this.Splitter1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.Name = "FormArchive";
			this.Text = "لیست پیام ها";
			this.Shown += new System.EventHandler(this.FormArchive_Shown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.NsMessagesContainer.ResumeLayout(false);
			this.NsMessagesSender.ResumeLayout(false);
			this.NsMessagesSender.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private DevComponents.DotNetBar.ExpandableSplitter Splitter1;
		private System.Windows.Forms.Panel NsMessagesContainer;
		private MS_Control.Controls.MS_TextBox NsSearch;
		private MS_Control.Controls.MS_Button_GridX NsRefresh;
		private System.Windows.Forms.Panel NsUsersPanel;
		private System.Windows.Forms.Panel NsMessages;
		private System.Windows.Forms.Panel NsMessagesSender;
		private MS_Control.Controls.MS_TextBox NsMessageText;
		private MS_Control.Controls.MS_Button_GridX NsSend;
		private System.Windows.Forms.Panel panel2;
		private MS_Control.Controls.MS_ComboBox_Janus NsNumbers;
		private MS_Control.Controls.MS_ComboBox_Janus NsProirity;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem NsMnuCopy;
		private System.Windows.Forms.ToolStripMenuItem NsMnuDelete;
	}
}