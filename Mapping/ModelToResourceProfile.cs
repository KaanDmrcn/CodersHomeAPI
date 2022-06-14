using AutoMapper;
using CodersHomeAPI.Domain.Models;
using CodersHomeAPI.Resources;

namespace CodersHomeAPI.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<Product, ProductResource>();
        }
    }
}
