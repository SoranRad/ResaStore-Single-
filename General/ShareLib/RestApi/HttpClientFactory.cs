using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp.Serializers.Json;

namespace ShareLib.RestApi
{
    public class HttpClientFactory
    {
#if DEBUG
		private static Uri address = new Uri("https://smsservice.usra.ir");
#else
        private static Uri address = new Uri("https://smsservice.usra.ir");
#endif

		public static RestClient Create()
		{
			var httpClientHandler = new HttpClientHandler();
			httpClientHandler.ServerCertificateCustomValidationCallback = (msg, cert, chain, errors) => { return true; }; // Ignore SSL errors for local development
			var httpClient = new HttpClient(httpClientHandler);
			httpClient.BaseAddress = address;

			var client = new RestClient(httpClient, configureSerialization: s =>
				s.UseSystemTextJson(new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, PropertyNamingPolicy = null }));

			return client;
		}

		public static RestClient Create(Uri Url)
		{
			var httpClientHandler = new HttpClientHandler();
			httpClientHandler.ServerCertificateCustomValidationCallback = (msg, cert, chain, errors) => { return true; }; // Ignore SSL errors for local development
			var httpClient = new HttpClient(httpClientHandler);
			httpClient.BaseAddress = Url;

			var client = new RestClient(httpClient, configureSerialization: s =>
				s.UseSystemTextJson(new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, PropertyNamingPolicy = null }));

			return client;
		}

		public static RestClient Create(string Token)
		{
			var httpClientHandler = new HttpClientHandler();
			httpClientHandler.ServerCertificateCustomValidationCallback = (msg, cert, chain, errors) => { return true; }; // Ignore SSL errors for local development
			var httpClient = new HttpClient(httpClientHandler);
			httpClient.BaseAddress = address;


			var authenticator = new JwtAuthenticator(Token);
			var options = new RestClientOptions() { Authenticator = authenticator };
			var configSerialize = new ConfigureSerialization(config => config.UseSystemTextJson(new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, PropertyNamingPolicy = null }));

			var client = new RestClient
			(
				httpClient: httpClient
				, options: options
				, configureSerialization: configSerialize
			);

			return client;
		}

		public static RestClient Create(Uri Url, string Token)
		{
			var httpClientHandler = new HttpClientHandler();
			httpClientHandler.ServerCertificateCustomValidationCallback = (msg, cert, chain, errors) => { return true; }; // Ignore SSL errors for local development
			var httpClient = new HttpClient(httpClientHandler);
			httpClient.BaseAddress = Url;


			var authenticator = new JwtAuthenticator(Token);
			var options = new RestClientOptions() { Authenticator = authenticator };
			var configSerialize = new ConfigureSerialization(config => config.UseSystemTextJson(new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, PropertyNamingPolicy = null }));

			var client = new RestClient
			(
				httpClient: httpClient
				, options: options
				, configureSerialization: configSerialize
			);

			return client;
		}

		public static RestApiOptions Generate()
		{
			var httpClientHandler = new HttpClientHandler();
			httpClientHandler.ServerCertificateCustomValidationCallback = (msg, cert, chain, errors) => { return true; }; // Ignore SSL errors for local development
			var httpClient = new HttpClient(httpClientHandler);
			httpClient.BaseAddress = address;

			var client = new RestClient(httpClient, configureSerialization: s =>
				s.UseSystemTextJson(new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, PropertyNamingPolicy = null }));

			return new RestApiOptions(client);
		}

		public static RestApiOptions Generate(Uri Url)
		{
			var httpClientHandler = new HttpClientHandler();
			httpClientHandler.ServerCertificateCustomValidationCallback = (msg, cert, chain, errors) => { return true; }; // Ignore SSL errors for local development
			var httpClient = new HttpClient(httpClientHandler);
			httpClient.BaseAddress = Url;

			var client = new RestClient(httpClient, configureSerialization: s =>
				s.UseSystemTextJson(new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, PropertyNamingPolicy = null }));

			return new RestApiOptions(client);
		}

		public static RestApiOptions Generate(TokenDto Token)
		{
			var httpClientHandler = new HttpClientHandler();
			httpClientHandler.ServerCertificateCustomValidationCallback = (msg, cert, chain, errors) => { return true; }; // Ignore SSL errors for local development
			var httpClient = new HttpClient(httpClientHandler);
			httpClient.BaseAddress = address;


			var authenticator = new JwtAuthenticator(Token.Token);
			var options = new RestClientOptions() { Authenticator = authenticator };
			var configSerialize = new ConfigureSerialization(config => config.UseSystemTextJson(new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, PropertyNamingPolicy = null }));

			var client = new RestClient
			(
				httpClient: httpClient
				, options: options
				, configureSerialization: configSerialize
			);

			return new RestApiOptions(client, Token);
		}

		public static RestApiOptions Generate(Uri Url, TokenDto Token)
		{
			var httpClientHandler = new HttpClientHandler();
			httpClientHandler.ServerCertificateCustomValidationCallback = (msg, cert, chain, errors) => { return true; }; // Ignore SSL errors for local development
			var httpClient = new HttpClient(httpClientHandler);
			httpClient.BaseAddress = Url;


			var authenticator = new JwtAuthenticator(Token.Token);
			var options = new RestClientOptions() { Authenticator = authenticator };
			var configSerialize = new ConfigureSerialization(config => config.UseSystemTextJson(new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, PropertyNamingPolicy = null }));

			var client = new RestClient
			(
				httpClient: httpClient
				, options: options
				, configureSerialization: configSerialize
			);

			return new RestApiOptions(client, Token);
		}


	}
}
