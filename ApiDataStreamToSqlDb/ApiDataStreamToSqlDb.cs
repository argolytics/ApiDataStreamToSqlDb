using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using ApiDataStreamToSqlDb.Services;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using System;
using System.Net.Http.Headers;

namespace ApiDataStreamToSqlDb
{
    public class ApiDataStreamToSqlDb
    {
        private readonly Uri _baseUrl;
        private readonly string _authToken;
        public ApiDataStreamToSqlDb()
        {
            _baseUrl = new Uri("https://opendata.maryland.gov/");
            _authToken = "Basic " + " {{InsertKeyHere}}";
        }

        [FunctionName("ApiDataStreamToSqlDb")]
        public async Task<IActionResult> HttpStart(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "sync-data")] HttpRequest request,
            ILogger log)
        {
            //if (stream is null)
            //{
            //    return new OkObjectResult("Stream is null"); // Todo: better exception handling
            //}
            //await httpClient.GetStreamAsync("https://opendata.maryland.gov/resource/9xq5-z8s2.json?account_id_mdp_field_acctid=0603043312");

            HttpClient httpClient = new();
            httpClient.BaseAddress = _baseUrl;
            
            httpClient.DefaultRequestHeaders.Authorization =  new AuthenticationHeaderValue("Authorization", _authToken);
            HttpResponseMessage response = await httpClient.GetAsync("resource/9xq5-z8s2.json?account_id_mdp_field_acctid=0603043312");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            return new OkObjectResult("Stream retreived.");

            // For when the service bus queue is set up:
            //stream = await httpClient.GetStreamAsync("/9xq5-z8s2.json?account_id_mdp_field_acctid=0603043312");
            //var openDataPortalPropertyModel = await openDataPortalDatasetService.TransformAndMapData(stream);
            //await openDataPortalDatasetService.CreatePropertyAsync(openDataPortalPropertyModel);
            //return new OkObjectResult("Listing created in database.");
        }
    }
}
