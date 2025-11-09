namespace Nz.Anbar.WinForms.App
{
    partial class Form_BarCode
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
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem1 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem2 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem3 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem4 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.GridEX.GridEXLayout NzGrid_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BarCode));
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.HeaderImage");
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_3 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.HeaderImage");
			Janus.Windows.GridEX.GridEXLayout NzPrefactorGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
			Janus.Windows.Common.Layouts.JanusLayoutReference NzPrefactorGrid_DesignTimeLayout_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
			Janus.Windows.GridEX.GridEXLayout NzGroupKala_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGroupKala_DesignTimeLayout_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage");
			this.uiTab1 = new Janus.Windows.UI.Tab.UITab();
			this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
			this.Splitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
			this.uiTab2 = new Janus.Windows.UI.Tab.UITab();
			this.uiTabPage5 = new Janus.Windows.UI.Tab.UITabPage();
			this.NzDescription = new MS_Control.Controls.MS_TextBox();
			this.label37 = new System.Windows.Forms.Label();
			this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
			this.NzSumFactor = new MS_Control.Controls.MS_Decimal_Label();
			this.NzSumRows = new MS_Control.Controls.MS_Decimal_Label();
			this.mS_Lable_Ex6 = new MS_Control.Controls.MS_Lable_Ex();
			this.mS_Lable_Ex1 = new MS_Control.Controls.MS_Lable_Ex();
			this.uiGroupBox3 = new Janus.Windows.EditControls.UIGroupBox();
			this.NzKind = new MS_Control.Controls.MS_ComboBox_Janus();
			this.NzOffPrice = new MS_Control.Controls.MS_NumericTextBox();
			this.NzOffPercent = new MS_Control.Controls.MS_NumericTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.mS_Lable_Ex7 = new MS_Control.Controls.MS_Lable_Ex();
			this.label10 = new System.Windows.Forms.Label();
			this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
			this.NzSerial = new MS_Control.Controls.MS_NumericTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.NzDate = new MS_Control.Tarikh.MS_Tarikh_TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.uiGroupBox5 = new Janus.Windows.EditControls.UIGroupBox();
			this.NzCustomerRemain = new NZ.General.WinForms.Component.NzRemainCustomer();
			this.NzCustomer = new NZ.General.WinForms.Component.NzPeople();
			this.label19 = new System.Windows.Forms.Label();
			this.NzGrid = new MS_Control.Controls.MS_GridX();
			this.uiGroupBox6 = new Janus.Windows.EditControls.UIGroupBox();
			this.NzFactorKinds = new Janus.Windows.UI.Tab.UITab();
			this.NzTabPurchaseBack = new Janus.Windows.UI.Tab.UITabPage();
			this.NzPrefactorGrid = new MS_Control.Controls.MS_GridX();
			this.NsGroupKala = new Janus.Windows.UI.Tab.UITabPage();
			this.NzGroupKala = new MS_Control.Controls.MS_GridX();
			this.SubGroupsPanel = new Nz.Anbar.WinForms.Component.GroupKalaFlayoutPanel();
			this.NzTabPurchase = new Janus.Windows.UI.Tab.UITabPage();
			this.NsCopyBarcode = new MS_Control.Controls.MS_Button_GridX();
			this.NsTakhfifPrice = new MS_Control.Controls.MS_Decimal_Label();
			this.NsHamkari = new MS_Control.Controls.MS_Decimal_Label();
			this.NsOmdePrice = new MS_Control.Controls.MS_Decimal_Label();
			this.NsAdiPrice = new MS_Control.Controls.MS_Decimal_Label();
			this.NzBarcodePrice = new Nz.Anbar.WinForms.Component.NzBarcodeReader();
			this.label36 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.NsPriceBarcodeTitle = new Nz.Anbar.WinForms.Component.NzLabel();
			this.label32 = new System.Windows.Forms.Label();
			this.NzLocation = new Nz.Anbar.WinForms.Component.NzLocation();
			this.NzLableLocation = new System.Windows.Forms.Label();
			this.NzFindObject = new Nz.Anbar.WinForms.Component.NzLabel();
			this.nzBarcodeReader1 = new Nz.Anbar.WinForms.Component.NzBarcodeReader();
			this.label13 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mS_Panel2 = new MS_Control.Controls.MS_Panel();
			this.NzNew = new MS_Control.Controls.MS_Button_GridX();
			this.NzPrintA4 = new MS_Control.Controls.MS_Button_GridX();
			this.NzPrintNormalA5 = new MS_Control.Controls.MS_Button_GridX();
			this.NzPosPrint = new MS_Control.Controls.MS_Button_GridX();
			this.NzNewWindows = new MS_Control.Controls.MS_Button_GridX();
			this.NzPayment = new MS_Control.Controls.MS_Button_GridX();
			this.NzSave = new MS_Control.Controls.MS_Button_GridX();
			this.nzObjectPopup1 = new Nz.Anbar.WinForms.Component.NzObjectPopup();
			((System.ComponentModel.ISupportInitialize)(this.uiTab1)).BeginInit();
			this.uiTab1.SuspendLayout();
			this.uiTabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiTab2)).BeginInit();
			this.uiTab2.SuspendLayout();
			this.uiTabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
			this.uiGroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).BeginInit();
			this.uiGroupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
			this.uiGroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox5)).BeginInit();
			this.uiGroupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NzGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox6)).BeginInit();
			this.uiGroupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NzFactorKinds)).BeginInit();
			this.NzFactorKinds.SuspendLayout();
			this.NzTabPurchaseBack.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NzPrefactorGrid)).BeginInit();
			this.NsGroupKala.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NzGroupKala)).BeginInit();
			this.NzTabPurchase.SuspendLayout();
			this.uiTabPage3.SuspendLayout();
			this.mS_Panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// uiTab1
			// 
			this.uiTab1.BackColor = System.Drawing.Color.Transparent;
			this.uiTab1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uiTab1.FirstTabOffset = 20;
			this.uiTab1.Font = new System.Drawing.Font("IRANSans(Small) Medium", 12F);
			this.uiTab1.Location = new System.Drawing.Point(0, 0);
			this.uiTab1.MultiLine = true;
			this.uiTab1.Name = "uiTab1";
			this.uiTab1.Office2007CustomColor = System.Drawing.Color.Transparent;
			this.uiTab1.ShowFocusRectangle = false;
			this.uiTab1.Size = new System.Drawing.Size(1412, 624);
			this.uiTab1.TabIndex = 0;
			this.uiTab1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage3});
			this.uiTab1.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.uiTab1.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.uiTab1.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.PowderBlue;
			this.uiTab1.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
			this.uiTab1.TabsStateStyles.SelectedFormatStyle.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.uiTab1.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right;
			this.uiTab1.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Vertical;
			this.uiTab1.UseThemes = false;
			this.uiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
			// 
			// uiTabPage1
			// 
			this.uiTabPage1.Controls.Add(this.Splitter1);
			this.uiTabPage1.Controls.Add(this.uiTab2);
			this.uiTabPage1.Controls.Add(this.uiGroupBox6);
			this.uiTabPage1.Location = new System.Drawing.Point(1, 1);
			this.uiTabPage1.Name = "uiTabPage1";
			this.uiTabPage1.PanelFormatStyle.Alpha = 150;
			this.uiTabPage1.PanelFormatStyle.BackColor = System.Drawing.Color.PowderBlue;
			this.uiTabPage1.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.uiTabPage1.PanelFormatStyle.BackColorGradient = System.Drawing.Color.LightSkyBlue;
			this.uiTabPage1.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
			this.uiTabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uiTabPage1.Size = new System.Drawing.Size(1380, 622);
			this.uiTabPage1.TabStop = true;
			this.uiTabPage1.Text = "فاکتور";
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
			this.Splitter1.Location = new System.Drawing.Point(804, 0);
			this.Splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Splitter1.Name = "Splitter1";
			this.Splitter1.Size = new System.Drawing.Size(7, 622);
			this.Splitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
			this.Splitter1.TabIndex = 767;
			this.Splitter1.TabStop = false;
			// 
			// uiTab2
			// 
			this.uiTab2.BackColor = System.Drawing.Color.Transparent;
			this.uiTab2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uiTab2.FirstTabOffset = 40;
			this.uiTab2.Font = new System.Drawing.Font("IRANSans(Small) Medium", 12F);
			this.uiTab2.Location = new System.Drawing.Point(0, 0);
			this.uiTab2.MultiLine = true;
			this.uiTab2.Name = "uiTab2";
			this.uiTab2.Office2007CustomColor = System.Drawing.Color.Transparent;
			this.uiTab2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uiTab2.ShowFocusRectangle = false;
			this.uiTab2.ShowTabs = false;
			this.uiTab2.Size = new System.Drawing.Size(811, 622);
			this.uiTab2.TabIndex = 766;
			this.uiTab2.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage5});
			this.uiTab2.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.uiTab2.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.uiTab2.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.PowderBlue;
			this.uiTab2.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
			this.uiTab2.TabsStateStyles.SelectedFormatStyle.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.uiTab2.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Horizontal;
			this.uiTab2.UseThemes = false;
			this.uiTab2.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
			// 
			// uiTabPage5
			// 
			this.uiTabPage5.Controls.Add(this.NzDescription);
			this.uiTabPage5.Controls.Add(this.label37);
			this.uiTabPage5.Controls.Add(this.uiGroupBox2);
			this.uiTabPage5.Controls.Add(this.uiGroupBox3);
			this.uiTabPage5.Controls.Add(this.uiGroupBox1);
			this.uiTabPage5.Controls.Add(this.uiGroupBox5);
			this.uiTabPage5.Controls.Add(this.NzGrid);
			this.uiTabPage5.Location = new System.Drawing.Point(1, 1);
			this.uiTabPage5.Name = "uiTabPage5";
			this.uiTabPage5.PanelFormatStyle.Alpha = 150;
			this.uiTabPage5.PanelFormatStyle.BackColor = System.Drawing.Color.PowderBlue;
			this.uiTabPage5.PanelFormatStyle.BackColorGradient = System.Drawing.Color.PowderBlue;
			this.uiTabPage5.Size = new System.Drawing.Size(809, 620);
			this.uiTabPage5.TabStop = true;
			this.uiTabPage5.Text = "ریـز فـاکتـور";
			// 
			// NzDescription
			// 
			this.NzDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NzDescription.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzDescription.Location = new System.Drawing.Point(4, 29);
			this.NzDescription.MaxLength = 300;
			this.NzDescription.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzDescription.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzDescription.MS_Change_Border_Color_On_Enter = true;
			this.NzDescription.MS_Change_Color_On_Enter = true;
			this.NzDescription.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzDescription.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzDescription.MS_Exit_By_Down = true;
			this.NzDescription.MS_Exit_By_Enter = true;
			this.NzDescription.MS_Exit_By_Up = true;
			this.NzDescription.MS_Last_Control = null;
			this.NzDescription.MS_Next_Control = null;
			this.NzDescription.Multiline = true;
			this.NzDescription.Name = "NzDescription";
			this.NzDescription.Size = new System.Drawing.Size(131, 94);
			this.NzDescription.TabIndex = 162;
			// 
			// label37
			// 
			this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label37.AutoSize = true;
			this.label37.BackColor = System.Drawing.Color.Transparent;
			this.label37.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label37.Location = new System.Drawing.Point(93, 7);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(41, 23);
			this.label37.TabIndex = 163;
			this.label37.Text = "شرح :";
			// 
			// uiGroupBox2
			// 
			this.uiGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.uiGroupBox2.BackColor = System.Drawing.Color.Transparent;
			this.uiGroupBox2.BorderColor = System.Drawing.Color.DarkTurquoise;
			this.uiGroupBox2.Controls.Add(this.NzSumFactor);
			this.uiGroupBox2.Controls.Add(this.NzSumRows);
			this.uiGroupBox2.Controls.Add(this.mS_Lable_Ex6);
			this.uiGroupBox2.Controls.Add(this.mS_Lable_Ex1);
			this.uiGroupBox2.Location = new System.Drawing.Point(139, 3);
			this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.uiGroupBox2.Name = "uiGroupBox2";
			this.uiGroupBox2.Size = new System.Drawing.Size(168, 120);
			this.uiGroupBox2.TabIndex = 9;
			// 
			// NzSumFactor
			// 
			this.NzSumFactor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NzSumFactor.BackColor = System.Drawing.Color.Lavender;
			this.NzSumFactor.Font = new System.Drawing.Font("IRANSans(Small)", 17F);
			this.NzSumFactor.Location = new System.Drawing.Point(6, 82);
			this.NzSumFactor.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzSumFactor.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzSumFactor.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.NzSumFactor.MS_Format_String = "0,0.##;(0,0.##); ";
			this.NzSumFactor.Name = "NzSumFactor";
			this.NzSumFactor.Size = new System.Drawing.Size(157, 33);
			this.NzSumFactor.TabIndex = 774;
			this.NzSumFactor.Text = " ";
			this.NzSumFactor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NzSumRows
			// 
			this.NzSumRows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NzSumRows.BackColor = System.Drawing.Color.Lavender;
			this.NzSumRows.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.NzSumRows.Location = new System.Drawing.Point(6, 28);
			this.NzSumRows.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzSumRows.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzSumRows.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.NzSumRows.MS_Format_String = "0,0.##;(0,0.##); ";
			this.NzSumRows.Name = "NzSumRows";
			this.NzSumRows.Size = new System.Drawing.Size(157, 32);
			this.NzSumRows.TabIndex = 771;
			this.NzSumRows.Text = " ";
			this.NzSumRows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// mS_Lable_Ex6
			// 
			this.mS_Lable_Ex6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Lable_Ex6.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.mS_Lable_Ex6.Location = new System.Drawing.Point(6, 59);
			this.mS_Lable_Ex6.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.mS_Lable_Ex6.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
			this.mS_Lable_Ex6.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex6.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex6.Name = "mS_Lable_Ex6";
			this.mS_Lable_Ex6.Size = new System.Drawing.Size(159, 27);
			this.mS_Lable_Ex6.TabIndex = 773;
			this.mS_Lable_Ex6.Text = "مبلغ قابل پرداخت :";
			this.mS_Lable_Ex6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mS_Lable_Ex1
			// 
			this.mS_Lable_Ex1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Lable_Ex1.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.mS_Lable_Ex1.Location = new System.Drawing.Point(6, 3);
			this.mS_Lable_Ex1.MS_BorderColor = System.Drawing.Color.Tan;
			this.mS_Lable_Ex1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
			this.mS_Lable_Ex1.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex1.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex1.Name = "mS_Lable_Ex1";
			this.mS_Lable_Ex1.Size = new System.Drawing.Size(157, 29);
			this.mS_Lable_Ex1.TabIndex = 770;
			this.mS_Lable_Ex1.Text = "مجموع اقلام :";
			this.mS_Lable_Ex1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uiGroupBox3
			// 
			this.uiGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.uiGroupBox3.BackColor = System.Drawing.Color.Transparent;
			this.uiGroupBox3.BorderColor = System.Drawing.Color.DarkTurquoise;
			this.uiGroupBox3.Controls.Add(this.NzKind);
			this.uiGroupBox3.Controls.Add(this.NzOffPrice);
			this.uiGroupBox3.Controls.Add(this.NzOffPercent);
			this.uiGroupBox3.Controls.Add(this.label9);
			this.uiGroupBox3.Controls.Add(this.mS_Lable_Ex7);
			this.uiGroupBox3.Controls.Add(this.label10);
			this.uiGroupBox3.Location = new System.Drawing.Point(312, 3);
			this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(2);
			this.uiGroupBox3.Name = "uiGroupBox3";
			this.uiGroupBox3.Size = new System.Drawing.Size(135, 120);
			this.uiGroupBox3.TabIndex = 7;
			// 
			// NzKind
			// 
			this.NzKind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzKind.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.NzKind.Cursor = System.Windows.Forms.Cursors.Hand;
			uiComboBoxItem1.FormatStyle.Alpha = 0;
			uiComboBoxItem1.IsSeparator = false;
			uiComboBoxItem1.Text = "فروش عادی";
			uiComboBoxItem2.FormatStyle.Alpha = 0;
			uiComboBoxItem2.IsSeparator = false;
			uiComboBoxItem2.Text = "فروش عمده";
			uiComboBoxItem3.FormatStyle.Alpha = 0;
			uiComboBoxItem3.IsSeparator = false;
			uiComboBoxItem3.Text = "همکاری";
			uiComboBoxItem4.FormatStyle.Alpha = 0;
			uiComboBoxItem4.IsSeparator = false;
			uiComboBoxItem4.Text = "تخفیفات";
			this.NzKind.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem1,
            uiComboBoxItem2,
            uiComboBoxItem3,
            uiComboBoxItem4});
			this.NzKind.Location = new System.Drawing.Point(4, 29);
			this.NzKind.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzKind.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzKind.MS_Change_Border_Color_On_Enter = true;
			this.NzKind.MS_Change_Color_On_Enter = true;
			this.NzKind.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzKind.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzKind.MS_Exit_By_Down = true;
			this.NzKind.MS_Exit_By_Enter = true;
			this.NzKind.MS_Exit_By_Up = true;
			this.NzKind.MS_Last_Control = null;
			this.NzKind.MS_Next_Control = null;
			this.NzKind.Name = "NzKind";
			this.NzKind.Size = new System.Drawing.Size(125, 27);
			this.NzKind.TabIndex = 0;
			this.NzKind.TabStop = false;
			this.NzKind.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			// 
			// NzOffPrice
			// 
			this.NzOffPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzOffPrice.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NzOffPrice.Location = new System.Drawing.Point(49, 85);
			this.NzOffPrice.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzOffPrice.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzOffPrice.MS_Change_Border_Color_On_Enter = true;
			this.NzOffPrice.MS_Change_Color_On_Enter = true;
			this.NzOffPrice.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzOffPrice.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzOffPrice.MS_Exit_By_Down = true;
			this.NzOffPrice.MS_Exit_By_Enter = true;
			this.NzOffPrice.MS_Exit_By_Up = true;
			this.NzOffPrice.MS_Is_Negative = false;
			this.NzOffPrice.MS_Last_Control = null;
			this.NzOffPrice.MS_Next_Control = null;
			this.NzOffPrice.Name = "NzOffPrice";
			this.NzOffPrice.Size = new System.Drawing.Size(80, 31);
			this.NzOffPrice.TabIndex = 1;
			this.NzOffPrice.TabStop = false;
			this.NzOffPrice.Text = "0";
			this.NzOffPrice.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
			this.NzOffPrice.TextChanged += new System.EventHandler(this.NzOffPrice_TextChanged);
			// 
			// NzOffPercent
			// 
			this.NzOffPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzOffPercent.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NzOffPercent.Location = new System.Drawing.Point(4, 85);
			this.NzOffPercent.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzOffPercent.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzOffPercent.MS_Change_Border_Color_On_Enter = true;
			this.NzOffPercent.MS_Change_Color_On_Enter = true;
			this.NzOffPercent.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzOffPercent.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzOffPercent.MS_Exit_By_Down = true;
			this.NzOffPercent.MS_Exit_By_Enter = true;
			this.NzOffPercent.MS_Exit_By_Up = true;
			this.NzOffPercent.MS_Is_Negative = false;
			this.NzOffPercent.MS_Last_Control = null;
			this.NzOffPercent.MS_Next_Control = null;
			this.NzOffPercent.Name = "NzOffPercent";
			this.NzOffPercent.Size = new System.Drawing.Size(27, 31);
			this.NzOffPercent.TabIndex = 2;
			this.NzOffPercent.TabStop = false;
			this.NzOffPercent.Text = "0";
			this.NzOffPercent.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.NzOffPercent.TextChanged += new System.EventHandler(this.NzOffPercent_TextChanged);
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label9.Location = new System.Drawing.Point(69, 6);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(64, 23);
			this.label9.TabIndex = 764;
			this.label9.Text = "نوع فروش";
			// 
			// mS_Lable_Ex7
			// 
			this.mS_Lable_Ex7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Lable_Ex7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.mS_Lable_Ex7.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.mS_Lable_Ex7.Location = new System.Drawing.Point(30, 85);
			this.mS_Lable_Ex7.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.mS_Lable_Ex7.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Lable_Ex7.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex7.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex7.Name = "mS_Lable_Ex7";
			this.mS_Lable_Ex7.Size = new System.Drawing.Size(20, 31);
			this.mS_Lable_Ex7.TabIndex = 773;
			this.mS_Lable_Ex7.Text = "%";
			this.mS_Lable_Ex7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label10.Location = new System.Drawing.Point(86, 64);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 23);
			this.label10.TabIndex = 764;
			this.label10.Text = "تخفیف";
			// 
			// uiGroupBox1
			// 
			this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.uiGroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.uiGroupBox1.BorderColor = System.Drawing.Color.DarkTurquoise;
			this.uiGroupBox1.Controls.Add(this.NzSerial);
			this.uiGroupBox1.Controls.Add(this.label3);
			this.uiGroupBox1.Controls.Add(this.NzDate);
			this.uiGroupBox1.Controls.Add(this.label1);
			this.uiGroupBox1.Location = new System.Drawing.Point(451, 3);
			this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.uiGroupBox1.Name = "uiGroupBox1";
			this.uiGroupBox1.Size = new System.Drawing.Size(111, 120);
			this.uiGroupBox1.TabIndex = 6;
			// 
			// NzSerial
			// 
			this.NzSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzSerial.ButtonText = "000";
			this.NzSerial.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzSerial.DigitGroup = false;
			this.NzSerial.Font = new System.Drawing.Font("IRANSans(Small)", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzSerial.Location = new System.Drawing.Point(6, 29);
			this.NzSerial.MaxLength = 4;
			this.NzSerial.Mode = MS_Control.Controls.MS_NumericTextBox.TextBoxMode.IntNumber;
			this.NzSerial.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzSerial.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzSerial.MS_Change_Border_Color_On_Enter = true;
			this.NzSerial.MS_Change_Color_On_Enter = true;
			this.NzSerial.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzSerial.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzSerial.MS_Exit_By_Down = true;
			this.NzSerial.MS_Exit_By_Enter = true;
			this.NzSerial.MS_Exit_By_Up = true;
			this.NzSerial.MS_Is_Negative = false;
			this.NzSerial.MS_Last_Control = null;
			this.NzSerial.MS_Next_Control = null;
			this.NzSerial.Name = "NzSerial";
			this.NzSerial.Size = new System.Drawing.Size(99, 31);
			this.NzSerial.TabIndex = 0;
			this.NzSerial.TabStop = false;
			this.NzSerial.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.NzSerial.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label3.Location = new System.Drawing.Point(67, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 23);
			this.label3.TabIndex = 764;
			this.label3.Text = "سریال";
			// 
			// NzDate
			// 
			this.NzDate.AllowInternalTab = false;
			this.NzDate.AllowResizeDropDown = false;
			this.NzDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzDate.AutoHeight = false;
			this.NzDate.BackColor = System.Drawing.Color.White;
			this.NzDate.ControlSize = new System.Drawing.Size(0, 0);
			this.NzDate.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.NzDate.DropSize = new System.Drawing.Size(0, 0);
			this.NzDate.Font = new System.Drawing.Font("IRANSans(Small)", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzDate.Location = new System.Drawing.Point(2, 86);
			this.NzDate.MinimumSize = new System.Drawing.Size(107, 29);
			this.NzDate.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzDate.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzDate.MS_Change_Border_Color_On_Enter = true;
			this.NzDate.MS_Change_Color_On_Enter = true;
			this.NzDate.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzDate.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzDate.MS_Exit_By_Down = true;
			this.NzDate.MS_Exit_By_Enter = true;
			this.NzDate.MS_Exit_By_Up = true;
			this.NzDate.MS_Last_Control = null;
			this.NzDate.MS_Next_Control = null;
			this.NzDate.MS_Separation = '/';
			this.NzDate.MS_Tarikh = null;
			this.NzDate.Name = "NzDate";
			this.NzDate.ReadOnly = false;
			this.NzDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.NzDate.Size = new System.Drawing.Size(107, 29);
			this.NzDate.TabIndex = 1;
			this.NzDate.TabStop = false;
			this.NzDate.Text = "//";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label1.Location = new System.Drawing.Point(70, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 23);
			this.label1.TabIndex = 762;
			this.label1.Text = "تاریخ";
			// 
			// uiGroupBox5
			// 
			this.uiGroupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.uiGroupBox5.BackColor = System.Drawing.Color.Transparent;
			this.uiGroupBox5.BorderColor = System.Drawing.Color.DarkTurquoise;
			this.uiGroupBox5.Controls.Add(this.NzCustomerRemain);
			this.uiGroupBox5.Controls.Add(this.NzCustomer);
			this.uiGroupBox5.Controls.Add(this.label19);
			this.uiGroupBox5.Location = new System.Drawing.Point(565, 2);
			this.uiGroupBox5.Margin = new System.Windows.Forms.Padding(2);
			this.uiGroupBox5.Name = "uiGroupBox5";
			this.uiGroupBox5.Size = new System.Drawing.Size(234, 121);
			this.uiGroupBox5.TabIndex = 5;
			// 
			// NzCustomerRemain
			// 
			this.NzCustomerRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzCustomerRemain.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NzCustomerRemain.Location = new System.Drawing.Point(4, 89);
			this.NzCustomerRemain.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzCustomerRemain.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzCustomerRemain.MS_Color_End = System.Drawing.Color.Empty;
			this.NzCustomerRemain.MS_Color_Start = System.Drawing.Color.Empty;
			this.NzCustomerRemain.Name = "NzCustomerRemain";
			this.NzCustomerRemain.Size = new System.Drawing.Size(225, 29);
			this.NzCustomerRemain.TabIndex = 771;
			this.NzCustomerRemain.Text = "0";
			this.NzCustomerRemain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NzCustomer
			// 
			this.NzCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzCustomer.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.NzCustomer.DropSize = new System.Drawing.Size(225, 31);
			this.NzCustomer.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NzCustomer.Location = new System.Drawing.Point(4, 29);
			this.NzCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
			this.NzCustomer.Size = new System.Drawing.Size(225, 31);
			this.NzCustomer.TabIndex = 0;
			this.NzCustomer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NzCustomer.MS_On_Row_Selected += new System.EventHandler<MS_Control.TSDD.On_Selected>(this.NzCustomer_MS_On_Row_Selected);
			// 
			// label19
			// 
			this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label19.AutoSize = true;
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label19.Location = new System.Drawing.Point(138, 8);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(94, 23);
			this.label19.TabIndex = 768;
			this.label19.Text = "انتخـاب مشتری";
			// 
			// NzGrid
			// 
			this.NzGrid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NzGrid.AlternatingColors = true;
			this.NzGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.PowderBlue;
			this.NzGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NzGrid.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NzGrid.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
			this.NzGrid.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell;
			this.NzGrid.CellToolTip = Janus.Windows.GridEX.CellToolTip.NoToolTip;
			this.NzGrid.ColumnAutoResize = true;
			this.NzGrid.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
			this.NzGrid.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
			this.NzGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.NzGrid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			this.NzGrid.DynamicFiltering = true;
			this.NzGrid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell;
			this.NzGrid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.NzGrid.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.NzGrid.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzGrid.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.NzGrid.FocusCellFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat;
			this.NzGrid.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzGrid.FocusCellFormatStyle.FontSize = 15F;
			this.NzGrid.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
			this.NzGrid.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.NzGrid.GridLineColor = System.Drawing.Color.Black;
			this.NzGrid.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.NzGrid.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
			this.NzGrid.GroupByBoxVisible = false;
			this.NzGrid.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.NzGrid.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NzGrid.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			NzGrid_Layout_0.IsCurrentLayout = true;
			NzGrid_Layout_0.Key = "Items";
			NzGrid_Layout_0_Reference_0.Instance = ((object)(resources.GetObject("NzGrid_Layout_0_Reference_0.Instance")));
			NzGrid_Layout_0_Reference_1.Instance = ((object)(resources.GetObject("NzGrid_Layout_0_Reference_1.Instance")));
			NzGrid_Layout_0_Reference_2.Instance = ((object)(resources.GetObject("NzGrid_Layout_0_Reference_2.Instance")));
			NzGrid_Layout_0_Reference_3.Instance = ((object)(resources.GetObject("NzGrid_Layout_0_Reference_3.Instance")));
			NzGrid_Layout_0.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            NzGrid_Layout_0_Reference_0,
            NzGrid_Layout_0_Reference_1,
            NzGrid_Layout_0_Reference_2,
            NzGrid_Layout_0_Reference_3});
			NzGrid_Layout_0.LayoutString = resources.GetString("NzGrid_Layout_0.LayoutString");
			this.NzGrid.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            NzGrid_Layout_0});
			this.NzGrid.Location = new System.Drawing.Point(0, 128);
			this.NzGrid.Name = "NzGrid";
			this.NzGrid.NewRowEnterKeyBehavior = Janus.Windows.GridEX.NewRowEnterKeyBehavior.AddRowAndMoveToAddedRow;
			this.NzGrid.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.NzGrid.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.NzGrid.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.NzGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzGrid.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.NzGrid.SelectedFormatStyle.BackColor = System.Drawing.Color.AntiqueWhite;
			this.NzGrid.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NzGrid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.AntiqueWhite;
			this.NzGrid.SelectOnExpand = false;
			this.NzGrid.Size = new System.Drawing.Size(799, 492);
			this.NzGrid.TabIndex = 1;
			this.NzGrid.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
			this.NzGrid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzGrid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.NzGrid.TreeLineColor = System.Drawing.Color.Black;
			this.NzGrid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.NzGrid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NzGrid.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.ms_grid_RowDoubleClick);
			this.NzGrid.EditModeChanged += new System.EventHandler(this.ms_grid_EditModeChanged);
			this.NzGrid.CancelingRowEdit += new Janus.Windows.GridEX.RowActionCancelEventHandler(this.NzGrid_CancelingRowEdit);
			this.NzGrid.GetNewRow += new Janus.Windows.GridEX.GetNewRowEventHandler(this.NzGrid_GetNewRow);
			this.NzGrid.CellUpdated += new Janus.Windows.GridEX.ColumnActionEventHandler(this.ms_grid_CellUpdated);
			this.NzGrid.RecordAdded += new System.EventHandler(this.NzGrid_RecordAdded);
			this.NzGrid.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.ms_grid_UpdatingRecord);
			this.NzGrid.AddingRecord += new System.ComponentModel.CancelEventHandler(this.ms_grid_AddingRecord);
			this.NzGrid.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.ms_grid_ColumnButtonClick);
			this.NzGrid.CurrentCellChanged += new System.EventHandler(this.ms_grid_CurrentCellChanged);
			this.NzGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ms_grid_KeyPress);
			// 
			// uiGroupBox6
			// 
			this.uiGroupBox6.BackColor = System.Drawing.Color.Transparent;
			this.uiGroupBox6.BorderColor = System.Drawing.Color.DarkTurquoise;
			this.uiGroupBox6.Controls.Add(this.NzFactorKinds);
			this.uiGroupBox6.Controls.Add(this.NzLocation);
			this.uiGroupBox6.Controls.Add(this.NzLableLocation);
			this.uiGroupBox6.Controls.Add(this.NzFindObject);
			this.uiGroupBox6.Controls.Add(this.nzBarcodeReader1);
			this.uiGroupBox6.Controls.Add(this.label13);
			this.uiGroupBox6.Controls.Add(this.label15);
			this.uiGroupBox6.Dock = System.Windows.Forms.DockStyle.Right;
			this.uiGroupBox6.Location = new System.Drawing.Point(811, 0);
			this.uiGroupBox6.Margin = new System.Windows.Forms.Padding(2);
			this.uiGroupBox6.Name = "uiGroupBox6";
			this.uiGroupBox6.Size = new System.Drawing.Size(569, 622);
			this.uiGroupBox6.TabIndex = 0;
			// 
			// NzFactorKinds
			// 
			this.NzFactorKinds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NzFactorKinds.BackColor = System.Drawing.Color.Transparent;
			this.NzFactorKinds.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzFactorKinds.Font = new System.Drawing.Font("IRANSans(Small)", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzFactorKinds.Location = new System.Drawing.Point(1, 108);
			this.NzFactorKinds.Name = "NzFactorKinds";
			this.NzFactorKinds.PageBorder = Janus.Windows.UI.Tab.PageBorder.StripLine;
			this.NzFactorKinds.SettingsKey = "NzFactorKinds";
			this.NzFactorKinds.Size = new System.Drawing.Size(568, 512);
			this.NzFactorKinds.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.NzFactorKinds.TabIndex = 783;
			this.NzFactorKinds.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.NzTabPurchaseBack,
            this.NsGroupKala,
            this.NzTabPurchase});
			this.NzFactorKinds.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Yellow;
			this.NzFactorKinds.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Bottom;
			this.NzFactorKinds.TabStripOffset = 4;
			this.NzFactorKinds.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Horizontal;
			this.NzFactorKinds.UseCompatibleTextRendering = false;
			this.NzFactorKinds.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007;
			// 
			// NzTabPurchaseBack
			// 
			this.NzTabPurchaseBack.Controls.Add(this.NzPrefactorGrid);
			this.NzTabPurchaseBack.Key = "NzTabPurchaseBack";
			this.NzTabPurchaseBack.Location = new System.Drawing.Point(0, 0);
			this.NzTabPurchaseBack.Name = "NzTabPurchaseBack";
			this.NzTabPurchaseBack.Size = new System.Drawing.Size(568, 479);
			this.NzTabPurchaseBack.TabStop = true;
			this.NzTabPurchaseBack.Text = " اقلام آماده ";
			// 
			// NzPrefactorGrid
			// 
			this.NzPrefactorGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.NzPrefactorGrid.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NzPrefactorGrid.AlternatingColors = true;
			this.NzPrefactorGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzPrefactorGrid.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NzPrefactorGrid.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
			this.NzPrefactorGrid.BuiltInTextsData = resources.GetString("NzPrefactorGrid.BuiltInTextsData");
			this.NzPrefactorGrid.CardHeaders = false;
			this.NzPrefactorGrid.CardInnerSpacing = 5;
			this.NzPrefactorGrid.CardSpacing = 5;
			this.NzPrefactorGrid.CardWidth = 140;
			this.NzPrefactorGrid.ColumnAutoResize = true;
			this.NzPrefactorGrid.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
			this.NzPrefactorGrid.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
			this.NzPrefactorGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.NzPrefactorGrid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			NzPrefactorGrid_DesignTimeLayout_Reference_0.Instance = ((object)(resources.GetObject("NzPrefactorGrid_DesignTimeLayout_Reference_0.Instance")));
			NzPrefactorGrid_DesignTimeLayout.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            NzPrefactorGrid_DesignTimeLayout_Reference_0});
			NzPrefactorGrid_DesignTimeLayout.LayoutString = resources.GetString("NzPrefactorGrid_DesignTimeLayout.LayoutString");
			this.NzPrefactorGrid.DesignTimeLayout = NzPrefactorGrid_DesignTimeLayout;
			this.NzPrefactorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NzPrefactorGrid.DynamicFiltering = true;
			this.NzPrefactorGrid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.NzPrefactorGrid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.NzPrefactorGrid.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.NzPrefactorGrid.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzPrefactorGrid.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.NzPrefactorGrid.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
			this.NzPrefactorGrid.FocusStyle = Janus.Windows.GridEX.FocusStyle.None;
			this.NzPrefactorGrid.Font = new System.Drawing.Font("IRANSans(Small)", 16F);
			this.NzPrefactorGrid.GridLineColor = System.Drawing.Color.Black;
			this.NzPrefactorGrid.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.NzPrefactorGrid.GroupByBoxVisible = false;
			this.NzPrefactorGrid.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.NzPrefactorGrid.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NzPrefactorGrid.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.NzPrefactorGrid.Location = new System.Drawing.Point(0, 0);
			this.NzPrefactorGrid.Name = "NzPrefactorGrid";
			this.NzPrefactorGrid.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.NzPrefactorGrid.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.NzPrefactorGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzPrefactorGrid.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.NzPrefactorGrid.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.NzPrefactorGrid.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NzPrefactorGrid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.NzPrefactorGrid.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
			this.NzPrefactorGrid.SelectOnExpand = false;
			this.NzPrefactorGrid.Size = new System.Drawing.Size(568, 479);
			this.NzPrefactorGrid.TabIndex = 781;
			this.NzPrefactorGrid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzPrefactorGrid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.NzPrefactorGrid.TreeLineColor = System.Drawing.Color.Black;
			this.NzPrefactorGrid.View = Janus.Windows.GridEX.View.CardView;
			this.NzPrefactorGrid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NzPrefactorGrid.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.NzPrefactorGrid_ColumnButtonClick);
			// 
			// NsGroupKala
			// 
			this.NsGroupKala.Controls.Add(this.NzGroupKala);
			this.NsGroupKala.Controls.Add(this.SubGroupsPanel);
			this.NsGroupKala.Location = new System.Drawing.Point(0, 0);
			this.NsGroupKala.Name = "NsGroupKala";
			this.NsGroupKala.Size = new System.Drawing.Size(568, 479);
			this.NsGroupKala.TabStop = true;
			this.NsGroupKala.Text = "  گروه کالا  ";
			// 
			// NzGroupKala
			// 
			this.NzGroupKala.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.NzGroupKala.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NzGroupKala.AlternatingColors = true;
			this.NzGroupKala.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzGroupKala.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NzGroupKala.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
			this.NzGroupKala.BuiltInTextsData = resources.GetString("NzGroupKala.BuiltInTextsData");
			this.NzGroupKala.CardHeaders = false;
			this.NzGroupKala.CardInnerSpacing = 3;
			this.NzGroupKala.CardSpacing = 10;
			this.NzGroupKala.CardWidth = 170;
			this.NzGroupKala.ColumnAutoResize = true;
			this.NzGroupKala.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
			this.NzGroupKala.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
			this.NzGroupKala.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.NzGroupKala.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			NzGroupKala_DesignTimeLayout_Reference_0.Instance = ((object)(resources.GetObject("NzGroupKala_DesignTimeLayout_Reference_0.Instance")));
			NzGroupKala_DesignTimeLayout.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            NzGroupKala_DesignTimeLayout_Reference_0});
			NzGroupKala_DesignTimeLayout.LayoutString = resources.GetString("NzGroupKala_DesignTimeLayout.LayoutString");
			this.NzGroupKala.DesignTimeLayout = NzGroupKala_DesignTimeLayout;
			this.NzGroupKala.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NzGroupKala.DynamicFiltering = true;
			this.NzGroupKala.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.NzGroupKala.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.NzGroupKala.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.NzGroupKala.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzGroupKala.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.NzGroupKala.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
			this.NzGroupKala.FocusStyle = Janus.Windows.GridEX.FocusStyle.None;
			this.NzGroupKala.Font = new System.Drawing.Font("IRANSans(Small)", 16F);
			this.NzGroupKala.GridLineColor = System.Drawing.Color.Black;
			this.NzGroupKala.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.NzGroupKala.GroupByBoxVisible = false;
			this.NzGroupKala.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.NzGroupKala.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NzGroupKala.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.NzGroupKala.Location = new System.Drawing.Point(0, 20);
			this.NzGroupKala.Name = "NzGroupKala";
			this.NzGroupKala.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.NzGroupKala.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.NzGroupKala.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzGroupKala.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.NzGroupKala.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.NzGroupKala.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NzGroupKala.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.NzGroupKala.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
			this.NzGroupKala.SelectOnExpand = false;
			this.NzGroupKala.Size = new System.Drawing.Size(568, 459);
			this.NzGroupKala.TabIndex = 782;
			this.NzGroupKala.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzGroupKala.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.NzGroupKala.TreeLineColor = System.Drawing.Color.Black;
			this.NzGroupKala.View = Janus.Windows.GridEX.View.CardView;
			this.NzGroupKala.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NzGroupKala.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.NzGroupKala_ColumnButtonClick);
			// 
			// SubGroupsPanel
			// 
			this.SubGroupsPanel.AutoSize = true;
			this.SubGroupsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.SubGroupsPanel.BackColor = System.Drawing.Color.Transparent;
			this.SubGroupsPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.SubGroupsPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.SubGroupsPanel.Location = new System.Drawing.Point(0, 0);
			this.SubGroupsPanel.MinimumSize = new System.Drawing.Size(0, 20);
			this.SubGroupsPanel.Name = "SubGroupsPanel";
			this.SubGroupsPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.SubGroupsPanel.Size = new System.Drawing.Size(568, 20);
			this.SubGroupsPanel.TabIndex = 783;
			// 
			// NzTabPurchase
			// 
			this.NzTabPurchase.Controls.Add(this.NsCopyBarcode);
			this.NzTabPurchase.Controls.Add(this.NsTakhfifPrice);
			this.NzTabPurchase.Controls.Add(this.NsHamkari);
			this.NzTabPurchase.Controls.Add(this.NsOmdePrice);
			this.NzTabPurchase.Controls.Add(this.NsAdiPrice);
			this.NzTabPurchase.Controls.Add(this.NzBarcodePrice);
			this.NzTabPurchase.Controls.Add(this.label36);
			this.NzTabPurchase.Controls.Add(this.label35);
			this.NzTabPurchase.Controls.Add(this.label34);
			this.NzTabPurchase.Controls.Add(this.label11);
			this.NzTabPurchase.Controls.Add(this.label33);
			this.NzTabPurchase.Controls.Add(this.NsPriceBarcodeTitle);
			this.NzTabPurchase.Controls.Add(this.label32);
			this.NzTabPurchase.Key = "NzTabPurchase";
			this.NzTabPurchase.Location = new System.Drawing.Point(0, 0);
			this.NzTabPurchase.Name = "NzTabPurchase";
			this.NzTabPurchase.PanelFormatStyle.Alpha = 150;
			this.NzTabPurchase.PanelFormatStyle.BackColor = System.Drawing.Color.PowderBlue;
			this.NzTabPurchase.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.NzTabPurchase.PanelFormatStyle.BackColorGradient = System.Drawing.Color.LightSkyBlue;
			this.NzTabPurchase.Size = new System.Drawing.Size(568, 479);
			this.NzTabPurchase.TabStop = true;
			this.NzTabPurchase.Text = "مشاهده قیمت";
			// 
			// NsCopyBarcode
			// 
			this.NsCopyBarcode.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsCopyBarcode.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsCopyBarcode.Image = ((System.Drawing.Image)(resources.GetObject("NsCopyBarcode.Image")));
			this.NsCopyBarcode.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center;
			this.NsCopyBarcode.Location = new System.Drawing.Point(1, 35);
			this.NsCopyBarcode.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsCopyBarcode.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsCopyBarcode.MS_Change_Border_Color_On_Enter = false;
			this.NsCopyBarcode.MS_Change_Color_On_Enter = false;
			this.NsCopyBarcode.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NsCopyBarcode.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NsCopyBarcode.Name = "NsCopyBarcode";
			this.NsCopyBarcode.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NsCopyBarcode.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NsCopyBarcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsCopyBarcode.ShowFocusRectangle = false;
			this.NsCopyBarcode.Size = new System.Drawing.Size(32, 33);
			this.NsCopyBarcode.TabIndex = 787;
			this.NsCopyBarcode.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.NsCopyBarcode.UseThemes = false;
			this.NsCopyBarcode.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NsCopyBarcode.WordWrap = false;
			this.NsCopyBarcode.Click += new System.EventHandler(this.NsCopyBarcode_Click);
			// 
			// NsTakhfifPrice
			// 
			this.NsTakhfifPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsTakhfifPrice.BackColor = System.Drawing.Color.Transparent;
			this.NsTakhfifPrice.Font = new System.Drawing.Font("IRANSans(Small)", 17F);
			this.NsTakhfifPrice.ForeColor = System.Drawing.Color.Green;
			this.NsTakhfifPrice.Location = new System.Drawing.Point(3, 287);
			this.NsTakhfifPrice.MS_BorderColor = System.Drawing.Color.Empty;
			this.NsTakhfifPrice.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsTakhfifPrice.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.NsTakhfifPrice.MS_Format_String = "0,0.##;(0,0.##); ";
			this.NsTakhfifPrice.Name = "NsTakhfifPrice";
			this.NsTakhfifPrice.Size = new System.Drawing.Size(491, 32);
			this.NsTakhfifPrice.TabIndex = 786;
			this.NsTakhfifPrice.Text = " ";
			this.NsTakhfifPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NsHamkari
			// 
			this.NsHamkari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsHamkari.BackColor = System.Drawing.Color.Transparent;
			this.NsHamkari.Font = new System.Drawing.Font("IRANSans(Small)", 17F);
			this.NsHamkari.ForeColor = System.Drawing.Color.Green;
			this.NsHamkari.Location = new System.Drawing.Point(4, 237);
			this.NsHamkari.MS_BorderColor = System.Drawing.Color.Empty;
			this.NsHamkari.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsHamkari.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.NsHamkari.MS_Format_String = "0,0.##;(0,0.##); ";
			this.NsHamkari.Name = "NsHamkari";
			this.NsHamkari.Size = new System.Drawing.Size(491, 32);
			this.NsHamkari.TabIndex = 786;
			this.NsHamkari.Text = " ";
			this.NsHamkari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NsOmdePrice
			// 
			this.NsOmdePrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsOmdePrice.BackColor = System.Drawing.Color.Transparent;
			this.NsOmdePrice.Font = new System.Drawing.Font("IRANSans(Small)", 17F);
			this.NsOmdePrice.ForeColor = System.Drawing.Color.Green;
			this.NsOmdePrice.Location = new System.Drawing.Point(5, 187);
			this.NsOmdePrice.MS_BorderColor = System.Drawing.Color.Empty;
			this.NsOmdePrice.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsOmdePrice.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.NsOmdePrice.MS_Format_String = "0,0.##;(0,0.##); ";
			this.NsOmdePrice.Name = "NsOmdePrice";
			this.NsOmdePrice.Size = new System.Drawing.Size(491, 32);
			this.NsOmdePrice.TabIndex = 786;
			this.NsOmdePrice.Text = " ";
			this.NsOmdePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NsAdiPrice
			// 
			this.NsAdiPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsAdiPrice.BackColor = System.Drawing.Color.Transparent;
			this.NsAdiPrice.Font = new System.Drawing.Font("IRANSans(Small)", 17F);
			this.NsAdiPrice.ForeColor = System.Drawing.Color.Green;
			this.NsAdiPrice.Location = new System.Drawing.Point(3, 137);
			this.NsAdiPrice.MS_BorderColor = System.Drawing.Color.Empty;
			this.NsAdiPrice.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsAdiPrice.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.NsAdiPrice.MS_Format_String = "0,0.##;(0,0.##); ";
			this.NsAdiPrice.Name = "NsAdiPrice";
			this.NsAdiPrice.Size = new System.Drawing.Size(491, 32);
			this.NsAdiPrice.TabIndex = 786;
			this.NsAdiPrice.Text = " ";
			this.NsAdiPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NzBarcodePrice
			// 
			this.NzBarcodePrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NzBarcodePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NzBarcodePrice.Font = new System.Drawing.Font("IRANSans(Small) Medium", 20F);
			this.NzBarcodePrice.Location = new System.Drawing.Point(34, 35);
			this.NzBarcodePrice.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzBarcodePrice.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzBarcodePrice.MS_Change_Border_Color_On_Enter = true;
			this.NzBarcodePrice.MS_Change_Color_On_Enter = true;
			this.NzBarcodePrice.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzBarcodePrice.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzBarcodePrice.Name = "NzBarcodePrice";
			this.NzBarcodePrice.Size = new System.Drawing.Size(505, 33);
			this.NzBarcodePrice.TabIndex = 785;
			this.NzBarcodePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label36
			// 
			this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label36.AutoSize = true;
			this.label36.BackColor = System.Drawing.Color.Transparent;
			this.label36.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label36.Location = new System.Drawing.Point(500, 293);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(63, 23);
			this.label36.TabIndex = 783;
			this.label36.Text = "تخفیفات :";
			// 
			// label35
			// 
			this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label35.AutoSize = true;
			this.label35.BackColor = System.Drawing.Color.Transparent;
			this.label35.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label35.Location = new System.Drawing.Point(500, 243);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(59, 23);
			this.label35.TabIndex = 783;
			this.label35.Text = "همکاری :";
			// 
			// label34
			// 
			this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label34.AutoSize = true;
			this.label34.BackColor = System.Drawing.Color.Transparent;
			this.label34.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label34.Location = new System.Drawing.Point(500, 193);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(43, 23);
			this.label34.TabIndex = 783;
			this.label34.Text = "عمده :";
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label11.ForeColor = System.Drawing.Color.Green;
			this.label11.Location = new System.Drawing.Point(276, 9);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(283, 23);
			this.label11.TabIndex = 783;
			this.label11.Text = "برای مشاهده قیمت بارکد کالا را در کادر زیر وارد کنید.";
			// 
			// label33
			// 
			this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label33.AutoSize = true;
			this.label33.BackColor = System.Drawing.Color.Transparent;
			this.label33.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label33.Location = new System.Drawing.Point(500, 143);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(43, 23);
			this.label33.TabIndex = 783;
			this.label33.Text = "عادی :";
			// 
			// NsPriceBarcodeTitle
			// 
			this.NsPriceBarcodeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsPriceBarcodeTitle.BackColor = System.Drawing.Color.Transparent;
			this.NsPriceBarcodeTitle.Font = new System.Drawing.Font("IRANSans(Small) Medium", 17F);
			this.NsPriceBarcodeTitle.Location = new System.Drawing.Point(0, 69);
			this.NsPriceBarcodeTitle.Name = "NsPriceBarcodeTitle";
			this.NsPriceBarcodeTitle.Size = new System.Drawing.Size(569, 29);
			this.NsPriceBarcodeTitle.TabIndex = 782;
			this.NsPriceBarcodeTitle.Text = "...";
			this.NsPriceBarcodeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label32
			// 
			this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label32.BackColor = System.Drawing.Color.Transparent;
			this.label32.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label32.Image = ((System.Drawing.Image)(resources.GetObject("label32.Image")));
			this.label32.Location = new System.Drawing.Point(542, 39);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(22, 27);
			this.label32.TabIndex = 780;
			// 
			// NzLocation
			// 
			this.NzLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NzLocation.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.NzLocation.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzLocation.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzLocation.Location = new System.Drawing.Point(5, 11);
			this.NzLocation.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzLocation.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzLocation.MS_Change_Border_Color_On_Enter = true;
			this.NzLocation.MS_Change_Color_On_Enter = true;
			this.NzLocation.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzLocation.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzLocation.MS_Exit_By_Down = true;
			this.NzLocation.MS_Exit_By_Enter = true;
			this.NzLocation.MS_Exit_By_Up = true;
			this.NzLocation.MS_Last_Control = null;
			this.NzLocation.MS_Next_Control = null;
			this.NzLocation.Name = "NzLocation";
			this.NzLocation.Size = new System.Drawing.Size(534, 29);
			this.NzLocation.TabIndex = 782;
			this.NzLocation.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			// 
			// NzLableLocation
			// 
			this.NzLableLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzLableLocation.BackColor = System.Drawing.Color.Transparent;
			this.NzLableLocation.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzLableLocation.Image = ((System.Drawing.Image)(resources.GetObject("NzLableLocation.Image")));
			this.NzLableLocation.Location = new System.Drawing.Point(543, 11);
			this.NzLableLocation.Name = "NzLableLocation";
			this.NzLableLocation.Size = new System.Drawing.Size(25, 23);
			this.NzLableLocation.TabIndex = 781;
			this.NzLableLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NzFindObject
			// 
			this.NzFindObject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NzFindObject.Font = new System.Drawing.Font("IRANSans(Small) Medium", 17F);
			this.NzFindObject.Location = new System.Drawing.Point(0, 76);
			this.NzFindObject.Name = "NzFindObject";
			this.NzFindObject.Size = new System.Drawing.Size(569, 29);
			this.NzFindObject.TabIndex = 779;
			this.NzFindObject.Text = "...";
			this.NzFindObject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nzBarcodeReader1
			// 
			this.nzBarcodeReader1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nzBarcodeReader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.nzBarcodeReader1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nzBarcodeReader1.Font = new System.Drawing.Font("IRANSans(Small) Medium", 20F);
			this.nzBarcodeReader1.Location = new System.Drawing.Point(5, 42);
			this.nzBarcodeReader1.MS_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.nzBarcodeReader1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.nzBarcodeReader1.MS_Change_Border_Color_On_Enter = true;
			this.nzBarcodeReader1.MS_Change_Color_On_Enter = true;
			this.nzBarcodeReader1.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.nzBarcodeReader1.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.nzBarcodeReader1.Name = "nzBarcodeReader1";
			this.nzBarcodeReader1.Size = new System.Drawing.Size(534, 33);
			this.nzBarcodeReader1.TabIndex = 778;
			this.nzBarcodeReader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nzBarcodeReader1.Click += new System.EventHandler(this.nzBarcodeReader1_Enter);
			this.nzBarcodeReader1.Enter += new System.EventHandler(this.nzBarcodeReader1_Enter);
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
			this.label13.Location = new System.Drawing.Point(542, 48);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(22, 27);
			this.label13.TabIndex = 766;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label15.Location = new System.Drawing.Point(355, 52);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(34, 23);
			this.label15.TabIndex = 767;
			this.label15.Text = "[F3]";
			// 
			// uiTabPage3
			// 
			this.uiTabPage3.Controls.Add(this.label7);
			this.uiTabPage3.Controls.Add(this.label6);
			this.uiTabPage3.Controls.Add(this.label5);
			this.uiTabPage3.Controls.Add(this.label30);
			this.uiTabPage3.Controls.Add(this.label8);
			this.uiTabPage3.Controls.Add(this.label28);
			this.uiTabPage3.Controls.Add(this.label31);
			this.uiTabPage3.Controls.Add(this.label16);
			this.uiTabPage3.Controls.Add(this.label4);
			this.uiTabPage3.Controls.Add(this.label23);
			this.uiTabPage3.Controls.Add(this.label22);
			this.uiTabPage3.Controls.Add(this.label21);
			this.uiTabPage3.Controls.Add(this.label20);
			this.uiTabPage3.Controls.Add(this.label27);
			this.uiTabPage3.Controls.Add(this.label29);
			this.uiTabPage3.Controls.Add(this.label14);
			this.uiTabPage3.Controls.Add(this.label12);
			this.uiTabPage3.Controls.Add(this.label2);
			this.uiTabPage3.Controls.Add(this.label25);
			this.uiTabPage3.Controls.Add(this.label26);
			this.uiTabPage3.Controls.Add(this.label24);
			this.uiTabPage3.Location = new System.Drawing.Point(1, 1);
			this.uiTabPage3.Name = "uiTabPage3";
			this.uiTabPage3.PanelFormatStyle.Alpha = 70;
			this.uiTabPage3.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.uiTabPage3.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.uiTabPage3.Size = new System.Drawing.Size(1380, 622);
			this.uiTabPage3.TabStop = true;
			this.uiTabPage3.Text = "پرسش و پاسخ";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label7.ForeColor = System.Drawing.Color.Maroon;
			this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
			this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label7.Location = new System.Drawing.Point(1262, 489);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 23);
			this.label7.TabIndex = 788;
			this.label7.Text = "[F12]";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label6.ForeColor = System.Drawing.Color.Maroon;
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label6.Location = new System.Drawing.Point(1263, 458);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 23);
			this.label6.TabIndex = 789;
			this.label6.Text = "[F10]";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label5.ForeColor = System.Drawing.Color.Maroon;
			this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
			this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label5.Location = new System.Drawing.Point(1266, 349);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 23);
			this.label5.TabIndex = 790;
			this.label5.Text = "[F6]";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label30
			// 
			this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label30.BackColor = System.Drawing.Color.Transparent;
			this.label30.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label30.ForeColor = System.Drawing.Color.Maroon;
			this.label30.Image = ((System.Drawing.Image)(resources.GetObject("label30.Image")));
			this.label30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label30.Location = new System.Drawing.Point(1256, 312);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(62, 23);
			this.label30.TabIndex = 794;
			this.label30.Text = "[F5]";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label8.ForeColor = System.Drawing.Color.Maroon;
			this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
			this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label8.Location = new System.Drawing.Point(1264, 384);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 23);
			this.label8.TabIndex = 793;
			this.label8.Text = "[F7]";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label28
			// 
			this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label28.ForeColor = System.Drawing.Color.Maroon;
			this.label28.Image = ((System.Drawing.Image)(resources.GetObject("label28.Image")));
			this.label28.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label28.Location = new System.Drawing.Point(1264, 422);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(54, 23);
			this.label28.TabIndex = 792;
			this.label28.Text = "[F8]";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label31
			// 
			this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label31.BackColor = System.Drawing.Color.Transparent;
			this.label31.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label31.ForeColor = System.Drawing.Color.Maroon;
			this.label31.Image = ((System.Drawing.Image)(resources.GetObject("label31.Image")));
			this.label31.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label31.Location = new System.Drawing.Point(1264, 195);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(54, 23);
			this.label31.TabIndex = 791;
			this.label31.Text = "[F1]";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label16
			// 
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label16.ForeColor = System.Drawing.Color.Maroon;
			this.label16.Image = ((System.Drawing.Image)(resources.GetObject("label16.Image")));
			this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label16.Location = new System.Drawing.Point(1264, 233);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(54, 23);
			this.label16.TabIndex = 791;
			this.label16.Text = "[F3]";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label4.ForeColor = System.Drawing.Color.Maroon;
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label4.Location = new System.Drawing.Point(1266, 272);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 23);
			this.label4.TabIndex = 795;
			this.label4.Text = "[F4]";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label23
			// 
			this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label23.AutoSize = true;
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label23.ForeColor = System.Drawing.Color.DarkBlue;
			this.label23.Location = new System.Drawing.Point(1027, 488);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(222, 25);
			this.label23.TabIndex = 785;
			this.label23.Text = "باز کردن فاکتور جدید در صفحه جدید";
			// 
			// label22
			// 
			this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label22.AutoSize = true;
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label22.Location = new System.Drawing.Point(1168, 458);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(81, 25);
			this.label22.TabIndex = 784;
			this.label22.Text = "فاکتور جدید";
			// 
			// label21
			// 
			this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label21.AutoSize = true;
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label21.ForeColor = System.Drawing.Color.DarkBlue;
			this.label21.Location = new System.Drawing.Point(1140, 349);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(109, 25);
			this.label21.TabIndex = 783;
			this.label21.Text = "چاپ فیش پرینت";
			// 
			// label20
			// 
			this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label20.AutoSize = true;
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label20.ForeColor = System.Drawing.Color.DarkBlue;
			this.label20.Location = new System.Drawing.Point(1126, 272);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(123, 25);
			this.label20.TabIndex = 782;
			this.label20.Text = "افزودن کالا با کیبورد";
			// 
			// label27
			// 
			this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label27.AutoSize = true;
			this.label27.BackColor = System.Drawing.Color.Transparent;
			this.label27.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label27.ForeColor = System.Drawing.Color.DarkBlue;
			this.label27.Location = new System.Drawing.Point(1157, 422);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(92, 25);
			this.label27.TabIndex = 781;
			this.label27.Text = "دخیره تغییرات";
			// 
			// label29
			// 
			this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label29.AutoSize = true;
			this.label29.BackColor = System.Drawing.Color.Transparent;
			this.label29.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label29.ForeColor = System.Drawing.Color.Black;
			this.label29.Location = new System.Drawing.Point(1113, 311);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(136, 25);
			this.label29.TabIndex = 780;
			this.label29.Text = "ارسال به دستگاه POS";
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(1136, 383);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(113, 25);
			this.label14.TabIndex = 779;
			this.label14.Text = "ثبت تسویه فاکتور";
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label12.ForeColor = System.Drawing.Color.DarkBlue;
			this.label12.Location = new System.Drawing.Point(1138, 195);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(111, 25);
			this.label12.TabIndex = 787;
			this.label12.Text = "دریافت قیمت کالا";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(1103, 233);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 25);
			this.label2.TabIndex = 787;
			this.label2.Text = "افزودن کالا با بارکدخوان";
			// 
			// label25
			// 
			this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label25.Location = new System.Drawing.Point(861, 60);
			this.label25.Name = "label25";
			this.label25.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label25.Size = new System.Drawing.Size(479, 37);
			this.label25.TabIndex = 772;
			this.label25.Text = "در صورت تغییر یکی موارد زیر برای ثبت اطلاعات حتما کلید اینتر را بزنید [Enter]";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label26
			// 
			this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label26.BackColor = System.Drawing.Color.Transparent;
			this.label26.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label26.ForeColor = System.Drawing.Color.Olive;
			this.label26.Location = new System.Drawing.Point(1141, 95);
			this.label26.Name = "label26";
			this.label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label26.Size = new System.Drawing.Size(178, 73);
			this.label26.TabIndex = 772;
			this.label26.Text = "مبالغ اضافات\r\nتـخفیفات و درصد تخفیف\r\nدرصد مالیات\r\n";
			// 
			// label24
			// 
			this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label24.ForeColor = System.Drawing.Color.Brown;
			this.label24.Location = new System.Drawing.Point(1162, 21);
			this.label24.Name = "label24";
			this.label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label24.Size = new System.Drawing.Size(178, 37);
			this.label24.TabIndex = 772;
			this.label24.Text = "به موارد زیر دقت فرمایید  !";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			this.contextMenuStrip1.Text = "انتـخاب کالا هایی با بارکد یکسان";
			this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
			// 
			// mS_Panel2
			// 
			this.mS_Panel2.Controls.Add(this.NzNew);
			this.mS_Panel2.Controls.Add(this.NzPrintA4);
			this.mS_Panel2.Controls.Add(this.NzPrintNormalA5);
			this.mS_Panel2.Controls.Add(this.NzPosPrint);
			this.mS_Panel2.Controls.Add(this.NzNewWindows);
			this.mS_Panel2.Controls.Add(this.NzPayment);
			this.mS_Panel2.Controls.Add(this.NzSave);
			this.mS_Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.mS_Panel2.Location = new System.Drawing.Point(0, 624);
			this.mS_Panel2.MS_BorderColor = System.Drawing.Color.Aqua;
			this.mS_Panel2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Panel2.MS_Color_End = System.Drawing.Color.SkyBlue;
			this.mS_Panel2.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.mS_Panel2.Name = "mS_Panel2";
			this.mS_Panel2.Size = new System.Drawing.Size(1412, 101);
			this.mS_Panel2.TabIndex = 769;
			// 
			// NzNew
			// 
			this.NzNew.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzNew.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NzNew.Font = new System.Drawing.Font("IRANSans(Small)", 16F);
			this.NzNew.Image = ((System.Drawing.Image)(resources.GetObject("NzNew.Image")));
			this.NzNew.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NzNew.ImageSize = new System.Drawing.Size(32, 32);
			this.NzNew.Location = new System.Drawing.Point(409, 6);
			this.NzNew.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzNew.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzNew.MS_Change_Border_Color_On_Enter = false;
			this.NzNew.MS_Change_Color_On_Enter = false;
			this.NzNew.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NzNew.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NzNew.Name = "NzNew";
			this.NzNew.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NzNew.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NzNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzNew.ShowFocusRectangle = false;
			this.NzNew.Size = new System.Drawing.Size(189, 88);
			this.NzNew.TabIndex = 2;
			this.NzNew.Text = "فاکتور جدید                            [F10]";
			this.NzNew.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.NzNew.UseThemes = false;
			this.NzNew.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NzNew.Click += new System.EventHandler(this.NzNew_Click);
			// 
			// NzPrintA4
			// 
			this.NzPrintA4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzPrintA4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzPrintA4.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NzPrintA4.Font = new System.Drawing.Font("IRANSans(Small)", 16F);
			this.NzPrintA4.Image = ((System.Drawing.Image)(resources.GetObject("NzPrintA4.Image")));
			this.NzPrintA4.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NzPrintA4.ImageSize = new System.Drawing.Size(32, 32);
			this.NzPrintA4.Location = new System.Drawing.Point(1213, 6);
			this.NzPrintA4.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzPrintA4.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzPrintA4.MS_Change_Border_Color_On_Enter = false;
			this.NzPrintA4.MS_Change_Color_On_Enter = false;
			this.NzPrintA4.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NzPrintA4.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NzPrintA4.Name = "NzPrintA4";
			this.NzPrintA4.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NzPrintA4.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NzPrintA4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzPrintA4.ShowFocusRectangle = false;
			this.NzPrintA4.Size = new System.Drawing.Size(189, 88);
			this.NzPrintA4.TabIndex = 6;
			this.NzPrintA4.Text = "چاپ A4";
			this.NzPrintA4.UseThemes = false;
			this.NzPrintA4.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NzPrintA4.Click += new System.EventHandler(this.NzPrintNormalA4_Click);
			// 
			// NzPrintNormalA5
			// 
			this.NzPrintNormalA5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzPrintNormalA5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzPrintNormalA5.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NzPrintNormalA5.Font = new System.Drawing.Font("IRANSans(Small)", 16F);
			this.NzPrintNormalA5.Image = ((System.Drawing.Image)(resources.GetObject("NzPrintNormalA5.Image")));
			this.NzPrintNormalA5.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NzPrintNormalA5.ImageSize = new System.Drawing.Size(32, 32);
			this.NzPrintNormalA5.Location = new System.Drawing.Point(1013, 6);
			this.NzPrintNormalA5.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzPrintNormalA5.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzPrintNormalA5.MS_Change_Border_Color_On_Enter = false;
			this.NzPrintNormalA5.MS_Change_Color_On_Enter = false;
			this.NzPrintNormalA5.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NzPrintNormalA5.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NzPrintNormalA5.Name = "NzPrintNormalA5";
			this.NzPrintNormalA5.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NzPrintNormalA5.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NzPrintNormalA5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzPrintNormalA5.ShowFocusRectangle = false;
			this.NzPrintNormalA5.Size = new System.Drawing.Size(189, 88);
			this.NzPrintNormalA5.TabIndex = 5;
			this.NzPrintNormalA5.Text = "چاپ A5";
			this.NzPrintNormalA5.UseThemes = false;
			this.NzPrintNormalA5.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NzPrintNormalA5.Click += new System.EventHandler(this.NzPrintNormalA5_Click);
			// 
			// NzPosPrint
			// 
			this.NzPosPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzPosPrint.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzPosPrint.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NzPosPrint.Font = new System.Drawing.Font("IRANSans(Small)", 16F);
			this.NzPosPrint.Image = ((System.Drawing.Image)(resources.GetObject("NzPosPrint.Image")));
			this.NzPosPrint.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NzPosPrint.ImageSize = new System.Drawing.Size(32, 38);
			this.NzPosPrint.Location = new System.Drawing.Point(815, 6);
			this.NzPosPrint.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzPosPrint.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzPosPrint.MS_Change_Border_Color_On_Enter = false;
			this.NzPosPrint.MS_Change_Color_On_Enter = false;
			this.NzPosPrint.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NzPosPrint.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NzPosPrint.Name = "NzPosPrint";
			this.NzPosPrint.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NzPosPrint.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NzPosPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzPosPrint.ShowFocusRectangle = false;
			this.NzPosPrint.Size = new System.Drawing.Size(189, 88);
			this.NzPosPrint.TabIndex = 4;
			this.NzPosPrint.Text = "چاپ فیش پرینت       [F6]";
			this.NzPosPrint.UseThemes = false;
			this.NzPosPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NzPosPrint.Click += new System.EventHandler(this.NzPosPrint_Click);
			// 
			// NzNewWindows
			// 
			this.NzNewWindows.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzNewWindows.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NzNewWindows.Font = new System.Drawing.Font("IRANSans(Small)", 16F);
			this.NzNewWindows.Image = ((System.Drawing.Image)(resources.GetObject("NzNewWindows.Image")));
			this.NzNewWindows.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NzNewWindows.ImageSize = new System.Drawing.Size(32, 32);
			this.NzNewWindows.Location = new System.Drawing.Point(611, 6);
			this.NzNewWindows.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzNewWindows.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzNewWindows.MS_Change_Border_Color_On_Enter = false;
			this.NzNewWindows.MS_Change_Color_On_Enter = false;
			this.NzNewWindows.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NzNewWindows.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NzNewWindows.Name = "NzNewWindows";
			this.NzNewWindows.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NzNewWindows.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NzNewWindows.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzNewWindows.ShowFocusRectangle = false;
			this.NzNewWindows.Size = new System.Drawing.Size(189, 88);
			this.NzNewWindows.TabIndex = 3;
			this.NzNewWindows.Text = "فاکتور در صفحه جدید          [F12]";
			this.NzNewWindows.UseThemes = false;
			this.NzNewWindows.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NzNewWindows.Click += new System.EventHandler(this.NzNewWindows_Click);
			// 
			// NzPayment
			// 
			this.NzPayment.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzPayment.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NzPayment.Font = new System.Drawing.Font("IRANSans(Small)", 16F);
			this.NzPayment.Image = ((System.Drawing.Image)(resources.GetObject("NzPayment.Image")));
			this.NzPayment.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NzPayment.ImageSize = new System.Drawing.Size(32, 32);
			this.NzPayment.Location = new System.Drawing.Point(210, 6);
			this.NzPayment.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzPayment.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzPayment.MS_Change_Border_Color_On_Enter = false;
			this.NzPayment.MS_Change_Color_On_Enter = false;
			this.NzPayment.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NzPayment.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NzPayment.Name = "NzPayment";
			this.NzPayment.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NzPayment.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NzPayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzPayment.ShowFocusRectangle = false;
			this.NzPayment.Size = new System.Drawing.Size(189, 88);
			this.NzPayment.TabIndex = 1;
			this.NzPayment.Text = "تسویه حساب              [F7]";
			this.NzPayment.UseThemes = false;
			this.NzPayment.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NzPayment.Click += new System.EventHandler(this.NzPayment_Click);
			// 
			// NzSave
			// 
			this.NzSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzSave.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NzSave.Font = new System.Drawing.Font("IRANSans(Small)", 16F);
			this.NzSave.Image = ((System.Drawing.Image)(resources.GetObject("NzSave.Image")));
			this.NzSave.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NzSave.ImageSize = new System.Drawing.Size(25, 25);
			this.NzSave.Location = new System.Drawing.Point(12, 6);
			this.NzSave.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzSave.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzSave.MS_Change_Border_Color_On_Enter = false;
			this.NzSave.MS_Change_Color_On_Enter = false;
			this.NzSave.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NzSave.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NzSave.Name = "NzSave";
			this.NzSave.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NzSave.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NzSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzSave.ShowFocusRectangle = false;
			this.NzSave.Size = new System.Drawing.Size(189, 88);
			this.NzSave.TabIndex = 0;
			this.NzSave.Text = "ثبت تغییرات                [F8]";
			this.NzSave.UseThemes = false;
			this.NzSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NzSave.Click += new System.EventHandler(this.NzSave_Click);
			// 
			// nzObjectPopup1
			// 
			this.nzObjectPopup1.DropShadowEnabled = false;
			this.nzObjectPopup1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
			this.nzObjectPopup1.Name = "nzObjectPopup1";
			this.nzObjectPopup1.NzSelected = null;
			this.nzObjectPopup1.Padding = new System.Windows.Forms.Padding(0);
			this.nzObjectPopup1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.nzObjectPopup1.Size = new System.Drawing.Size(0, 0);
			// 
			// Form_BarCode
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1412, 725);
			this.Controls.Add(this.uiTab1);
			this.Controls.Add(this.mS_Panel2);
			this.KeyPreview = true;
			this.Name = "Form_BarCode";
			this.Text = "فاکتور فروش (بارکد خوان)";
			this.Shown += new System.EventHandler(this.Form_Purchase_Shown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_Purchase_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.uiTab1)).EndInit();
			this.uiTab1.ResumeLayout(false);
			this.uiTabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uiTab2)).EndInit();
			this.uiTab2.ResumeLayout(false);
			this.uiTabPage5.ResumeLayout(false);
			this.uiTabPage5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
			this.uiGroupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).EndInit();
			this.uiGroupBox3.ResumeLayout(false);
			this.uiGroupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
			this.uiGroupBox1.ResumeLayout(false);
			this.uiGroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox5)).EndInit();
			this.uiGroupBox5.ResumeLayout(false);
			this.uiGroupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NzGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox6)).EndInit();
			this.uiGroupBox6.ResumeLayout(false);
			this.uiGroupBox6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NzFactorKinds)).EndInit();
			this.NzFactorKinds.ResumeLayout(false);
			this.NzTabPurchaseBack.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.NzPrefactorGrid)).EndInit();
			this.NsGroupKala.ResumeLayout(false);
			this.NsGroupKala.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NzGroupKala)).EndInit();
			this.NzTabPurchase.ResumeLayout(false);
			this.NzTabPurchase.PerformLayout();
			this.uiTabPage3.ResumeLayout(false);
			this.uiTabPage3.PerformLayout();
			this.mS_Panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Tab.UITab uiTab1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private MS_Control.Controls.MS_GridX NzGrid;
        private MS_Control.Controls.MS_Notify mS_Notify1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Component.NzBarcodeReader nzBarcodeReader1;
        private Component.NzLabel NzFindObject;
        private Janus.Windows.UI.Tab.UITab uiTab2;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox5;
        private NZ.General.WinForms.Component.NzPeople NzCustomer;
        private System.Windows.Forms.Label label19;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox3;
        private MS_Control.Controls.MS_ComboBox_Janus NzKind;
        private MS_Control.Controls.MS_NumericTextBox NzOffPrice;
        private MS_Control.Controls.MS_NumericTextBox NzOffPercent;
        private System.Windows.Forms.Label label9;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex7;
        private System.Windows.Forms.Label label10;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private MS_Control.Controls.MS_NumericTextBox NzSerial;
        private System.Windows.Forms.Label label3;
        private MS_Control.Tarikh.MS_Tarikh_TextBox NzDate;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private MS_Control.Controls.MS_Decimal_Label NzSumFactor;
        private MS_Control.Controls.MS_Decimal_Label NzSumRows;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex6;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex1;
        private Component.NzLocation NzLocation;
        private System.Windows.Forms.Label NzLableLocation;
        private Janus.Windows.UI.Tab.UITab NzFactorKinds;
        private Janus.Windows.UI.Tab.UITabPage NzTabPurchaseBack;
        private Janus.Windows.UI.Tab.UITabPage NzTabPurchase;
        private MS_Control.Controls.MS_GridX NzPrefactorGrid;
        private Component.NzBarcodeReader NzBarcodePrice;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label12;
        private Component.NzObjectPopup nzObjectPopup1;
		private Component.NzLabel NsPriceBarcodeTitle;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label11;
		private MS_Control.Controls.MS_Decimal_Label NsOmdePrice;
		private MS_Control.Controls.MS_Decimal_Label NsAdiPrice;
		private MS_Control.Controls.MS_Decimal_Label NsHamkari;
		private MS_Control.Controls.MS_Decimal_Label NsTakhfifPrice;
		private MS_Control.Controls.MS_Button_GridX NsCopyBarcode;
		private NZ.General.WinForms.Component.NzRemainCustomer NzCustomerRemain;
		private MS_Control.Controls.MS_TextBox NzDescription;
		private System.Windows.Forms.Label label37;
		private Janus.Windows.UI.Tab.UITabPage NsGroupKala;
		private MS_Control.Controls.MS_GridX NzGroupKala;
		private DevComponents.DotNetBar.ExpandableSplitter Splitter1;
		private Component.GroupKalaFlayoutPanel SubGroupsPanel;
		private MS_Control.Controls.MS_Panel mS_Panel2;
		private MS_Control.Controls.MS_Button_GridX NzPayment;
		private MS_Control.Controls.MS_Button_GridX NzSave;
		private MS_Control.Controls.MS_Button_GridX NzNewWindows;
		private MS_Control.Controls.MS_Button_GridX NzNew;
		private MS_Control.Controls.MS_Button_GridX NzPosPrint;
		private MS_Control.Controls.MS_Button_GridX NzPrintA4;
		private MS_Control.Controls.MS_Button_GridX NzPrintNormalA5;
	}
}