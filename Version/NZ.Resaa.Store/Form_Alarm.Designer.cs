namespace NZ.Resaa.Store
{
    partial class Form_Alarm
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
            this.NzTab = new Janus.Windows.UI.Tab.UITab();
            ((System.ComponentModel.ISupportInitialize)(this.NzTab)).BeginInit();
            this.SuspendLayout();
            // 
            // NzTab
            // 
            this.NzTab.BackColor = System.Drawing.Color.Transparent;
            this.NzTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NzTab.FirstTabOffset = 20;
            this.NzTab.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzTab.Location = new System.Drawing.Point(0, 0);
            this.NzTab.MultiLine = true;
            this.NzTab.Name = "NzTab";
            this.NzTab.Office2007CustomColor = System.Drawing.Color.Transparent;
            this.NzTab.ShowFocusRectangle = false;
            this.NzTab.Size = new System.Drawing.Size(1046, 404);
            this.NzTab.TabIndex = 6;
            this.NzTab.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NzTab.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NzTab.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.PowderBlue;
            this.NzTab.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
            this.NzTab.TabsStateStyles.SelectedFormatStyle.FontSize = 14F;
            this.NzTab.TabStripOffset = 10;
            this.NzTab.UseThemes = false;
            this.NzTab.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            // 
            // Form_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 404);
            this.Controls.Add(this.NzTab);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Alarm";
            this.Text = "هشدارهای امروز";
            this.Load += new System.EventHandler(this.Form_Alarm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NzTab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Tab.UITab NzTab;
    }
}