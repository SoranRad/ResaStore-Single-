namespace SmsBan.UI.Components
{
	partial class LeftChatMessage
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.NsBody = new System.Windows.Forms.Label();
			this.NsPicPanel = new System.Windows.Forms.Panel();
			this.NsFooter = new System.Windows.Forms.Panel();
			this.NsMeta = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.NsUserPic = new System.Windows.Forms.PictureBox();
			this.NsPicPanel.SuspendLayout();
			this.NsFooter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NsUserPic)).BeginInit();
			this.SuspendLayout();
			// 
			// NsBody
			// 
			this.NsBody.AutoSize = true;
			this.NsBody.BackColor = System.Drawing.Color.Teal;
			this.NsBody.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.NsBody.Dock = System.Windows.Forms.DockStyle.Left;
			this.NsBody.ForeColor = System.Drawing.Color.White;
			this.NsBody.Location = new System.Drawing.Point(52, 10);
			this.NsBody.MaximumSize = new System.Drawing.Size(140, 0);
			this.NsBody.Name = "NsBody";
			this.NsBody.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.NsBody.Size = new System.Drawing.Size(138, 174);
			this.NsBody.TabIndex = 11;
			this.NsBody.Text = " This is a sample text message. This is a sample text message. This is a sample t" +
    "ext message. \r\n\r\nThis is a sample text message. ";
			// 
			// NsPicPanel
			// 
			this.NsPicPanel.Controls.Add(this.NsUserPic);
			this.NsPicPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.NsPicPanel.Location = new System.Drawing.Point(10, 10);
			this.NsPicPanel.Name = "NsPicPanel";
			this.NsPicPanel.Size = new System.Drawing.Size(42, 211);
			this.NsPicPanel.TabIndex = 12;
			// 
			// NsFooter
			// 
			this.NsFooter.Controls.Add(this.NsMeta);
			this.NsFooter.Controls.Add(this.pictureBox1);
			this.NsFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.NsFooter.Location = new System.Drawing.Point(52, 190);
			this.NsFooter.Name = "NsFooter";
			this.NsFooter.Size = new System.Drawing.Size(461, 31);
			this.NsFooter.TabIndex = 16;
			// 
			// NsMeta
			// 
			this.NsMeta.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NsMeta.ForeColor = System.Drawing.Color.DimGray;
			this.NsMeta.Location = new System.Drawing.Point(26, 0);
			this.NsMeta.Name = "NsMeta";
			this.NsMeta.Size = new System.Drawing.Size(435, 31);
			this.NsMeta.TabIndex = 15;
			this.NsMeta.Text = "123";
			this.NsMeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = global::SmsBan.Properties.Resources.information;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
			this.pictureBox1.Size = new System.Drawing.Size(26, 31);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// NsUserPic
			// 
			this.NsUserPic.BackColor = System.Drawing.Color.Transparent;
			this.NsUserPic.Image = global::SmsBan.Properties.Resources.users1;
			this.NsUserPic.Location = new System.Drawing.Point(0, 0);
			this.NsUserPic.Margin = new System.Windows.Forms.Padding(5);
			this.NsUserPic.Name = "NsUserPic";
			this.NsUserPic.Padding = new System.Windows.Forms.Padding(5);
			this.NsUserPic.Size = new System.Drawing.Size(42, 45);
			this.NsUserPic.TabIndex = 11;
			this.NsUserPic.TabStop = false;
			// 
			// LeftChatMessage
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.NsBody);
			this.Controls.Add(this.NsFooter);
			this.Controls.Add(this.NsPicPanel);
			this.Font = new System.Drawing.Font("IRANSans(Small) Medium", 12F);
			this.Name = "LeftChatMessage";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(523, 231);
			this.NsPicPanel.ResumeLayout(false);
			this.NsFooter.ResumeLayout(false);
			this.NsFooter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NsUserPic)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label NsBody;
		private System.Windows.Forms.Panel NsPicPanel;
		private System.Windows.Forms.PictureBox NsUserPic;
		private System.Windows.Forms.Panel NsFooter;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label NsMeta;
	}
}
