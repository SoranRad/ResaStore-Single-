using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.RestApi
{
	public class RestApiOptions
	{
		public RestApiOptions(RestClient restClient, TokenDto tokens)
		{
			RestClient = restClient;
			Tokens = tokens;
		}

		public RestApiOptions(RestClient restClient)
		{
			RestClient = restClient;
		}

		public RestClient RestClient { get; set; }
		public TokenDto Tokens { get; set; }



	}
}
