using AutoMapper;
using SimpleAPI.Domain.Models;
using SimpleAPI.Resources;

namespace SimpleAPI.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveSportResource, Sport>();
        }
    }
}