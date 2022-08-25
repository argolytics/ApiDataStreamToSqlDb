using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using ApiDataStreamToSqlDb.Services;
using System.Net.Http;
using Microsoft.AspNetCore.Http;

namespace ApiDataStreamToSqlDb
{
    public static class ApiDataStreamToSqlDb
    {
        [FunctionName("ApiDataStreamToSqlDb")]
        public static async Task<IActionResult> HttpStart(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "sync-data")] HttpRequest req,
            ILogger log)
        {
            //if (stream is null)
            //{
            //    return new OkObjectResult("Stream is null"); // Todo: better exception handling
            //}

            HttpClient httpClient = new();

            await httpClient.GetStreamAsync("/9xq5-z8s2.json?account_id_mdp_field_acctid=0603043312");
            
            
            return new OkObjectResult("Stream retreived.");

            // For when the service bus queue is set up:
            //stream = await httpClient.GetStreamAsync("/9xq5-z8s2.json?account_id_mdp_field_acctid=0603043312");
            //var openDataPortalPropertyModel = await openDataPortalDatasetService.TransformAndMapData(stream);
            //await openDataPortalDatasetService.CreatePropertyAsync(openDataPortalPropertyModel);
            //return new OkObjectResult("Listing created in database.");
        }
    }
}
