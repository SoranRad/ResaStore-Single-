namespace NZ.General.WinForms.Base
{
    partial class Form_State
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ms_Title = new MS_Control.Controls.MS_TextBox();
            this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
            this.Panel_Foother.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
            this.Tab_Control_Main.SuspendLayout();
            this.uiTabPage12.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Foother
            // 
            this.Panel_Foother.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Foother.Controls.Add(this.ms_Save);
            this.Panel_Foother.Controls.Add(this.ms_Exit);
            this.Panel_Foother.Location = new System.Drawing.Point(1, 96);
            this.Panel_Foother.MS_BorderColor = System.Drawing.Color.DarkGray;
            this.Panel_Foother.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.Panel_Foother.MS_Color_End = System.Drawing.Color.Gainsboro;
            this.Panel_Foother.MS_Color_Start = System.Drawing.Color.WhiteSmoke;
            this.Panel_Foother.Name = "Panel_Foother";
            this.Panel_Foother.Size = new System.Drawing.Size(413, 48);
            this.Panel_Foother.TabIndex = 3;
            // 
            // ms_Save
            // 
            this.ms_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_Save.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_Save.Image = global::MS_Resource.GlobalResources._ms_Save;
            this.ms_Save.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.ms_Save.Location = new System.Drawing.Point(148, 9);
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
            this.ms_Exit.Size = new System.Drawing.Size(130, 30);
            this.ms_Exit.TabIndex = 2;
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
            this.Tab_Control_Main.Location = new System.Drawing.Point(1, 0);
            this.Tab_Control_Main.MultiLine = true;
            this.Tab_Control_Main.Name = "Tab_Control_Main";
            this.Tab_Control_Main.Office2007CustomColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.ShowFocusRectangle = false;
            this.Tab_Control_Main.Size = new System.Drawing.Size(437, 97);
            this.Tab_Control_Main.TabIndex = 2;
            this.Tab_Control_Main.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage12});
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
            this.uiTabPage12.Controls.Add(this.label5);
            this.uiTabPage12.Controls.Add(this.label3);
            this.uiTabPage12.Controls.Add(this.ms_Title);
            this.uiTabPage12.Location = new System.Drawing.Point(1, 1);
            this.uiTabPage12.Name = "uiTabPage12";
            this.uiTabPage12.PanelFormatStyle.Alpha = 70;
            this.uiTabPage12.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.uiTabPage12.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
            this.uiTabPage12.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
            this.uiTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiTabPage12.Size = new System.Drawing.Size(412, 95);
            this.uiTabPage12.TabStop = true;
            this.uiTabPage12.Text = "اطلاعات";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(386, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 23);
            this.label5.TabIndex = 98;
            this.label5.Text = "*";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(331, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 95;
            this.label3.Text = "عـنـوان :";
            // 
            // ms_Title
            // 
            this.ms_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_Title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_Title.Location = new System.Drawing.Point(15, 35);
            this.ms_Title.MaxLength = 500;
            this.ms_Title.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_Title.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_Title.MS_Change_Border_Color_On_Enter = true;
            this.ms_Title.MS_Change_Color_On_Enter = true;
            this.ms_Title.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ms_Title.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_Title.MS_Exit_By_Down = true;
            this.ms_Title.MS_Exit_By_Enter = true;
            this.ms_Title.MS_Exit_By_Up = true;
            this.ms_Title.MS_Last_Control = null;
            this.ms_Title.MS_Next_Control = null;
            this.ms_Title.Name = "ms_Title";
            this.ms_Title.Size = new System.Drawing.Size(314, 29);
            this.ms_Title.TabIndex = 0;
            // 
            // Form_State
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 143);
            this.Controls.Add(this.Panel_Foother);
            this.Controls.Add(this.Tab_Control_Main);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_State";
            this.Text = "تـعریـف اسـتــان";
            this.Shown += new System.EventHandler(this.Form_State_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_KeyUp);
            this.Panel_Foother.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
            this.Tab_Control_Main.ResumeLayout(false);
            this.uiTabPage12.ResumeLayout(false);
            this.uiTabPage12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MS_Control.Controls.MS_Panel Panel_Foother;
        private MS_Control.Controls.MS_Button_GridX ms_Save;
        private MS_Control.Controls.MS_Button_GridX ms_Exit;
        private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private MS_Control.Controls.MS_TextBox ms_Title;
        private MS_Control.Controls.MS_Notify mS_Notify1;
    }
}