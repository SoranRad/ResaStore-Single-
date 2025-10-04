using Nz.Site.WinForms.Settings;
using ShareLib.Utils;
using System; 
using System.Windows.Forms;
using WooCommerceNET;
using WooCommerceNET.WooCommerce.v3;
using WooCommerceNET.WooCommerce.v3.Extension;

namespace Nz.Site.Winforms.App
{
	public partial class FormProducts : Form
	{
		SettingItems _settingItems;
		public FormProducts()
		{
			InitializeComponent();
			_settingItems = Form_Factory._Form_Factory_Site.GetSettings() as SettingItems ;

		}

		private async void FormProducts_Load(object sender, EventArgs e)
		{
			RestAPI rest = new RestAPI(_settingItems.WebSite + "/wp-json/wc/v3/", _settingItems.ApiKey, _settingItems.SecretKey);
			WCObject wc = new WCObject(rest);


			var  list = await wc.Product.GetAll();
			var varia = await wc.Product.Variations.GetAll(97054);
			ms_Grid.DataSource = list;
			//ms_Grid.DataSource = await wc.Order.GetAll();
			ms_Grid.RetrieveStructure(true);

			//var options = new RestClientOptions(_settingItems.WebSite + "/wp-json/wc/v3/")
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
	}
}
