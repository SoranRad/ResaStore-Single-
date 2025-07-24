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
using Nz.Anbar.Model.Model;
using Nz.Bar.Bussiness;
using Nz.Bar.Model.Models;
using ShareLib.Models;
using ShareLib.Utils;

namespace Nz.Bar.Winforms.App
{
	public partial class FormCar : Form_Mother_IRANSans
	{

		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion
		private Manager             _Manager;
		private Car					_Item;
		private bool                _Is_Edit = false;
		public event EventHandler   MS_Do_Save;
		private short _id;


		public FormCar(short Id)
		{
			_id = Id;
			InitializeComponent();
			_Manager = new Manager();
			_Item = new Car();
			NzRanande.Refresh_Grid     (null, (byte)3);
		}


		#region Methods
		private void    LoadItem            ()
		{
			try
			{

				_Item = _Manager.GetItem<Car>(new { ID = _id });
				_Is_Edit				= true;


				NzCode.MS_Decimal		= _Item.Code;
				NsPlak.Text				= _Item.Plak;
				NzCartype.Text			= _Item.CarType;
				NzState.SelectedIndex	= _Item.IsDisable ? 1 : 0; 
				NzRanande.MS_Set_Select(_Item.FK_People);

			}
			catch (Exception ex)
			{
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}
		}
		private void    Save                ()
		{
			_Item.Code			= Convert.ToInt16(NzCode.MS_Decimal);
			_Item.FK_People		= (NzRanande.MS_Get_Selected() as People).ID;
			_Item.CarType		= NzCartype.Text;
			_Item.Plak			= NsPlak.Text;
			_Item.IsDisable		= NzState.SelectedIndex == 1;
		}
		private void    Reset               ()
		{
			try
			{
				_Item                   = new Car();
				_Is_Edit                = false;
				MaxCode();
				NzRanande.MS_Set_Select(null);
				NsPlak.Text = "";
				NzCartype.Text = "";
				NzState.SelectedIndex = 0;

				NzRanande.Focus();
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

			var Code = Convert.ToInt16(NzCode.MS_Decimal);
			if(_Item.ID==0 || (_Item.ID>0 && _Item.Code!=Code))
				if (!_Manager.IsCodeUnique<Car>
				    (new
				    { 
					    Code = Code
				    })
				   )
				{
					MS_Message.Show("کد وارد شده تکراری است");
					mS_Notify1.Show(NzCode);
					return false;
				}


			if (NzRanande.MS_Get_Selected() == null)
			{
				NzRanande.Focus();
				mS_Notify1.Show(NzRanande);
				return false;
			}

			if (string.IsNullOrWhiteSpace(NzCartype.Text))
			{
				mS_Notify1.Show(NzCartype);
				NzCartype.Focus();
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
				.GenerateCode<Car, short>
				(0, new
				{
						 
				});

			NzCode.MS_Decimal = Code+1;
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

				if (_Is_Edit)
					Close();
				else
					Reset();
				DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MS_Message.Show("سیستم قادر به ثبت اطلاعات نیست",
					"خطا در ثبت", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}
		}
		private void    ms_Exit_Click       (object sender, EventArgs e)
		{
			Close();
		}
		private void    FormStorage_Shown   (object sender, EventArgs e)
		{
			Init();
		}
		private void    FormStorage_KeyUp   (object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.F2)
				ms_Save.PerformClick();

		}
	}
}
