namespace Nz.Aqsat.Winforms.App
{
    partial class Form_TasviehAqsat
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TasviehAqsat));
			this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.NsSarResid = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.NsMablaqAqsat = new MS_Control.Controls.MS_NumericTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.NsDirKard = new MS_Control.Controls.MS_CheckBox();
			this.NsGroupDirkard = new Janus.Windows.EditControls.UIGroupBox();
			this.NsAmountOfPast = new MS_Control.Controls.MS_NumericTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.NsDaysPast = new MS_Control.Controls.MS_NumericTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.NsAmount = new MS_Control.Controls.MS_NumericTextBox();
			this.NsPercentAmount = new MS_Control.Controls.MS_NumericTextBox();
			this.NsPercent = new MS_Control.Controls.MS_RadioBox();
			this.mS_Text_Simple1 = new MS_Control.Controls.MS_Text_Simple();
			this.mS_Text_Simple3 = new MS_Control.Controls.MS_Text_Simple();
			this.mS_Text_Simple2 = new MS_Control.Controls.MS_Text_Simple();
			this.NsFixAmount = new MS_Control.Controls.MS_RadioBox();
			this.mS_Text_Simple4 = new MS_Control.Controls.MS_Text_Simple();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.NzTarikh = new MS_Control.Tarikh.MS_Tarikh_TextBox();
			this.NsSharh = new MS_Control.Controls.MS_TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Panel_Foother = new MS_Control.Controls.MS_Panel();
			this.NsDeleteTasvieh = new MS_Control.Controls.MS_Button_GridX();
			this.NsSave = new MS_Control.Controls.MS_Button_GridX();
			this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
			this.NsMablaqDaryafti = new MS_Control.Controls.MS_NumericTextBox();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
			this.uiGroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NsGroupDirkard)).BeginInit();
			this.NsGroupDirkard.SuspendLayout();
			this.Panel_Foother.SuspendLayout();
			this.SuspendLayout();
			// 
			// uiGroupBox2
			// 
			this.uiGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uiGroupBox2.BackColor = System.Drawing.Color.Transparent;
			this.uiGroupBox2.BorderColor = System.Drawing.Color.LightBlue;
			this.uiGroupBox2.Controls.Add(this.NsMablaqDaryafti);
			this.uiGroupBox2.Controls.Add(this.label12);
			this.uiGroupBox2.Controls.Add(this.NsSarResid);
			this.uiGroupBox2.Controls.Add(this.label10);
			this.uiGroupBox2.Controls.Add(this.label9);
			this.uiGroupBox2.Controls.Add(this.NsDirKard);
			this.uiGroupBox2.Controls.Add(this.NsGroupDirkard);
			this.uiGroupBox2.Controls.Add(this.NzTarikh);
			this.uiGroupBox2.Controls.Add(this.NsSharh);
			this.uiGroupBox2.Controls.Add(this.label1);
			this.uiGroupBox2.Controls.Add(this.label2);
			this.uiGroupBox2.Location = new System.Drawing.Point(8, 2);
			this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.uiGroupBox2.Name = "uiGroupBox2";
			this.uiGroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uiGroupBox2.Size = new System.Drawing.Size(817, 374);
			this.uiGroupBox2.TabIndex = 0;
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.AutoSize = true;
			this.label12.ForeColor = System.Drawing.Color.Green;
			this.label12.Location = new System.Drawing.Point(53, 329);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(670, 23);
			this.label12.TabIndex = 850;
			this.label12.Text = "در صورت تغییر مبلغ اقساط و ثبت تغییرات امکان برگشت به مبلغ اولیه وحود ندارد و بای" +
    "د برگه اصلی یا سایر اقساط را مشاهده کنید";
			// 
			// NsSarResid
			// 
			this.NsSarResid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsSarResid.BackColor = System.Drawing.Color.Transparent;
			this.NsSarResid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.NsSarResid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.NsSarResid.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NsSarResid.ForeColor = System.Drawing.Color.Blue;
			this.NsSarResid.Location = new System.Drawing.Point(596, 14);
			this.NsSarResid.Name = "NsSarResid";
			this.NsSarResid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsSarResid.Size = new System.Drawing.Size(123, 29);
			this.NsSarResid.TabIndex = 849;
			this.NsSarResid.Text = "...";
			this.NsSarResid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label10.Location = new System.Drawing.Point(725, 17);
			this.label10.Name = "label10";
			this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label10.Size = new System.Drawing.Size(92, 23);
			this.label10.TabIndex = 849;
			this.label10.Text = "تاریخ سر رسید :";
			// 
			// NsMablaqAqsat
			// 
			this.NsMablaqAqsat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsMablaqAqsat.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsMablaqAqsat.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsMablaqAqsat.Location = new System.Drawing.Point(585, 47);
			this.NsMablaqAqsat.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsMablaqAqsat.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsMablaqAqsat.MS_Change_Border_Color_On_Enter = true;
			this.NsMablaqAqsat.MS_Change_Color_On_Enter = true;
			this.NsMablaqAqsat.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.NsMablaqAqsat.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsMablaqAqsat.MS_Exit_By_Down = true;
			this.NsMablaqAqsat.MS_Exit_By_Enter = true;
			this.NsMablaqAqsat.MS_Exit_By_Up = true;
			this.NsMablaqAqsat.MS_Is_Negative = false;
			this.NsMablaqAqsat.MS_Last_Control = null;
			this.NsMablaqAqsat.MS_Next_Control = null;
			this.NsMablaqAqsat.Name = "NsMablaqAqsat";
			this.NsMablaqAqsat.Size = new System.Drawing.Size(117, 30);
			this.NsMablaqAqsat.TabIndex = 0;
			this.NsMablaqAqsat.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
			this.NsMablaqAqsat.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NsMablaqAqsat.TextChanged += new System.EventHandler(this.NsMablaqAqsat_TextChanged);
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label9.Location = new System.Drawing.Point(725, 254);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(82, 23);
			this.label9.TabIndex = 848;
			this.label9.Text = "مبلغ دریافتی :";
			// 
			// NsDirKard
			// 
			this.NsDirKard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsDirKard.BackColor = System.Drawing.Color.Transparent;
			this.NsDirKard.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsDirKard.Location = new System.Drawing.Point(626, 100);
			this.NsDirKard.MS_BorderColor = System.Drawing.Color.LightBlue;
			this.NsDirKard.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsDirKard.MS_Change_Border_Color_On_Enter = true;
			this.NsDirKard.MS_Change_Color_On_Checked = true;
			this.NsDirKard.MS_Change_Color_On_Enter = true;
			this.NsDirKard.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsDirKard.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsDirKard.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsDirKard.MS_Exit_By_Down = true;
			this.NsDirKard.MS_Exit_By_Enter = true;
			this.NsDirKard.MS_Exit_By_Up = true;
			this.NsDirKard.MS_Last_Control = null;
			this.NsDirKard.MS_Next_Control = null;
			this.NsDirKard.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.NsDirKard.Name = "NsDirKard";
			this.NsDirKard.Padding = new System.Windows.Forms.Padding(5);
			this.NsDirKard.ShowFocusRectangle = false;
			this.NsDirKard.Size = new System.Drawing.Size(150, 26);
			this.NsDirKard.TabIndex = 1;
			this.NsDirKard.Text = "  محاسبه دیر کرد اقساط";
			this.NsDirKard.UseCompatibleTextRendering = false;
			this.NsDirKard.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.NsDirKard.CheckedChanged += new System.EventHandler(this.NsMablaqAqsat_TextChanged);
			// 
			// NsGroupDirkard
			// 
			this.NsGroupDirkard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsGroupDirkard.BackColor = System.Drawing.Color.Transparent;
			this.NsGroupDirkard.BorderColor = System.Drawing.Color.LightBlue;
			this.NsGroupDirkard.Controls.Add(this.NsAmountOfPast);
			this.NsGroupDirkard.Controls.Add(this.label8);
			this.NsGroupDirkard.Controls.Add(this.NsDaysPast);
			this.NsGroupDirkard.Controls.Add(this.label6);
			this.NsGroupDirkard.Controls.Add(this.NsMablaqAqsat);
			this.NsGroupDirkard.Controls.Add(this.NsAmount);
			this.NsGroupDirkard.Controls.Add(this.NsPercentAmount);
			this.NsGroupDirkard.Controls.Add(this.NsPercent);
			this.NsGroupDirkard.Controls.Add(this.mS_Text_Simple1);
			this.NsGroupDirkard.Controls.Add(this.mS_Text_Simple3);
			this.NsGroupDirkard.Controls.Add(this.mS_Text_Simple2);
			this.NsGroupDirkard.Controls.Add(this.NsFixAmount);
			this.NsGroupDirkard.Controls.Add(this.mS_Text_Simple4);
			this.NsGroupDirkard.Controls.Add(this.label3);
			this.NsGroupDirkard.Controls.Add(this.label5);
			this.NsGroupDirkard.Controls.Add(this.label7);
			this.NsGroupDirkard.Controls.Add(this.label4);
			this.NsGroupDirkard.Enabled = false;
			this.NsGroupDirkard.Location = new System.Drawing.Point(6, 107);
			this.NsGroupDirkard.Margin = new System.Windows.Forms.Padding(2);
			this.NsGroupDirkard.Name = "NsGroupDirkard";
			this.NsGroupDirkard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsGroupDirkard.Size = new System.Drawing.Size(806, 126);
			this.NsGroupDirkard.TabIndex = 2;
			// 
			// NsAmountOfPast
			// 
			this.NsAmountOfPast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsAmountOfPast.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsAmountOfPast.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsAmountOfPast.Location = new System.Drawing.Point(9, 62);
			this.NsAmountOfPast.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsAmountOfPast.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsAmountOfPast.MS_Change_Border_Color_On_Enter = true;
			this.NsAmountOfPast.MS_Change_Color_On_Enter = true;
			this.NsAmountOfPast.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.NsAmountOfPast.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsAmountOfPast.MS_Exit_By_Down = true;
			this.NsAmountOfPast.MS_Exit_By_Enter = true;
			this.NsAmountOfPast.MS_Exit_By_Up = true;
			this.NsAmountOfPast.MS_Is_Negative = false;
			this.NsAmountOfPast.MS_Last_Control = null;
			this.NsAmountOfPast.MS_Next_Control = null;
			this.NsAmountOfPast.Name = "NsAmountOfPast";
			this.NsAmountOfPast.Size = new System.Drawing.Size(117, 30);
			this.NsAmountOfPast.TabIndex = 5;
			this.NsAmountOfPast.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
			this.NsAmountOfPast.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(32, 37);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 23);
			this.label8.TabIndex = 846;
			this.label8.Text = "مبلغ دیرکرد";
			// 
			// NsDaysPast
			// 
			this.NsDaysPast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsDaysPast.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsDaysPast.DigitGroup = false;
			this.NsDaysPast.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsDaysPast.Location = new System.Drawing.Point(193, 62);
			this.NsDaysPast.MaxLength = 2;
			this.NsDaysPast.Mode = MS_Control.Controls.MS_NumericTextBox.TextBoxMode.IntNumber;
			this.NsDaysPast.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsDaysPast.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsDaysPast.MS_Change_Border_Color_On_Enter = true;
			this.NsDaysPast.MS_Change_Color_On_Enter = true;
			this.NsDaysPast.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.NsDaysPast.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsDaysPast.MS_Exit_By_Down = true;
			this.NsDaysPast.MS_Exit_By_Enter = true;
			this.NsDaysPast.MS_Exit_By_Up = true;
			this.NsDaysPast.MS_Is_Negative = false;
			this.NsDaysPast.MS_Last_Control = null;
			this.NsDaysPast.MS_Next_Control = null;
			this.NsDaysPast.Name = "NsDaysPast";
			this.NsDaysPast.Size = new System.Drawing.Size(51, 30);
			this.NsDaysPast.TabIndex = 4;
			this.NsDaysPast.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.NsDaysPast.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NsDaysPast.TextChanged += new System.EventHandler(this.NsMablaqAqsat_TextChanged);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(166, 37);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 23);
			this.label6.TabIndex = 843;
			this.label6.Text = "تعداد روز دیر کرد";
			// 
			// NsAmount
			// 
			this.NsAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsAmount.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsAmount.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsAmount.Location = new System.Drawing.Point(306, 21);
			this.NsAmount.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsAmount.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsAmount.MS_Change_Border_Color_On_Enter = true;
			this.NsAmount.MS_Change_Color_On_Enter = true;
			this.NsAmount.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.NsAmount.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsAmount.MS_Exit_By_Down = true;
			this.NsAmount.MS_Exit_By_Enter = true;
			this.NsAmount.MS_Exit_By_Up = true;
			this.NsAmount.MS_Is_Negative = false;
			this.NsAmount.MS_Last_Control = null;
			this.NsAmount.MS_Next_Control = null;
			this.NsAmount.Name = "NsAmount";
			this.NsAmount.Size = new System.Drawing.Size(87, 30);
			this.NsAmount.TabIndex = 3;
			this.NsAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
			this.NsAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NsAmount.TextChanged += new System.EventHandler(this.NsMablaqAqsat_TextChanged);
			// 
			// NsPercentAmount
			// 
			this.NsPercentAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsPercentAmount.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsPercentAmount.DigitGroup = false;
			this.NsPercentAmount.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsPercentAmount.Location = new System.Drawing.Point(349, 76);
			this.NsPercentAmount.MaxLength = 2;
			this.NsPercentAmount.Mode = MS_Control.Controls.MS_NumericTextBox.TextBoxMode.IntNumber;
			this.NsPercentAmount.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsPercentAmount.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsPercentAmount.MS_Change_Border_Color_On_Enter = true;
			this.NsPercentAmount.MS_Change_Color_On_Enter = true;
			this.NsPercentAmount.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.NsPercentAmount.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsPercentAmount.MS_Exit_By_Down = true;
			this.NsPercentAmount.MS_Exit_By_Enter = true;
			this.NsPercentAmount.MS_Exit_By_Up = true;
			this.NsPercentAmount.MS_Is_Negative = false;
			this.NsPercentAmount.MS_Last_Control = null;
			this.NsPercentAmount.MS_Next_Control = null;
			this.NsPercentAmount.Name = "NsPercentAmount";
			this.NsPercentAmount.Size = new System.Drawing.Size(43, 30);
			this.NsPercentAmount.TabIndex = 3;
			this.NsPercentAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.NsPercentAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NsPercentAmount.TextChanged += new System.EventHandler(this.NsMablaqAqsat_TextChanged);
			// 
			// NsPercent
			// 
			this.NsPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsPercent.Checked = true;
			this.NsPercent.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsPercent.Location = new System.Drawing.Point(410, 80);
			this.NsPercent.MS_BorderColor = System.Drawing.Color.Empty;
			this.NsPercent.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsPercent.MS_Change_Border_Color_On_Enter = true;
			this.NsPercent.MS_Change_Color_On_Checked = true;
			this.NsPercent.MS_Change_Color_On_Enter = true;
			this.NsPercent.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsPercent.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsPercent.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsPercent.MS_Exit_By_Down = true;
			this.NsPercent.MS_Exit_By_Enter = true;
			this.NsPercent.MS_Exit_By_Up = true;
			this.NsPercent.MS_Last_Control = null;
			this.NsPercent.MS_Next_Control = null;
			this.NsPercent.MS_UnChecked_Color = System.Drawing.Color.Empty;
			this.NsPercent.Name = "NsPercent";
			this.NsPercent.ShowFocusRectangle = false;
			this.NsPercent.Size = new System.Drawing.Size(139, 23);
			this.NsPercent.TabIndex = 2;
			this.NsPercent.TabStop = true;
			this.NsPercent.Text = "  درصدی از مبلغ اقساط";
			// 
			// mS_Text_Simple1
			// 
			this.mS_Text_Simple1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Text_Simple1.BackColor = System.Drawing.Color.LimeGreen;
			this.mS_Text_Simple1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mS_Text_Simple1.Location = new System.Drawing.Point(555, 90);
			this.mS_Text_Simple1.MS_BorderColor = System.Drawing.Color.Empty;
			this.mS_Text_Simple1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
			this.mS_Text_Simple1.MS_Change_Border_Color_On_Enter = false;
			this.mS_Text_Simple1.MS_Change_Color_On_Enter = false;
			this.mS_Text_Simple1.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.mS_Text_Simple1.MS_Enter_Color = System.Drawing.Color.Empty;
			this.mS_Text_Simple1.MS_Exit_By_Down = false;
			this.mS_Text_Simple1.MS_Exit_By_Enter = false;
			this.mS_Text_Simple1.MS_Exit_By_Up = false;
			this.mS_Text_Simple1.MS_Last_Control = null;
			this.mS_Text_Simple1.MS_Next_Control = null;
			this.mS_Text_Simple1.Multiline = true;
			this.mS_Text_Simple1.Name = "mS_Text_Simple1";
			this.mS_Text_Simple1.Size = new System.Drawing.Size(12, 2);
			this.mS_Text_Simple1.TabIndex = 837;
			// 
			// mS_Text_Simple3
			// 
			this.mS_Text_Simple3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Text_Simple3.BackColor = System.Drawing.Color.LimeGreen;
			this.mS_Text_Simple3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mS_Text_Simple3.Location = new System.Drawing.Point(566, 60);
			this.mS_Text_Simple3.MS_BorderColor = System.Drawing.Color.Empty;
			this.mS_Text_Simple3.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
			this.mS_Text_Simple3.MS_Change_Border_Color_On_Enter = false;
			this.mS_Text_Simple3.MS_Change_Color_On_Enter = false;
			this.mS_Text_Simple3.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.mS_Text_Simple3.MS_Enter_Color = System.Drawing.Color.Empty;
			this.mS_Text_Simple3.MS_Exit_By_Down = false;
			this.mS_Text_Simple3.MS_Exit_By_Enter = false;
			this.mS_Text_Simple3.MS_Exit_By_Up = false;
			this.mS_Text_Simple3.MS_Last_Control = null;
			this.mS_Text_Simple3.MS_Next_Control = null;
			this.mS_Text_Simple3.Multiline = true;
			this.mS_Text_Simple3.Name = "mS_Text_Simple3";
			this.mS_Text_Simple3.Size = new System.Drawing.Size(16, 2);
			this.mS_Text_Simple3.TabIndex = 834;
			// 
			// mS_Text_Simple2
			// 
			this.mS_Text_Simple2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Text_Simple2.BackColor = System.Drawing.Color.LimeGreen;
			this.mS_Text_Simple2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mS_Text_Simple2.Location = new System.Drawing.Point(566, 32);
			this.mS_Text_Simple2.MS_BorderColor = System.Drawing.Color.Empty;
			this.mS_Text_Simple2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
			this.mS_Text_Simple2.MS_Change_Border_Color_On_Enter = false;
			this.mS_Text_Simple2.MS_Change_Color_On_Enter = false;
			this.mS_Text_Simple2.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.mS_Text_Simple2.MS_Enter_Color = System.Drawing.Color.Empty;
			this.mS_Text_Simple2.MS_Exit_By_Down = false;
			this.mS_Text_Simple2.MS_Exit_By_Enter = false;
			this.mS_Text_Simple2.MS_Exit_By_Up = false;
			this.mS_Text_Simple2.MS_Last_Control = null;
			this.mS_Text_Simple2.MS_Next_Control = null;
			this.mS_Text_Simple2.Multiline = true;
			this.mS_Text_Simple2.Name = "mS_Text_Simple2";
			this.mS_Text_Simple2.Size = new System.Drawing.Size(2, 60);
			this.mS_Text_Simple2.TabIndex = 835;
			// 
			// NsFixAmount
			// 
			this.NsFixAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsFixAmount.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsFixAmount.Location = new System.Drawing.Point(383, 22);
			this.NsFixAmount.MS_BorderColor = System.Drawing.Color.Empty;
			this.NsFixAmount.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsFixAmount.MS_Change_Border_Color_On_Enter = true;
			this.NsFixAmount.MS_Change_Color_On_Checked = true;
			this.NsFixAmount.MS_Change_Color_On_Enter = true;
			this.NsFixAmount.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsFixAmount.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsFixAmount.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsFixAmount.MS_Exit_By_Down = true;
			this.NsFixAmount.MS_Exit_By_Enter = true;
			this.NsFixAmount.MS_Exit_By_Up = true;
			this.NsFixAmount.MS_Last_Control = null;
			this.NsFixAmount.MS_Next_Control = null;
			this.NsFixAmount.MS_UnChecked_Color = System.Drawing.Color.Empty;
			this.NsFixAmount.Name = "NsFixAmount";
			this.NsFixAmount.ShowFocusRectangle = false;
			this.NsFixAmount.Size = new System.Drawing.Size(166, 23);
			this.NsFixAmount.TabIndex = 1;
			this.NsFixAmount.Text = "  مبلغ ثابت به ازای هر روز";
			this.NsFixAmount.CheckedChanged += new System.EventHandler(this.NsMablaqAqsat_TextChanged);
			// 
			// mS_Text_Simple4
			// 
			this.mS_Text_Simple4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Text_Simple4.BackColor = System.Drawing.Color.LimeGreen;
			this.mS_Text_Simple4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mS_Text_Simple4.Location = new System.Drawing.Point(555, 32);
			this.mS_Text_Simple4.MS_BorderColor = System.Drawing.Color.Empty;
			this.mS_Text_Simple4.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
			this.mS_Text_Simple4.MS_Change_Border_Color_On_Enter = false;
			this.mS_Text_Simple4.MS_Change_Color_On_Enter = false;
			this.mS_Text_Simple4.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.mS_Text_Simple4.MS_Enter_Color = System.Drawing.Color.Empty;
			this.mS_Text_Simple4.MS_Exit_By_Down = false;
			this.mS_Text_Simple4.MS_Exit_By_Enter = false;
			this.mS_Text_Simple4.MS_Exit_By_Up = false;
			this.mS_Text_Simple4.MS_Last_Control = null;
			this.mS_Text_Simple4.MS_Next_Control = null;
			this.mS_Text_Simple4.Multiline = true;
			this.mS_Text_Simple4.Name = "mS_Text_Simple4";
			this.mS_Text_Simple4.Size = new System.Drawing.Size(12, 2);
			this.mS_Text_Simple4.TabIndex = 838;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(392, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(20, 23);
			this.label3.TabIndex = 841;
			this.label3.Text = "%";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("IRANSans(Small) Medium", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label5.Location = new System.Drawing.Point(250, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 86);
			this.label5.TabIndex = 842;
			this.label5.Text = "˟";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("IRANSans(Small) Medium", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label7.Location = new System.Drawing.Point(126, 30);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 86);
			this.label7.TabIndex = 845;
			this.label7.Text = "=";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(704, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 23);
			this.label4.TabIndex = 836;
			this.label4.Text = "مبلغ اقسط :";
			// 
			// NzTarikh
			// 
			this.NzTarikh.AllowInternalTab = false;
			this.NzTarikh.AllowResizeDropDown = false;
			this.NzTarikh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzTarikh.AutoHeight = false;
			this.NzTarikh.BackColor = System.Drawing.Color.White;
			this.NzTarikh.ControlSize = new System.Drawing.Size(0, 0);
			this.NzTarikh.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.NzTarikh.DropSize = new System.Drawing.Size(0, 0);
			this.NzTarikh.Font = new System.Drawing.Font("IRANSans(Small)", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzTarikh.Location = new System.Drawing.Point(596, 52);
			this.NzTarikh.MinimumSize = new System.Drawing.Size(107, 29);
			this.NzTarikh.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzTarikh.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzTarikh.MS_Change_Border_Color_On_Enter = true;
			this.NzTarikh.MS_Change_Color_On_Enter = true;
			this.NzTarikh.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzTarikh.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzTarikh.MS_Exit_By_Down = true;
			this.NzTarikh.MS_Exit_By_Enter = true;
			this.NzTarikh.MS_Exit_By_Up = true;
			this.NzTarikh.MS_Last_Control = null;
			this.NzTarikh.MS_Next_Control = null;
			this.NzTarikh.MS_Separation = '/';
			this.NzTarikh.MS_Tarikh = null;
			this.NzTarikh.Name = "NzTarikh";
			this.NzTarikh.ReadOnly = false;
			this.NzTarikh.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.NzTarikh.Size = new System.Drawing.Size(123, 29);
			this.NzTarikh.TabIndex = 0;
			this.NzTarikh.Text = "//";
			this.NzTarikh.TextChanged += new System.EventHandler(this.NzTarikh_TextChanged);
			// 
			// NsSharh
			// 
			this.NsSharh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsSharh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsSharh.Location = new System.Drawing.Point(6, 285);
			this.NsSharh.MaxLength = 200;
			this.NsSharh.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsSharh.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsSharh.MS_Change_Border_Color_On_Enter = true;
			this.NsSharh.MS_Change_Color_On_Enter = true;
			this.NsSharh.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsSharh.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsSharh.MS_Exit_By_Down = true;
			this.NsSharh.MS_Exit_By_Enter = true;
			this.NsSharh.MS_Exit_By_Up = true;
			this.NsSharh.MS_Last_Control = null;
			this.NsSharh.MS_Next_Control = null;
			this.NsSharh.Name = "NsSharh";
			this.NsSharh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsSharh.Size = new System.Drawing.Size(713, 29);
			this.NsSharh.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label1.Location = new System.Drawing.Point(725, 288);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(73, 23);
			this.label1.TabIndex = 162;
			this.label1.Text = "توضیـحات :";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label2.Location = new System.Drawing.Point(725, 55);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.Size = new System.Drawing.Size(81, 23);
			this.label2.TabIndex = 162;
			this.label2.Text = "تاریخ تسویه :";
			// 
			// Panel_Foother
			// 
			this.Panel_Foother.Controls.Add(this.NsDeleteTasvieh);
			this.Panel_Foother.Controls.Add(this.NsSave);
			this.Panel_Foother.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Panel_Foother.Location = new System.Drawing.Point(0, 386);
			this.Panel_Foother.MS_BorderColor = System.Drawing.Color.DarkGray;
			this.Panel_Foother.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.Panel_Foother.MS_Color_End = System.Drawing.Color.Gainsboro;
			this.Panel_Foother.MS_Color_Start = System.Drawing.Color.WhiteSmoke;
			this.Panel_Foother.Name = "Panel_Foother";
			this.Panel_Foother.Size = new System.Drawing.Size(833, 44);
			this.Panel_Foother.TabIndex = 5;
			// 
			// NsDeleteTasvieh
			// 
			this.NsDeleteTasvieh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsDeleteTasvieh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsDeleteTasvieh.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsDeleteTasvieh.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsDeleteTasvieh.Image = global::MS_Resource.GlobalResources.Negin__1_;
			this.NsDeleteTasvieh.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NsDeleteTasvieh.Location = new System.Drawing.Point(620, 7);
			this.NsDeleteTasvieh.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsDeleteTasvieh.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsDeleteTasvieh.MS_Change_Border_Color_On_Enter = false;
			this.NsDeleteTasvieh.MS_Change_Color_On_Enter = false;
			this.NsDeleteTasvieh.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NsDeleteTasvieh.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NsDeleteTasvieh.Name = "NsDeleteTasvieh";
			this.NsDeleteTasvieh.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NsDeleteTasvieh.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.NsDeleteTasvieh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsDeleteTasvieh.ShowFocusRectangle = false;
			this.NsDeleteTasvieh.Size = new System.Drawing.Size(202, 30);
			this.NsDeleteTasvieh.TabIndex = 1;
			this.NsDeleteTasvieh.Text = "حدف کامل اطلاعات تسویه";
			this.NsDeleteTasvieh.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.NsDeleteTasvieh.UseThemes = false;
			this.NsDeleteTasvieh.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NsDeleteTasvieh.WordWrap = false;
			this.NsDeleteTasvieh.Click += new System.EventHandler(this.NsDeleteTasvieh_Click);
			// 
			// NsSave
			// 
			this.NsSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsSave.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsSave.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsSave.Image = ((System.Drawing.Image)(resources.GetObject("NsSave.Image")));
			this.NsSave.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NsSave.Location = new System.Drawing.Point(8, 7);
			this.NsSave.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsSave.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsSave.MS_Change_Border_Color_On_Enter = false;
			this.NsSave.MS_Change_Color_On_Enter = false;
			this.NsSave.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NsSave.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NsSave.Name = "NsSave";
			this.NsSave.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NsSave.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NsSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsSave.ShowFocusRectangle = false;
			this.NsSave.Size = new System.Drawing.Size(110, 30);
			this.NsSave.TabIndex = 0;
			this.NsSave.Text = "ثـبــت   [F2]";
			this.NsSave.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.NsSave.UseThemes = false;
			this.NsSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NsSave.WordWrap = false;
			this.NsSave.Click += new System.EventHandler(this.NsSave_Click);
			// 
			// NsMablaqDaryafti
			// 
			this.NsMablaqDaryafti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsMablaqDaryafti.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsMablaqDaryafti.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsMablaqDaryafti.Location = new System.Drawing.Point(602, 250);
			this.NsMablaqDaryafti.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsMablaqDaryafti.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsMablaqDaryafti.MS_Change_Border_Color_On_Enter = true;
			this.NsMablaqDaryafti.MS_Change_Color_On_Enter = true;
			this.NsMablaqDaryafti.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.NsMablaqDaryafti.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsMablaqDaryafti.MS_Exit_By_Down = true;
			this.NsMablaqDaryafti.MS_Exit_By_Enter = true;
			this.NsMablaqDaryafti.MS_Exit_By_Up = true;
			this.NsMablaqDaryafti.MS_Is_Negative = false;
			this.NsMablaqDaryafti.MS_Last_Control = null;
			this.NsMablaqDaryafti.MS_Next_Control = null;
			this.NsMablaqDaryafti.Name = "NsMablaqDaryafti";
			this.NsMablaqDaryafti.Size = new System.Drawing.Size(117, 30);
			this.NsMablaqDaryafti.TabIndex = 847;
			this.NsMablaqDaryafti.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
			this.NsMablaqDaryafti.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// Form_TasviehAqsat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(833, 430);
			this.Controls.Add(this.uiGroupBox2);
			this.Controls.Add(this.Panel_Foother);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form_TasviehAqsat";
			this.Text = "تسویه اقساط";
			this.Load += new System.EventHandler(this.Form_TasviehAqsat_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_TasviehAqsat_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
			this.uiGroupBox2.ResumeLayout(false);
			this.uiGroupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NsGroupDirkard)).EndInit();
			this.NsGroupDirkard.ResumeLayout(false);
			this.NsGroupDirkard.PerformLayout();
			this.Panel_Foother.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private System.Windows.Forms.Label label2;
        private MS_Control.Controls.MS_Panel Panel_Foother;
        private MS_Control.Controls.MS_Button_GridX NsSave;
        private System.Windows.Forms.Label label1;
        private MS_Control.Controls.MS_TextBox NsSharh;
        private MS_Control.Tarikh.MS_Tarikh_TextBox NzTarikh;
        private MS_Control.Controls.MS_Button_GridX NsDeleteTasvieh;
        private MS_Control.Controls.MS_Notify mS_Notify1;
        private Janus.Windows.EditControls.UIGroupBox NsGroupDirkard;
        private MS_Control.Controls.MS_RadioBox NsPercent;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple1;
        private System.Windows.Forms.Label label4;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple3;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple2;
        private MS_Control.Controls.MS_RadioBox NsFixAmount;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple4;
        private MS_Control.Controls.MS_CheckBox NsDirKard;
        private MS_Control.Controls.MS_NumericTextBox NsPercentAmount;
        private MS_Control.Controls.MS_NumericTextBox NsAmount;
        private System.Windows.Forms.Label label3;
        private MS_Control.Controls.MS_NumericTextBox NsAmountOfPast;
        private System.Windows.Forms.Label label8;
        private MS_Control.Controls.MS_NumericTextBox NsDaysPast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private MS_Control.Controls.MS_NumericTextBox NsMablaqAqsat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label NsSarResid;
        private System.Windows.Forms.Label label12;
        private MS_Control.Controls.MS_NumericTextBox NsMablaqDaryafti;
    }
}