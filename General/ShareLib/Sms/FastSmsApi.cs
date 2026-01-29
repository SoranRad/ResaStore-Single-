using RestSharp;
using ShareLib.RestApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyDevs.ResultCore;

namespace ShareLib.Sms
{
	public class FastSmsApi : BaseApi
	{
		public FastSmsApi(RestApiOptions options) : base(options)
		{
		}

		public async Task<string> GetToken(string Username, string Password)
		{
			var url = "api/Login/Token";

			var user = new { Username, Password };
			var result = await PostAsync<Result<string>>(url, user);

			return result?.Data?.Data;
		}

		public async Task<Result> SendSms(FastSendSmsDto model, string token)
		{
			RestClient = HttpClientFactory.Create(base.RestClient.Options.BaseUrl, token);
			var url = "api/FastSms/Send";
			var result = await PostAsJsonbodyAsync<Result>(url, model);

			return result.Data;
		}

	}
}
