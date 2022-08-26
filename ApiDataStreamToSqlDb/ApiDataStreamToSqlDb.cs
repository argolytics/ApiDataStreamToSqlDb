using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using System;
using System.Net.Http.Headers;
using System.IO;
using System.Text;

namespace ApiDataStreamToSqlDb
{
    public class ApiDataStreamToSqlDb
    {
        private readonly Uri baseUrl;
        private readonly HttpClient client;
        private readonly string apiKeyId;
        private readonly string apiKeySecret;

        public ApiDataStreamToSqlDb(HttpClient client)
        {
            baseUrl = new Uri("https://opendata.maryland.gov/");
            apiKeyId = "9yyt9inh3wdm4hov1bgdmqwav";
            apiKeySecret = "30byco91x8t1be3hehmsxvoq18kdpkv0ud4hnuz7101odkxedi";
            this.client = client;
        }

        [FunctionName("ApiDataStreamToSqlDb")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, nameof(HttpMethods.Get), Route = null)] 
            HttpRequest request)
        {
            client.BaseAddress = baseUrl;
            string authHeader = apiKeyId + ":" + apiKeySecret;
            client.DefaultRequestHeaders.Authorization = 
                new AuthenticationHeaderValue(
                    "Authorization", "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(authHeader)));
            
            Stream stream = 
                await client.GetStreamAsync("resource/ed4q-f8tm.json?account_id_mdp_field_acctid=0603043312");
            return new OkObjectResult(stream);
        }
    }
}