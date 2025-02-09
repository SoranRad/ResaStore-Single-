namespace NZ.Xazane.WinForms.Cheque
{
    partial class FormArrive_Back
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
            this.Panel_Foother = new MS_Control.Controls.MS_Panel();
            this.ms_Save = new MS_Control.Controls.MS_Button_GridX();
            this.ms_Exit = new MS_Control.Controls.MS_Button_GridX();
            this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mS_Text_Simple10 = new MS_Control.Controls.MS_Text_Simple();
            this.mS_Text_Simple9 = new MS_Control.Controls.MS_Text_Simple();
            this.mS_Text_Simple8 = new MS_Control.Controls.MS_Text_Simple();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NzDateEmpty = new MS_Control.Tarikh.MS_Tarikh_TextBox();
            this.NzDateBoxArrive = new MS_Control.Tarikh.MS_Tarikh_TextBox();
            this.NzDateUsanc = new MS_Control.Controls.MS_RadioBox();
            this.NzDateArrive = new MS_Control.Controls.MS_RadioBox();
            this.mS_Text_Simple7 = new MS_Control.Controls.MS_Text_Simple();
            this.NzDate = new MS_Control.Tarikh.MS_Tarikh_TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NzDescription = new MS_Control.Controls.MS_TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiTabPage14 = new Janus.Windows.UI.Tab.UITabPage();
            this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
            this.Panel_Foother.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
            this.Tab_Control_Main.SuspendLayout();
            this.uiTabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Foother
            // 
            this.Panel_Foother.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Foother.Controls.Add(this.ms_Save);
            this.Panel_Foother.Controls.Add(this.ms_Exit);
            this.Panel_Foother.Location = new System.Drawing.Point(0, 202);
            this.Panel_Foother.MS_BorderColor = System.Drawing.Color.DarkGray;
            this.Panel_Foother.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.Panel_Foother.MS_Color_End = System.Drawing.Color.Gainsboro;
            this.Panel_Foother.MS_Color_Start = System.Drawing.Color.WhiteSmoke;
            this.Panel_Foother.Name = "Panel_Foother";
            this.Panel_Foother.Size = new System.Drawing.Size(497, 48);
            this.Panel_Foother.TabIndex = 5;
            // 
            // ms_Save
            // 
            this.ms_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_Save.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_Save.Image = global::MS_Resource.GlobalResources._ms_Save;
            this.ms_Save.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.ms_Save.Location = new System.Drawing.Point(150, 9);
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
            this.ms_Exit.Image = global::MS_Resource.GlobalResources._ms_Back;
            this.ms_Exit.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.ms_Exit.Location = new System.Drawing.Point(12, 9);
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
            this.ms_Exit.Click += new System.EventHandler(this.ms_Exit_Click);
            // 
            // Tab_Control_Main
            // 
            this.Tab_Control_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Control_Main.BackColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.Location = new System.Drawing.Point(0, 0);
            this.Tab_Control_Main.MultiLine = true;
            this.Tab_Control_Main.Name = "Tab_Control_Main";
            this.Tab_Control_Main.Office2007CustomColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.ShowFocusRectangle = false;
            this.Tab_Control_Main.Size = new System.Drawing.Size(527, 202);
            this.Tab_Control_Main.TabIndex = 4;
            this.Tab_Control_Main.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage12,
            this.uiTabPage14});
            this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tab_Control_Main.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.PowderBlue;
            this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
            this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.Tab_Control_Main.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right;
            this.Tab_Control_Main.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Vertical;
            this.Tab_Control_Main.UseThemes = false;
            this.Tab_Control_Main.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            // 
            // uiTabPage12
            // 
            this.uiTabPage12.Controls.Add(this.uiGroupBox1);
            this.uiTabPage12.Location = new System.Drawing.Point(1, 1);
            this.uiTabPage12.Name = "uiTabPage12";
            this.uiTabPage12.PanelFormatStyle.Alpha = 70;
            this.uiTabPage12.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.uiTabPage12.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
            this.uiTabPage12.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
            this.uiTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiTabPage12.Size = new System.Drawing.Size(495, 200);
            this.uiTabPage12.TabStop = true;
            this.uiTabPage12.Text = "اطلاعات";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.BorderColor = System.Drawing.Color.LightBlue;
            this.uiGroupBox1.Controls.Add(this.panel1);
            this.uiGroupBox1.Controls.Add(this.NzDate);
            this.uiGroupBox1.Controls.Add(this.label4);
            this.uiGroupBox1.Controls.Add(this.NzDescription);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Location = new System.Drawing.Point(10, 2);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(475, 191);
            this.uiGroupBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mS_Text_Simple10);
            this.panel1.Controls.Add(this.mS_Text_Simple9);
            this.panel1.Controls.Add(this.mS_Text_Simple8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.NzDateEmpty);
            this.panel1.Controls.Add(this.NzDateBoxArrive);
            this.panel1.Controls.Add(this.NzDateUsanc);
            this.panel1.Controls.Add(this.NzDateArrive);
            this.panel1.Controls.Add(this.mS_Text_Simple7);
            this.panel1.Location = new System.Drawing.Point(6, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 123);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // mS_Text_Simple10
            // 
            this.mS_Text_Simple10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mS_Text_Simple10.BackColor = System.Drawing.Color.LimeGreen;
            this.mS_Text_Simple10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mS_Text_Simple10.Location = new System.Drawing.Point(317, 65);
            this.mS_Text_Simple10.MS_BorderColor = System.Drawing.Color.Empty;
            this.mS_Text_Simple10.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.mS_Text_Simple10.MS_Change_Border_Color_On_Enter = false;
            this.mS_Text_Simple10.MS_Change_Color_On_Enter = false;
            this.mS_Text_Simple10.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.mS_Text_Simple10.MS_Enter_Color = System.Drawing.Color.Empty;
            this.mS_Text_Simple10.MS_Exit_By_Down = false;
            this.mS_Text_Simple10.MS_Exit_By_Enter = false;
            this.mS_Text_Simple10.MS_Exit_By_Up = false;
            this.mS_Text_Simple10.MS_Last_Control = null;
            this.mS_Text_Simple10.MS_Next_Control = null;
            this.mS_Text_Simple10.Multiline = true;
            this.mS_Text_Simple10.Name = "mS_Text_Simple10";
            this.mS_Text_Simple10.Size = new System.Drawing.Size(12, 2);
            this.mS_Text_Simple10.TabIndex = 839;
            // 
            // mS_Text_Simple9
            // 
            this.mS_Text_Simple9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mS_Text_Simple9.BackColor = System.Drawing.Color.LimeGreen;
            this.mS_Text_Simple9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mS_Text_Simple9.Location = new System.Drawing.Point(318, 19);
            this.mS_Text_Simple9.MS_BorderColor = System.Drawing.Color.Empty;
            this.mS_Text_Simple9.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.mS_Text_Simple9.MS_Change_Border_Color_On_Enter = false;
            this.mS_Text_Simple9.MS_Change_Color_On_Enter = false;
            this.mS_Text_Simple9.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.mS_Text_Simple9.MS_Enter_Color = System.Drawing.Color.Empty;
            this.mS_Text_Simple9.MS_Exit_By_Down = false;
            this.mS_Text_Simple9.MS_Exit_By_Enter = false;
            this.mS_Text_Simple9.MS_Exit_By_Up = false;
            this.mS_Text_Simple9.MS_Last_Control = null;
            this.mS_Text_Simple9.MS_Next_Control = null;
            this.mS_Text_Simple9.Multiline = true;
            this.mS_Text_Simple9.Name = "mS_Text_Simple9";
            this.mS_Text_Simple9.Size = new System.Drawing.Size(12, 2);
            this.mS_Text_Simple9.TabIndex = 838;
            // 
            // mS_Text_Simple8
            // 
            this.mS_Text_Simple8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mS_Text_Simple8.BackColor = System.Drawing.Color.LimeGreen;
            this.mS_Text_Simple8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mS_Text_Simple8.Location = new System.Drawing.Point(328, 41);
            this.mS_Text_Simple8.MS_BorderColor = System.Drawing.Color.Empty;
            this.mS_Text_Simple8.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.mS_Text_Simple8.MS_Change_Border_Color_On_Enter = false;
            this.mS_Text_Simple8.MS_Change_Color_On_Enter = false;
            this.mS_Text_Simple8.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.mS_Text_Simple8.MS_Enter_Color = System.Drawing.Color.Empty;
            this.mS_Text_Simple8.MS_Exit_By_Down = false;
            this.mS_Text_Simple8.MS_Exit_By_Enter = false;
            this.mS_Text_Simple8.MS_Exit_By_Up = false;
            this.mS_Text_Simple8.MS_Last_Control = null;
            this.mS_Text_Simple8.MS_Next_Control = null;
            this.mS_Text_Simple8.Multiline = true;
            this.mS_Text_Simple8.Name = "mS_Text_Simple8";
            this.mS_Text_Simple8.Size = new System.Drawing.Size(8, 2);
            this.mS_Text_Simple8.TabIndex = 837;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(110, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 40);
            this.label1.TabIndex = 822;
            this.label1.Text = "در صورتی که تاریخ سر رسید خالی باشد\r\n به این تاریخ ثبت زده شود.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(336, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 822;
            this.label5.Text = "تاریخ وصول چـک هـا";
            // 
            // NzDateEmpty
            // 
            this.NzDateEmpty.AllowInternalTab = false;
            this.NzDateEmpty.AllowResizeDropDown = false;
            this.NzDateEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzDateEmpty.AutoHeight = true;
            this.NzDateEmpty.BackColor = System.Drawing.Color.White;
            this.NzDateEmpty.ControlSize = new System.Drawing.Size(0, 0);
            this.NzDateEmpty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NzDateEmpty.DropSize = new System.Drawing.Size(0, 0);
            this.NzDateEmpty.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
            this.NzDateEmpty.Location = new System.Drawing.Point(9, 81);
            this.NzDateEmpty.MinimumSize = new System.Drawing.Size(99, 27);
            this.NzDateEmpty.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzDateEmpty.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzDateEmpty.MS_Change_Border_Color_On_Enter = true;
            this.NzDateEmpty.MS_Change_Color_On_Enter = true;
            this.NzDateEmpty.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NzDateEmpty.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzDateEmpty.MS_Exit_By_Down = true;
            this.NzDateEmpty.MS_Exit_By_Enter = true;
            this.NzDateEmpty.MS_Exit_By_Up = true;
            this.NzDateEmpty.MS_Last_Control = null;
            this.NzDateEmpty.MS_Next_Control = null;
            this.NzDateEmpty.MS_Separation = '/';
            this.NzDateEmpty.MS_Tarikh = null;
            this.NzDateEmpty.Name = "NzDateEmpty";
            this.NzDateEmpty.ReadOnly = false;
            this.NzDateEmpty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NzDateEmpty.Size = new System.Drawing.Size(99, 27);
            this.NzDateEmpty.TabIndex = 1;
            this.NzDateEmpty.Text = "//";
            // 
            // NzDateBoxArrive
            // 
            this.NzDateBoxArrive.AllowInternalTab = false;
            this.NzDateBoxArrive.AllowResizeDropDown = false;
            this.NzDateBoxArrive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzDateBoxArrive.AutoHeight = true;
            this.NzDateBoxArrive.BackColor = System.Drawing.Color.White;
            this.NzDateBoxArrive.ControlSize = new System.Drawing.Size(0, 0);
            this.NzDateBoxArrive.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NzDateBoxArrive.DropSize = new System.Drawing.Size(0, 0);
            this.NzDateBoxArrive.Enabled = false;
            this.NzDateBoxArrive.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
            this.NzDateBoxArrive.Location = new System.Drawing.Point(98, 7);
            this.NzDateBoxArrive.MinimumSize = new System.Drawing.Size(99, 27);
            this.NzDateBoxArrive.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzDateBoxArrive.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzDateBoxArrive.MS_Change_Border_Color_On_Enter = true;
            this.NzDateBoxArrive.MS_Change_Color_On_Enter = true;
            this.NzDateBoxArrive.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NzDateBoxArrive.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzDateBoxArrive.MS_Exit_By_Down = true;
            this.NzDateBoxArrive.MS_Exit_By_Enter = true;
            this.NzDateBoxArrive.MS_Exit_By_Up = true;
            this.NzDateBoxArrive.MS_Last_Control = null;
            this.NzDateBoxArrive.MS_Next_Control = null;
            this.NzDateBoxArrive.MS_Separation = '/';
            this.NzDateBoxArrive.MS_Tarikh = null;
            this.NzDateBoxArrive.Name = "NzDateBoxArrive";
            this.NzDateBoxArrive.ReadOnly = false;
            this.NzDateBoxArrive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NzDateBoxArrive.Size = new System.Drawing.Size(99, 27);
            this.NzDateBoxArrive.TabIndex = 1;
            this.NzDateBoxArrive.Text = "//";
            // 
            // NzDateUsanc
            // 
            this.NzDateUsanc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzDateUsanc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzDateUsanc.Checked = true;
            this.NzDateUsanc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzDateUsanc.Location = new System.Drawing.Point(9, 50);
            this.NzDateUsanc.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzDateUsanc.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzDateUsanc.MS_Change_Border_Color_On_Enter = true;
            this.NzDateUsanc.MS_Change_Color_On_Checked = true;
            this.NzDateUsanc.MS_Change_Color_On_Enter = true;
            this.NzDateUsanc.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzDateUsanc.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzDateUsanc.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzDateUsanc.MS_Exit_By_Down = true;
            this.NzDateUsanc.MS_Exit_By_Enter = true;
            this.NzDateUsanc.MS_Exit_By_Up = true;
            this.NzDateUsanc.MS_Last_Control = null;
            this.NzDateUsanc.MS_Next_Control = null;
            this.NzDateUsanc.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.NzDateUsanc.Name = "NzDateUsanc";
            this.NzDateUsanc.Size = new System.Drawing.Size(304, 27);
            this.NzDateUsanc.TabIndex = 2;
            this.NzDateUsanc.TabStop = true;
            this.NzDateUsanc.Text = "  در تاریخ سر رسید هر چـک ";
            this.NzDateUsanc.CheckedChanged += new System.EventHandler(this.NzDateUsanc_CheckedChanged);
            // 
            // NzDateArrive
            // 
            this.NzDateArrive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzDateArrive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzDateArrive.Location = new System.Drawing.Point(9, 9);
            this.NzDateArrive.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzDateArrive.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzDateArrive.MS_Change_Border_Color_On_Enter = true;
            this.NzDateArrive.MS_Change_Color_On_Checked = true;
            this.NzDateArrive.MS_Change_Color_On_Enter = true;
            this.NzDateArrive.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzDateArrive.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzDateArrive.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzDateArrive.MS_Exit_By_Down = true;
            this.NzDateArrive.MS_Exit_By_Enter = true;
            this.NzDateArrive.MS_Exit_By_Up = true;
            this.NzDateArrive.MS_Last_Control = null;
            this.NzDateArrive.MS_Next_Control = null;
            this.NzDateArrive.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.NzDateArrive.Name = "NzDateArrive";
            this.NzDateArrive.Size = new System.Drawing.Size(304, 23);
            this.NzDateArrive.TabIndex = 0;
            this.NzDateArrive.Text = "  در تاریخ :";
            this.NzDateArrive.CheckedChanged += new System.EventHandler(this.NzDateUsanc_CheckedChanged);
            // 
            // mS_Text_Simple7
            // 
            this.mS_Text_Simple7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mS_Text_Simple7.BackColor = System.Drawing.Color.LimeGreen;
            this.mS_Text_Simple7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mS_Text_Simple7.Location = new System.Drawing.Point(328, 21);
            this.mS_Text_Simple7.MS_BorderColor = System.Drawing.Color.Empty;
            this.mS_Text_Simple7.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.mS_Text_Simple7.MS_Change_Border_Color_On_Enter = false;
            this.mS_Text_Simple7.MS_Change_Color_On_Enter = false;
            this.mS_Text_Simple7.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.mS_Text_Simple7.MS_Enter_Color = System.Drawing.Color.Empty;
            this.mS_Text_Simple7.MS_Exit_By_Down = false;
            this.mS_Text_Simple7.MS_Exit_By_Enter = false;
            this.mS_Text_Simple7.MS_Exit_By_Up = false;
            this.mS_Text_Simple7.MS_Last_Control = null;
            this.mS_Text_Simple7.MS_Next_Control = null;
            this.mS_Text_Simple7.Multiline = true;
            this.mS_Text_Simple7.Name = "mS_Text_Simple7";
            this.mS_Text_Simple7.Size = new System.Drawing.Size(2, 46);
            this.mS_Text_Simple7.TabIndex = 832;
            // 
            // NzDate
            // 
            this.NzDate.AllowInternalTab = false;
            this.NzDate.AllowResizeDropDown = false;
            this.NzDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzDate.AutoHeight = true;
            this.NzDate.BackColor = System.Drawing.Color.White;
            this.NzDate.ControlSize = new System.Drawing.Size(0, 0);
            this.NzDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NzDate.DropSize = new System.Drawing.Size(0, 0);
            this.NzDate.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
            this.NzDate.Location = new System.Drawing.Point(237, 55);
            this.NzDate.MinimumSize = new System.Drawing.Size(99, 27);
            this.NzDate.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzDate.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzDate.MS_Change_Border_Color_On_Enter = true;
            this.NzDate.MS_Change_Color_On_Enter = true;
            this.NzDate.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
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
            this.NzDate.Size = new System.Drawing.Size(99, 27);
            this.NzDate.TabIndex = 6;
            this.NzDate.Text = "//";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(336, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 835;
            this.label4.Text = "در تاریخ :";
            // 
            // NzDescription
            // 
            this.NzDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NzDescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzDescription.Location = new System.Drawing.Point(15, 100);
            this.NzDescription.MaxLength = 200;
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
            this.NzDescription.Size = new System.Drawing.Size(321, 72);
            this.NzDescription.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(336, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 822;
            this.label3.Text = "شـرح :";
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
            this.uiTabPage14.Size = new System.Drawing.Size(505, 358);
            this.uiTabPage14.TabStop = true;
            this.uiTabPage14.Text = "پرسش و پاسخ";
            // 
            // FormArrive_Back
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(532, 250);
            this.Controls.Add(this.Panel_Foother);
            this.Controls.Add(this.Tab_Control_Main);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormArrive_Back";
            this.Text = "FormArrive_Back";
            this.Shown += new System.EventHandler(this.FormArrive_Back_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormArrive_Back_KeyUp);
            this.Panel_Foother.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
            this.Tab_Control_Main.ResumeLayout(false);
            this.uiTabPage12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MS_Control.Controls.MS_Panel Panel_Foother;
        private MS_Control.Controls.MS_Button_GridX ms_Save;
        private MS_Control.Controls.MS_Button_GridX ms_Exit;
        private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Panel panel1;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple10;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple9;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private MS_Control.Tarikh.MS_Tarikh_TextBox NzDateEmpty;
        private MS_Control.Tarikh.MS_Tarikh_TextBox NzDateBoxArrive;
        private MS_Control.Controls.MS_RadioBox NzDateUsanc;
        private MS_Control.Controls.MS_RadioBox NzDateArrive;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple7;
        private MS_Control.Tarikh.MS_Tarikh_TextBox NzDate;
        private System.Windows.Forms.Label label4;
        private MS_Control.Controls.MS_TextBox NzDescription;
        private System.Windows.Forms.Label label3;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage14;
        private MS_Control.Controls.MS_Notify mS_Notify1;
    }
}