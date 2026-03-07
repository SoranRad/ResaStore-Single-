using MS_Control;
using MS_Control.MainForms;
using NZ.General.WinForms.Setting;
using ShareLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nz.Aqsat.Winforms.App
{
	public partial class FormRememberAnnual : Form_Mother_IRANSans
	{

		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion

		public FormRememberAnnual()
		{
			InitializeComponent();
			NzCustomer.Refresh_Grid((byte)3, null);
			NsKind.RefreshKinds();

		}

		private void GenerateText()
		{
			var customer = NzCustomer.MS_Get_Selected() as People;
			NsSampleText.Text = @"تمدید اقساط " + NsKind.Text + " " + customer?.title+ @" با موبایل " + customer?.mobile + " " + NsVasileh.Text + @" به شماره "+ NzSerial.Text+ " " + NsSharh.Text;
		}

		private bool IsOK()
		{
			if (NzCustomer.MS_Get_Selected() == null)
			{
				NzCustomer.Focus();
				mS_Notify1.Show(NzCustomer);
				return false;
			}

			if (!NzTarikh.MS_Tarikh.HasValue)
			{
				NzTarikh.Focus();
				mS_Notify1.Show(NzTarikh);
				return false;
			}


			if (NsKind.GetValue() == null)
			{
				NsKind.Focus();
				mS_Notify1.Show(NsKind);
				return false;
			}

			return true;
		}

		private void Reset()
		{
			NsKind.SelectedIndex = -1;
			NsVasileh.Text = "";
			NzSerial.Text =" ";
			NsSharh.Text = "";
		}

		private void Save()
		{
			try
			{

				DailyNoteService.AddNote(NzTarikh.MS_Tarikh.Value.ToDatetime().Date, NsSampleText.Text);
				new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
						Form_Notify.FarsiMessageBoxIcon.اضافه)
					.Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);
				Reset();
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show("خطا در برنامه", "", ex.Message, MessageBoxButtons.OK);
			}
		}

		private void NzCustomer_MS_On_Row_Selected(object sender, MS_Control.TSDD.On_Selected e)
		{
			GenerateText();
		}

		private void NsVasileh_TextChanged(object sender, EventArgs e)
		{
			GenerateText();
		}

		private void NsKind_SelectedValueChanged(object sender, EventArgs e)
		{
			GenerateText();

		}

		private void NzSerial_TextChanged(object sender, EventArgs e)
		{
			GenerateText();

		}

		private void NsSharh_TextChanged(object sender, EventArgs e)
		{
			GenerateText();
		}

		private void ms_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ms_Save_Click(object sender, EventArgs e)
		{
			if(!IsOK())
				return;

			Save();
		}
	}
}
