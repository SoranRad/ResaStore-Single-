namespace NZ.Xazane.WinForms.App
{
    partial class FormBarCodePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBarCodePayment));
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.NzDeleteDp = new MS_Control.Controls.MS_Button_GridX();
            this.NzSaveSetting = new MS_Control.Controls.MS_Button_GridX();
            this.NzSavePayment = new MS_Control.Controls.MS_Button_GridX();
            this.NzGroupCache = new Janus.Windows.EditControls.UIGroupBox();
            this.NzNaqdi_Checked = new MS_Control.Controls.MS_CheckBox();
            this.mS_Lable_Ex3 = new MS_Control.Controls.MS_Lable_Ex();
            this.mS_Lable_Ex2 = new MS_Control.Controls.MS_Lable_Ex();
            this.NzCachePrice = new MS_Control.Controls.MS_NumericTextBox();
            this.NzGroupPos = new Janus.Windows.EditControls.UIGroupBox();
            this.NzPos_Checked = new MS_Control.Controls.MS_CheckBox();
            this.mS_Lable_Ex4 = new MS_Control.Controls.MS_Lable_Ex();
            this.mS_Lable_Ex5 = new MS_Control.Controls.MS_Lable_Ex();
            this.NzPosPrice = new MS_Control.Controls.MS_NumericTextBox();
            this.uiGroupBox3 = new Janus.Windows.EditControls.UIGroupBox();
            this.mS_Lable_Ex6 = new MS_Control.Controls.MS_Lable_Ex();
            this.NzFactorPrice = new MS_Control.Controls.MS_Decimal_Label();
            this.mS_Lable_Ex1 = new MS_Control.Controls.MS_Lable_Ex();
            this.NzLableCheque = new MS_Control.Controls.MS_Lable_Ex();
            this.NzRemaind = new MS_Control.Controls.MS_Decimal_Label();
            this.NzSum = new MS_Control.Controls.MS_Decimal_Label();
            this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NzPos = new NZ.Xazane.WinForms.Component.NzAccounts();
            this.NzCache = new NZ.Xazane.WinForms.Component.NzAccounts();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NzGroupCache)).BeginInit();
            this.NzGroupCache.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NzGroupPos)).BeginInit();
            this.NzGroupPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).BeginInit();
            this.uiGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox2.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.uiGroupBox2.Controls.Add(this.NzDeleteDp);
            this.uiGroupBox2.Controls.Add(this.NzSaveSetting);
            this.uiGroupBox2.Controls.Add(this.NzSavePayment);
            this.uiGroupBox2.Location = new System.Drawing.Point(6, 430);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(544, 82);
            this.uiGroupBox2.TabIndex = 3;
            // 
            // NzDeleteDp
            // 
            this.NzDeleteDp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NzDeleteDp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzDeleteDp.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzDeleteDp.Font = new System.Drawing.Font("IRANSans(Small) Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzDeleteDp.Image = ((System.Drawing.Image)(resources.GetObject("NzDeleteDp.Image")));
            this.NzDeleteDp.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzDeleteDp.ImageSize = new System.Drawing.Size(18, 18);
            this.NzDeleteDp.Location = new System.Drawing.Point(202, 13);
            this.NzDeleteDp.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzDeleteDp.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzDeleteDp.MS_Change_Border_Color_On_Enter = false;
            this.NzDeleteDp.MS_Change_Color_On_Enter = false;
            this.NzDeleteDp.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.NzDeleteDp.MS_Enter_Color = System.Drawing.Color.Empty;
            this.NzDeleteDp.Name = "NzDeleteDp";
            this.NzDeleteDp.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzDeleteDp.Office2007CustomColor = System.Drawing.Color.Orange;
            this.NzDeleteDp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzDeleteDp.ShowFocusRectangle = false;
            this.NzDeleteDp.Size = new System.Drawing.Size(141, 61);
            this.NzDeleteDp.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Red;
            this.NzDeleteDp.TabIndex = 771;
            this.NzDeleteDp.Text = "نسـیـه کامل (حذف مبالغ) [F5]";
            this.NzDeleteDp.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.NzDeleteDp.UseThemes = false;
            this.NzDeleteDp.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzDeleteDp.Click += new System.EventHandler(this.NzDeleteDp_Click);
            // 
            // NzSaveSetting
            // 
            this.NzSaveSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NzSaveSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzSaveSetting.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzSaveSetting.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzSaveSetting.Image = ((System.Drawing.Image)(resources.GetObject("NzSaveSetting.Image")));
            this.NzSaveSetting.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzSaveSetting.Location = new System.Drawing.Point(405, 13);
            this.NzSaveSetting.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzSaveSetting.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzSaveSetting.MS_Change_Border_Color_On_Enter = false;
            this.NzSaveSetting.MS_Change_Color_On_Enter = false;
            this.NzSaveSetting.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.NzSaveSetting.MS_Enter_Color = System.Drawing.Color.Empty;
            this.NzSaveSetting.Name = "NzSaveSetting";
            this.NzSaveSetting.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzSaveSetting.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.NzSaveSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzSaveSetting.ShowFocusRectangle = false;
            this.NzSaveSetting.Size = new System.Drawing.Size(132, 61);
            this.NzSaveSetting.TabIndex = 770;
            this.NzSaveSetting.TabStop = false;
            this.NzSaveSetting.Text = "ذخیره تنظیمات ";
            this.NzSaveSetting.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.NzSaveSetting.UseThemes = false;
            this.NzSaveSetting.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzSaveSetting.WordWrap = false;
            this.NzSaveSetting.Click += new System.EventHandler(this.NzSaveSetting_Click);
            // 
            // NzSavePayment
            // 
            this.NzSavePayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NzSavePayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzSavePayment.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzSavePayment.Font = new System.Drawing.Font("IRANSans(Small) Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzSavePayment.Image = ((System.Drawing.Image)(resources.GetObject("NzSavePayment.Image")));
            this.NzSavePayment.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzSavePayment.Location = new System.Drawing.Point(6, 13);
            this.NzSavePayment.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzSavePayment.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzSavePayment.MS_Change_Border_Color_On_Enter = false;
            this.NzSavePayment.MS_Change_Color_On_Enter = false;
            this.NzSavePayment.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.NzSavePayment.MS_Enter_Color = System.Drawing.Color.Empty;
            this.NzSavePayment.Name = "NzSavePayment";
            this.NzSavePayment.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzSavePayment.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.NzSavePayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzSavePayment.ShowFocusRectangle = false;
            this.NzSavePayment.Size = new System.Drawing.Size(164, 61);
            this.NzSavePayment.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Green;
            this.NzSavePayment.TabIndex = 2;
            this.NzSavePayment.Text = "ثبت تسـویه   [F2]";
            this.NzSavePayment.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.NzSavePayment.UseThemes = false;
            this.NzSavePayment.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzSavePayment.WordWrap = false;
            this.NzSavePayment.Click += new System.EventHandler(this.NzSavePayment_Click);
            // 
            // NzGroupCache
            // 
            this.NzGroupCache.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NzGroupCache.BackColor = System.Drawing.Color.Transparent;
            this.NzGroupCache.BorderColor = System.Drawing.Color.SteelBlue;
            this.NzGroupCache.Controls.Add(this.label2);
            this.NzGroupCache.Controls.Add(this.NzNaqdi_Checked);
            this.NzGroupCache.Controls.Add(this.mS_Lable_Ex3);
            this.NzGroupCache.Controls.Add(this.mS_Lable_Ex2);
            this.NzGroupCache.Controls.Add(this.NzCache);
            this.NzGroupCache.Controls.Add(this.NzCachePrice);
            this.NzGroupCache.Location = new System.Drawing.Point(5, 2);
            this.NzGroupCache.Margin = new System.Windows.Forms.Padding(2);
            this.NzGroupCache.Name = "NzGroupCache";
            this.NzGroupCache.Padding = new System.Windows.Forms.Padding(5);
            this.NzGroupCache.Size = new System.Drawing.Size(545, 122);
            this.NzGroupCache.TabIndex = 4;
            // 
            // NzNaqdi_Checked
            // 
            this.NzNaqdi_Checked.BackColor = System.Drawing.Color.Transparent;
            this.NzNaqdi_Checked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzNaqdi_Checked.Dock = System.Windows.Forms.DockStyle.Right;
            this.NzNaqdi_Checked.Font = new System.Drawing.Font("IRANSans(Small) Medium", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzNaqdi_Checked.Image = ((System.Drawing.Image)(resources.GetObject("NzNaqdi_Checked.Image")));
            this.NzNaqdi_Checked.ImageAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzNaqdi_Checked.Location = new System.Drawing.Point(389, 13);
            this.NzNaqdi_Checked.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzNaqdi_Checked.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzNaqdi_Checked.MS_Change_Border_Color_On_Enter = true;
            this.NzNaqdi_Checked.MS_Change_Color_On_Checked = true;
            this.NzNaqdi_Checked.MS_Change_Color_On_Enter = true;
            this.NzNaqdi_Checked.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzNaqdi_Checked.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzNaqdi_Checked.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzNaqdi_Checked.MS_Exit_By_Down = true;
            this.NzNaqdi_Checked.MS_Exit_By_Enter = true;
            this.NzNaqdi_Checked.MS_Exit_By_Up = true;
            this.NzNaqdi_Checked.MS_Last_Control = null;
            this.NzNaqdi_Checked.MS_Next_Control = null;
            this.NzNaqdi_Checked.MS_UnChecked_Color = System.Drawing.Color.Transparent;
            this.NzNaqdi_Checked.Name = "NzNaqdi_Checked";
            this.NzNaqdi_Checked.ShowFocusRectangle = false;
            this.NzNaqdi_Checked.Size = new System.Drawing.Size(148, 101);
            this.NzNaqdi_Checked.TabIndex = 7;
            this.NzNaqdi_Checked.Text = "   نقـدی ";
            this.NzNaqdi_Checked.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            this.NzNaqdi_Checked.CheckedChanged += new System.EventHandler(this.NzNaqdi_Checked_CheckedChanged);
            // 
            // mS_Lable_Ex3
            // 
            this.mS_Lable_Ex3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mS_Lable_Ex3.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.mS_Lable_Ex3.Location = new System.Drawing.Point(325, 67);
            this.mS_Lable_Ex3.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.mS_Lable_Ex3.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Lable_Ex3.MS_Color_End = System.Drawing.Color.Empty;
            this.mS_Lable_Ex3.MS_Color_Start = System.Drawing.Color.Empty;
            this.mS_Lable_Ex3.Name = "mS_Lable_Ex3";
            this.mS_Lable_Ex3.Size = new System.Drawing.Size(57, 41);
            this.mS_Lable_Ex3.TabIndex = 767;
            this.mS_Lable_Ex3.Text = "مبلغ :";
            this.mS_Lable_Ex3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mS_Lable_Ex2
            // 
            this.mS_Lable_Ex2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mS_Lable_Ex2.Font = new System.Drawing.Font("IRANSans(Small)", 12.75F);
            this.mS_Lable_Ex2.Location = new System.Drawing.Point(324, 19);
            this.mS_Lable_Ex2.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.mS_Lable_Ex2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Lable_Ex2.MS_Color_End = System.Drawing.Color.Empty;
            this.mS_Lable_Ex2.MS_Color_Start = System.Drawing.Color.Empty;
            this.mS_Lable_Ex2.Name = "mS_Lable_Ex2";
            this.mS_Lable_Ex2.Size = new System.Drawing.Size(57, 37);
            this.mS_Lable_Ex2.TabIndex = 767;
            this.mS_Lable_Ex2.Text = "صندوق :";
            this.mS_Lable_Ex2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NzCachePrice
            // 
            this.NzCachePrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NzCachePrice.Enabled = false;
            this.NzCachePrice.Font = new System.Drawing.Font("IRANSans(Small)", 20F);
            this.NzCachePrice.Location = new System.Drawing.Point(12, 67);
            this.NzCachePrice.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzCachePrice.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzCachePrice.MS_Change_Border_Color_On_Enter = true;
            this.NzCachePrice.MS_Change_Color_On_Enter = true;
            this.NzCachePrice.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzCachePrice.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzCachePrice.MS_Exit_By_Down = true;
            this.NzCachePrice.MS_Exit_By_Enter = true;
            this.NzCachePrice.MS_Exit_By_Up = true;
            this.NzCachePrice.MS_Is_Negative = false;
            this.NzCachePrice.MS_Last_Control = null;
            this.NzCachePrice.MS_Next_Control = null;
            this.NzCachePrice.Name = "NzCachePrice";
            this.NzCachePrice.Size = new System.Drawing.Size(314, 41);
            this.NzCachePrice.TabIndex = 1;
            this.NzCachePrice.Text = "0";
            this.NzCachePrice.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
            this.NzCachePrice.TextChanged += new System.EventHandler(this.NzCachePrice_TextChanged);
            // 
            // NzGroupPos
            // 
            this.NzGroupPos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NzGroupPos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzGroupPos.BorderColor = System.Drawing.Color.SteelBlue;
            this.NzGroupPos.Controls.Add(this.label1);
            this.NzGroupPos.Controls.Add(this.NzPos_Checked);
            this.NzGroupPos.Controls.Add(this.mS_Lable_Ex4);
            this.NzGroupPos.Controls.Add(this.mS_Lable_Ex5);
            this.NzGroupPos.Controls.Add(this.NzPos);
            this.NzGroupPos.Controls.Add(this.NzPosPrice);
            this.NzGroupPos.Location = new System.Drawing.Point(5, 133);
            this.NzGroupPos.Margin = new System.Windows.Forms.Padding(2);
            this.NzGroupPos.Name = "NzGroupPos";
            this.NzGroupPos.Padding = new System.Windows.Forms.Padding(5);
            this.NzGroupPos.Size = new System.Drawing.Size(545, 134);
            this.NzGroupPos.TabIndex = 5;
            // 
            // NzPos_Checked
            // 
            this.NzPos_Checked.BackColor = System.Drawing.Color.Transparent;
            this.NzPos_Checked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzPos_Checked.Dock = System.Windows.Forms.DockStyle.Right;
            this.NzPos_Checked.Font = new System.Drawing.Font("IRANSans(Small) Medium", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzPos_Checked.Image = ((System.Drawing.Image)(resources.GetObject("NzPos_Checked.Image")));
            this.NzPos_Checked.ImageAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzPos_Checked.ImageSize = new System.Drawing.Size(20, 28);
            this.NzPos_Checked.Location = new System.Drawing.Point(389, 13);
            this.NzPos_Checked.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzPos_Checked.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzPos_Checked.MS_Change_Border_Color_On_Enter = true;
            this.NzPos_Checked.MS_Change_Color_On_Checked = true;
            this.NzPos_Checked.MS_Change_Color_On_Enter = true;
            this.NzPos_Checked.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzPos_Checked.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzPos_Checked.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzPos_Checked.MS_Exit_By_Down = true;
            this.NzPos_Checked.MS_Exit_By_Enter = true;
            this.NzPos_Checked.MS_Exit_By_Up = true;
            this.NzPos_Checked.MS_Last_Control = null;
            this.NzPos_Checked.MS_Next_Control = null;
            this.NzPos_Checked.MS_UnChecked_Color = System.Drawing.Color.Transparent;
            this.NzPos_Checked.Name = "NzPos_Checked";
            this.NzPos_Checked.Padding = new System.Windows.Forms.Padding(5);
            this.NzPos_Checked.ShowFocusRectangle = false;
            this.NzPos_Checked.Size = new System.Drawing.Size(148, 113);
            this.NzPos_Checked.TabIndex = 774;
            this.NzPos_Checked.Text = " کارتخوان";
            this.NzPos_Checked.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            this.NzPos_Checked.CheckedChanged += new System.EventHandler(this.NzPos_Checked_CheckedChanged);
            // 
            // mS_Lable_Ex4
            // 
            this.mS_Lable_Ex4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mS_Lable_Ex4.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.mS_Lable_Ex4.Location = new System.Drawing.Point(324, 72);
            this.mS_Lable_Ex4.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.mS_Lable_Ex4.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Lable_Ex4.MS_Color_End = System.Drawing.Color.Empty;
            this.mS_Lable_Ex4.MS_Color_Start = System.Drawing.Color.Empty;
            this.mS_Lable_Ex4.Name = "mS_Lable_Ex4";
            this.mS_Lable_Ex4.Size = new System.Drawing.Size(53, 41);
            this.mS_Lable_Ex4.TabIndex = 772;
            this.mS_Lable_Ex4.Text = "مبلغ :";
            this.mS_Lable_Ex4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mS_Lable_Ex5
            // 
            this.mS_Lable_Ex5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mS_Lable_Ex5.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.mS_Lable_Ex5.Location = new System.Drawing.Point(324, 27);
            this.mS_Lable_Ex5.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.mS_Lable_Ex5.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Lable_Ex5.MS_Color_End = System.Drawing.Color.Empty;
            this.mS_Lable_Ex5.MS_Color_Start = System.Drawing.Color.Empty;
            this.mS_Lable_Ex5.Name = "mS_Lable_Ex5";
            this.mS_Lable_Ex5.Size = new System.Drawing.Size(53, 37);
            this.mS_Lable_Ex5.TabIndex = 773;
            this.mS_Lable_Ex5.Text = "حساب :";
            this.mS_Lable_Ex5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NzPosPrice
            // 
            this.NzPosPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NzPosPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzPosPrice.Enabled = false;
            this.NzPosPrice.Font = new System.Drawing.Font("IRANSans(Small)", 20F);
            this.NzPosPrice.Location = new System.Drawing.Point(12, 72);
            this.NzPosPrice.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzPosPrice.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzPosPrice.MS_Change_Border_Color_On_Enter = true;
            this.NzPosPrice.MS_Change_Color_On_Enter = true;
            this.NzPosPrice.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzPosPrice.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzPosPrice.MS_Exit_By_Down = true;
            this.NzPosPrice.MS_Exit_By_Enter = true;
            this.NzPosPrice.MS_Exit_By_Up = true;
            this.NzPosPrice.MS_Is_Negative = false;
            this.NzPosPrice.MS_Last_Control = null;
            this.NzPosPrice.MS_Next_Control = null;
            this.NzPosPrice.Name = "NzPosPrice";
            this.NzPosPrice.Size = new System.Drawing.Size(313, 41);
            this.NzPosPrice.TabIndex = 1;
            this.NzPosPrice.Text = "0";
            this.NzPosPrice.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
            this.NzPosPrice.TextChanged += new System.EventHandler(this.NzPosPrice_TextChanged);
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uiGroupBox3.BackColor = System.Drawing.Color.LightCyan;
            this.uiGroupBox3.BorderColor = System.Drawing.Color.PowderBlue;
            this.uiGroupBox3.Controls.Add(this.mS_Lable_Ex6);
            this.uiGroupBox3.Controls.Add(this.NzFactorPrice);
            this.uiGroupBox3.Controls.Add(this.mS_Lable_Ex1);
            this.uiGroupBox3.Controls.Add(this.NzLableCheque);
            this.uiGroupBox3.Controls.Add(this.NzRemaind);
            this.uiGroupBox3.Controls.Add(this.NzSum);
            this.uiGroupBox3.Location = new System.Drawing.Point(5, 271);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Size = new System.Drawing.Size(545, 158);
            this.uiGroupBox3.TabIndex = 6;
            // 
            // mS_Lable_Ex6
            // 
            this.mS_Lable_Ex6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mS_Lable_Ex6.Font = new System.Drawing.Font("IRANSans(Small)", 18F);
            this.mS_Lable_Ex6.Location = new System.Drawing.Point(272, 59);
            this.mS_Lable_Ex6.MS_BorderColor = System.Drawing.Color.CadetBlue;
            this.mS_Lable_Ex6.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Lable_Ex6.MS_Color_End = System.Drawing.Color.Empty;
            this.mS_Lable_Ex6.MS_Color_Start = System.Drawing.Color.Empty;
            this.mS_Lable_Ex6.Name = "mS_Lable_Ex6";
            this.mS_Lable_Ex6.Size = new System.Drawing.Size(106, 46);
            this.mS_Lable_Ex6.TabIndex = 768;
            this.mS_Lable_Ex6.Text = "مبلغ فاکتور :";
            this.mS_Lable_Ex6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NzFactorPrice
            // 
            this.NzFactorPrice.BackColor = System.Drawing.Color.LightCyan;
            this.NzFactorPrice.Font = new System.Drawing.Font("IRANSans(Small)", 22F);
            this.NzFactorPrice.Location = new System.Drawing.Point(7, 59);
            this.NzFactorPrice.MS_BorderColor = System.Drawing.Color.CadetBlue;
            this.NzFactorPrice.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzFactorPrice.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NzFactorPrice.MS_Format_String = "0,0.##;(0,0.##); ";
            this.NzFactorPrice.Name = "NzFactorPrice";
            this.NzFactorPrice.Size = new System.Drawing.Size(266, 46);
            this.NzFactorPrice.TabIndex = 769;
            this.NzFactorPrice.Text = " ";
            this.NzFactorPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mS_Lable_Ex1
            // 
            this.mS_Lable_Ex1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mS_Lable_Ex1.Font = new System.Drawing.Font("IRANSans(Small)", 18F);
            this.mS_Lable_Ex1.Location = new System.Drawing.Point(272, 104);
            this.mS_Lable_Ex1.MS_BorderColor = System.Drawing.Color.CadetBlue;
            this.mS_Lable_Ex1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Lable_Ex1.MS_Color_End = System.Drawing.Color.Empty;
            this.mS_Lable_Ex1.MS_Color_Start = System.Drawing.Color.Empty;
            this.mS_Lable_Ex1.Name = "mS_Lable_Ex1";
            this.mS_Lable_Ex1.Size = new System.Drawing.Size(106, 46);
            this.mS_Lable_Ex1.TabIndex = 762;
            this.mS_Lable_Ex1.Text = "مانده :";
            this.mS_Lable_Ex1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NzLableCheque
            // 
            this.NzLableCheque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzLableCheque.Font = new System.Drawing.Font("IRANSans(Small)", 18F);
            this.NzLableCheque.Location = new System.Drawing.Point(272, 14);
            this.NzLableCheque.MS_BorderColor = System.Drawing.Color.CadetBlue;
            this.NzLableCheque.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzLableCheque.MS_Color_End = System.Drawing.Color.Empty;
            this.NzLableCheque.MS_Color_Start = System.Drawing.Color.Empty;
            this.NzLableCheque.Name = "NzLableCheque";
            this.NzLableCheque.Size = new System.Drawing.Size(106, 46);
            this.NzLableCheque.TabIndex = 762;
            this.NzLableCheque.Text = "مجموع :";
            this.NzLableCheque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NzRemaind
            // 
            this.NzRemaind.BackColor = System.Drawing.Color.LightCyan;
            this.NzRemaind.Font = new System.Drawing.Font("IRANSans(Small)", 22F);
            this.NzRemaind.Location = new System.Drawing.Point(7, 104);
            this.NzRemaind.MS_BorderColor = System.Drawing.Color.CadetBlue;
            this.NzRemaind.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzRemaind.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NzRemaind.MS_Format_String = "0,0.##;(0,0.##); ";
            this.NzRemaind.Name = "NzRemaind";
            this.NzRemaind.Size = new System.Drawing.Size(266, 46);
            this.NzRemaind.TabIndex = 767;
            this.NzRemaind.Text = " ";
            this.NzRemaind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NzSum
            // 
            this.NzSum.BackColor = System.Drawing.Color.LightCyan;
            this.NzSum.Font = new System.Drawing.Font("IRANSans(Small)", 22F);
            this.NzSum.Location = new System.Drawing.Point(7, 14);
            this.NzSum.MS_BorderColor = System.Drawing.Color.CadetBlue;
            this.NzSum.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzSum.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NzSum.MS_Format_String = "0,0.##;(0,0.##); ";
            this.NzSum.Name = "NzSum";
            this.NzSum.Size = new System.Drawing.Size(266, 46);
            this.NzSum.TabIndex = 767;
            this.NzSum.Text = " ";
            this.NzSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(447, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 775;
            this.label1.Text = "[F8]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(447, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 775;
            this.label2.Text = "[F9]";
            // 
            // NzPos
            // 
            this.NzPos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NzPos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzPos.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
            this.NzPos.DropSize = new System.Drawing.Size(313, 37);
            this.NzPos.Enabled = false;
            this.NzPos.Font = new System.Drawing.Font("IRANSans(Small)", 18F);
            this.NzPos.Location = new System.Drawing.Point(12, 27);
            this.NzPos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NzPos.MS_Auto_Popup = false;
            this.NzPos.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzPos.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzPos.MS_CaptureFocus = false;
            this.NzPos.MS_Change_Border_Color_On_Enter = true;
            this.NzPos.MS_Change_Color_On_Enter = true;
            this.NzPos.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
            this.NzPos.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
            this.NzPos.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzPos.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzPos.MS_Exit_By_Down = true;
            this.NzPos.MS_Exit_By_Enter = true;
            this.NzPos.MS_Exit_By_Up = true;
            this.NzPos.MS_Last_Control = null;
            this.NzPos.MS_Next_Control = null;
            this.NzPos.Name = "NzPos";
            this.NzPos.Office2007CustomColor = System.Drawing.Color.SkyBlue;
            this.NzPos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzPos.Size = new System.Drawing.Size(313, 37);
            this.NzPos.TabIndex = 0;
            this.NzPos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzCache
            // 
            this.NzCache.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NzCache.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
            this.NzCache.DropSize = new System.Drawing.Size(314, 37);
            this.NzCache.Enabled = false;
            this.NzCache.Font = new System.Drawing.Font("IRANSans(Small)", 18F);
            this.NzCache.Location = new System.Drawing.Point(11, 19);
            this.NzCache.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NzCache.MS_Auto_Popup = false;
            this.NzCache.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzCache.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzCache.MS_CaptureFocus = false;
            this.NzCache.MS_Change_Border_Color_On_Enter = true;
            this.NzCache.MS_Change_Color_On_Enter = true;
            this.NzCache.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
            this.NzCache.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
            this.NzCache.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzCache.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzCache.MS_Exit_By_Down = true;
            this.NzCache.MS_Exit_By_Enter = true;
            this.NzCache.MS_Exit_By_Up = true;
            this.NzCache.MS_Last_Control = null;
            this.NzCache.MS_Next_Control = null;
            this.NzCache.Name = "NzCache";
            this.NzCache.Office2007CustomColor = System.Drawing.Color.SkyBlue;
            this.NzCache.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzCache.Size = new System.Drawing.Size(314, 37);
            this.NzCache.TabIndex = 0;
            this.NzCache.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // FormBarCodePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 515);
            this.Controls.Add(this.uiGroupBox3);
            this.Controls.Add(this.NzGroupPos);
            this.Controls.Add(this.NzGroupCache);
            this.Controls.Add(this.uiGroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormBarCodePayment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Text = "تسویه فاکتور فروش";
            this.Shown += new System.EventHandler(this.FormBarCodePayment_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormBarCodePayment_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NzGroupCache)).EndInit();
            this.NzGroupCache.ResumeLayout(false);
            this.NzGroupCache.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NzGroupPos)).EndInit();
            this.NzGroupPos.ResumeLayout(false);
            this.NzGroupPos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).EndInit();
            this.uiGroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private MS_Control.Controls.MS_Button_GridX NzSaveSetting;
        private MS_Control.Controls.MS_Button_GridX NzSavePayment;
        private MS_Control.Controls.MS_Button_GridX NzDeleteDp;
        private Janus.Windows.EditControls.UIGroupBox NzGroupCache;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex3;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex2;
        private Component.NzAccounts NzCache;
        private MS_Control.Controls.MS_NumericTextBox NzCachePrice;
        private MS_Control.Controls.MS_CheckBox NzNaqdi_Checked;
        private Janus.Windows.EditControls.UIGroupBox NzGroupPos;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex4;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex5;
        private Component.NzAccounts NzPos;
        private MS_Control.Controls.MS_NumericTextBox NzPosPrice;
        private MS_Control.Controls.MS_CheckBox NzPos_Checked;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox3;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex1;
        private MS_Control.Controls.MS_Lable_Ex NzLableCheque;
        private MS_Control.Controls.MS_Decimal_Label NzRemaind;
        private MS_Control.Controls.MS_Decimal_Label NzSum;
        private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex6;
        private MS_Control.Controls.MS_Decimal_Label NzFactorPrice;
        private MS_Control.Controls.MS_Notify mS_Notify1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}