namespace SmsBan.UI.Components
{
	partial class UsersControl
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
			this.NsMobiles = new System.Windows.Forms.Label();
			this.NsTitle = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// NsMobiles
			// 
			this.NsMobiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NsMobiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.NsMobiles.Location = new System.Drawing.Point(0, 23);
			this.NsMobiles.Name = "NsMobiles";
			this.NsMobiles.Size = new System.Drawing.Size(178, 23);
			this.NsMobiles.TabIndex = 8;
			this.NsMobiles.Text = "Online";
			// 
			// NsTitle
			// 
			this.NsTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.NsTitle.ForeColor = System.Drawing.Color.Black;
			this.NsTitle.Location = new System.Drawing.Point(0, 0);
			this.NsTitle.Name = "NsTitle";
			this.NsTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsTitle.Size = new System.Drawing.Size(178, 23);
			this.NsTitle.TabIndex = 7;
			this.NsTitle.Text = "User name";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox1.Image = global::SmsBan.Properties.Resources.users1;
			this.pictureBox1.Location = new System.Drawing.Point(178, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(45, 46);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Right;
			this.label1.Location = new System.Drawing.Point(223, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(5, 46);
			this.label1.TabIndex = 10;
			// 
			// UsersControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.Controls.Add(this.NsMobiles);
			this.Controls.Add(this.NsTitle);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.MinimumSize = new System.Drawing.Size(228, 46);
			this.Name = "UsersControl";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(228, 46);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label NsMobiles;
		private System.Windows.Forms.Label NsTitle;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}
