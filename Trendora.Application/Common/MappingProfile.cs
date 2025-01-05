using AutoMapper;
using Trendora.Application.DTO.Catagory;
using Trendora.Domain.Models;

namespace Trendora.Application.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Catagory, CreateCatagoryDto>().ReverseMap();
            CreateMap<Catagory, UpdateCatagoryDto>().ReverseMap();
            CreateMap<Catagory, CatagoryDto>().ReverseMap();
        }
    }
}
