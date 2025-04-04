using AutoMapper;
using BusinessLayer.DTO;
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

        public void Delete(CityDTO cityDTO, int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<City>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CityDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(CityDTO cityDTO, int id)
        {
            throw new NotImplementedException();
        }
    }
}
