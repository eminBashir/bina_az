using AutoMapper;
using BusinessLayer.DTO;
using BusinessLayer.DTO.CityDTO_s;
using BusinessLayer.DTO.RegionDTO_s;
using DataLayer.Models;

namespace BusinessLayer.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<City, CityDTO>().ReverseMap();
            CreateMap<City, CityWithRegionDTO>().ReverseMap();
            CreateMap<Region, RegionCreateDTO>().ReverseMap();
            CreateMap<Region, RegionGetDto>().ReverseMap();
            CreateMap<Region, RegionDTO>().ReverseMap();
        }
    }
}
