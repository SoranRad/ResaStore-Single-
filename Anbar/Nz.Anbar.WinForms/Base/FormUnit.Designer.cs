namespace Nz.Anbar.WinForms.Base
{
    partial class FormUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUnit));
            this.Panel_Foother = new MS_Control.Controls.MS_Panel();
            this.NzSave = new MS_Control.Controls.MS_Button_GridX();
            this.NzCancel = new MS_Control.Controls.MS_Button_GridX();
            this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.NzTitle = new MS_Control.Controls.MS_TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
            this.Panel_Foother.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
            this.Tab_Control_Main.SuspendLayout();
            this.uiTabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Foother
            // 
            this.Panel_Foother.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Foother.Controls.Add(this.NzSave);
            this.Panel_Foother.Controls.Add(this.NzCancel);
            this.Panel_Foother.Location = new System.Drawing.Point(0, 124);
            this.Panel_Foother.MS_BorderColor = System.Drawing.Color.DarkGray;
            this.Panel_Foother.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.Panel_Foother.MS_Color_End = System.Drawing.Color.Gainsboro;
            this.Panel_Foother.MS_Color_Start = System.Drawing.Color.WhiteSmoke;
            this.Panel_Foother.Name = "Panel_Foother";
            this.Panel_Foother.Size = new System.Drawing.Size(368, 51);
            this.Panel_Foother.TabIndex = 1;
            // 
            // NzSave
            // 
            this.NzSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzSave.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzSave.Image = ((System.Drawing.Image)(resources.GetObject("NzSave.Image")));
            this.NzSave.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzSave.Location = new System.Drawing.Point(150, 9);
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
            this.NzSave.Size = new System.Drawing.Size(113, 30);
            this.NzSave.TabIndex = 0;
            this.NzSave.Text = "ثـبــت      [F2]";
            this.NzSave.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.NzSave.UseThemes = false;
            this.NzSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzSave.WordWrap = false;
            this.NzSave.Click += new System.EventHandler(this.NzSave_Click);
            // 
            // NzCancel
            // 
            this.NzCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzCancel.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzCancel.Image = ((System.Drawing.Image)(resources.GetObject("NzCancel.Image")));
            this.NzCancel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzCancel.Location = new System.Drawing.Point(12, 9);
            this.NzCancel.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzCancel.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzCancel.MS_Change_Border_Color_On_Enter = false;
            this.NzCancel.MS_Change_Color_On_Enter = false;
            this.NzCancel.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.NzCancel.MS_Enter_Color = System.Drawing.Color.Empty;
            this.NzCancel.Name = "NzCancel";
            this.NzCancel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzCancel.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.NzCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzCancel.ShowFocusRectangle = false;
            this.NzCancel.Size = new System.Drawing.Size(132, 30);
            this.NzCancel.TabIndex = 1;
            this.NzCancel.Text = "انــصــراف   [Esc]";
            this.NzCancel.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.NzCancel.UseThemes = false;
            this.NzCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzCancel.WordWrap = false;
            this.NzCancel.Click += new System.EventHandler(this.NzCancel_Click);
            // 
            // Tab_Control_Main
            // 
            this.Tab_Control_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Control_Main.BackColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.Font = new System.Drawing.Font("IRANSans(Small) Medium", 12F);
            this.Tab_Control_Main.Location = new System.Drawing.Point(-1, 0);
            this.Tab_Control_Main.MultiLine = true;
            this.Tab_Control_Main.Name = "Tab_Control_Main";
            this.Tab_Control_Main.Office2007CustomColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.ShowFocusRectangle = false;
            this.Tab_Control_Main.Size = new System.Drawing.Size(400, 124);
            this.Tab_Control_Main.TabIndex = 0;
            this.Tab_Control_Main.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage12});
            this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tab_Control_Main.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.PowderBlue;
            this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
            this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
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
            this.uiTabPage12.Size = new System.Drawing.Size(368, 122);
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
            this.uiGroupBox1.Controls.Add(this.NzTitle);
            this.uiGroupBox1.Controls.Add(this.label6);
            this.uiGroupBox1.Location = new System.Drawing.Point(11, 8);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(344, 100);
            this.uiGroupBox1.TabIndex = 0;
            // 
            // NzTitle
            // 
            this.NzTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzTitle.Location = new System.Drawing.Point(13, 34);
            this.NzTitle.MaxLength = 200;
            this.NzTitle.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzTitle.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzTitle.MS_Change_Border_Color_On_Enter = true;
            this.NzTitle.MS_Change_Color_On_Enter = true;
            this.NzTitle.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzTitle.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzTitle.MS_Exit_By_Down = true;
            this.NzTitle.MS_Exit_By_Enter = true;
            this.NzTitle.MS_Exit_By_Up = true;
            this.NzTitle.MS_Last_Control = null;
            this.NzTitle.MS_Next_Control = null;
            this.NzTitle.Name = "NzTitle";
            this.NzTitle.Size = new System.Drawing.Size(279, 27);
            this.NzTitle.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(290, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = " عنوان : ";
            // 
            // FormUnit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(399, 175);
            this.Controls.Add(this.Panel_Foother);
            this.Controls.Add(this.Tab_Control_Main);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUnit";
            this.Text = "واحد های شمارش";
            this.Shown += new System.EventHandler(this.FormUnit_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormUnit_KeyUp);
            this.Panel_Foother.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
            this.Tab_Control_Main.ResumeLayout(false);
            this.uiTabPage12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MS_Control.Controls.MS_Panel Panel_Foother;
        private MS_Control.Controls.MS_Button_GridX NzSave;
        private MS_Control.Controls.MS_Button_GridX NzCancel;
        private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private MS_Control.Controls.MS_TextBox NzTitle;
        private System.Windows.Forms.Label label6;
        private MS_Control.Controls.MS_Notify mS_Notify1;
    }
}