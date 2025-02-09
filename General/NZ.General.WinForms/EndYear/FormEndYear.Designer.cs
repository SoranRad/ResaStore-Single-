
namespace NZ.General.WinForms.EndYear
{
    partial class FormEndYear
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
            this.mS_Panel1 = new MS_Control.Controls.MS_Panel();
            this.NzYear = new MS_Control.Controls.MS_Button_GridX();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NzStorage = new MS_Control.Controls.MS_Button_GridX();
            this.mS_Panel2 = new MS_Control.Controls.MS_Panel();
            this.mS_Panel3 = new MS_Control.Controls.MS_Panel();
            this.NzXazane = new MS_Control.Controls.MS_Button_GridX();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mS_Panel1.SuspendLayout();
            this.mS_Panel2.SuspendLayout();
            this.mS_Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mS_Panel1
            // 
            this.mS_Panel1.Controls.Add(this.NzYear);
            this.mS_Panel1.Controls.Add(this.label2);
            this.mS_Panel1.Controls.Add(this.label1);
            this.mS_Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mS_Panel1.Location = new System.Drawing.Point(0, 0);
            this.mS_Panel1.MS_BorderColor = System.Drawing.Color.Silver;
            this.mS_Panel1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Panel1.MS_Color_End = System.Drawing.Color.SkyBlue;
            this.mS_Panel1.MS_Color_Start = System.Drawing.Color.LightBlue;
            this.mS_Panel1.Name = "mS_Panel1";
            this.mS_Panel1.Size = new System.Drawing.Size(457, 120);
            this.mS_Panel1.TabIndex = 2;
            // 
            // NzYear
            // 
            this.NzYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzYear.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzYear.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.NzYear.Image = global::MS_Resource.GlobalResources.Negin__26_;
            this.NzYear.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzYear.Location = new System.Drawing.Point(12, 72);
            this.NzYear.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzYear.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzYear.MS_Change_Border_Color_On_Enter = false;
            this.NzYear.MS_Change_Color_On_Enter = false;
            this.NzYear.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.NzYear.MS_Enter_Color = System.Drawing.Color.Empty;
            this.NzYear.Name = "NzYear";
            this.NzYear.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzYear.Office2007CustomColor = System.Drawing.Color.LightBlue;
            this.NzYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzYear.ShowFocusRectangle = false;
            this.NzYear.Size = new System.Drawing.Size(191, 33);
            this.NzYear.TabIndex = 4;
            this.NzYear.Text = "تعریف سال مالی";
            this.NzYear.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.NzYear.UseThemes = false;
            this.NzYear.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzYear.WordWrap = false;
            this.NzYear.Click += new System.EventHandler(this.NzYear_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("IRANSans(Small) Medium", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(406, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("IRANSans(Small)", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(411, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "در قدم اول ابتدا سال مالی جدید را تعریف کنید";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("IRANSans(Small)", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(4, 14);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(411, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "سپس مانده موجودی انبار را به سال بعد انتقال دهید";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("IRANSans(Small) Medium", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(406, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NzStorage
            // 
            this.NzStorage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzStorage.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzStorage.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.NzStorage.Image = global::MS_Resource.GlobalResources.Negin__16_;
            this.NzStorage.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzStorage.Location = new System.Drawing.Point(12, 77);
            this.NzStorage.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzStorage.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzStorage.MS_Change_Border_Color_On_Enter = false;
            this.NzStorage.MS_Change_Color_On_Enter = false;
            this.NzStorage.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.NzStorage.MS_Enter_Color = System.Drawing.Color.Empty;
            this.NzStorage.Name = "NzStorage";
            this.NzStorage.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzStorage.Office2007CustomColor = System.Drawing.Color.LightBlue;
            this.NzStorage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzStorage.ShowFocusRectangle = false;
            this.NzStorage.Size = new System.Drawing.Size(191, 33);
            this.NzStorage.TabIndex = 4;
            this.NzStorage.Text = "انتقال موجودی انبار";
            this.NzStorage.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.NzStorage.UseThemes = false;
            this.NzStorage.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzStorage.WordWrap = false;
            this.NzStorage.Click += new System.EventHandler(this.NzStorage_Click);
            // 
            // mS_Panel2
            // 
            this.mS_Panel2.Controls.Add(this.NzStorage);
            this.mS_Panel2.Controls.Add(this.label3);
            this.mS_Panel2.Controls.Add(this.label4);
            this.mS_Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.mS_Panel2.Location = new System.Drawing.Point(0, 120);
            this.mS_Panel2.MS_BorderColor = System.Drawing.Color.Silver;
            this.mS_Panel2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Panel2.MS_Color_End = System.Drawing.Color.CadetBlue;
            this.mS_Panel2.MS_Color_Start = System.Drawing.Color.PaleTurquoise;
            this.mS_Panel2.Name = "mS_Panel2";
            this.mS_Panel2.Size = new System.Drawing.Size(457, 120);
            this.mS_Panel2.TabIndex = 3;
            // 
            // mS_Panel3
            // 
            this.mS_Panel3.Controls.Add(this.NzXazane);
            this.mS_Panel3.Controls.Add(this.label5);
            this.mS_Panel3.Controls.Add(this.label6);
            this.mS_Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.mS_Panel3.Location = new System.Drawing.Point(0, 240);
            this.mS_Panel3.MS_BorderColor = System.Drawing.Color.Silver;
            this.mS_Panel3.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Panel3.MS_Color_End = System.Drawing.Color.CornflowerBlue;
            this.mS_Panel3.MS_Color_Start = System.Drawing.Color.LightSteelBlue;
            this.mS_Panel3.Name = "mS_Panel3";
            this.mS_Panel3.Size = new System.Drawing.Size(457, 120);
            this.mS_Panel3.TabIndex = 4;
            // 
            // NzXazane
            // 
            this.NzXazane.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzXazane.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzXazane.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.NzXazane.Image = global::MS_Resource.GlobalResources.Negin__1_1;
            this.NzXazane.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzXazane.Location = new System.Drawing.Point(12, 78);
            this.NzXazane.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzXazane.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzXazane.MS_Change_Border_Color_On_Enter = false;
            this.NzXazane.MS_Change_Color_On_Enter = false;
            this.NzXazane.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.NzXazane.MS_Enter_Color = System.Drawing.Color.Empty;
            this.NzXazane.Name = "NzXazane";
            this.NzXazane.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzXazane.Office2007CustomColor = System.Drawing.Color.LightBlue;
            this.NzXazane.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzXazane.ShowFocusRectangle = false;
            this.NzXazane.Size = new System.Drawing.Size(191, 33);
            this.NzXazane.TabIndex = 4;
            this.NzXazane.Text = "انتقال مانده حساب اشخاص";
            this.NzXazane.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.NzXazane.UseThemes = false;
            this.NzXazane.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzXazane.WordWrap = false;
            this.NzXazane.Click += new System.EventHandler(this.NzXazane_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("IRANSans(Small) Medium", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(406, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 36);
            this.label5.TabIndex = 1;
            this.label5.Text = "3";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("IRANSans(Small)", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(4, 14);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10);
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(411, 40);
            this.label6.TabIndex = 0;
            this.label6.Text = "در نهایت مانده حساب اشخاص را نیز انتقال دهید";
            // 
            // FormEndYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 360);
            this.Controls.Add(this.mS_Panel3);
            this.Controls.Add(this.mS_Panel2);
            this.Controls.Add(this.mS_Panel1);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.Name = "FormEndYear";
            this.Text = "عملیات پایان سال";
            this.mS_Panel1.ResumeLayout(false);
            this.mS_Panel2.ResumeLayout(false);
            this.mS_Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MS_Control.Controls.MS_Panel mS_Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MS_Control.Controls.MS_Button_GridX NzYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MS_Control.Controls.MS_Button_GridX NzStorage;
        private MS_Control.Controls.MS_Panel mS_Panel2;
        private MS_Control.Controls.MS_Panel mS_Panel3;
        private MS_Control.Controls.MS_Button_GridX NzXazane;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}