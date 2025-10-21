namespace Nz.Site.Winforms.App
{
	partial class FormProducts
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
			Janus.Windows.GridEX.GridEXLayout NsGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem1 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem2 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem3 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem4 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem5 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem6 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem7 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem8 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem9 = new Janus.Windows.EditControls.UIComboBoxItem();
			this.NsGrid = new MS_Control.Controls.MS_GridX();
			this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
			this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
			this.mS_Panel1 = new MS_Control.Controls.MS_Panel();
			this.NsUpdatePrice = new MS_Control.Controls.MS_CheckBox();
			this.NsUpdateMeqdar = new MS_Control.Controls.MS_CheckBox();
			this.NsCategories = new MS_Control.Controls.MS_ComboBox_Janus();
			this.NsStockStatus = new MS_Control.Controls.MS_ComboBox_Janus();
			this.NsPriceKind = new MS_Control.Controls.MS_ComboBox_Janus();
			this.NsUpdate = new MS_Control.Controls.MS_Button_GridX();
			this.NzLoading2 = new System.Windows.Forms.PictureBox();
			this.NzReport = new MS_Control.Controls.MS_Button_GridX();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.uiTabPage14 = new Janus.Windows.UI.Tab.UITabPage();
			this.mS_GridX_Setting1 = new MS_Control.Controls.MS_GridX_Setting();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
			((System.ComponentModel.ISupportInitialize)(this.NsGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
			this.Tab_Control_Main.SuspendLayout();
			this.uiTabPage12.SuspendLayout();
			this.mS_Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NzLoading2)).BeginInit();
			this.mS_GridX_Setting1.SuspendLayout();
			this.SuspendLayout();
			// 
			// NsGrid
			// 
			this.NsGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.NsGrid.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NsGrid.AlternatingColors = true;
			this.NsGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NsGrid.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NsGrid.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
			this.NsGrid.BuiltInTextsData = resources.GetString("NsGrid.BuiltInTextsData");
			this.NsGrid.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
			this.NsGrid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			NsGrid_DesignTimeLayout.LayoutString = resources.GetString("NsGrid_DesignTimeLayout.LayoutString");
			this.NsGrid.DesignTimeLayout = NsGrid_DesignTimeLayout;
			this.NsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NsGrid.DynamicFiltering = true;
			this.NsGrid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.NsGrid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.NsGrid.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.NsGrid.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsGrid.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.NsGrid.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
			this.NsGrid.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
			this.NsGrid.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsGrid.GridLineColor = System.Drawing.Color.Black;
			this.NsGrid.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.NsGrid.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
			this.NsGrid.GroupByBoxVisible = false;
			this.NsGrid.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.NsGrid.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NsGrid.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.NsGrid.Location = new System.Drawing.Point(0, 45);
			this.NsGrid.Name = "NsGrid";
			this.NsGrid.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.NsGrid.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.NsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsGrid.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.NsGrid.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.NsGrid.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NsGrid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.NsGrid.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
			this.NsGrid.SelectOnExpand = false;
			this.NsGrid.Size = new System.Drawing.Size(1499, 486);
			this.NsGrid.TabIndex = 719;
			this.NsGrid.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NsGrid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsGrid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.NsGrid.TreeLineColor = System.Drawing.Color.Black;
			this.NsGrid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// Tab_Control_Main
			// 
			this.Tab_Control_Main.BackColor = System.Drawing.Color.Transparent;
			this.Tab_Control_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Tab_Control_Main.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Tab_Control_Main.Location = new System.Drawing.Point(0, 0);
			this.Tab_Control_Main.MultiLine = true;
			this.Tab_Control_Main.Name = "Tab_Control_Main";
			this.Tab_Control_Main.Office2007CustomColor = System.Drawing.Color.Transparent;
			this.Tab_Control_Main.ShowFocusRectangle = false;
			this.Tab_Control_Main.Size = new System.Drawing.Size(1533, 533);
			this.Tab_Control_Main.TabIndex = 731;
			this.Tab_Control_Main.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage12,
            this.uiTabPage14});
			this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Tab_Control_Main.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.PowderBlue;
			this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
			this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.Font = new System.Drawing.Font("IRANSans(Small) Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.FontSize = 14F;
			this.Tab_Control_Main.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right;
			this.Tab_Control_Main.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Vertical;
			this.Tab_Control_Main.UseThemes = false;
			this.Tab_Control_Main.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
			// 
			// uiTabPage12
			// 
			this.uiTabPage12.Controls.Add(this.NsGrid);
			this.uiTabPage12.Controls.Add(this.mS_Panel1);
			this.uiTabPage12.Location = new System.Drawing.Point(1, 1);
			this.uiTabPage12.Name = "uiTabPage12";
			this.uiTabPage12.PanelFormatStyle.Alpha = 70;
			this.uiTabPage12.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.uiTabPage12.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.uiTabPage12.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
			this.uiTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uiTabPage12.Size = new System.Drawing.Size(1499, 531);
			this.uiTabPage12.TabStop = true;
			this.uiTabPage12.Text = "اطلاعات";
			// 
			// mS_Panel1
			// 
			this.mS_Panel1.Controls.Add(this.NsUpdatePrice);
			this.mS_Panel1.Controls.Add(this.NsUpdateMeqdar);
			this.mS_Panel1.Controls.Add(this.NsCategories);
			this.mS_Panel1.Controls.Add(this.NsStockStatus);
			this.mS_Panel1.Controls.Add(this.NsPriceKind);
			this.mS_Panel1.Controls.Add(this.NsUpdate);
			this.mS_Panel1.Controls.Add(this.NzLoading2);
			this.mS_Panel1.Controls.Add(this.NzReport);
			this.mS_Panel1.Controls.Add(this.label2);
			this.mS_Panel1.Controls.Add(this.label1);
			this.mS_Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.mS_Panel1.Location = new System.Drawing.Point(0, 0);
			this.mS_Panel1.MS_BorderColor = System.Drawing.Color.Aqua;
			this.mS_Panel1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Panel1.MS_Color_End = System.Drawing.Color.SkyBlue;
			this.mS_Panel1.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.mS_Panel1.Name = "mS_Panel1";
			this.mS_Panel1.Size = new System.Drawing.Size(1499, 45);
			this.mS_Panel1.TabIndex = 720;
			// 
			// NsUpdatePrice
			// 
			this.NsUpdatePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsUpdatePrice.BackColor = System.Drawing.Color.Transparent;
			this.NsUpdatePrice.Cursor = System.Windows.Forms.Cursors.Default;
			this.NsUpdatePrice.Location = new System.Drawing.Point(1142, 7);
			this.NsUpdatePrice.Margin = new System.Windows.Forms.Padding(7, 21, 7, 21);
			this.NsUpdatePrice.MS_BorderColor = System.Drawing.Color.Transparent;
			this.NsUpdatePrice.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsUpdatePrice.MS_Change_Border_Color_On_Enter = false;
			this.NsUpdatePrice.MS_Change_Color_On_Checked = false;
			this.NsUpdatePrice.MS_Change_Color_On_Enter = false;
			this.NsUpdatePrice.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsUpdatePrice.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsUpdatePrice.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsUpdatePrice.MS_Exit_By_Down = true;
			this.NsUpdatePrice.MS_Exit_By_Enter = true;
			this.NsUpdatePrice.MS_Exit_By_Up = true;
			this.NsUpdatePrice.MS_Last_Control = null;
			this.NsUpdatePrice.MS_Next_Control = null;
			this.NsUpdatePrice.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.NsUpdatePrice.Name = "NsUpdatePrice";
			this.NsUpdatePrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsUpdatePrice.ShowFocusRectangle = false;
			this.NsUpdatePrice.Size = new System.Drawing.Size(165, 31);
			this.NsUpdatePrice.TabIndex = 820;
			this.NsUpdatePrice.Text = "   بروزرسانی نرخ محصولات";
			this.NsUpdatePrice.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NsUpdatePrice.CheckedChanged += new System.EventHandler(this.NsUpdatePrice_CheckedChanged);
			// 
			// NsUpdateMeqdar
			// 
			this.NsUpdateMeqdar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsUpdateMeqdar.BackColor = System.Drawing.Color.Transparent;
			this.NsUpdateMeqdar.Cursor = System.Windows.Forms.Cursors.Default;
			this.NsUpdateMeqdar.Location = new System.Drawing.Point(1321, 7);
			this.NsUpdateMeqdar.Margin = new System.Windows.Forms.Padding(7, 21, 7, 21);
			this.NsUpdateMeqdar.MS_BorderColor = System.Drawing.Color.Transparent;
			this.NsUpdateMeqdar.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsUpdateMeqdar.MS_Change_Border_Color_On_Enter = false;
			this.NsUpdateMeqdar.MS_Change_Color_On_Checked = false;
			this.NsUpdateMeqdar.MS_Change_Color_On_Enter = false;
			this.NsUpdateMeqdar.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsUpdateMeqdar.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsUpdateMeqdar.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsUpdateMeqdar.MS_Exit_By_Down = true;
			this.NsUpdateMeqdar.MS_Exit_By_Enter = true;
			this.NsUpdateMeqdar.MS_Exit_By_Up = true;
			this.NsUpdateMeqdar.MS_Last_Control = null;
			this.NsUpdateMeqdar.MS_Next_Control = null;
			this.NsUpdateMeqdar.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.NsUpdateMeqdar.Name = "NsUpdateMeqdar";
			this.NsUpdateMeqdar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsUpdateMeqdar.ShowFocusRectangle = false;
			this.NsUpdateMeqdar.Size = new System.Drawing.Size(171, 31);
			this.NsUpdateMeqdar.TabIndex = 820;
			this.NsUpdateMeqdar.Text = "   بروز رسانی تعداد موجودی";
			this.NsUpdateMeqdar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			// 
			// NsCategories
			// 
			this.NsCategories.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.NsCategories.Cursor = System.Windows.Forms.Cursors.Default;
			this.NsCategories.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			uiComboBoxItem1.FormatStyle.Alpha = 0;
			uiComboBoxItem1.IsSeparator = false;
			uiComboBoxItem1.Text = "همه دسته ها";
			this.NsCategories.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem1});
			this.NsCategories.Location = new System.Drawing.Point(387, 8);
			this.NsCategories.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsCategories.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsCategories.MS_Change_Border_Color_On_Enter = true;
			this.NsCategories.MS_Change_Color_On_Enter = true;
			this.NsCategories.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsCategories.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsCategories.MS_Exit_By_Down = true;
			this.NsCategories.MS_Exit_By_Enter = true;
			this.NsCategories.MS_Exit_By_Up = true;
			this.NsCategories.MS_Last_Control = null;
			this.NsCategories.MS_Next_Control = null;
			this.NsCategories.Name = "NsCategories";
			this.NsCategories.Size = new System.Drawing.Size(222, 29);
			this.NsCategories.TabIndex = 773;
			this.NsCategories.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			// 
			// NsStockStatus
			// 
			this.NsStockStatus.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.NsStockStatus.Cursor = System.Windows.Forms.Cursors.Default;
			this.NsStockStatus.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			uiComboBoxItem2.FormatStyle.Alpha = 0;
			uiComboBoxItem2.IsSeparator = false;
			uiComboBoxItem2.Text = "همه محصولات";
			uiComboBoxItem3.FormatStyle.Alpha = 0;
			uiComboBoxItem3.IsSeparator = false;
			uiComboBoxItem3.Text = "موجود";
			uiComboBoxItem3.Value = "instock";
			uiComboBoxItem4.FormatStyle.Alpha = 0;
			uiComboBoxItem4.IsSeparator = false;
			uiComboBoxItem4.Text = "ناموجود";
			uiComboBoxItem4.Value = "outofstock";
			uiComboBoxItem5.FormatStyle.Alpha = 0;
			uiComboBoxItem5.IsSeparator = false;
			uiComboBoxItem5.Text = "در پیش خرید";
			uiComboBoxItem5.Value = "onbackorder";
			this.NsStockStatus.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem2,
            uiComboBoxItem3,
            uiComboBoxItem4,
            uiComboBoxItem5});
			this.NsStockStatus.Location = new System.Drawing.Point(170, 8);
			this.NsStockStatus.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsStockStatus.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsStockStatus.MS_Change_Border_Color_On_Enter = true;
			this.NsStockStatus.MS_Change_Color_On_Enter = true;
			this.NsStockStatus.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsStockStatus.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsStockStatus.MS_Exit_By_Down = true;
			this.NsStockStatus.MS_Exit_By_Enter = true;
			this.NsStockStatus.MS_Exit_By_Up = true;
			this.NsStockStatus.MS_Last_Control = null;
			this.NsStockStatus.MS_Next_Control = null;
			this.NsStockStatus.Name = "NsStockStatus";
			this.NsStockStatus.Size = new System.Drawing.Size(111, 29);
			this.NsStockStatus.TabIndex = 773;
			this.NsStockStatus.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			// 
			// NsPriceKind
			// 
			this.NsPriceKind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsPriceKind.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.NsPriceKind.Cursor = System.Windows.Forms.Cursors.Default;
			this.NsPriceKind.Enabled = false;
			this.NsPriceKind.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			uiComboBoxItem6.FormatStyle.Alpha = 0;
			uiComboBoxItem6.IsSeparator = false;
			uiComboBoxItem6.Text = "فروش خرده";
			uiComboBoxItem7.FormatStyle.Alpha = 0;
			uiComboBoxItem7.IsSeparator = false;
			uiComboBoxItem7.Text = "فروش عمـده";
			uiComboBoxItem8.FormatStyle.Alpha = 0;
			uiComboBoxItem8.IsSeparator = false;
			uiComboBoxItem8.Text = "همکاری";
			uiComboBoxItem9.FormatStyle.Alpha = 0;
			uiComboBoxItem9.IsSeparator = false;
			uiComboBoxItem9.Text = "تخفیفات";
			this.NsPriceKind.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem6,
            uiComboBoxItem7,
            uiComboBoxItem8,
            uiComboBoxItem9});
			this.NsPriceKind.Location = new System.Drawing.Point(967, 8);
			this.NsPriceKind.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsPriceKind.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsPriceKind.MS_Change_Border_Color_On_Enter = true;
			this.NsPriceKind.MS_Change_Color_On_Enter = true;
			this.NsPriceKind.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsPriceKind.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsPriceKind.MS_Exit_By_Down = true;
			this.NsPriceKind.MS_Exit_By_Enter = true;
			this.NsPriceKind.MS_Exit_By_Up = true;
			this.NsPriceKind.MS_Last_Control = null;
			this.NsPriceKind.MS_Next_Control = null;
			this.NsPriceKind.Name = "NsPriceKind";
			this.NsPriceKind.Size = new System.Drawing.Size(171, 29);
			this.NsPriceKind.TabIndex = 772;
			this.NsPriceKind.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			// 
			// NsUpdate
			// 
			this.NsUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsUpdate.Cursor = System.Windows.Forms.Cursors.Default;
			this.NsUpdate.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsUpdate.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsUpdate.Image = ((System.Drawing.Image)(resources.GetObject("NsUpdate.Image")));
			this.NsUpdate.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NsUpdate.Location = new System.Drawing.Point(844, 8);
			this.NsUpdate.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsUpdate.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsUpdate.MS_Change_Border_Color_On_Enter = false;
			this.NsUpdate.MS_Change_Color_On_Enter = false;
			this.NsUpdate.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NsUpdate.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NsUpdate.Name = "NsUpdate";
			this.NsUpdate.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NsUpdate.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NsUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsUpdate.ShowFocusRectangle = false;
			this.NsUpdate.Size = new System.Drawing.Size(117, 29);
			this.NsUpdate.TabIndex = 771;
			this.NsUpdate.Text = "بروزرسانی";
			this.NsUpdate.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.NsUpdate.UseThemes = false;
			this.NsUpdate.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NsUpdate.WordWrap = false;
			this.NsUpdate.Click += new System.EventHandler(this.NsUpdate_Click);
			// 
			// NzLoading2
			// 
			this.NzLoading2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.NzLoading2.BackColor = System.Drawing.Color.Transparent;
			this.NzLoading2.Cursor = System.Windows.Forms.Cursors.Default;
			this.NzLoading2.Image = ((System.Drawing.Image)(resources.GetObject("NzLoading2.Image")));
			this.NzLoading2.Location = new System.Drawing.Point(709, 8);
			this.NzLoading2.Name = "NzLoading2";
			this.NzLoading2.Size = new System.Drawing.Size(33, 29);
			this.NzLoading2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.NzLoading2.TabIndex = 770;
			this.NzLoading2.TabStop = false;
			this.NzLoading2.Visible = false;
			// 
			// NzReport
			// 
			this.NzReport.Cursor = System.Windows.Forms.Cursors.Default;
			this.NzReport.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NzReport.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzReport.Image = ((System.Drawing.Image)(resources.GetObject("NzReport.Image")));
			this.NzReport.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NzReport.Location = new System.Drawing.Point(11, 8);
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
			this.NzReport.Size = new System.Drawing.Size(153, 29);
			this.NzReport.TabIndex = 3;
			this.NzReport.Text = "مشـاهده محصولات";
			this.NzReport.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.NzReport.UseThemes = false;
			this.NzReport.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NzReport.WordWrap = false;
			this.NzReport.Click += new System.EventHandler(this.NzReport_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.label2.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label2.Location = new System.Drawing.Point(281, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 23);
			this.label2.TabIndex = 774;
			this.label2.Text = "وضعیت موجودی :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.label1.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label1.Location = new System.Drawing.Point(607, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 774;
			this.label1.Text = "دسته بندی :";
			// 
			// uiTabPage14
			// 
			this.uiTabPage14.AutoScroll = true;
			this.uiTabPage14.Location = new System.Drawing.Point(1, 1);
			this.uiTabPage14.Name = "uiTabPage14";
			this.uiTabPage14.PanelFormatStyle.Alpha = 70;
			this.uiTabPage14.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.uiTabPage14.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.uiTabPage14.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
			this.uiTabPage14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uiTabPage14.Size = new System.Drawing.Size(899, 431);
			this.uiTabPage14.TabStop = true;
			this.uiTabPage14.Text = "پرسش و پاسخ";
			// 
			// mS_GridX_Setting1
			// 
			this.mS_GridX_Setting1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.mS_GridX_Setting1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mS_GridX_Setting1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
			this.mS_GridX_Setting1.Location = new System.Drawing.Point(0, 533);
			this.mS_GridX_Setting1.MS_BorderColor = System.Drawing.Color.DodgerBlue;
			this.mS_GridX_Setting1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_GridX_Setting1.MS_Color_End = System.Drawing.Color.PowderBlue;
			this.mS_GridX_Setting1.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.mS_GridX_Setting1.MS_GridX = this.NsGrid;
			this.mS_GridX_Setting1.Name = "mS_GridX_Setting1";
			this.mS_GridX_Setting1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.mS_GridX_Setting1.Size = new System.Drawing.Size(1533, 25);
			this.mS_GridX_Setting1.TabIndex = 730;
			this.mS_GridX_Setting1.Text = "mS_GridX_Setting1";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// FormProducts
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1533, 558);
			this.Controls.Add(this.Tab_Control_Main);
			this.Controls.Add(this.mS_GridX_Setting1);
			this.Font = new System.Drawing.Font("IRANSans(Small)", 12F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormProducts";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ShowInTaskbar = false;
			this.Text = "محصولات";
			this.Load += new System.EventHandler(this.FormProducts_Load);
			((System.ComponentModel.ISupportInitialize)(this.NsGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
			this.Tab_Control_Main.ResumeLayout(false);
			this.uiTabPage12.ResumeLayout(false);
			this.mS_Panel1.ResumeLayout(false);
			this.mS_Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NzLoading2)).EndInit();
			this.mS_GridX_Setting1.ResumeLayout(false);
			this.mS_GridX_Setting1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MS_Control.Controls.MS_GridX NsGrid;
		private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage14;
		private MS_Control.Controls.MS_GridX_Setting mS_GridX_Setting1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private MS_Control.Controls.MS_Panel mS_Panel1;
		private System.Windows.Forms.PictureBox NzLoading2;
		private MS_Control.Controls.MS_Button_GridX NzReport;
		private MS_Control.Controls.MS_Button_GridX NsUpdate;
		private MS_Control.Controls.MS_ComboBox_Janus NsPriceKind;
		private MS_Control.Controls.MS_ComboBox_Janus NsStockStatus;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private MS_Control.Controls.MS_ComboBox_Janus NsCategories;
		private MS_Control.Controls.MS_CheckBox NsUpdatePrice;
		private MS_Control.Controls.MS_CheckBox NsUpdateMeqdar;
		private MS_Control.Controls.MS_Notify mS_Notify1;
	}
}