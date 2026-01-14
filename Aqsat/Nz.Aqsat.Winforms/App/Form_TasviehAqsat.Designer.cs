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
			this.NzTarikh = new MS_Control.Tarikh.MS_Tarikh_TextBox();
			this.NsSharh = new MS_Control.Controls.MS_TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Panel_Foother = new MS_Control.Controls.MS_Panel();
			this.NsDeleteTasvieh = new MS_Control.Controls.MS_Button_GridX();
			this.NsSave = new MS_Control.Controls.MS_Button_GridX();
			this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
			this.uiGroupBox2.SuspendLayout();
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
			this.uiGroupBox2.Controls.Add(this.NzTarikh);
			this.uiGroupBox2.Controls.Add(this.NsSharh);
			this.uiGroupBox2.Controls.Add(this.label1);
			this.uiGroupBox2.Controls.Add(this.label2);
			this.uiGroupBox2.Location = new System.Drawing.Point(8, 2);
			this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.uiGroupBox2.Name = "uiGroupBox2";
			this.uiGroupBox2.Size = new System.Drawing.Size(595, 106);
			this.uiGroupBox2.TabIndex = 0;
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
			this.NzTarikh.Location = new System.Drawing.Point(374, 23);
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
			// 
			// NsSharh
			// 
			this.NsSharh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsSharh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsSharh.Location = new System.Drawing.Point(6, 59);
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
			this.NsSharh.Size = new System.Drawing.Size(491, 29);
			this.NsSharh.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label1.Location = new System.Drawing.Point(503, 62);
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
			this.label2.Location = new System.Drawing.Point(503, 26);
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
			this.Panel_Foother.Location = new System.Drawing.Point(0, 118);
			this.Panel_Foother.MS_BorderColor = System.Drawing.Color.DarkGray;
			this.Panel_Foother.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.Panel_Foother.MS_Color_End = System.Drawing.Color.Gainsboro;
			this.Panel_Foother.MS_Color_Start = System.Drawing.Color.WhiteSmoke;
			this.Panel_Foother.Name = "Panel_Foother";
			this.Panel_Foother.Size = new System.Drawing.Size(612, 44);
			this.Panel_Foother.TabIndex = 1;
			// 
			// NsDeleteTasvieh
			// 
			this.NsDeleteTasvieh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsDeleteTasvieh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsDeleteTasvieh.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsDeleteTasvieh.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsDeleteTasvieh.Image = global::MS_Resource.GlobalResources.Negin__1_;
			this.NsDeleteTasvieh.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NsDeleteTasvieh.Location = new System.Drawing.Point(399, 7);
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
			// Form_TasviehAqsat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(612, 162);
			this.Controls.Add(this.uiGroupBox2);
			this.Controls.Add(this.Panel_Foother);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form_TasviehAqsat";
			this.RightToLeftLayout = true;
			this.Text = "تسویه اقساط";
			this.Load += new System.EventHandler(this.Form_TasviehAqsat_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_TasviehAqsat_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
			this.uiGroupBox2.ResumeLayout(false);
			this.uiGroupBox2.PerformLayout();
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
    }
}