using MS_Control.MainForms;
using Nz.Aqsat.Model.Models;
using NZ.Aqsat.Business;
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
using MS_Control.Tarikh;
using ShareLib;

namespace Nz.Aqsat.Winforms.App
{
    public partial class Form_TasviehAqsat : Form_Mother_IRANSans
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion
		#region Fields

		private readonly long	_idHead;
		private readonly long	_idRadif;
		private Aqsat_Main		_Aqsat;
		private AqsatManager	_Manager;

		#endregion

		#region Constructor

		public Form_TasviehAqsat(long IdHead, long IdRadif)
		{
			_idHead = IdHead;
			_idRadif = IdRadif;
			_Manager = new AqsatManager();
			InitializeComponent();
		}

		#endregion
		#region Methods

		private void LoadAqsat()
		{
			_Aqsat = _Manager.GetItem(_idHead);
			if (_Aqsat == null)
			{
				MS_Message.Show("سیستم قادر به خواندن اطلاعات اقساط نیست");
				Panel_Foother.Enabled = false;
				return;
			}

			var riz = _Aqsat.AqsatRizs.SingleOrDefault(x => x.ID == _idRadif);

			if (riz == null)
			{
				MS_Message.Show("سیستم قادر به خواندن اطلاعات اقساط نیست");
				Panel_Foother.Enabled = false;
				return;
			}

			if (!riz.isPardaxt)
			{
				NsDeleteTasvieh.Visible = riz.isPardaxt;
				return;
			}

			NzTarikh.MS_Tarikh	= new MS_Structure_Shamsi(riz.tarixPardaxt);
			NsSharh.Text		= riz.Sharh;

		}

		private bool IsOk()
		{
			if (!NzTarikh.MS_Tarikh.HasValue)
			{
				MS_Message.Show("تاریخ را وارد کنید");
				mS_Notify1.Show(NzTarikh);
				NzTarikh.Focus();
				return false;
			}

			return true;
		}

		private void Save()
		{

			if (!IsOk())
				return;
			_Manager = new AqsatManager();

			var riz				= _Aqsat.AqsatRizs.SingleOrDefault(x => x.ID == _idRadif);
			riz.isPardaxt		= true;
			riz.tarixPardaxt	= NzTarikh.MS_Tarikh.Value.ToDatetime().Date;
			riz.Sharh			= NsSharh.Text;
			riz.State			= Enums.NzItemState.Modified;
			//===================================

			_Aqsat.IsTasvie = _Aqsat.AqsatRizs.All(x => x.isPardaxt);

			_Manager.Save(_Aqsat);
			NsDeleteTasvieh.Visible = riz.isPardaxt;

		}
		#endregion

		#region Events

		private void Form_TasviehAqsat_Load(object sender, EventArgs e)
		{
			LoadAqsat();
		}

		private void NsSave_Click(object sender, EventArgs e)
		{
			try
			{
				Save();
				new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
						Form_Notify.FarsiMessageBoxIcon.اضافه)
					.Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show("خطا در برنامه", "", ex.Message, MessageBoxButtons.OK);
			}

		}

		private void NsDeleteTasvieh_Click(object sender, EventArgs e)
		{
			try
			{
				var r = MS_Message.Show("آیا برای حذف مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo);
				
				if (r != DialogResult.Yes) 
					return; 

				var riz = _Aqsat.AqsatRizs.SingleOrDefault(x => x.ID == _idRadif);
				
				riz.isPardaxt = false;
				riz.tarixPardaxt = null;
				riz.Sharh = null;
				riz.State = Enums.NzItemState.Modified;
				//===================================

				_Aqsat.IsTasvie = _Aqsat.AqsatRizs.All(x => x.isPardaxt);

				_Manager.Save(_Aqsat);
				NsDeleteTasvieh.Visible = riz.isPardaxt;
			}
			catch (Exception ex)
			{
				MS_Message.Show("خطا در برنامه", "", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}
		}
		private void Form_TasviehAqsat_KeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.F2)
				NsSave.PerformClick();
		}
		#endregion


	}
}
