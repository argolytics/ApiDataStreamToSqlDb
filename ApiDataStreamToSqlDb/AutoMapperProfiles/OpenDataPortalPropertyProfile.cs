using AutoMapper;
using ApiDataStreamToSqlDb.Models;
using ApiDataStreamToSqlDb.Dtos;

namespace ApiDataStreamToSqlDb.AutoMapperProfiles
{
    public class OpenDataPortalPropertyProfile : Profile
    {
        public OpenDataPortalPropertyProfile()
        {
            CreateMap<OpenDataPortalPropertyDto, OpenDataPortalPropertyModel>();
        }
    }
}
