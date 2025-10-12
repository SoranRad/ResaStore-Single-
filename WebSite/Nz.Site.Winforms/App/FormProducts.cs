using Janus.Windows.EditControls;
using MS_Control;
using Nz.Site.Model.Models;
using Nz.Site.Model.Report;
using Nz.Site.WinForms.Settings;
using ShareLib;
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nz.Site.Business;
using NZ.Xazane.Model.Report;
using WooCommerceNET;
using WooCommerceNET.Base;
using WooCommerceNET.WooCommerce.v3;

namespace Nz.Site.Winforms.App
{
	public partial class FormProducts : Form
	{
		#region Logging
		private static readonly log4net.ILog 
			log =
				log4net
					.LogManager
					.GetLogger
						(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion

		private SettingItems		_settingItems;
		private List<Product>		_products		= new List<Product>();
		private List<ProductDto>	_productDtos	= new List<ProductDto>();

		public FormProducts()
		{
			InitializeComponent();
			_settingItems = Form_Factory._Form_Factory_Site.GetSettings() as SettingItems ;

		}

		private bool IsOK()
		{
			if (!NsUpdateMeqdar.Checked && !NsUpdatePrice.Checked)
			{
				MS_Message.Show("یک مورد را برای بروز رسانی انتخاب کنید" );
				mS_Notify1.Show(NsUpdateMeqdar);
				mS_Notify1.Show(NsUpdatePrice);

				return false;
			}
			if (NsUpdatePrice.Checked && NsPriceKind.SelectedIndex<0)
			{
				MS_Message.Show("نوع قیمت محصول را انتخاب کنید" );
				mS_Notify1.Show(NsUpdateMeqdar);
				mS_Notify1.Show(NsUpdatePrice);

				return false;
			}

			if (!NsGrid.GetCheckedRows().Any())
			{
				MS_Message.Show("نوع قیمت محصول را انتخاب کنید" );
				mS_Notify1.Show(NsGrid);

				return false;
			}


			return true;
		}
		private async Task LoadCategories()
		{
			NzReport.Enabled = false;
			NzLoading2.Show();
			NzLoading2.Invalidate();
			NzReport.Focus();

			try
			{
				RestAPI rest = new RestAPI(_settingItems.WebSite + "/wp-json/wc/v3/", _settingItems.ApiKey, _settingItems.SecretKey);
				WCObject wc = new WCObject(rest);

				var cats = await wc.Category.GetAll();
				var items = cats.Select(x => new UIComboBoxItem(x.name + "(" + x.count + " محصول" + ")", x)).ToArray();

				NsCategories.Items.AddRange(items);
			}
			catch (Exception ex)
			{
				MS_Message.Show("سیستم قادر به خواندن اطلاعات نیست", "خطا در خواندن اطلاعات", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}
			NzReport.Enabled = true;
			NzLoading2.Hide();
		}
		private async void FormProducts_Load(object sender, EventArgs e)
		{
			await LoadCategories();
			//RestAPI rest = new RestAPI(_settingItems.WebSite + "/wp-json/wc/v3/", _settingItems.ApiKey, _settingItems.SecretKey);
			//WCObject wc = new WCObject(rest);


			//var  list = await wc.Product.GetAll();
			//var varia = await wc.Product.Variations.GetAll(97054);
			//ms_Grid.DataSource = list;
			////ms_Grid.DataSource = await wc.Order.GetAll();
			//ms_Grid.RetrieveStructure(true);

			////var options = new RestClientOptions(_settingItems.WebSite + "/wp-json/wc/v3/")
			//{
			//	Authenticator = new HttpBasicAuthenticator(_settingItems.ApiKey, _settingItems.SecretKey)
			//};

			//var client = new RestClient(options,
			//	configureSerialization: s => s.UseSystemTextJson(new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
			//	);

			//var request = new RestRequest("/orders ", Method.Get);

			////var response = await client.GetAsync(request);

			//var list = await client.GetAsync<IEnumerable<Order>>(request);
			//ms_Grid.DataSource = list;
			//ms_Grid.RetrieveStructure(true);
		}

		private async void NzReport_Click(object sender, EventArgs e)
		{
			var parametters			= new Dictionary<string, string>();
			int currentPage			= 1;
			int ordersPerPage		= 100;  
			bool morePagesExist		= true;

			RestAPI rest			= new RestAPI(_settingItems.WebSite + "/wp-json/wc/v3/", _settingItems.ApiKey, _settingItems.SecretKey);
			WCObject wc				= new WCObject(rest);

			_products				= new List<Product>();
			_productDtos			= new List<ProductDto>();
			var variantionTasks		= new List<(Product Product, Task<List<Variation>> VariationTask)>();
			var mgr					= new ReportManager();


			NzReport.Enabled = false;
			NzLoading2.Show();
			NzLoading2.Invalidate();
			NzReport.Focus();

			parametters.Add("page",		currentPage.ToString());
			parametters.Add("per_page", ordersPerPage.ToString());
			parametters.Add("status",	"publish" );

			if (NsStockStatus.SelectedIndex >= 1)
				parametters.Add("stock_status",	NsStockStatus.SelectedItem.Value.ToString() );

			if(NsCategories.SelectedIndex>0)
				parametters.Add("category",	((ProductCategory)NsCategories.SelectedItem.Value).id.ToString() );

			//============================================

			try
			{
				while (morePagesExist)
				{
					parametters["page"]			= currentPage.ToString();
					parametters["per_page"]		= ordersPerPage.ToString();
					var productsPage			= await wc.Product.GetAll(parametters);

					if (productsPage != null && productsPage.Count > 0)
					{
						variantionTasks = productsPage
							.Select(x =>(x, wc.Product.Variations.GetAll(x.id)))
							.ToList();

						await Task.WhenAll(variantionTasks.Where(x => x.Product.type == "variable").Select(t => t.VariationTask));

						var tmp = variantionTasks
							.Where		(x=>x.Product.type!="variable")
							.Select		(x=>x.Product)
							.Select		(x => new ProductDto()
							{
								id					= x.id,
								name				= x.name,
								price				= x.price,
								status				= x.status,
								stock_quantity		= x.stock_quantity,
								stock_status		= x.stock_status,
								type				= x.type,
							});
						_productDtos.AddRange(tmp);

						tmp = variantionTasks
							.Where		(x=>x.Product.type=="variable")
							.SelectMany	(x=>x.VariationTask.Result.Select(y=>(x.Product,y)))
							.Select		(x => new ProductDto()
							{
								id					= x.Product.id,
								name				= x.Product.name,
								price				= x.y.price,
								status				= x.y.status,
								stock_quantity		= x.y.stock_quantity,
								stock_status		= x.y.stock_status,
								type				= x.Product.type,
								VariationId			= x.y.id,
								VariationAttributes = string.Join(" , ", x.y.attributes.Select(w=>w.name+ " "+ w.option)),
							});

						_productDtos.AddRange(tmp);
						_products.AddRange(productsPage);
						currentPage++;

						NsGrid.DataSource = _productDtos;
						NsGrid.Refetch();
						NsGrid.Invalidate();
					}
					else
					{
						morePagesExist = false;
					}

					if (_productDtos.Any())
					{
						var objects = mgr.GetReport<SyncObjectsInProducts>(new {Year = SystemConstant.ActiveYear.Salmali},null);

						_productDtos =
							(
								from productDto		in _productDtos
								join nsObject		in objects 
								on	new {id1 = (long?)productDto.id,		id2 = (long?)productDto.VariationId} equals 
									new {id1 = nsObject.WebSiteProductId1,	id2 = nsObject.WebSiteProductId2}
								into productGrouped
								from nsObject in productGrouped.DefaultIfEmpty()
								select new ProductDto
								{
									id						= productDto.id,
									name					= productDto.name,
									price					= productDto.price,
									status					= productDto.status,
									stock_quantity			= productDto.stock_quantity,
									stock_status			= productDto.stock_status,
									type					= productDto.type,
									VariationId				= productDto.VariationId,
									VariationAttributes		= productDto.VariationAttributes,
									
									Code					= nsObject?.Code,
									IdObject				= nsObject?.ID,
									SubGroupTitle			= nsObject?.SubGroupTitle,
									TitleObject				= nsObject?.ObjectTitle,
									nerkh_frosh				= nsObject?.nerkh_frosh,
									nerkh_frosh1			= nsObject?.nerkh_frosh1,
									nerkh_frosh2			= nsObject?.nerkh_frosh2,
									nerkh_frosh3			= nsObject?.nerkh_frosh3,
									Remain					= nsObject?.Remain,
								}).ToList();

						NsGrid.DataSource = _productDtos.ToList();

					}
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

		private async void NsUpdate_Click(object sender, EventArgs e)
		{
			NzReport.Enabled = false;
			NzLoading2.Show();
			NzLoading2.Invalidate();

			try
			{
				if(!IsOK())
					return;

				RestAPI rest			= new RestAPI(_settingItems.WebSite + "/wp-json/wc/v3/", _settingItems.ApiKey, _settingItems.SecretKey);
				WCObject wc				= new WCObject(rest);

				Task<BatchObject<Product>> SimpleTask = null;
				IEnumerable<Task<Variation>> VariationTask;


				var CheckedRows = NsGrid.GetCheckedRows().Select(x => x.DataRow as ProductDto);

				if (CheckedRows.Any(x => x.type == "simple"))
				{

					BatchObject<Product> bc = new BatchObject<Product>();

					var simple = CheckedRows.Where(x => x.type == "simple").Select(p =>
					{
						Product up = new Product();

						up.id = p.id;
						if (NsUpdateMeqdar.Checked)
						{
							up.manage_stock = true;
							up.stock_quantity = Convert.ToInt32(p.Remain);
						}

						if (NsUpdatePrice.Checked)
						{
							switch (NsPriceKind.SelectedIndex)
							{
								case 0: up.regular_price = p.nerkh_frosh; break;
								case 1: up.regular_price = p.nerkh_frosh1; break;
								case 2: up.regular_price = p.nerkh_frosh2; break;
								case 3: up.regular_price = p.nerkh_frosh3; break;
							}
						}
						return up;
					});
					
					bc.update= simple.ToList();
					SimpleTask = wc.Product.UpdateRange(bc);
				}

				if (CheckedRows.Any(x => x.type == "variable"))
				{
					VariationTask = CheckedRows.Where(x => x.type == "variable")//.GroupBy(x => x.id)
						.Select(parent =>
						{
							Variation vu = new Variation();

								vu.id = parent.VariationId;

								if (NsUpdateMeqdar.Checked)
								{
									vu.manage_stock = true;
									vu.stock_quantity = Convert.ToInt32(parent.Remain);
								}

								if (NsUpdatePrice.Checked)
								{
									switch (NsPriceKind.SelectedIndex)
									{
										case 0: vu.regular_price = parent.nerkh_frosh; break;
										case 1: vu.regular_price = parent.nerkh_frosh1; break;
										case 2: vu.regular_price = parent.nerkh_frosh2; break;
										case 3: vu.regular_price = parent.nerkh_frosh3; break;
									}
								}

								 
							return wc.Product.Variations.Update(parent.VariationId.Value, vu,parent.id.Value);

							//BatchObject<Variation> bcVariables = new BatchObject<Variation>();

							//var b = parent.Select(v =>
							//{
							//	Variation vu = new Variation();

							//	vu.id = v.id;

							//	if (NsUpdateMeqdar.Checked)
							//		vu.stock_quantity = Convert.ToInt32(v.Remain);

							//	if (NsUpdatePrice.Checked)
							//	{
							//		switch (NsPriceKind.SelectedIndex)
							//		{
							//			case 0: vu.regular_price = v.nerkh_frosh; break;
							//			case 1: vu.regular_price = v.nerkh_frosh1; break;
							//			case 2: vu.regular_price = v.nerkh_frosh2; break;
							//			case 3: vu.regular_price = v.nerkh_frosh3; break;
							//		}
							//	}

							//	return vu;
							//});

							//bcVariables.update=b.ToList();
							//return wc.Product.Variations.UpdateRange(parent.Key.Value, bcVariables);;
						});

					if (SimpleTask != null)
					{
						var r = await SimpleTask;
					}
					if (VariationTask != null && VariationTask.Any())
					{
						var r = await Task.WhenAll(VariationTask);
					}
				}
				

				MS_Message.Show("اطلاعات با موفقیت بروز رسانی شد.");
			}
			catch (Exception ex)
			{
				MS_Message.Show("سیستم قادر به خواندن اطلاعات نیست", "خطا در خواندن اطلاعات", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}

			NzReport.Enabled = true;
			NzLoading2.Hide();
		}

		private void NsUpdatePrice_CheckedChanged(object sender, EventArgs e)
		{
			NsPriceKind.Enabled = NsUpdatePrice.Checked;
		}
	}
}
