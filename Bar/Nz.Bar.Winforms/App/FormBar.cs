using MS_Control;
using MS_Control.Controls;
using MS_Control.MainForms;
using MS_Control.Tarikh;
using Nz.Bar.Bussiness;
using Nz.Bar.Model.Models;
using Nz.Bar.Model.Report;
using Nz.Bar.WinForms.Settings;
using NZ.Anbar.Model;
using NZ.General.WinForms.Component;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nz.Bar.Winforms.App
{
    public partial class FormBar : Form_Mother_IRANSans, IForm_Editor
    {
	    #region Logging
	    private static readonly log4net.ILog log =
		    log4net
			    .LogManager
			    .GetLogger
				    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
	    #endregion
	    private Manager             _Manager;
	    private BarFactor			_Item;
	    private bool                _Is_Edit = false, _DoRefresh = true;
	    public event EventHandler   MS_Do_Save;
	    private long				_id;

        public FormBar(long Id)
        {
	        InitializeComponent();
	        _id			= Id;
	        _Manager	= new Manager(); 
	        NzRanande.Refresh_Grid			(null, (byte)3);
	        NzKeshavarz.Refresh_Grid		(null, (byte)3);
	        NzObjectSelection.Refresh_Grid((object)null);
        }


        public void Set_Form_Param(params object[] List_Parametter)
        {
             
        }

		#region Methods
		private void    LoadItem            ()
		{
			try
			{

				_Item = _Manager.GetItem<BarFactor>(new { ID = _id });
				if (_Item == null)
				{
					MS_Message.Show("فاکتور مورد نظر یافت نشد");
					ms_Save.Enabled = false;
					return;
				}
				_Is_Edit					= true;
				
				NzDate.MS_Tarikh			= new MS_Structure_Shamsi(_Item.Tarikh);
				NzSerial.MS_Decimal			= _Item.Serial;
				
				NzRanande.					MS_Set_Select(_Item.FK_Car);
				NzKeshavarz.				MS_Set_Select(_Item.FK_People);
				NzObjectSelection.			MS_Set_Select(_Item.FK_Kala);

				_DoRefresh = false;

				NzVazPorMachin.MS_Decimal		= _Item.VaznPorMachine;
				NzVaznKhaliMachine.MS_Decimal	= _Item.VaznKHaliMachine;
				NzTedadBox.MS_Decimal			= _Item.TedadBox;
				NzVazBoxXali.MS_Decimal			= _Item.VaznKhaliBox;
				NzVaznOft.MS_Decimal			= _Item.VaznOft;
				NzVaznXales.MS_Decimal			= _Item.VaznKHales;

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
				_Item.FK_User_Add	= SystemConstant.ActiveUser.ID;
				_Item.Tarikh_add	= DateTime.Now;
				_Item.kind			= (byte) Enums.NzFactorKind.XaridBar;
			}
			else
			{
				_Item.FK_User_Edit	= SystemConstant.ActiveUser.ID;
				_Item.Tarikh_edit	= DateTime.Now;
			}


			_Item.Tarikh = NzDate.MS_Tarikh.Value.ToDatetime();
			_Item.Serial = Convert.ToInt32(NzSerial.MS_Decimal);

			var car = NzRanande.MS_Get_Selected() as CarList;
			if (car != null)
				_Item.FK_Car = car.ID;
			else
				_Item.FK_Car = null;

			_Item.FK_People			= ((People)NzKeshavarz.MS_Get_Selected()).ID;
			_Item.FK_Kala			= ((NzObject)NzObjectSelection.MS_Get_Selected()).Code;

			_Item.VaznPorMachine	= NzVazPorMachin.MS_Decimal;
			_Item.VaznKHaliMachine	= NzVaznKhaliMachine.MS_Decimal;
			_Item.TedadBox			= NzTedadBox.MS_Decimal;
			_Item.VaznKhaliBox		= NzVazBoxXali.MS_Decimal;
			_Item.VaznOft			= NzVaznOft.MS_Decimal;
			_Item.VaznKHales		= NzVaznXales.MS_Decimal;
			
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

				_Item                   = new BarFactor();
				_Is_Edit                = false;
				MaxCode();
				
				if(settings.DefaultKala>0)
					NzRanande.MS_Set_Select(settings.DefaultKala);
				else 
					NzRanande.MS_Set_Select(null);

				NzDate.MS_Tarikh = new MS_Structure_Shamsi(DateTime.Now);
				NzKeshavarz.MS_Set_Select(null);
				NzRanande.Focus();

				_DoRefresh = false;

				NzVazPorMachin.Text			= 
				NzVaznKhaliMachine.Text		= 
				NzTedadBox.Text				= 
				NzVazBoxXali.Text			= 
				NzVaznOft.Text				= 
				NzVaznXales.Text			= 

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

			var Code = Convert.ToInt16(NzSerial.MS_Decimal);
			if(_Item.ID==0 || (_Item.ID>0 && _Item.Serial!=Code))
				if (!_Manager.IsCodeUnique<BarFactor>
				    (new
				    { 
					    Code
				    })
				   )
				{
					MS_Message.Show("کد وارد شده تکراری است");
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

			if (NzKeshavarz.MS_Get_Selected() == null)
			{
				NzKeshavarz.Focus();
				mS_Notify1.Show(NzKeshavarz);
				return false;
			}
 
			if (NzObjectSelection.MS_Get_Selected() == null)
			{
				NzObjectSelection.Focus();
				mS_Notify1.Show(NzObjectSelection);
				return false;
			}

			if (NzVazPorMachin.MS_Decimal <= 0)
			{
				NzVazPorMachin.Focus();
				mS_Notify1.Show(NzVazPorMachin);
				return false;
			}

			if (NzVaznKhaliMachine.MS_Decimal <= 0)
			{
				NzVaznKhaliMachine.Focus();
				mS_Notify1.Show(NzVaznKhaliMachine);
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
				.GenerateCode<BarFactor, int>
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

			NzVaznXales.MS_Decimal =   (NzVazPorMachin.MS_Decimal	- NzVaznKhaliMachine.MS_Decimal)
			                         - (NzVazBoxXali.MS_Decimal		* NzTedadBox.MS_Decimal)
			                         -  NzVaznOft.MS_Decimal;
			_DoRefresh = true;
		}
		private void	RefreshMount		()
		{
			if(!_DoRefresh)
				return;

			_DoRefresh = false;

			NzMablaq.MS_Decimal = NzVaznXales.MS_Decimal * NzFi.MS_Decimal;

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
		private void	NzPrint_Click		(object sender, EventArgs e)
		{
			if(_Item.ID>0)
				new Print.Print(new List<long>(){_Item.ID}).Show(this);
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
    }
}
