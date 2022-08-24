using ApiDataStreamToSqlDb.Models;
using System.IO;
using System.Threading.Tasks;

namespace ApiDataStreamToSqlDb.Services
{
    public interface IOpenDataPortalDatasetService
    {
        Task<bool> CreatePropertyAsync(OpenDataPortalPropertyModel model);
        Task<OpenDataPortalPropertyModel> TransformAndMapData(Stream stream);
    }
}