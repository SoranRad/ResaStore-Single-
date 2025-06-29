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
using ShareLib.Utils;

namespace NZ.Resaa.Store
{
	public partial class FormUserLock : Form_Mother_IRANSans
	{
		public FormUserLock()
		{
			InitializeComponent();
		}

		private void ms_Save_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(NzPass.Text))
			{
				mS_Notify1.Show(NzPass);
				NzPass.Focus();
				return;
			}

			var pass = NzPass.Text.Trim();
			if (string.CompareOrdinal(pass, SystemConstant.ActiveUser.OriginalPassword.Trim()) != 0)
			{
				MS_Message.Show("کلمه عـبور اشتـباه است");
			}
			else
			{
				DialogResult = DialogResult.OK;
			}
		}
	}
}
