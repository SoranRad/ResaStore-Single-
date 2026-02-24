using MS_Control.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using MS_Control.Controls;

namespace Nz.Activator
{
    public partial class Form1 : Form_Mother_IRANSans
	{
        public Form1()
        {
            InitializeComponent();
        }

        private void ms_Save_Click(object sender, EventArgs e)
        {
	        NzMSGDecode.Text        = CryptographyHelper.Encrypt(NzSerial.Text + ";" + NzCPU.Text + ";" + NzMB.Text);
	        NzSerialDecode.Text     = CryptographyHelper.Encrypt(NzSerial.Text.Trim());
	        NzStartDecode.Text      = CryptographyHelper.Encrypt(NzStartDate.Text.Trim());
	        NzEndDecode.Text        = CryptographyHelper.Encrypt(NzEndDate.Text.Trim());
	        NzTitleDecode.Text      = CryptographyHelper.Encrypt(NzTitle.Text.Trim());
		}

        private void NzMSGDecode_ButtonClick(object sender, EventArgs e)
        {
	        var box = sender as MS_TextBox;
            Clipboard.SetText(box.Text);
			new Form_Notify("کپی", "اطـلاعـات بـا مـوفـقـیـت کپی شـــد.",
					Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
				.Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);
		}

		private void NzMB_ButtonClick(object sender, EventArgs e)
		{
			NzMB.Text = MS_Control.Hardware.Hardware.mb_serial_number().Trim();
		}

		private void NzCPU_ButtonClick(object sender, EventArgs e)
		{
			NzCPU.Text = MS_Control.Hardware.Hardware.cpu_id().Trim();
		}
	}
}
