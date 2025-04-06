using AutoMapper;
using BusinessLayer.DTO;
using BusinessLayer.DTO.CityDTO_s;
using BusinessLayer.Services.Interfaces;
using DataLayer.Models;
using RepositoryLayer.Interface;

namespace BusinessLayer.Services.Implementation
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public CityService(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }
        public async Task Create(CityDTO cityDTO)
        {
            var entity = _mapper.Map<City>(cityDTO);
            await _cityRepository.Create(entity);
            _ = await _cityRepository.Save();
        }
        public async Task<List<CityDTO>> GetAllAsync()
        {
            var cities = await _cityRepository.GetAll();
            var cityDtos = _mapper.Map<List<CityDTO>>(cities);
            return cityDtos;
        }

        public async Task<CityDTO> GetById(int id)
        {
            var cityEntity = await _cityRepository.GetById(id);

            if (cityEntity == null)
            {
                throw new Exception("City not found");
            }

            var cityDto = _mapper.Map<CityDTO>(cityEntity);
            return cityDto;
        }

        public async Task Update(CityDTO cityDTO, int id)
        {
            var city = await _cityRepository.GetById(id);

            if (city == null)
            {
                throw new Exception("City not found");
            }
            _mapper.Map(cityDTO, city);
            await _cityRepository.Update(city,id);
            await _cityRepository.Save();
        }

        public async Task Delete(int id)
        {
            var city = await _cityRepository.GetById(id);

            if(city == null)
            {
                throw new Exception("City not found");
            }

            await _cityRepository.Delete(city);
            await _cityRepository.Save();
        }

        public async Task<CityWithRegionDTO> GetCityWithRegions(int id)
        {
            var city = await _cityRepository.GetCityWithRegions(id);

            if(city == null)
            {
                throw new Exception("City not found");
            }
            return _mapper.Map<CityWithRegionDTO>(city);
        }
    }
}
