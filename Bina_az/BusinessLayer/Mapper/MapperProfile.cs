using AutoMapper;
using BusinessLayer.DTO;
using BusinessLayer.DTO.AnnouncTypeDTO_s;
using BusinessLayer.DTO.CategoryDTO_s;
using BusinessLayer.DTO.CityDTO_s;
using BusinessLayer.DTO.RegionDTO_s;
using BusinessLayer.DTO.SettlementDTO_s;
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
            CreateMap<Region, RegionDTO>().ReverseMap();
            CreateMap<Region, RegionSettlementsDTO>().ReverseMap();
            CreateMap<Settlement, SettlementDTO>().ReverseMap();
            CreateMap<Settlement, SettlementCreateDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<AnnouncmentType, AnnouncmentTypeDTO>().ReverseMap();
        }
    }
}
