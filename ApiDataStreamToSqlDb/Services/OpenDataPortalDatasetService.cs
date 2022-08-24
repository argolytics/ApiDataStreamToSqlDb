using Dapper;
using AutoMapper;
using ApiDataStreamToSqlDb.Data;
using ApiDataStreamToSqlDb.Models;
using ApiDataStreamToSqlDb.Dtos;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;

namespace ApiDataStreamToSqlDb.Services
{
    public class OpenDataPortalDatasetService : IOpenDataPortalDatasetService
    {
        private readonly IDataAccess dataAccess;
        private readonly IMapper autoMapper;
        public OpenDataPortalDatasetService(IDataAccess dataAccess, IMapper mapper)
        {
            this.dataAccess = dataAccess;
            this.autoMapper = mapper;
        }
        public async Task<OpenDataPortalPropertyModel> TransformAndMapData(Stream stream)
        {
            var dtoObject = await JsonSerializer.DeserializeAsync<OpenDataPortalPropertyDto>(stream);
            return autoMapper.Map<OpenDataPortalPropertyModel>(dtoObject);
        }
        public async Task<bool> CreatePropertyAsync(OpenDataPortalPropertyModel model)
        {
            var dynParms = new DynamicParameters(model);
            dynParms.Add("@Id", dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Output);
            await dataAccess.SaveData("dbo.spCreateOpenDataPortalPropertyAsync", dynParms);
            model.Id = dynParms.Get<int>("Id");

            return true;
        }
    }
}
