using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using iPet.Logic.Models;
using Newtonsoft.Json;

namespace iPet.Logic.Services
{
    public class LoginServices
    {

        const String URL_BASE = "http:hola/";

        public LoginServices()
        {
        }

        public async Task Login(){

            var url = String.Format("{0}/application/login?email={1}&password={2}", URL_BASE, "username_email", "test123");
            var client = new HttpClient();

            var response = await CallGetService(client, url);
        }

		public async Task<HttpResponseMessage> CallGetService(HttpClient client, string url)
		{
			client.BaseAddress = new Uri(url);

			HttpResponseMessage response = await client.GetAsync(url);

			var result = await response.Content.ReadAsStringAsync();
            var newRecord = JsonConvert.DeserializeObject<Response>(result);

			return response;
		}

		public async Task Sites()
		{

			var url = "https://apis/";
			var client = new HttpClient();

			var response = await CallPostService(client, url);
		}

        async Task<HttpResponseMessage> CallPostService(HttpClient client, String url){

            Authentication obj = new Authentication();
            obj.latitude = "6.2032360134368441";
            obj.longitude = "-75.562890283763409";
            obj.userLatitude = "0";
            obj.userLongitude = "0";
            obj.idType = "123";
            obj.radioInKms = "2";
            obj.filterProperties = new String[]{};

            var request = JsonConvert.SerializeObject(obj);
			var content = new StringContent(request, Encoding.UTF8, "application/json");

            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await client.PostAsync(url, content);

			var result = await response.Content.ReadAsStringAsync();
			var newRecord = JsonConvert.DeserializeObject(result);

			return response;
            
        }
    }
}
