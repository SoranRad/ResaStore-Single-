using Nz.Anbar.WinForms.Component;
using NZ.General.WinForms.Component;

namespace Nz.Anbar.WinForms.App
{
    partial class Form_Purchase
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Purchase));
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem3 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem4 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.GridEX.GridEXLayout NzGrid_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.HeaderImage");
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_3 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.HeaderImage");
			this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
			this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
			this.NzDescription = new MS_Control.Controls.MS_TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.mS_Lable_Ex9 = new MS_Control.Controls.MS_Lable_Ex();
			this.NzlblCheque = new MS_Control.Controls.MS_Lable_Ex();
			this.mS_Lable_Ex11 = new MS_Control.Controls.MS_Lable_Ex();
			this.NzRemain = new MS_Control.Controls.MS_Decimal_Label();
			this.NzSumPayment = new MS_Control.Controls.MS_Lable_Ex();
			this.NzSumMoney = new MS_Control.Controls.MS_Decimal_Label();
			this.mS_Lable_Ex13 = new MS_Control.Controls.MS_Lable_Ex();
			this.NzSumCash = new MS_Control.Controls.MS_Decimal_Label();
			this.NzSumPos = new MS_Control.Controls.MS_Decimal_Label();
			this.NzSumCheque = new MS_Control.Controls.MS_Decimal_Label();
			this.mS_Lable_Ex2 = new MS_Control.Controls.MS_Lable_Ex();
			this.NzSumFactor = new MS_Control.Controls.MS_Decimal_Label();
			this.NzSumRows = new MS_Control.Controls.MS_Decimal_Label();
			this.NzTaxPrice = new MS_Control.Controls.MS_Decimal_Label();
			this.mS_Decimal_Label1 = new MS_Control.Controls.MS_Decimal_Label();
			this.NzTaxPercent = new MS_Control.Controls.MS_NumericTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.mS_Lable_Ex14 = new MS_Control.Controls.MS_Lable_Ex();
			this.mS_Lable_Ex6 = new MS_Control.Controls.MS_Lable_Ex();
			this.mS_Lable_Ex3 = new MS_Control.Controls.MS_Lable_Ex();
			this.mS_Lable_Ex5 = new MS_Control.Controls.MS_Lable_Ex();
			this.mS_Lable_Ex4 = new MS_Control.Controls.MS_Lable_Ex();
			this.NzExtend = new MS_Control.Controls.MS_NumericTextBox();
			this.mS_Lable_Ex1 = new MS_Control.Controls.MS_Lable_Ex();
			this.NzOffPrice = new MS_Control.Controls.MS_NumericTextBox();
			this.mS_Tool_Strip1 = new MS_Control.Controls.MS_Tool_Strip();
			this.NzPrint = new System.Windows.Forms.ToolStripSplitButton();
			this.NzPrintA4 = new System.Windows.Forms.ToolStripMenuItem();
			this.NzPrintA5 = new System.Windows.Forms.ToolStripMenuItem();
			this.NzPosPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.NzPeopleRemaind = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.NzSave = new System.Windows.Forms.ToolStripButton();
			this.NzNew = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.NzPayment = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.NsKardex = new System.Windows.Forms.ToolStripButton();
			this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
			this.NzAnbar = new Nz.Anbar.WinForms.Component.NzStorage();
			this.NzLocation = new Nz.Anbar.WinForms.Component.NzLocationEx();
			this.NzKindSale = new MS_Control.Controls.MS_ComboBox_Janus();
			this.NzCustomerRemain = new NZ.General.WinForms.Component.NzRemainCustomer();
			this.NzLableLocation = new System.Windows.Forms.Label();
			this.NzKindSaleLbl = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.NzDate = new MS_Control.Tarikh.MS_Tarikh_TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.NzSerial = new MS_Control.Controls.MS_NumericTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.NzCustomer = new NZ.General.WinForms.Component.NzPeople();
			this.NzCustomerLable = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.NzGrid = new MS_Control.Controls.MS_GridX();
			this.label6 = new System.Windows.Forms.Label();
			this.NzOffPercent = new MS_Control.Controls.MS_NumericTextBox();
			this.mS_Lable_Ex7 = new MS_Control.Controls.MS_Lable_Ex();
			this.label5 = new System.Windows.Forms.Label();
			this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
			this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
			this.label19 = new System.Windows.Forms.Label();
			this.NsSendToGirande = new MS_Control.Controls.MS_CheckBox();
			this.NzNoRemainEffect = new MS_Control.Controls.MS_CheckBox();
			this.NzfactorMabna = new Nz.Anbar.WinForms.Component.NzFactors();
			this.NsAddressGirande = new MS_Control.Controls.MS_TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.NsMobileGirande = new MS_Control.Controls.MS_TextBox();
			this.NsTitleGirande = new MS_Control.Controls.MS_TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.NsMohlatTasvieh = new MS_Control.Tarikh.MS_Tarikh_TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nzObjectPopup1 = new Nz.Anbar.WinForms.Component.NzObjectPopup();
			this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
			this.Tab_Control_Main.SuspendLayout();
			this.uiTabPage12.SuspendLayout();
			this.panel1.SuspendLayout();
			this.mS_Tool_Strip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
			this.uiGroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NzGrid)).BeginInit();
			this.uiTabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
			this.uiGroupBox1.SuspendLayout();
			this.uiTabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Tab_Control_Main
			// 
			this.Tab_Control_Main.BackColor = System.Drawing.Color.Transparent;
			this.Tab_Control_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Tab_Control_Main.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Tab_Control_Main.Location = new System.Drawing.Point(0, 0);
			this.Tab_Control_Main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Tab_Control_Main.MultiLine = true;
			this.Tab_Control_Main.Name = "Tab_Control_Main";
			this.Tab_Control_Main.Office2007CustomColor = System.Drawing.Color.Transparent;
			this.Tab_Control_Main.ShowFocusRectangle = false;
			this.Tab_Control_Main.Size = new System.Drawing.Size(963, 574);
			this.Tab_Control_Main.TabIndex = 0;
			this.Tab_Control_Main.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage12,
            this.uiTabPage2,
            this.uiTabPage1});
			this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Tab_Control_Main.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.PowderBlue;
			this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
			this.Tab_Control_Main.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right;
			this.Tab_Control_Main.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Vertical;
			this.Tab_Control_Main.UseThemes = false;
			this.Tab_Control_Main.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
			// 
			// uiTabPage12
			// 
			this.uiTabPage12.Controls.Add(this.NzDescription);
			this.uiTabPage12.Controls.Add(this.panel1);
			this.uiTabPage12.Controls.Add(this.NzSumFactor);
			this.uiTabPage12.Controls.Add(this.NzSumRows);
			this.uiTabPage12.Controls.Add(this.NzTaxPrice);
			this.uiTabPage12.Controls.Add(this.mS_Decimal_Label1);
			this.uiTabPage12.Controls.Add(this.NzTaxPercent);
			this.uiTabPage12.Controls.Add(this.label2);
			this.uiTabPage12.Controls.Add(this.mS_Lable_Ex14);
			this.uiTabPage12.Controls.Add(this.mS_Lable_Ex6);
			this.uiTabPage12.Controls.Add(this.mS_Lable_Ex3);
			this.uiTabPage12.Controls.Add(this.mS_Lable_Ex5);
			this.uiTabPage12.Controls.Add(this.mS_Lable_Ex4);
			this.uiTabPage12.Controls.Add(this.NzExtend);
			this.uiTabPage12.Controls.Add(this.mS_Lable_Ex1);
			this.uiTabPage12.Controls.Add(this.NzOffPrice);
			this.uiTabPage12.Controls.Add(this.mS_Tool_Strip1);
			this.uiTabPage12.Controls.Add(this.uiGroupBox2);
			this.uiTabPage12.Controls.Add(this.NzGrid);
			this.uiTabPage12.Controls.Add(this.label6);
			this.uiTabPage12.Controls.Add(this.NzOffPercent);
			this.uiTabPage12.Controls.Add(this.mS_Lable_Ex7);
			this.uiTabPage12.Controls.Add(this.label5);
			this.uiTabPage12.Location = new System.Drawing.Point(1, 1);
			this.uiTabPage12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.uiTabPage12.Name = "uiTabPage12";
			this.uiTabPage12.PanelFormatStyle.Alpha = 70;
			this.uiTabPage12.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.uiTabPage12.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.uiTabPage12.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
			this.uiTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uiTabPage12.Size = new System.Drawing.Size(933, 572);
			this.uiTabPage12.TabStop = true;
			this.uiTabPage12.Text = "اطلاعات";
			// 
			// NzDescription
			// 
			this.NzDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NzDescription.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzDescription.Location = new System.Drawing.Point(4, 402);
			this.NzDescription.MaxLength = 500;
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
			this.NzDescription.Name = "NzDescription";
			this.NzDescription.Size = new System.Drawing.Size(858, 27);
			this.NzDescription.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.Controls.Add(this.mS_Lable_Ex9);
			this.panel1.Controls.Add(this.NzlblCheque);
			this.panel1.Controls.Add(this.mS_Lable_Ex11);
			this.panel1.Controls.Add(this.NzRemain);
			this.panel1.Controls.Add(this.NzSumPayment);
			this.panel1.Controls.Add(this.NzSumMoney);
			this.panel1.Controls.Add(this.mS_Lable_Ex13);
			this.panel1.Controls.Add(this.NzSumCash);
			this.panel1.Controls.Add(this.NzSumPos);
			this.panel1.Controls.Add(this.NzSumCheque);
			this.panel1.Controls.Add(this.mS_Lable_Ex2);
			this.panel1.Location = new System.Drawing.Point(4, 427);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(291, 151);
			this.panel1.TabIndex = 770;
			// 
			// mS_Lable_Ex9
			// 
			this.mS_Lable_Ex9.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.mS_Lable_Ex9.Location = new System.Drawing.Point(165, 29);
			this.mS_Lable_Ex9.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.mS_Lable_Ex9.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Lable_Ex9.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex9.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex9.Name = "mS_Lable_Ex9";
			this.mS_Lable_Ex9.Size = new System.Drawing.Size(125, 23);
			this.mS_Lable_Ex9.TabIndex = 749;
			this.mS_Lable_Ex9.Text = "وجـه نـقـد :";
			this.mS_Lable_Ex9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NzlblCheque
			// 
			this.NzlblCheque.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzlblCheque.Location = new System.Drawing.Point(165, 75);
			this.NzlblCheque.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzlblCheque.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzlblCheque.MS_Color_End = System.Drawing.Color.Empty;
			this.NzlblCheque.MS_Color_Start = System.Drawing.Color.Empty;
			this.NzlblCheque.Name = "NzlblCheque";
			this.NzlblCheque.Size = new System.Drawing.Size(125, 23);
			this.NzlblCheque.TabIndex = 746;
			this.NzlblCheque.Text = "0   فقره چـک :";
			this.NzlblCheque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// mS_Lable_Ex11
			// 
			this.mS_Lable_Ex11.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.mS_Lable_Ex11.Location = new System.Drawing.Point(165, 52);
			this.mS_Lable_Ex11.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.mS_Lable_Ex11.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Lable_Ex11.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex11.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex11.Name = "mS_Lable_Ex11";
			this.mS_Lable_Ex11.Size = new System.Drawing.Size(125, 23);
			this.mS_Lable_Ex11.TabIndex = 747;
			this.mS_Lable_Ex11.Text = "POS و حواله بانـکی :";
			this.mS_Lable_Ex11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NzRemain
			// 
			this.NzRemain.BackColor = System.Drawing.Color.Lavender;
			this.NzRemain.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzRemain.Location = new System.Drawing.Point(0, 121);
			this.NzRemain.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzRemain.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzRemain.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.NzRemain.MS_Format_String = "0,0.##;(0,0.##); ";
			this.NzRemain.Name = "NzRemain";
			this.NzRemain.Size = new System.Drawing.Size(166, 23);
			this.NzRemain.TabIndex = 759;
			this.NzRemain.Text = " ";
			this.NzRemain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NzSumPayment
			// 
			this.NzSumPayment.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzSumPayment.Location = new System.Drawing.Point(165, 98);
			this.NzSumPayment.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzSumPayment.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzSumPayment.MS_Color_End = System.Drawing.Color.Empty;
			this.NzSumPayment.MS_Color_Start = System.Drawing.Color.Empty;
			this.NzSumPayment.Name = "NzSumPayment";
			this.NzSumPayment.Size = new System.Drawing.Size(125, 23);
			this.NzSumPayment.TabIndex = 748;
			this.NzSumPayment.Text = "کل دریـافتی :";
			this.NzSumPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NzSumMoney
			// 
			this.NzSumMoney.BackColor = System.Drawing.Color.Lavender;
			this.NzSumMoney.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzSumMoney.Location = new System.Drawing.Point(0, 98);
			this.NzSumMoney.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzSumMoney.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzSumMoney.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.NzSumMoney.MS_Format_String = "0,0.##;(0,0.##); ";
			this.NzSumMoney.Name = "NzSumMoney";
			this.NzSumMoney.Size = new System.Drawing.Size(166, 23);
			this.NzSumMoney.TabIndex = 759;
			this.NzSumMoney.Text = " ";
			this.NzSumMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// mS_Lable_Ex13
			// 
			this.mS_Lable_Ex13.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.mS_Lable_Ex13.Location = new System.Drawing.Point(165, 121);
			this.mS_Lable_Ex13.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.mS_Lable_Ex13.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Lable_Ex13.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex13.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex13.Name = "mS_Lable_Ex13";
			this.mS_Lable_Ex13.Size = new System.Drawing.Size(125, 23);
			this.mS_Lable_Ex13.TabIndex = 748;
			this.mS_Lable_Ex13.Text = "مانـده (نسـیه) :";
			this.mS_Lable_Ex13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NzSumCash
			// 
			this.NzSumCash.BackColor = System.Drawing.Color.Lavender;
			this.NzSumCash.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzSumCash.Location = new System.Drawing.Point(0, 29);
			this.NzSumCash.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzSumCash.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzSumCash.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.NzSumCash.MS_Format_String = "0,0.##;(0,0.##); ";
			this.NzSumCash.Name = "NzSumCash";
			this.NzSumCash.Size = new System.Drawing.Size(166, 23);
			this.NzSumCash.TabIndex = 760;
			this.NzSumCash.Text = " ";
			this.NzSumCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NzSumPos
			// 
			this.NzSumPos.BackColor = System.Drawing.Color.Lavender;
			this.NzSumPos.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzSumPos.Location = new System.Drawing.Point(0, 52);
			this.NzSumPos.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzSumPos.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzSumPos.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.NzSumPos.MS_Format_String = "0,0.##;(0,0.##); ";
			this.NzSumPos.Name = "NzSumPos";
			this.NzSumPos.Size = new System.Drawing.Size(166, 23);
			this.NzSumPos.TabIndex = 761;
			this.NzSumPos.Text = " ";
			this.NzSumPos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NzSumCheque
			// 
			this.NzSumCheque.BackColor = System.Drawing.Color.Lavender;
			this.NzSumCheque.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzSumCheque.Location = new System.Drawing.Point(0, 75);
			this.NzSumCheque.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzSumCheque.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzSumCheque.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.NzSumCheque.MS_Format_String = "0,0.##;(0,0.##); ";
			this.NzSumCheque.Name = "NzSumCheque";
			this.NzSumCheque.Size = new System.Drawing.Size(166, 23);
			this.NzSumCheque.TabIndex = 761;
			this.NzSumCheque.Text = " ";
			this.NzSumCheque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// mS_Lable_Ex2
			// 
			this.mS_Lable_Ex2.BackColor = System.Drawing.Color.PowderBlue;
			this.mS_Lable_Ex2.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.mS_Lable_Ex2.ForeColor = System.Drawing.Color.Maroon;
			this.mS_Lable_Ex2.Location = new System.Drawing.Point(0, 4);
			this.mS_Lable_Ex2.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.mS_Lable_Ex2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Lable_Ex2.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex2.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex2.Name = "mS_Lable_Ex2";
			this.mS_Lable_Ex2.Size = new System.Drawing.Size(290, 25);
			this.mS_Lable_Ex2.TabIndex = 757;
			this.mS_Lable_Ex2.Text = "مجموع مبالغ تسویه فاکتور";
			this.mS_Lable_Ex2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NzSumFactor
			// 
			this.NzSumFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.NzSumFactor.BackColor = System.Drawing.Color.Lavender;
			this.NzSumFactor.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NzSumFactor.Location = new System.Drawing.Point(531, 543);
			this.NzSumFactor.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzSumFactor.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzSumFactor.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.NzSumFactor.MS_Format_String = "0,0.##;(0,0.##); ";
			this.NzSumFactor.Name = "NzSumFactor";
			this.NzSumFactor.Size = new System.Drawing.Size(212, 27);
			this.NzSumFactor.TabIndex = 767;
			this.NzSumFactor.Text = " ";
			this.NzSumFactor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NzSumRows
			// 
			this.NzSumRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.NzSumRows.BackColor = System.Drawing.Color.Lavender;
			this.NzSumRows.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NzSumRows.Location = new System.Drawing.Point(531, 435);
			this.NzSumRows.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzSumRows.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzSumRows.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.NzSumRows.MS_Format_String = "0,0.##;(0,0.##); ";
			this.NzSumRows.Name = "NzSumRows";
			this.NzSumRows.Size = new System.Drawing.Size(212, 29);
			this.NzSumRows.TabIndex = 768;
			this.NzSumRows.Text = " ";
			this.NzSumRows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NzTaxPrice
			// 
			this.NzTaxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.NzTaxPrice.BackColor = System.Drawing.Color.Lavender;
			this.NzTaxPrice.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NzTaxPrice.Location = new System.Drawing.Point(593, 517);
			this.NzTaxPrice.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzTaxPrice.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzTaxPrice.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.NzTaxPrice.MS_Format_String = "0,0.##;(0,0.##); ";
			this.NzTaxPrice.Name = "NzTaxPrice";
			this.NzTaxPrice.Size = new System.Drawing.Size(150, 27);
			this.NzTaxPrice.TabIndex = 760;
			this.NzTaxPrice.Text = " ";
			this.NzTaxPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// mS_Decimal_Label1
			// 
			this.mS_Decimal_Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Decimal_Label1.BackColor = System.Drawing.Color.White;
			this.mS_Decimal_Label1.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.mS_Decimal_Label1.Location = new System.Drawing.Point(531, 435);
			this.mS_Decimal_Label1.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.mS_Decimal_Label1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Decimal_Label1.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.mS_Decimal_Label1.MS_Format_String = "N";
			this.mS_Decimal_Label1.Name = "mS_Decimal_Label1";
			this.mS_Decimal_Label1.Size = new System.Drawing.Size(212, 29);
			this.mS_Decimal_Label1.TabIndex = 769;
			this.mS_Decimal_Label1.Text = "0";
			this.mS_Decimal_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NzTaxPercent
			// 
			this.NzTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.NzTaxPercent.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NzTaxPercent.Location = new System.Drawing.Point(531, 517);
			this.NzTaxPercent.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzTaxPercent.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzTaxPercent.MS_Change_Border_Color_On_Enter = true;
			this.NzTaxPercent.MS_Change_Color_On_Enter = true;
			this.NzTaxPercent.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzTaxPercent.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzTaxPercent.MS_Exit_By_Down = true;
			this.NzTaxPercent.MS_Exit_By_Enter = true;
			this.NzTaxPercent.MS_Exit_By_Up = true;
			this.NzTaxPercent.MS_Is_Negative = false;
			this.NzTaxPercent.MS_Last_Control = null;
			this.NzTaxPercent.MS_Next_Control = null;
			this.NzTaxPercent.Name = "NzTaxPercent";
			this.NzTaxPercent.Size = new System.Drawing.Size(41, 31);
			this.NzTaxPercent.TabIndex = 7;
			this.NzTaxPercent.Text = "0";
			this.NzTaxPercent.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
			this.NzTaxPercent.TextChanged += new System.EventHandler(this.NzTaxPercent_TextChanged);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("IRANSans(Small)", 12F);
			this.label2.Location = new System.Drawing.Point(861, 402);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 20);
			this.label2.TabIndex = 161;
			this.label2.Text = "شرح :";
			// 
			// mS_Lable_Ex14
			// 
			this.mS_Lable_Ex14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Lable_Ex14.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.mS_Lable_Ex14.Location = new System.Drawing.Point(571, 517);
			this.mS_Lable_Ex14.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.mS_Lable_Ex14.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Lable_Ex14.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex14.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex14.Name = "mS_Lable_Ex14";
			this.mS_Lable_Ex14.Size = new System.Drawing.Size(23, 27);
			this.mS_Lable_Ex14.TabIndex = 765;
			this.mS_Lable_Ex14.Text = "%";
			this.mS_Lable_Ex14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mS_Lable_Ex6
			// 
			this.mS_Lable_Ex6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Lable_Ex6.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.mS_Lable_Ex6.Location = new System.Drawing.Point(742, 543);
			this.mS_Lable_Ex6.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.mS_Lable_Ex6.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Lable_Ex6.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex6.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex6.Name = "mS_Lable_Ex6";
			this.mS_Lable_Ex6.Size = new System.Drawing.Size(121, 27);
			this.mS_Lable_Ex6.TabIndex = 763;
			this.mS_Lable_Ex6.Text = "مبلغ قابل پرداخت :";
			this.mS_Lable_Ex6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mS_Lable_Ex3
			// 
			this.mS_Lable_Ex3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Lable_Ex3.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.mS_Lable_Ex3.Location = new System.Drawing.Point(742, 491);
			this.mS_Lable_Ex3.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.mS_Lable_Ex3.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Lable_Ex3.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex3.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex3.Name = "mS_Lable_Ex3";
			this.mS_Lable_Ex3.Size = new System.Drawing.Size(121, 27);
			this.mS_Lable_Ex3.TabIndex = 762;
			this.mS_Lable_Ex3.Text = "اضافات :";
			this.mS_Lable_Ex3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mS_Lable_Ex5
			// 
			this.mS_Lable_Ex5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Lable_Ex5.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.mS_Lable_Ex5.Location = new System.Drawing.Point(742, 463);
			this.mS_Lable_Ex5.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.mS_Lable_Ex5.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Lable_Ex5.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex5.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex5.Name = "mS_Lable_Ex5";
			this.mS_Lable_Ex5.Size = new System.Drawing.Size(121, 29);
			this.mS_Lable_Ex5.TabIndex = 762;
			this.mS_Lable_Ex5.Text = "تخفیف :";
			this.mS_Lable_Ex5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mS_Lable_Ex4
			// 
			this.mS_Lable_Ex4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Lable_Ex4.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.mS_Lable_Ex4.Location = new System.Drawing.Point(742, 517);
			this.mS_Lable_Ex4.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.mS_Lable_Ex4.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Lable_Ex4.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex4.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex4.Name = "mS_Lable_Ex4";
			this.mS_Lable_Ex4.Size = new System.Drawing.Size(121, 27);
			this.mS_Lable_Ex4.TabIndex = 761;
			this.mS_Lable_Ex4.Text = "ارزش افزوده :";
			this.mS_Lable_Ex4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// NzExtend
			// 
			this.NzExtend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.NzExtend.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NzExtend.Location = new System.Drawing.Point(531, 491);
			this.NzExtend.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzExtend.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzExtend.MS_Change_Border_Color_On_Enter = true;
			this.NzExtend.MS_Change_Color_On_Enter = true;
			this.NzExtend.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzExtend.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzExtend.MS_Exit_By_Down = true;
			this.NzExtend.MS_Exit_By_Enter = true;
			this.NzExtend.MS_Exit_By_Up = true;
			this.NzExtend.MS_Is_Negative = false;
			this.NzExtend.MS_Last_Control = null;
			this.NzExtend.MS_Next_Control = null;
			this.NzExtend.Name = "NzExtend";
			this.NzExtend.Size = new System.Drawing.Size(212, 31);
			this.NzExtend.TabIndex = 6;
			this.NzExtend.Text = "0";
			this.NzExtend.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
			this.NzExtend.TextChanged += new System.EventHandler(this.NzExtend_TextChanged);
			// 
			// mS_Lable_Ex1
			// 
			this.mS_Lable_Ex1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Lable_Ex1.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.mS_Lable_Ex1.Location = new System.Drawing.Point(742, 435);
			this.mS_Lable_Ex1.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.mS_Lable_Ex1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Lable_Ex1.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex1.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex1.Name = "mS_Lable_Ex1";
			this.mS_Lable_Ex1.Size = new System.Drawing.Size(121, 29);
			this.mS_Lable_Ex1.TabIndex = 764;
			this.mS_Lable_Ex1.Text = "مجموع اقلام :";
			this.mS_Lable_Ex1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// NzOffPrice
			// 
			this.NzOffPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.NzOffPrice.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NzOffPrice.Location = new System.Drawing.Point(593, 463);
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
			this.NzOffPrice.Size = new System.Drawing.Size(150, 31);
			this.NzOffPrice.TabIndex = 4;
			this.NzOffPrice.Text = "0";
			this.NzOffPrice.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
			this.NzOffPrice.TextChanged += new System.EventHandler(this.NzOffPrice_TextChanged);
			// 
			// mS_Tool_Strip1
			// 
			this.mS_Tool_Strip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mS_Tool_Strip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NzPrint,
            this.toolStripSeparator3,
            this.NzSave,
            this.NzNew,
            this.toolStripSeparator1,
            this.NzPayment,
            this.toolStripSeparator4,
            this.NsKardex});
			this.mS_Tool_Strip1.Location = new System.Drawing.Point(0, 0);
			this.mS_Tool_Strip1.MS_BorderColor = System.Drawing.Color.SkyBlue;
			this.mS_Tool_Strip1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Tool_Strip1.MS_Color_End = System.Drawing.Color.LightBlue;
			this.mS_Tool_Strip1.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.mS_Tool_Strip1.Name = "mS_Tool_Strip1";
			this.mS_Tool_Strip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.mS_Tool_Strip1.Size = new System.Drawing.Size(933, 25);
			this.mS_Tool_Strip1.TabIndex = 6;
			this.mS_Tool_Strip1.Text = "mS_Tool_Strip1";
			// 
			// NzPrint
			// 
			this.NzPrint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.NzPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NzPrint.DropDownButtonWidth = 15;
			this.NzPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NzPrintA4,
            this.NzPrintA5,
            this.NzPosPrint,
            this.toolStripSeparator2,
            this.NzPeopleRemaind});
			this.NzPrint.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzPrint.Image = ((System.Drawing.Image)(resources.GetObject("NzPrint.Image")));
			this.NzPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NzPrint.Margin = new System.Windows.Forms.Padding(15, 1, 2, 2);
			this.NzPrint.Name = "NzPrint";
			this.NzPrint.Size = new System.Drawing.Size(36, 22);
			this.NzPrint.Text = "چاپ فاکتور ";
			this.NzPrint.Click += new System.EventHandler(this.NzPrint_Click);
			// 
			// NzPrintA4
			// 
			this.NzPrintA4.Name = "NzPrintA4";
			this.NzPrintA4.Size = new System.Drawing.Size(174, 28);
			this.NzPrintA4.Text = "چاپ  A4";
			this.NzPrintA4.Click += new System.EventHandler(this.NzPrintNormalA4_Click);
			// 
			// NzPrintA5
			// 
			this.NzPrintA5.Name = "NzPrintA5";
			this.NzPrintA5.Size = new System.Drawing.Size(174, 28);
			this.NzPrintA5.Text = "چاپ  A5";
			this.NzPrintA5.Click += new System.EventHandler(this.NzPrintNormalA5_Click);
			// 
			// NzPosPrint
			// 
			this.NzPosPrint.Name = "NzPosPrint";
			this.NzPosPrint.Size = new System.Drawing.Size(174, 28);
			this.NzPosPrint.Text = "فیش پرینت";
			this.NzPosPrint.Click += new System.EventHandler(this.NzPosPrint_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
			// 
			// NzPeopleRemaind
			// 
			this.NzPeopleRemaind.CheckOnClick = true;
			this.NzPeopleRemaind.Name = "NzPeopleRemaind";
			this.NzPeopleRemaind.Size = new System.Drawing.Size(174, 28);
			this.NzPeopleRemaind.Text = "چاپ مانده شخص";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// NzSave
			// 
			this.NzSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.NzSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NzSave.Image = ((System.Drawing.Image)(resources.GetObject("NzSave.Image")));
			this.NzSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NzSave.Name = "NzSave";
			this.NzSave.Size = new System.Drawing.Size(23, 22);
			this.NzSave.Text = "ذخیـره فاکـتور";
			this.NzSave.Click += new System.EventHandler(this.NzSave_Click);
			// 
			// NzNew
			// 
			this.NzNew.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.NzNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NzNew.Image = ((System.Drawing.Image)(resources.GetObject("NzNew.Image")));
			this.NzNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NzNew.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
			this.NzNew.Name = "NzNew";
			this.NzNew.Size = new System.Drawing.Size(23, 22);
			this.NzNew.Text = "فاکتور جدید ";
			this.NzNew.Click += new System.EventHandler(this.NzNew_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// NzPayment
			// 
			this.NzPayment.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.NzPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NzPayment.Image = ((System.Drawing.Image)(resources.GetObject("NzPayment.Image")));
			this.NzPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NzPayment.Name = "NzPayment";
			this.NzPayment.Size = new System.Drawing.Size(23, 22);
			this.NzPayment.Text = "تسویه فاکتور (پرداخت وجوه)";
			this.NzPayment.Click += new System.EventHandler(this.NzPayment_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// NsKardex
			// 
			this.NsKardex.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.NsKardex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NsKardex.Image = ((System.Drawing.Image)(resources.GetObject("NsKardex.Image")));
			this.NsKardex.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NsKardex.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
			this.NsKardex.Name = "NsKardex";
			this.NsKardex.Size = new System.Drawing.Size(23, 22);
			this.NsKardex.Text = "مـشاهده کاردکس کالا";
			this.NsKardex.Click += new System.EventHandler(this.NsKardex_Click);
			// 
			// uiGroupBox2
			// 
			this.uiGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uiGroupBox2.BackColor = System.Drawing.Color.Transparent;
			this.uiGroupBox2.BorderColor = System.Drawing.Color.LightBlue;
			this.uiGroupBox2.Controls.Add(this.NzAnbar);
			this.uiGroupBox2.Controls.Add(this.NzLocation);
			this.uiGroupBox2.Controls.Add(this.NzKindSale);
			this.uiGroupBox2.Controls.Add(this.NzCustomerRemain);
			this.uiGroupBox2.Controls.Add(this.NzLableLocation);
			this.uiGroupBox2.Controls.Add(this.NzKindSaleLbl);
			this.uiGroupBox2.Controls.Add(this.label4);
			this.uiGroupBox2.Controls.Add(this.NzDate);
			this.uiGroupBox2.Controls.Add(this.label8);
			this.uiGroupBox2.Controls.Add(this.NzSerial);
			this.uiGroupBox2.Controls.Add(this.label1);
			this.uiGroupBox2.Controls.Add(this.NzCustomer);
			this.uiGroupBox2.Controls.Add(this.NzCustomerLable);
			this.uiGroupBox2.Controls.Add(this.label15);
			this.uiGroupBox2.Location = new System.Drawing.Point(4, 21);
			this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.uiGroupBox2.Name = "uiGroupBox2";
			this.uiGroupBox2.Size = new System.Drawing.Size(923, 58);
			this.uiGroupBox2.TabIndex = 0;
			// 
			// NzAnbar
			// 
			this.NzAnbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzAnbar.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.NzAnbar.DropSize = new System.Drawing.Size(156, 29);
			this.NzAnbar.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzAnbar.Location = new System.Drawing.Point(764, 27);
			this.NzAnbar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NzAnbar.MS_Auto_Popup = false;
			this.NzAnbar.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzAnbar.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzAnbar.MS_CaptureFocus = false;
			this.NzAnbar.MS_Change_Border_Color_On_Enter = true;
			this.NzAnbar.MS_Change_Color_On_Enter = true;
			this.NzAnbar.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
			this.NzAnbar.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
			this.NzAnbar.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzAnbar.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzAnbar.MS_Exit_By_Down = true;
			this.NzAnbar.MS_Exit_By_Enter = true;
			this.NzAnbar.MS_Exit_By_Up = true;
			this.NzAnbar.MS_Last_Control = null;
			this.NzAnbar.MS_Next_Control = null;
			this.NzAnbar.Name = "NzAnbar";
			this.NzAnbar.Office2007CustomColor = System.Drawing.Color.SkyBlue;
			this.NzAnbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzAnbar.Size = new System.Drawing.Size(156, 29);
			this.NzAnbar.TabIndex = 0;
			this.NzAnbar.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// NzLocation
			// 
			this.NzLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzLocation.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.NzLocation.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzLocation.DropSize = new System.Drawing.Size(142, 29);
			this.NzLocation.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzLocation.Location = new System.Drawing.Point(15, 27);
			this.NzLocation.MS_Auto_Popup = false;
			this.NzLocation.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzLocation.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzLocation.MS_CaptureFocus = false;
			this.NzLocation.MS_Change_Border_Color_On_Enter = true;
			this.NzLocation.MS_Change_Color_On_Enter = true;
			this.NzLocation.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
			this.NzLocation.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
			this.NzLocation.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzLocation.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzLocation.MS_Exit_By_Down = true;
			this.NzLocation.MS_Exit_By_Enter = true;
			this.NzLocation.MS_Exit_By_Up = true;
			this.NzLocation.MS_Last_Control = null;
			this.NzLocation.MS_Next_Control = null;
			this.NzLocation.Name = "NzLocation";
			this.NzLocation.Size = new System.Drawing.Size(142, 29);
			this.NzLocation.TabIndex = 6;
			this.NzLocation.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// NzKindSale
			// 
			this.NzKindSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzKindSale.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.NzKindSale.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzKindSale.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			uiComboBoxItem3.FormatStyle.Alpha = 0;
			uiComboBoxItem3.Image = ((System.Drawing.Image)(resources.GetObject("uiComboBoxItem3.Image")));
			uiComboBoxItem3.IsSeparator = false;
			uiComboBoxItem3.Text = "فروش خرده";
			uiComboBoxItem4.FormatStyle.Alpha = 0;
			uiComboBoxItem4.Image = ((System.Drawing.Image)(resources.GetObject("uiComboBoxItem4.Image")));
			uiComboBoxItem4.IsSeparator = false;
			uiComboBoxItem4.Text = "فروش عمـده";
			this.NzKindSale.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem3,
            uiComboBoxItem4});
			this.NzKindSale.Location = new System.Drawing.Point(159, 27);
			this.NzKindSale.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzKindSale.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzKindSale.MS_Change_Border_Color_On_Enter = true;
			this.NzKindSale.MS_Change_Color_On_Enter = true;
			this.NzKindSale.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzKindSale.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzKindSale.MS_Exit_By_Down = true;
			this.NzKindSale.MS_Exit_By_Enter = true;
			this.NzKindSale.MS_Exit_By_Up = true;
			this.NzKindSale.MS_Last_Control = null;
			this.NzKindSale.MS_Next_Control = null;
			this.NzKindSale.Name = "NzKindSale";
			this.NzKindSale.Size = new System.Drawing.Size(138, 29);
			this.NzKindSale.TabIndex = 5;
			this.NzKindSale.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			// 
			// NzCustomerRemain
			// 
			this.NzCustomerRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzCustomerRemain.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NzCustomerRemain.Location = new System.Drawing.Point(299, 27);
			this.NzCustomerRemain.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzCustomerRemain.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzCustomerRemain.MS_Color_End = System.Drawing.Color.Empty;
			this.NzCustomerRemain.MS_Color_Start = System.Drawing.Color.Empty;
			this.NzCustomerRemain.Name = "NzCustomerRemain";
			this.NzCustomerRemain.Size = new System.Drawing.Size(129, 29);
			this.NzCustomerRemain.TabIndex = 4;
			this.NzCustomerRemain.Text = "0";
			this.NzCustomerRemain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NzLableLocation
			// 
			this.NzLableLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzLableLocation.AutoSize = true;
			this.NzLableLocation.BackColor = System.Drawing.Color.Transparent;
			this.NzLableLocation.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzLableLocation.Location = new System.Drawing.Point(52, 5);
			this.NzLableLocation.Name = "NzLableLocation";
			this.NzLableLocation.Size = new System.Drawing.Size(92, 23);
			this.NzLableLocation.TabIndex = 765;
			this.NzLableLocation.Text = "موقـعیت فروش";
			this.NzLableLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NzKindSaleLbl
			// 
			this.NzKindSaleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzKindSaleLbl.AutoSize = true;
			this.NzKindSaleLbl.BackColor = System.Drawing.Color.Transparent;
			this.NzKindSaleLbl.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzKindSaleLbl.Location = new System.Drawing.Point(220, 5);
			this.NzKindSaleLbl.Name = "NzKindSaleLbl";
			this.NzKindSaleLbl.Size = new System.Drawing.Size(64, 23);
			this.NzKindSaleLbl.TabIndex = 765;
			this.NzKindSaleLbl.Text = "نوع فروش";
			this.NzKindSaleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label4.Location = new System.Drawing.Point(322, 5);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 23);
			this.label4.TabIndex = 765;
			this.label4.Text = "وضعیت فعلی ";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.NzDate.Location = new System.Drawing.Point(591, 27);
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
			this.NzDate.TabIndex = 2;
			this.NzDate.Text = "//";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label8.Location = new System.Drawing.Point(624, 5);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(42, 23);
			this.label8.TabIndex = 756;
			this.label8.Text = "تاریخ ";
			// 
			// NzSerial
			// 
			this.NzSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzSerial.ButtonText = "000";
			this.NzSerial.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzSerial.DigitGroup = false;
			this.NzSerial.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzSerial.Location = new System.Drawing.Point(699, 27);
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
			this.NzSerial.Size = new System.Drawing.Size(63, 29);
			this.NzSerial.TabIndex = 1;
			this.NzSerial.TabStop = false;
			this.NzSerial.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.NzSerial.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label1.Location = new System.Drawing.Point(712, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 23);
			this.label1.TabIndex = 162;
			this.label1.Text = "سریال";
			// 
			// NzCustomer
			// 
			this.NzCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzCustomer.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.NzCustomer.DropSize = new System.Drawing.Size(160, 29);
			this.NzCustomer.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzCustomer.Location = new System.Drawing.Point(430, 27);
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
			this.NzCustomer.Size = new System.Drawing.Size(160, 29);
			this.NzCustomer.TabIndex = 3;
			this.NzCustomer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NzCustomer.MS_On_Row_Selected += new System.EventHandler<MS_Control.TSDD.On_Selected>(this.NzCustomer_Selected);
			// 
			// NzCustomerLable
			// 
			this.NzCustomerLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzCustomerLable.AutoSize = true;
			this.NzCustomerLable.BackColor = System.Drawing.Color.Transparent;
			this.NzCustomerLable.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzCustomerLable.Location = new System.Drawing.Point(487, 5);
			this.NzCustomerLable.Name = "NzCustomerLable";
			this.NzCustomerLable.Size = new System.Drawing.Size(52, 23);
			this.NzCustomerLable.TabIndex = 163;
			this.NzCustomerLable.Text = "فروشنده";
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label15.Location = new System.Drawing.Point(831, 5);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(29, 23);
			this.label15.TabIndex = 771;
			this.label15.Text = "انبار";
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
			this.NzGrid.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
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
			this.NzGrid.Location = new System.Drawing.Point(0, 82);
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
			this.NzGrid.Size = new System.Drawing.Size(933, 318);
			this.NzGrid.TabIndex = 1;
			this.NzGrid.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
			this.NzGrid.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NzGrid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzGrid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.NzGrid.TreeLineColor = System.Drawing.Color.Black;
			this.NzGrid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.NzGrid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NzGrid.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.ms_grid_RowDoubleClick);
			this.NzGrid.EditModeChanged += new System.EventHandler(this.ms_grid_EditModeChanged);
			this.NzGrid.CancelingRowEdit += new Janus.Windows.GridEX.RowActionCancelEventHandler(this.NzGrid_CancelingRowEdit);
			this.NzGrid.GetNewRow += new Janus.Windows.GridEX.GetNewRowEventHandler(this.NzGrid_GetNewRow);
			this.NzGrid.CellEdited += new Janus.Windows.GridEX.ColumnActionEventHandler(this.NzGrid_CellEdited);
			this.NzGrid.CellUpdated += new Janus.Windows.GridEX.ColumnActionEventHandler(this.ms_grid_CellUpdated);
			this.NzGrid.UpdatingCell += new Janus.Windows.GridEX.UpdatingCellEventHandler(this.NzGrid_UpdatingCell);
			this.NzGrid.RecordsDeleted += new System.EventHandler(this.NzGrid_RecordAdded);
			this.NzGrid.RecordUpdated += new System.EventHandler(this.NzGrid_RecordAdded);
			this.NzGrid.RecordAdded += new System.EventHandler(this.NzGrid_RecordAdded);
			this.NzGrid.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.ms_grid_UpdatingRecord);
			this.NzGrid.AddingRecord += new System.ComponentModel.CancelEventHandler(this.ms_grid_AddingRecord);
			this.NzGrid.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.ms_grid_ColumnButtonClick);
			this.NzGrid.CurrentCellChanged += new System.EventHandler(this.ms_grid_CurrentCellChanged);
			this.NzGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ms_grid_KeyPress);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label6.Location = new System.Drawing.Point(860, 466);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 23);
			this.label6.TabIndex = 161;
			this.label6.Text = "[ F7 ]";
			// 
			// NzOffPercent
			// 
			this.NzOffPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.NzOffPercent.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NzOffPercent.Location = new System.Drawing.Point(531, 463);
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
			this.NzOffPercent.Size = new System.Drawing.Size(41, 31);
			this.NzOffPercent.TabIndex = 3;
			this.NzOffPercent.Text = "0";
			this.NzOffPercent.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
			this.NzOffPercent.TextChanged += new System.EventHandler(this.NzOffPercent_TextChanged);
			// 
			// mS_Lable_Ex7
			// 
			this.mS_Lable_Ex7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Lable_Ex7.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.mS_Lable_Ex7.Location = new System.Drawing.Point(571, 463);
			this.mS_Lable_Ex7.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.mS_Lable_Ex7.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Lable_Ex7.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex7.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex7.Name = "mS_Lable_Ex7";
			this.mS_Lable_Ex7.Size = new System.Drawing.Size(23, 29);
			this.mS_Lable_Ex7.TabIndex = 766;
			this.mS_Lable_Ex7.Text = "%";
			this.mS_Lable_Ex7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label5.Location = new System.Drawing.Point(896, 404);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 23);
			this.label5.TabIndex = 161;
			this.label5.Text = "[ F6 ]";
			// 
			// uiTabPage2
			// 
			this.uiTabPage2.Controls.Add(this.uiGroupBox1);
			this.uiTabPage2.Location = new System.Drawing.Point(1, 1);
			this.uiTabPage2.Name = "uiTabPage2";
			this.uiTabPage2.PanelFormatStyle.Alpha = 70;
			this.uiTabPage2.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.uiTabPage2.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.uiTabPage2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uiTabPage2.Size = new System.Drawing.Size(919, 547);
			this.uiTabPage2.TabStop = true;
			this.uiTabPage2.Text = "سایر جزئیات";
			// 
			// uiGroupBox1
			// 
			this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uiGroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.uiGroupBox1.BorderColor = System.Drawing.Color.LightBlue;
			this.uiGroupBox1.Controls.Add(this.label19);
			this.uiGroupBox1.Controls.Add(this.NsSendToGirande);
			this.uiGroupBox1.Controls.Add(this.NzNoRemainEffect);
			this.uiGroupBox1.Controls.Add(this.NzfactorMabna);
			this.uiGroupBox1.Controls.Add(this.NsAddressGirande);
			this.uiGroupBox1.Controls.Add(this.label14);
			this.uiGroupBox1.Controls.Add(this.NsMobileGirande);
			this.uiGroupBox1.Controls.Add(this.NsTitleGirande);
			this.uiGroupBox1.Controls.Add(this.label16);
			this.uiGroupBox1.Controls.Add(this.NsMohlatTasvieh);
			this.uiGroupBox1.Controls.Add(this.label20);
			this.uiGroupBox1.Controls.Add(this.label17);
			this.uiGroupBox1.Controls.Add(this.label18);
			this.uiGroupBox1.Location = new System.Drawing.Point(10, 10);
			this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.uiGroupBox1.Name = "uiGroupBox1";
			this.uiGroupBox1.Size = new System.Drawing.Size(899, 294);
			this.uiGroupBox1.TabIndex = 781;
			// 
			// label19
			// 
			this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label19.AutoSize = true;
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label19.ForeColor = System.Drawing.Color.IndianRed;
			this.label19.Location = new System.Drawing.Point(290, 19);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(115, 23);
			this.label19.TabIndex = 820;
			this.label19.Text = "(فاکتور پیش فروش)";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NsSendToGirande
			// 
			this.NsSendToGirande.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsSendToGirande.BackColor = System.Drawing.Color.Transparent;
			this.NsSendToGirande.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsSendToGirande.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsSendToGirande.Location = new System.Drawing.Point(376, 246);
			this.NsSendToGirande.Margin = new System.Windows.Forms.Padding(7, 21, 7, 21);
			this.NsSendToGirande.MS_BorderColor = System.Drawing.Color.Transparent;
			this.NsSendToGirande.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsSendToGirande.MS_Change_Border_Color_On_Enter = true;
			this.NsSendToGirande.MS_Change_Color_On_Checked = true;
			this.NsSendToGirande.MS_Change_Color_On_Enter = true;
			this.NsSendToGirande.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsSendToGirande.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsSendToGirande.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsSendToGirande.MS_Exit_By_Down = true;
			this.NsSendToGirande.MS_Exit_By_Enter = true;
			this.NsSendToGirande.MS_Exit_By_Up = true;
			this.NsSendToGirande.MS_Last_Control = null;
			this.NsSendToGirande.MS_Next_Control = null;
			this.NsSendToGirande.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.NsSendToGirande.Name = "NsSendToGirande";
			this.NsSendToGirande.ShowFocusRectangle = false;
			this.NsSendToGirande.Size = new System.Drawing.Size(414, 31);
			this.NsSendToGirande.TabIndex = 819;
			this.NsSendToGirande.Text = "   به گیرنده ارسال شده است";
			this.NsSendToGirande.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// NzNoRemainEffect
			// 
			this.NzNoRemainEffect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzNoRemainEffect.BackColor = System.Drawing.Color.Transparent;
			this.NzNoRemainEffect.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzNoRemainEffect.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzNoRemainEffect.Location = new System.Drawing.Point(407, 15);
			this.NzNoRemainEffect.Margin = new System.Windows.Forms.Padding(7, 21, 7, 21);
			this.NzNoRemainEffect.MS_BorderColor = System.Drawing.Color.Transparent;
			this.NzNoRemainEffect.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzNoRemainEffect.MS_Change_Border_Color_On_Enter = true;
			this.NzNoRemainEffect.MS_Change_Color_On_Checked = true;
			this.NzNoRemainEffect.MS_Change_Color_On_Enter = true;
			this.NzNoRemainEffect.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NzNoRemainEffect.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzNoRemainEffect.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzNoRemainEffect.MS_Exit_By_Down = true;
			this.NzNoRemainEffect.MS_Exit_By_Enter = true;
			this.NzNoRemainEffect.MS_Exit_By_Up = true;
			this.NzNoRemainEffect.MS_Last_Control = null;
			this.NzNoRemainEffect.MS_Next_Control = null;
			this.NzNoRemainEffect.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.NzNoRemainEffect.Name = "NzNoRemainEffect";
			this.NzNoRemainEffect.ShowFocusRectangle = false;
			this.NzNoRemainEffect.Size = new System.Drawing.Size(383, 31);
			this.NzNoRemainEffect.TabIndex = 819;
			this.NzNoRemainEffect.Text = "   اقلام فاکتور پیش فروش شده و طی یک حواله از انبار خارج می گردد";
			this.NzNoRemainEffect.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// NzfactorMabna
			// 
			this.NzfactorMabna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzfactorMabna.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.NzfactorMabna.DropSize = new System.Drawing.Size(500, 29);
			this.NzfactorMabna.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzfactorMabna.Location = new System.Drawing.Point(290, 54);
			this.NzfactorMabna.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NzfactorMabna.MS_Auto_Popup = false;
			this.NzfactorMabna.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzfactorMabna.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzfactorMabna.MS_CaptureFocus = false;
			this.NzfactorMabna.MS_Change_Border_Color_On_Enter = true;
			this.NzfactorMabna.MS_Change_Color_On_Enter = true;
			this.NzfactorMabna.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
			this.NzfactorMabna.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
			this.NzfactorMabna.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzfactorMabna.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzfactorMabna.MS_Exit_By_Down = true;
			this.NzfactorMabna.MS_Exit_By_Enter = true;
			this.NzfactorMabna.MS_Exit_By_Up = true;
			this.NzfactorMabna.MS_Last_Control = null;
			this.NzfactorMabna.MS_Next_Control = null;
			this.NzfactorMabna.Name = "NzfactorMabna";
			this.NzfactorMabna.Office2007CustomColor = System.Drawing.Color.SkyBlue;
			this.NzfactorMabna.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzfactorMabna.Size = new System.Drawing.Size(500, 29);
			this.NzfactorMabna.TabIndex = 777;
			this.NzfactorMabna.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// NsAddressGirande
			// 
			this.NsAddressGirande.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsAddressGirande.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsAddressGirande.Location = new System.Drawing.Point(14, 215);
			this.NsAddressGirande.MaxLength = 500;
			this.NsAddressGirande.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsAddressGirande.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsAddressGirande.MS_Change_Border_Color_On_Enter = true;
			this.NsAddressGirande.MS_Change_Color_On_Enter = true;
			this.NsAddressGirande.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsAddressGirande.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsAddressGirande.MS_Exit_By_Down = true;
			this.NsAddressGirande.MS_Exit_By_Enter = true;
			this.NsAddressGirande.MS_Exit_By_Up = true;
			this.NsAddressGirande.MS_Last_Control = null;
			this.NsAddressGirande.MS_Next_Control = null;
			this.NsAddressGirande.Name = "NsAddressGirande";
			this.NsAddressGirande.Size = new System.Drawing.Size(776, 27);
			this.NsAddressGirande.TabIndex = 780;
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label14.Location = new System.Drawing.Point(791, 54);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(81, 23);
			this.label14.TabIndex = 778;
			this.label14.Text = "فاکتور مرجع :";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NsMobileGirande
			// 
			this.NsMobileGirande.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsMobileGirande.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsMobileGirande.Location = new System.Drawing.Point(581, 183);
			this.NsMobileGirande.MaxLength = 500;
			this.NsMobileGirande.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsMobileGirande.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsMobileGirande.MS_Change_Border_Color_On_Enter = true;
			this.NsMobileGirande.MS_Change_Color_On_Enter = true;
			this.NsMobileGirande.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsMobileGirande.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsMobileGirande.MS_Exit_By_Down = true;
			this.NsMobileGirande.MS_Exit_By_Enter = true;
			this.NsMobileGirande.MS_Exit_By_Up = true;
			this.NsMobileGirande.MS_Last_Control = null;
			this.NsMobileGirande.MS_Next_Control = null;
			this.NsMobileGirande.Name = "NsMobileGirande";
			this.NsMobileGirande.Size = new System.Drawing.Size(209, 27);
			this.NsMobileGirande.TabIndex = 780;
			// 
			// NsTitleGirande
			// 
			this.NsTitleGirande.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsTitleGirande.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsTitleGirande.Location = new System.Drawing.Point(511, 151);
			this.NsTitleGirande.MaxLength = 500;
			this.NsTitleGirande.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsTitleGirande.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsTitleGirande.MS_Change_Border_Color_On_Enter = true;
			this.NsTitleGirande.MS_Change_Color_On_Enter = true;
			this.NsTitleGirande.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsTitleGirande.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsTitleGirande.MS_Exit_By_Down = true;
			this.NsTitleGirande.MS_Exit_By_Enter = true;
			this.NsTitleGirande.MS_Exit_By_Up = true;
			this.NsTitleGirande.MS_Last_Control = null;
			this.NsTitleGirande.MS_Next_Control = null;
			this.NsTitleGirande.Name = "NsTitleGirande";
			this.NsTitleGirande.Size = new System.Drawing.Size(279, 27);
			this.NsTitleGirande.TabIndex = 780;
			// 
			// label16
			// 
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label16.Location = new System.Drawing.Point(791, 92);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(83, 23);
			this.label16.TabIndex = 778;
			this.label16.Text = "مهلت تسویه :";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NsMohlatTasvieh
			// 
			this.NsMohlatTasvieh.AllowInternalTab = false;
			this.NsMohlatTasvieh.AllowResizeDropDown = false;
			this.NsMohlatTasvieh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsMohlatTasvieh.AutoHeight = false;
			this.NsMohlatTasvieh.BackColor = System.Drawing.Color.White;
			this.NsMohlatTasvieh.ControlSize = new System.Drawing.Size(0, 0);
			this.NsMohlatTasvieh.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.NsMohlatTasvieh.DropSize = new System.Drawing.Size(0, 0);
			this.NsMohlatTasvieh.Font = new System.Drawing.Font("IRANSans(Small)", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsMohlatTasvieh.Location = new System.Drawing.Point(683, 90);
			this.NsMohlatTasvieh.MinimumSize = new System.Drawing.Size(107, 29);
			this.NsMohlatTasvieh.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsMohlatTasvieh.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsMohlatTasvieh.MS_Change_Border_Color_On_Enter = true;
			this.NsMohlatTasvieh.MS_Change_Color_On_Enter = true;
			this.NsMohlatTasvieh.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsMohlatTasvieh.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsMohlatTasvieh.MS_Exit_By_Down = true;
			this.NsMohlatTasvieh.MS_Exit_By_Enter = true;
			this.NsMohlatTasvieh.MS_Exit_By_Up = true;
			this.NsMohlatTasvieh.MS_Last_Control = null;
			this.NsMohlatTasvieh.MS_Next_Control = null;
			this.NsMohlatTasvieh.MS_Separation = '/';
			this.NsMohlatTasvieh.MS_Tarikh = null;
			this.NsMohlatTasvieh.Name = "NsMohlatTasvieh";
			this.NsMohlatTasvieh.ReadOnly = false;
			this.NsMohlatTasvieh.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.NsMohlatTasvieh.Size = new System.Drawing.Size(107, 29);
			this.NsMohlatTasvieh.TabIndex = 779;
			this.NsMohlatTasvieh.Text = "//";
			// 
			// label20
			// 
			this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label20.AutoSize = true;
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label20.Location = new System.Drawing.Point(792, 185);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(89, 23);
			this.label20.TabIndex = 778;
			this.label20.Text = "موبایل گیرنده :";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label17
			// 
			this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label17.Location = new System.Drawing.Point(792, 217);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(83, 23);
			this.label17.TabIndex = 778;
			this.label17.Text = "آدرس گیرنده :";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label18.AutoSize = true;
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label18.Location = new System.Drawing.Point(792, 153);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(82, 23);
			this.label18.TabIndex = 778;
			this.label18.Text = "عنوان گیرنده :";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// uiTabPage1
			// 
			this.uiTabPage1.Controls.Add(this.label10);
			this.uiTabPage1.Controls.Add(this.label9);
			this.uiTabPage1.Controls.Add(this.label13);
			this.uiTabPage1.Controls.Add(this.label12);
			this.uiTabPage1.Controls.Add(this.label11);
			this.uiTabPage1.Controls.Add(this.label7);
			this.uiTabPage1.Controls.Add(this.label3);
			this.uiTabPage1.Location = new System.Drawing.Point(1, 1);
			this.uiTabPage1.Name = "uiTabPage1";
			this.uiTabPage1.Size = new System.Drawing.Size(919, 547);
			this.uiTabPage1.TabStop = true;
			this.uiTabPage1.Text = "پرسش و پاسخ";
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label10.Location = new System.Drawing.Point(709, 124);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(81, 25);
			this.label10.TabIndex = 164;
			this.label10.Text = "چاپ فاکتور ";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label9.Location = new System.Drawing.Point(709, 90);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 25);
			this.label9.TabIndex = 164;
			this.label9.Text = "فاکتور جدید";
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label13.ForeColor = System.Drawing.Color.Green;
			this.label13.Location = new System.Drawing.Point(796, 124);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(79, 25);
			this.label13.TabIndex = 164;
			this.label13.Text = "[ Ctrl + P ]";
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label12.ForeColor = System.Drawing.Color.Green;
			this.label12.Location = new System.Drawing.Point(796, 90);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(67, 25);
			this.label12.TabIndex = 164;
			this.label12.Text = "[ Insert ]";
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label11.ForeColor = System.Drawing.Color.Green;
			this.label11.Location = new System.Drawing.Point(796, 54);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(45, 25);
			this.label11.TabIndex = 164;
			this.label11.Text = "[ F4 ]";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.label7.Location = new System.Drawing.Point(692, 54);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(98, 25);
			this.label7.TabIndex = 164;
			this.label7.Text = "ذخیـره تغییرات";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("IRANSans(Small)", 20F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.SteelBlue;
			this.label3.Location = new System.Drawing.Point(698, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(197, 34);
			this.label3.TabIndex = 164;
			this.label3.Text = "راهنمای کلید های میانبر";
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
			// Form_Purchase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(963, 574);
			this.Controls.Add(this.Tab_Control_Main);
			this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
			this.MinimumSize = new System.Drawing.Size(965, 588);
			this.Name = "Form_Purchase";
			this.Text = "فاکتور خرید ";
			this.Shown += new System.EventHandler(this.Form_Purchase_Shown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_Purchase_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
			this.Tab_Control_Main.ResumeLayout(false);
			this.uiTabPage12.ResumeLayout(false);
			this.uiTabPage12.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.mS_Tool_Strip1.ResumeLayout(false);
			this.mS_Tool_Strip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
			this.uiGroupBox2.ResumeLayout(false);
			this.uiGroupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NzGrid)).EndInit();
			this.uiTabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
			this.uiGroupBox1.ResumeLayout(false);
			this.uiGroupBox1.PerformLayout();
			this.uiTabPage1.ResumeLayout(false);
			this.uiTabPage1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
        private MS_Control.Controls.MS_GridX NzGrid;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private System.Windows.Forms.Label NzCustomerLable;
        private MS_Control.Controls.MS_NumericTextBox NzSerial;
        private MS_Control.Controls.MS_TextBox NzDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private NZ.General.WinForms.Component.NzPeople NzCustomer;
        private MS_Control.Controls.MS_Tool_Strip mS_Tool_Strip1;
        private MS_Control.Tarikh.MS_Tarikh_TextBox NzDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripSplitButton NzPrint;
        private System.Windows.Forms.ToolStripMenuItem NzPrintA4;
        private System.Windows.Forms.ToolStripMenuItem NzPrintA5;
        private System.Windows.Forms.ToolStripMenuItem NzPosPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton NzSave;
        private System.Windows.Forms.ToolStripButton NzPayment;
        private System.Windows.Forms.ToolStripButton NzNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private MS_Control.Controls.MS_Decimal_Label NzSumFactor;
        private MS_Control.Controls.MS_Decimal_Label NzSumRows;
        private MS_Control.Controls.MS_Decimal_Label NzTaxPrice;
        private MS_Control.Controls.MS_Decimal_Label mS_Decimal_Label1;
        private MS_Control.Controls.MS_NumericTextBox NzTaxPercent;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex14;
        private MS_Control.Controls.MS_NumericTextBox NzOffPercent;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex7;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex6;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex5;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex4;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex1;
        private MS_Control.Controls.MS_NumericTextBox NzOffPrice;
        private System.Windows.Forms.Panel panel1;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex2;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex9;
        private MS_Control.Controls.MS_Lable_Ex NzlblCheque;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex11;
        private MS_Control.Controls.MS_Decimal_Label NzRemain;
        private MS_Control.Controls.MS_Lable_Ex NzSumPayment;
        private MS_Control.Controls.MS_Decimal_Label NzSumMoney;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex13;
        private MS_Control.Controls.MS_Decimal_Label NzSumCash;
        private MS_Control.Controls.MS_Decimal_Label NzSumPos;
        private MS_Control.Controls.MS_Decimal_Label NzSumCheque;
        private System.Windows.Forms.Label label4;
        private Component.NzObjectPopup nzObjectPopup1;
        private NzRemainCustomer NzCustomerRemain;
        private System.Windows.Forms.Label label5;
        private MS_Control.Controls.MS_Notify mS_Notify1;
        private System.Windows.Forms.Label label6;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex3;
        private MS_Control.Controls.MS_NumericTextBox NzExtend;
        private MS_Control.Controls.MS_ComboBox_Janus NzKindSale;
        private System.Windows.Forms.Label NzKindSaleLbl;
        private Component.NzLocationEx NzLocation;
        private System.Windows.Forms.Label NzLableLocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem NzPeopleRemaind;
		private NzStorage NzAnbar;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton NsKardex;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
		private NzFactors NzfactorMabna;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label16;
		private MS_Control.Tarikh.MS_Tarikh_TextBox NsMohlatTasvieh;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private MS_Control.Controls.MS_TextBox NsTitleGirande;
		private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
		private MS_Control.Controls.MS_TextBox NsAddressGirande;
		private MS_Control.Controls.MS_CheckBox NzNoRemainEffect;
		private MS_Control.Controls.MS_CheckBox NsSendToGirande;
		private System.Windows.Forms.Label label19;
		private MS_Control.Controls.MS_TextBox NsMobileGirande;
		private System.Windows.Forms.Label label20;
	}
}