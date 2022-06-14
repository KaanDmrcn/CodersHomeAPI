using AutoMapper;
using CodersHomeAPI.Domain.Models;
using CodersHomeAPI.Resources;

namespace CodersHomeAPI.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
            CreateMap<SaveProductResource, Product>();
        }
    }
}