using Janus.Windows.EditControls;
using MS_Control;
using Nz.Site.WinForms.Settings;
using ShareLib;
using ShareLib.Utils;
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
using Janus.Windows.GridEX;
using Nz.Site.Business;
using Nz.Site.Model.Models;
using Nz.Site.Model.Report;
using WooCommerceNET;
using WooCommerceNET.WooCommerce.v3;
using WooCommerceNET.WooCommerce.v3.Extension;

namespace Nz.Site.Winforms.App
{
	public partial class FormOrders : Form
	{
		#region Logging
		private static readonly log4net.ILog 
			log =
				log4net
					.LogManager
					.GetLogger
						(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion

		SettingItems _settingItems;
		List<OrderDto> _ordersDto;
		List<Order> _orders;

		public FormOrders()
		{
			InitializeComponent();
			_settingItems = Form_Factory._Form_Factory_Site.GetSettings() as SettingItems ;

			NsOrderStatusFilter
			.Items
			.OfType<UIComboBoxItem>()
			.Where(x=>x.Value!=null)
			.MSZ_ForEach(item =>
			{
				NsStatusOrderUpdate.Items.Add(new DropDownItem(){Text = item.Text,Value = item.Value});
			});
		}

		private void			LoadDetails						()
		{
			if(!NzItems.Checked)
				return;
			if(ms_Grid.CurrentRow?.RowType!=RowType.Record)
				return;
			 
			if (ms_Grid.CurrentRow.DataRow is OrderDto orderDto)
			{
				var order = _orders.SingleOrDefault(x => x.id == orderDto.id);
				if (order== null)
					return;


				//==1. items
				NsGridItems.DataSource = order.line_items;

				//==2. Customer
				var customer			= order.billing;
				nsBillName.Text			= customer?.first_name;
				NsBillLastName.Text		= customer?.last_name;
				NsBillCode.Text			= order.customer_id?.ToString();
				NsBillEmail.Text		= customer?.email;
				NsBillMobile.Text		= customer?.phone;
				NsBillAddress.Text		= customer?.country + " " + customer?.state + " " + customer?.city + " " +
										  customer?.address_1 + " " + customer?.address_2 + " " + customer?.postcode;
				NsCustomerNote.Text		= order.customer_note;
				//==3. Shipp
				var shipp				= order.shipping;
				NsShippName.Text		= shipp?.first_name;
				NsShippLastName.Text	= shipp?.last_name;
				NsShippCompany.Text		= shipp?.company;
				NsShippAddress.Text		= shipp?.country + " " + shipp?.state + " " + shipp?.city + " " +
					                      shipp?.address_1 + " " + shipp?.address_2 + " " + shipp?.postcode;


			}

		}
		
		private async void		FormOrders_Load					(object sender, EventArgs e)
		{
			//RestAPI rest = new RestAPI(_settingItems.WebSite + "/wp-json/wc/v3/", _settingItems.ApiKey, _settingItems.SecretKey);
			//WCObject wc = new WCObject(rest);


			//var list = await wc.Order.GetAll();
			//ms_Grid.DataSource = list;
			////ms_Grid.DataSource = await wc.Order.GetAll();
			//ms_Grid.RetrieveStructure(true);
		}

		private async void		NzReport_Click					(object sender, EventArgs e)
		{
			
			var parametters			= new Dictionary<string, string>();
			int currentPage			= 1;
			int ordersPerPage		= 100;  
			bool morePagesExist		= true;
			RestAPI rest			= new RestAPI(_settingItems.WebSite + "/wp-json/wc/v3/", _settingItems.ApiKey, _settingItems.SecretKey);
			WCObject wc				= new WCObject(rest);
			_ordersDto				= new List<OrderDto>();
			_orders					= new List<Order>();
			var mgr					= new ReportManager();


			NzReport.Enabled = false;
			NzLoading2.Show();
			NzLoading2.Invalidate();
			NzReport.Focus();


			if (NzDateFrom.MS_Tarikh.HasValue)
			{
				var d = NzDateFrom.MS_Tarikh.Value.ToDatetime().Date;
				var after = new DateTime(d.Year, d.Month, d.Day, 0, 0, 0, DateTimeKind.Utc);
				parametters.Add("after",after.ToString("yyyy-MM-ddTHH:mm:ssZ"));
			}

			if (NzDateTo.MS_Tarikh.HasValue)
			{
				var d = NzDateTo.MS_Tarikh.Value.ToDatetime().Date;
				var before = new DateTime(d.Year, d.Month, d.Day, 0, 0, 0, DateTimeKind.Utc);
				parametters.Add("before",before.ToString("yyyy-MM-ddTHH:mm:ssZ"));
			}

			if (NsOrderStatusFilter.SelectedIndex >= 1)
				parametters.Add("status",NsOrderStatusFilter.SelectedItem.Value.ToString());

			parametters.Add("page", currentPage.ToString());
			parametters.Add("per_page", ordersPerPage.ToString());


			//=================================================================
			ms_Grid.DataSource = _ordersDto;

			try
			{
				while (morePagesExist)
				{
					parametters["page"] = currentPage.ToString();
					parametters["per_page"] = ordersPerPage.ToString();
					var ordersPage = await wc.Order.GetAll(parametters);


					if (ordersPage != null && ordersPage.Count > 0)
					{
						//var ids = "(" + string.Join(",", ordersPage.Select(x => x.id)) + ")";
						//var factors = mgr.GetReport<SyncOrdersInFactors>(null,ids);


						//var result = ordersPage
						//	.GroupJoin(factors,
						//		order => (long?)order.id, factor => factor.WebSiteId, 
						//		(order, factor) => new { Key = order, Factors = factor });

						//var ttt = result.Select(x => new OrderDto()
						//{
							
						//	Address			= x.Key.shipping?.state +" "+x.Key.shipping?.city+" "+x.Key.shipping?.address_1,
						//	Customer		= x.Key.billing?.first_name +" " +x.Key.billing?.last_name + " " + x.Key.billing?.phone,
						//	date_created	= x.Key.date_created?.ToPersianDate(),
						//	date_paid		= x.Key.date_paid?.ToPersianDate(),
						//	discount_total	= x.Key.discount_total,
						//	id				= x.Key.id,
						//	number			= x.Key.number,
						//	set_paid		= x.Key.set_paid,
						//	shipping_total	= x.Key.shipping_total,
						//	statusTitle		= x.Key.status.NzWebsiteStateOrderToPersian(),
						//	total			= x.Key.total,
						//	FactorDate = x.Factors.SingleOrDefault()?.tarikh.ToPersianDate(),
						//	FactorId = x.Factors.SingleOrDefault()?.ID,
						//	Serial = x.Factors.SingleOrDefault()?.Serial
						//});

						var tt = ordersPage.Select(x => new OrderDto()
						{
							
							Address			= x.shipping?.state +" "+x.shipping?.city+" "+x.shipping?.address_1,
							Customer		= x.billing?.first_name +" " +x.billing?.last_name + " " + x.billing?.phone,
							date_created	= x.date_created?.ToPersianDate(),
							date_paid		= x.date_paid?.ToPersianDate(),
							discount_total	= x.discount_total,
							id				= x.id,
							number			= x.number,
							set_paid		= x.set_paid,
							shipping_total	= x.shipping_total,
							statusTitle		= x.status.NzWebsiteStateOrderToPersian(),
							total			= x.total
						});

						_orders.AddRange(ordersPage);
						_ordersDto.AddRange(tt);
						currentPage++;
					}
					else
					{
						morePagesExist = false;
					}

					ms_Grid.DataSource = _ordersDto;
					ms_Grid.Refetch();
					ms_Grid.Invalidate();
				}

				if (_orders.Any())
				{
					var ids = "(" + string.Join(",", _orders.Select(x => x.id)) + ")";
					var factors = mgr.GetReport<SyncOrdersInFactors>(null,ids);

					var result = _orders
						.GroupJoin(factors,
							order => (long?)order.id, factor => factor.WebSiteId, 
							(order, factor) => new { Key = order, Factors = factor });

					_ordersDto	= result.Select(x => new OrderDto()
						{
							
							Address			= x.Key.shipping?.state +" "+x.Key.shipping?.city+" "+x.Key.shipping?.address_1,
							Customer		= x.Key.billing?.first_name +" " +x.Key.billing?.last_name + " " + x.Key.billing?.phone,
							date_created	= x.Key.date_created?.ToPersianDate(),
							date_paid		= x.Key.date_paid?.ToPersianDate(),
							discount_total	= x.Key.discount_total,
							id				= x.Key.id,
							number			= x.Key.number,
							set_paid		= x.Key.set_paid,
							shipping_total	= x.Key.shipping_total,
							statusTitle		= x.Key.status.NzWebsiteStateOrderToPersian(),
							total			= x.Key.total,
							FactorDate		= x.Factors.SingleOrDefault()?.tarikh.ToPersianDate(),
							FactorId		= x.Factors.SingleOrDefault()?.ID,
							Serial			= x.Factors.SingleOrDefault()?.Serial
						})
						.ToList();

					ms_Grid.DataSource = _ordersDto;
				}

			}
			catch (Exception ex)
			{
				MS_Message.Show("سیستم قادر به خواندن اطلاعات نیست", "خطا در خواندن اطلاعات", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}

			NzReport.Enabled = true;
			NzLoading2.Hide();
		}

		private void			NzItems_CheckedChanged			(object sender, EventArgs e)
		{
			mS_Panel2.Visible = Splitter1.Visible = NzItems.Checked;
			LoadDetails();
		}

		private void			ms_Grid_SelectionChanged		(object sender, EventArgs e)
		{
			LoadDetails();
		}

		private async void		NsUpdateOrders_Click			(object sender, EventArgs e)
		{
			if (!ms_Grid.GetCheckedRows().Any())
			{
				MS_Message.Show("کاربر گرامی یک یا چند ردیف را انتخاب کنید", "خطا", MessageBoxButtons.OK);
				return;
			}

			if (NsStatusOrderUpdate.SelectedIndex < 0)
			{
				MS_Message.Show("کاربر گرامی وضعیت جدید را انتخاب کنید", "خطا", MessageBoxButtons.OK);
				NsStatusOrderUpdate.DroppedDown = true;
				return;
			}

			var state = NsStatusOrderUpdate.SelectedItem as DropDownItem;
			var stateUiItem = state.Value;
			RestAPI rest			= new RestAPI(_settingItems.WebSite + "/wp-json/wc/v3/", _settingItems.ApiKey, _settingItems.SecretKey);
			WCObject wc				= new WCObject(rest);
			OrderBatch bc			= new OrderBatch();


			var updates = ms_Grid
				.GetCheckedRows()
				.Select(x => x.DataRow as OrderDto)
				.Select(x => new Order()
				{
					id = x.id, 
					status = stateUiItem.ToString()
				})
				.ToList();

			bc.update = updates;
			var result = await wc.Order.UpdateRange(bc);

			MessageBox.Show(result.update.Count.ToString());
		}
	}
}
