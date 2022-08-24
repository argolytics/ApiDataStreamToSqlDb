using ApiDataStreamToSqlDb.Data;
using ApiDataStreamToSqlDb.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(ApiDataStreamToSqlDb.Startup))]

namespace ApiDataStreamToSqlDb
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<IDataAccess, SqlDataAccess>();
            builder.Services.AddSingleton<IOpenDataPortalDatasetService, OpenDataPortalDatasetService>();
            builder.Services.AddAutoMapper(typeof(Startup));
        }
    }
}
