using MS_Control; 
using MS_Control.MainForms;
using MS_Control.Tarikh;
using Nz.Bar.Bussiness;
using Nz.Bar.Model.Models;
using Nz.Bar.Model.Report;
using Nz.Bar.WinForms.Settings;
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.Utils;
using System;
using System.ComponentModel; 
using System.Windows.Forms;

namespace Nz.Bar.Winforms.App
{
	public partial class FormErsalKarkhane : Form_Mother_IRANSans, IForm_Editor
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion
		private Manager             _Manager;
		private ErsalKarkhane		_Item;
		private bool                _Is_Edit = false, _DoRefresh = true;
		public event EventHandler   MS_Do_Save;
		private long				_id;

		public FormErsalKarkhane(long Id)
		{
			_id = Id;
			InitializeComponent();
			_id			= Id;
			_Manager	= new Manager(); 
			NzRanande.Refresh_Grid		(null, (byte)3);
			NzKarkhane.Refresh_Grid		(null, (byte)3); 
		}

		 public void Set_Form_Param(params object[] List_Parametter)
        {
	        foreach (var Item in List_Parametter)
	        {
		        if (Item is long ItemID)
			        _id     = (long) ItemID;
	        }

	        Init();
        }

		#region Methods
		private void    LoadItem            ()
		{
			try
			{

				_Item = _Manager.GetItem<ErsalKarkhane>(new { ID = _id });
				if (_Item == null)
				{
					MS_Message.Show("فاکتور مورد نظر یافت نشد");
					ms_Save.Enabled = false;
					return;
				}
				_Is_Edit					= true;
				
				NzDate.MS_Tarikh			= new MS_Structure_Shamsi(_Item.Tarikh);
				NzSerial.MS_Decimal			= _Item.Serial;
				NzShaomareQabz.MS_Decimal	= _Item.ShomareGhabz;

				NzRanande.					MS_Set_Select(_Item.FK_Car);
				NzKarkhane.					MS_Set_Select(_Item.FK_Karkhane);
				NzCustomerKeshavarz.		NzSetCustoemr(_Item.FK_Karkhane);


				_DoRefresh = false;

				NzVazNaKhales.MS_Decimal		= _Item.VaznNaKhales;
				NzVaznKhali.MS_Decimal			= _Item.VaznKHali;
				NzDarsadOft.MS_Decimal			= _Item.DarsadOft;
				NzVazOft.MS_Decimal				= _Item.VaznOft;
				NzVaznKhales.MS_Decimal			= _Item.VaznKHales;


				NzFi.MS_Decimal					= decimal.Ceiling(_Item.Nerkh);
				NzMablaq.MS_Decimal				= decimal.Ceiling(_Item.Mablaq);
				NzMablaqKeraye.MS_Decimal		= decimal.Ceiling(_Item.MablaqKeraye);

				NzDescription.Text				= _Item.Tozihat;

				_DoRefresh = true;
			}
			catch (Exception ex)
			{
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}
		}
		private void    Save                ()
		{
			if (_Item.ID == 0)
			{
				_Item.FK_Salmali	= SystemConstant.ActiveYear.Salmali;
			}
			 

			_Item.Tarikh		= NzDate.MS_Tarikh.Value.ToDatetime();
			_Item.Serial		= Convert.ToInt32(NzSerial.MS_Decimal);
			_Item.ShomareGhabz	= Convert.ToInt32(NzShaomareQabz.MS_Decimal);

			var car = NzRanande.MS_Get_Selected() as CarList;
			if (car != null)
				_Item.FK_Car = car.ID;
			else
				_Item.FK_Car = null;

			_Item.FK_Karkhane		= ((People)NzKarkhane.MS_Get_Selected()).ID;

			_Item.VaznNaKhales		= NzVazNaKhales.MS_Decimal;
			_Item.VaznKHali			= NzVaznKhali.MS_Decimal	;
			_Item.DarsadOft			= NzDarsadOft.MS_Decimal	;
			_Item.VaznOft			= NzVazOft.MS_Decimal		;
			_Item.VaznKHales		= NzVaznKhales.MS_Decimal	;
			
			_Item.Nerkh				= NzFi.MS_Decimal;
			_Item.Mablaq			= NzMablaq.MS_Decimal;
			_Item.MablaqKeraye		= NzMablaqKeraye.MS_Decimal;

			_Item.Tozihat			= NzDescription.Text;

		}
		private void    Reset               ()
		{
			try
			{
				var settings = Form_Factory._Form_Factory_Bar.GetSettings() as SettingItems;

				_Item                   = new ErsalKarkhane();
				_Is_Edit                = false;
				MaxCode();
				
				if(settings.DefaultKala>0)
					NzRanande.MS_Set_Select(settings.DefaultKala);
				else 
					NzRanande.MS_Set_Select(null);

				NzDate.MS_Tarikh = new MS_Structure_Shamsi(DateTime.Now);
				NzKarkhane.MS_Set_Select(null);
				NzRanande.Focus();

				_DoRefresh = false;

				NzVazNaKhales.Text			=
				NzVaznKhali.Text			=
				NzDarsadOft.Text			=
				NzVazOft.Text				=
				NzVaznKhales.Text			= 

				NzFi.Text					= 
				NzMablaq.Text				= 
				NzMablaqKeraye.Text			= "";

				_DoRefresh = true;
				NzDescription.Text			= "";
			}
			catch (Exception ex)
			{
				MS_Message.Show("سیستم قادر به اتصال به بانک اطلاعاتی نیست",
					"خطا در تولید کد", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}
		}
		private bool    IsOK                ()
		{
			if (SystemConstant.ActiveYear.is_close)
			{
				MS_Message.Show("سال مالی بسته شده است \n " +
				                "نمی توانید ادامه دهید ");
				return false;
			}

			if (NzCustomerKeshavarz.IsUserBlocked(_Item.Mablaq))
			{ 
				MS_Message.Show("سقف اعتبار کاربر پرشده است. " +
				                "نمی توانید بیشتر از اعتبار مشتری فاکتور صادر کنید"  );
				NzKarkhane.Focus();
				mS_Notify1.Show(NzKarkhane);
				return false;
			}

			var Code = Convert.ToInt16(NzSerial.MS_Decimal);
			if(_Item.ID==0 || (_Item.ID>0 && _Item.Serial!=Code))
				if (!_Manager.IsCodeUnique<ErsalKarkhane>
				    (new
				    { 
					    Code
				    })
				   )
				{
					MS_Message.Show("سریال وارد شده تکراری است");
					mS_Notify1.Show(NzSerial);
					return false;
				}

			if (NzDate.MS_Tarikh == null)
			{
				NzDate.Focus();
				mS_Notify1.Show(NzDate);
				return false;
			}

			if (NzSerial.MS_Decimal == 0)
			{
				NzSerial.Focus();
				mS_Notify1.Show(NzSerial);
				return false;
			}

			if (NzKarkhane.MS_Get_Selected() == null)
			{
				NzKarkhane.Focus();
				mS_Notify1.Show(NzKarkhane);
				return false;
			}
 
			if (NzVazNaKhales.MS_Decimal <= 0)
			{
				NzVazNaKhales.Focus();
				mS_Notify1.Show(NzVazNaKhales);
				return false;
			}

			if (NzVaznKhali.MS_Decimal <= 0)
			{
				NzVaznKhali.Focus();
				mS_Notify1.Show(NzVaznKhali);
				return false;
			}

			if (NzFi.MS_Decimal <= 0)
			{
				NzFi.Focus();
				mS_Notify1.Show(NzFi);
				return false;
			}

			return true;
		}
		private void    Init                ()
		{
			if (_id > 0)
				LoadItem();
			else
				Reset();
		}
		private void    MaxCode				()
		{
			var Code = _Manager
				.GenerateCode<ErsalKarkhane, int>
				(1, new
				{
					Year = SystemConstant.ActiveYear.Salmali,
				});

			NzSerial.MS_Decimal = Code + 1;
		}

		

		private void	RefreshVazn			()
		{
			if(!_DoRefresh)
				return;

			_DoRefresh = false;

			NzVaznKhales.MS_Decimal = NzVazNaKhales.MS_Decimal - NzVaznKhali.MS_Decimal
			                                                   - NzVazOft.MS_Decimal;
			_DoRefresh = true;
		}
		private void	RefreshMount		()
		{
			if(!_DoRefresh)
				return;

			_DoRefresh = false;

			NzMablaq.MS_Decimal = NzVaznKhales.MS_Decimal * NzFi.MS_Decimal;

			_DoRefresh = true;
		}
		
		#endregion
		private void    ms_Save_Click       (object sender, EventArgs e)
		{
			try
			{
				if (!IsOK())
					return;
				Save();

				_Manager.Save(_Item);

				MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_Item.ID));

				new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
						Form_Notify.FarsiMessageBoxIcon.اضافه)
					.Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);
				Tag = _Item.ID;

				DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MS_Message.Show("سیستم قادر به ثبت اطلاعات نیست", "خطا در ثبت", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}
		}
		private void	NzNew_Click			(object sender, EventArgs e)
		{
			Reset();
		}

		private void    FormStorage_Shown   (object sender, EventArgs e)
		{
			Init();
		}
		private void    FormStorage_KeyUp   (object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.F2)
				ms_Save.PerformClick();
			else if(e.KeyCode==Keys.F4)
				NzNew.PerformClick();
			 
		}

		private void	NzFi_TextChanged	(object sender, EventArgs e)
		{
			RefreshMount();
		}
		private void	Vazn_TextChanged	(object sender, EventArgs e)
		{
			RefreshVazn();
			RefreshMount();
		}

		private void NzDarsadOft_TextChanged(object sender, EventArgs e)
		{
			if(!_DoRefresh)
				return;

			_DoRefresh = false;

			NzVazOft.MS_Decimal = decimal.Ceiling((NzVazNaKhales.MS_Decimal - NzVaznKhali.MS_Decimal) * NzDarsadOft.MS_Decimal / 100);

			_DoRefresh = true;

			RefreshVazn();
			RefreshMount();
		}

		private void	NzKeshavarz_MS_On_Row_Selected(object sender, MS_Control.TSDD.On_Selected e)
		{
			if (NzKarkhane.MS_Get_Selected() == null)
				NzCustomerKeshavarz.Text = "0";
			else
			{
				var tmp = NzKarkhane.MS_Get_Selected() as People;
				NzCustomerKeshavarz.NzSetCustoemr(tmp?.ID ?? 0);
			}
		}

	}
}
