using log4net;
using MS_Control;
using Nz.Anbar.Model.Model;
using Nz.Order.Winforms.Helpers;
using Nz.Order.Winforms.Settings;
using NZ.Anbar.Business;
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nz.Order.Winforms.App
{
	public partial class FormCategory : Form
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
				(System.Reflection
					.MethodBase
					.GetCurrentMethod()
					.DeclaringType);
		#endregion
		#region Fields
		private Manager _Manager; 
		private OrderingSyncClient _client;
		#endregion

		public FormCategory()
		{
			InitializeComponent();
			this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
			_Manager = new Manager();
		}


		#region Methods
		private void			RefreshGrid_SubGroup			()
		{
			try
			{
				
				NsGridSubGroup.DataSource = 
					_Manager.GetList<SubGroup>(new 
						{ FkGroup1 =   (short?)null  })?.ToList();
			}
			catch (Exception ex)
			{
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}
		}
		private async Task		RefreshGrid_RemoteCategory		()
		{
			var client = OrderingSyncClient.GetInstance();

			var result = await client.GetCategoriesAsync();

			if (!result.IsSuccess)
			{
				MS_Message.Show("سیستم قادر به اتصال یه سامانه نیست");
				return;
			}

			NsGridRemote.DataSource = result.Data.ToList();
		}
		#endregion

		private async void		FormCategory_Shown				(object sender, EventArgs e)
		{
			RefreshGrid_SubGroup();
			await RefreshGrid_RemoteCategory();
		}
		private async void		NsSync_Click					(object sender, EventArgs e)
		{
			try
			{
				NsSync.Enabled = false;

				if (!NsGridSubGroup.GetCheckedRows().Any())
				{
					MS_Message.Show("لطفا یک یا چند ردیف را انتخاب کنید");
					return;
				}

				var client = OrderingSyncClient.GetInstance();
				if (client == null)
				{
					MS_Message.Show("امکان ارتباط با سرور وجود ندارد.");
					return;
				}

				var testResult = await client.TestConnectionAsync();
				if (!testResult.IsSuccess)
				{
					MS_Message.Show("امکان ارتباط با سرور وجود ندارد.", "قطع ارتباط", testResult.Message,
						MessageBoxButtons.OK);
					return;
				}

				var subGroups = NsGridSubGroup
					.GetCheckedRows()
					.Select(x => x.DataRow as SubGroup)
					.Where(x => x != null)
					.Select(x => new SyncCategoryDto
						{ Code = x.Code, Title = x.title });

				var result =
					await client.ImportCategoriesAsync(new ReadOnlyCollection<SyncCategoryDto>(subGroups.ToList()));

				if (result.IsSuccess)
				{
					MS_Message.Show("ارسال اطلاعات با موفقیت انجام شد.");
				}
				else
				{
					MS_Message.Show
					(
						"ارسال اطلاعات با خطا مواجه شد.",
						"خطای ارسال",
						result.Message,
						MessageBoxButtons.OK
					);
				}


			}
			catch (Exception ex)
			{
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}
			finally
			{
				NsSync.Enabled = true;
			}
		}
		private async void		NsRefresh_Click					(object sender, EventArgs e)
		{
			await RefreshGrid_RemoteCategory();
			RefreshGrid_SubGroup();
		}
	}
}
