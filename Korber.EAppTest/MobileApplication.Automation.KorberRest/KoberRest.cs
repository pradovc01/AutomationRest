using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serialization.Json;

namespace MobileApplication.Automation.KorberRest
{
	public class KoberRest
	{
		private string koberAplicationUrl;
		private string url;
		private AuthenticationRest authenticationTicket;

		//connect korber
		private RestClient Connect()
		{
			var korberClient = new RestClient(url);
			korberClient.Authenticator = new NtlmAuthenticator();
			korberClient.AddDefaultHeader("AuthenticationTicket", new JsonSerializer().Serialize(authenticationTicket));
			return korberClient;
		}
		public KoberRest(string url, AuthenticationRest authenticationTicket)
		{
			this.url = $"{url}/odata/";
			this.authenticationTicket = authenticationTicket;
		}
		protected IEnumerable<T> GetRest<T>(string resourceName) where T : class
		{
			var korberClient = Connect();
			var request = new RestRequest(resourceName, Method.GET);
			request.RequestFormat = DataFormat.Json;
			var response = korberClient.Execute<DataKorber<T>>(request);
			if (response.ErrorException != null)
			{
				string message = $"Error retrieving response.  Check inner details for more info Rest call: {resourceName}";
				var twilioException = new Exception(message, response.ErrorException);
				throw twilioException;
			}
			if (response.IsSuccessful)
				return response.Data.Value;
			return null;
		}
	}
}
