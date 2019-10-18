using AutoMapper;
using SimpleAPI.Domain.Models;
using SimpleAPI.Resources;

namespace SimpleAPI.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Sport, SportResource>();
        }
    }
}