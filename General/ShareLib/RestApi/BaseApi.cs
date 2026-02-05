using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using ShareLib.Component;

namespace ShareLib.RestApi
{
	public class BaseApi
	{
		private RestApiOptions _options;
		private static Dictionary<string, string> _headers = new Dictionary<string, string>();


		protected BaseApi(RestApiOptions options)
		{
			Options = options;
		}

		protected RestClient RestClient
		{
			get => _options.RestClient;
			set => _options.RestClient = value;
		}

		public RestApiOptions Options
		{
			get => _options;
			set => _options = value;
		}

		public static void AddOrUpdateHeader(string Key, string Value)
		{
			if (_headers.ContainsKey(Key))
				_headers[Key] = Value;
			else
				_headers.Add(Key, Value);
		}

		private void AddHeaderToRequest(RestRequest restRequest)
		{
			foreach (var header in _headers)
				restRequest.AddHeader(name: header.Key, value: header.Value);
		}

		public RestResponse Get(string Uri)
		{
			var request = new RestRequest(Uri);
			AddHeaderToRequest(restRequest: request);


			var response = RestClient.ExecuteGet(request);

			return response;
		}

		public RestResponse<T> Get<T>(string Uri)
		{
			var request = new RestRequest(Uri);
			AddHeaderToRequest(restRequest: request);


			var response = RestClient.ExecuteGet<T>(request);

			return response;
		}

		public async Task<RestResponse> GetAsync(string Uri)
		{
			var request = new RestRequest(Uri);
			AddHeaderToRequest(restRequest: request);

			var response = await RestClient.ExecuteGetAsync(request);

			return response;
		}

		public async Task<RestResponse<T>> GetAsync<T>(string Uri, params Tuple<string, string>[] QueryParam)
		{
			var request = new RestRequest(Uri);
			AddHeaderToRequest(restRequest: request);

			if (QueryParam != null && QueryParam.Length > 0)
				foreach (Tuple<string, string> param in QueryParam)
				{
					request.AddQueryParameter(param.Item1, param.Item2);
				}

			var response = await RestClient.ExecuteAsync<T>(request);

			return response;

		}
		//public async Task<RestResponse<T>> GetAsync<T>(string Uri,params Tuple<string,object>[] QueryParam)
		//{
		// var request = new RestRequest(Uri);
		// AddHeaderToRequest(restRequest: request);

		// if(QueryParam!=null && QueryParam.Length>0)
		//  foreach (Tuple<string, object> param in QueryParam)
		//  {
		//   request.AddQueryParameter(param.Item1, param.Item2.ToString());
		//  }

		// var response =  await RestClient.ExecuteAsync<T>(request);

		// return response;

		//}

		public async Task<RestResponse<T>> PostAsJsonbodyAsync<T>(string Uri, object Data)
		{
			var request = new RestRequest(Uri, Method.Post);
			AddHeaderToRequest(restRequest: request);


			request.RequestFormat = DataFormat.Json;
			request.AddJsonBody(Data);

			var response = await RestClient.ExecutePostAsync<T>(request);

			return response;
		}

		public RestResponse<T> PostAsJsonBody<T>(string Uri, object Data)
		{
			var request = new RestRequest(Uri, Method.Post);
			AddHeaderToRequest(restRequest: request);

			request.RequestFormat = DataFormat.Json;
			request.AddJsonBody(Data);

			var response = RestClient.ExecutePost<T>(request);

			return response;
		}

		public async Task<RestResponse<T>> PostAsync<T>(string Uri, object Data)
		{
			var request = new RestRequest(Uri, Method.Post);
			AddHeaderToRequest(restRequest: request);

			request.RequestFormat = DataFormat.Json;
			request.AddObject(Data);

			var response = await RestClient.ExecutePostAsync<T>(request);



			return response;
		}

		public async Task<RestResponse<T>> PutAsync<T>(string Uri, object Data)
		{
			var request = new RestRequest(Uri, Method.Put);
			AddHeaderToRequest(restRequest: request);


			request.RequestFormat = DataFormat.Json;
			request.AddObject(Data);


			var response = await RestClient.ExecutePutAsync<T>(request);

			return response;
		}

		public async Task<RestResponse<T>> PutBodyAsync<T>(string Uri, object Data)
		{
			var request = new RestRequest(Uri, Method.Put);
			AddHeaderToRequest(restRequest: request);

			request.RequestFormat = DataFormat.Json;
			request.AddBody(Data);

			var response = await RestClient.ExecutePutAsync<T>(request);

			return response;
		}

		public async Task<RestResponse<T>> PutJsonBodyAsync<T>(string Uri, object Data)
		{
			var request = new RestRequest(Uri, Method.Put);
			AddHeaderToRequest(restRequest: request);

			request.RequestFormat = DataFormat.Json;
			request.AddJsonBody(Data);

			var response = await RestClient.ExecutePutAsync<T>(request);

			return response;
		}

		public RestResponse<T> Put<T>(string Uri, object Data)
		{
			var request = new RestRequest(Uri, Method.Put);
			AddHeaderToRequest(restRequest: request);

			request.RequestFormat = DataFormat.Json;
			request.AddObject(Data);

			var response = RestClient.ExecutePut<T>(request);

			return response;
		}

		public async Task<RestResponse<T>> PostAsync<T>(string Uri)
		{
			var request = new RestRequest(Uri, Method.Post);
			AddHeaderToRequest(restRequest: request);

			request.RequestFormat = DataFormat.Json;

			var response = await RestClient.ExecutePostAsync<T>(request);

			return response;
		}

		public RestResponse<T> Post<T>(string Uri, object Data)
		{
			var request = new RestRequest(Uri, Method.Post);
			AddHeaderToRequest(restRequest: request);

			request.RequestFormat = DataFormat.Json;
			request.AddObject(Data);

			var response = RestClient.ExecutePost<T>(request);

			return response;
		}

		public RestResponse<T> Post<T>(string Uri)
		{
			var request = new RestRequest(Uri, Method.Post);
			AddHeaderToRequest(restRequest: request);

			request.RequestFormat = DataFormat.Json;
			var response = RestClient.ExecutePost<T>(request);

			return response;
		}

		#region Delete Methods

		protected async Task<RestResponse<T>> DeleteAsync<T>(string Uri, object Data, bool fromForm = false)
		{
			var request = new RestRequest(Uri, Method.Delete);
			AddHeaderToRequest(restRequest: request);

			if (fromForm)
			{
				request.RequestFormat = DataFormat.Json;
				request.AddObject(Data);
			}
			else
				request.AddJsonBody(obj: Data);

			return await RestClient.ExecuteAsync<T>(request);
		}

		protected async Task<RestResponse<T>> DeleteAsync<T>(string Uri, params string[][] Query)
		{
			var request = new RestRequest(Uri, Method.Delete);
			AddHeaderToRequest(restRequest: request);

			if (Query != null)
				foreach (var Params in Query)
					request.AddQueryParameter(Params[0], Params[1]);

			return await RestClient.ExecuteAsync<T>(request);
		}

		protected async Task<RestResponse<T>> DeleteAsync<T>(string Uri)
		{
			var request = new RestRequest(Uri, Method.Delete);
			AddHeaderToRequest(restRequest: request);

			request.RequestFormat = DataFormat.Json;
			return await RestClient.ExecuteAsync<T>(request);
		}

		#endregion

	}
}
