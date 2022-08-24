using AutoMapper;
using HeroesApp.Data.Models;
using HeroesApp.Models.Dtos;

namespace HeroesApp.Common.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Hero, HeroDto>().ReverseMap();
            CreateMap<Rating, RatingDto>().ReverseMap();
        }
    }
}
