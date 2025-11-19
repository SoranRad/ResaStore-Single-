using MS_Control;
using MS_Control.MainForms;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShareLib;
using ShareLib.Models;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.App
{
	public partial class FormCopyToYear : Form_Mother_IRANSans
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion

		private FactorManager       _Manager;
		private FactorHead          _Factor;


		public long IdFactor { get; set; }

		public FormCopyToYear()
		{
			InitializeComponent();
			_Manager    = new FactorManager();

		}

		private void Init()
		{
			try
			{
				NsYear.RefreshCombo();
				_Factor     = _Manager.GetItem(IdFactor);
				if (_Factor == null)
				{
					MS_Message.Show("سند مورد نظر یافت نشد");
					ms_Save.Enabled = false;
					NsYear.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show(ex.Message);
			}

		}

		private void GetNewSerial()
		{
			var currentYear = SystemConstant.ActiveYear;

			try
			{
				var selectedYear			= NsYear.SelectedValue as Year;
				SystemConstant.ActiveYear	= selectedYear;

				var _Serial = _Manager.GetMaxSerial(new
				{
					Kind = (byte)_Factor.kind,
					Year = SystemConstant.ActiveYear.Salmali,
					Anbar = _Factor.FK_Anbar_Az
				}) + 1;

				NsSerial.MS_Decimal = _Serial;
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show(ex.Message);
			}
			finally
			{
				SystemConstant.ActiveYear = currentYear;
			}
		}

		private bool IsOK()
		{
			if (NsYear.SelectedValue == null)
			{
				NsYear.Focus();
				NsYear.DroppedDown = true;
				return false;
			}
			return true;
		}
		private void Save()
		{

			var currentYear = SystemConstant.ActiveYear;

			try
			{
				var selectedYear			= NsYear.SelectedValue as Year;
				SystemConstant.ActiveYear	= selectedYear;

				var _Serial = _Manager.GetMaxSerial(new
				{
					Kind = (byte)_Factor.kind,
					Year = SystemConstant.ActiveYear.Salmali,
					Anbar = _Factor.FK_Anbar_Az
				}) + 1;

				_Factor.ID = 0;
				_Factor.FK_Salmali = SystemConstant.ActiveYear.Salmali;
				_Factor.Serial = _Serial;
				_Factor.FactorItems.MSZ_ForEach(item =>
				{
					item.ID = 0;
					item.State = Enums.NzItemState.AddedNew;
					item.FK_Salmali = SystemConstant.ActiveYear.Salmali;
					item.FactorHead = _Factor;
					item.FK_Title = 0;
				});

				_Manager.Save(_Factor,true);
				new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
						Form_Notify.FarsiMessageBoxIcon.اضافه)
					.Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);

			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show(ex.Message);
			}
			finally
			{
				SystemConstant.ActiveYear = currentYear;
				this.DialogResult = DialogResult.OK;
			}
		}

		private void FormCopyToYear_KeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.F2)
				ms_Save.PerformClick();
		}

		private void NsYear_SelectedIndexChanged(object sender, EventArgs e)
		{
			GetNewSerial();
		}

		private void FormCopyToYear_Shown(object sender, EventArgs e)
		{
			Init();
			NsYear.SelectedIndexChanged += NsYear_SelectedIndexChanged;
		}

		private void ms_Save_Click(object sender, EventArgs e)
		{
			if(!IsOK())
				return;
			Save();
		}
	}
}
