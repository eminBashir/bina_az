using AutoMapper;
using BusinessLayer.DTO;
using BusinessLayer.DTO.RegionDTO_s;
using BusinessLayer.Services.Interfaces;
using DataLayer.Models;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Implementation
{
    public class RegionService : IRegionService
    {
        private readonly IRegionRepository _regionRepository;
        private readonly IMapper _mapper;

        public RegionService(IRegionRepository regionRepository, IMapper mapper)
        {
            _regionRepository = regionRepository;
            _mapper = mapper;
        }
        public async Task Create(RegionCreateDTO createDTO)
        {
            var entity = _mapper.Map<Region>(createDTO);
            await _regionRepository.Create(entity);
            _ = await _regionRepository.Save();
        }


        public async Task<List<RegionDTO>> GetAllAsync()
        {
            var regions = await _regionRepository.GetAll();
            var regionDto = _mapper.Map<List<RegionDTO>>(regions);
            return regionDto;
        }

        public async Task<RegionGetDto> GetById(int id)
        {
            var regionEntity = await _regionRepository.GetById(id);

            if (regionEntity == null)
            {
                throw new Exception("Region not found");
            }

            var regionDto = _mapper.Map<RegionGetDto>(regionEntity);
            return regionDto;
        }

        public async Task Update(RegionDTO regionDTO, int id)
        {
            var region = await _regionRepository.GetById(id);

            if (region == null)
            {
                throw new Exception("Region not found");
            }

            _mapper.Map(regionDTO, region);
            await _regionRepository.Update(region, id);
            await _regionRepository.Save();
        }

        public async Task Delete(int id)
        {
            var region = await _regionRepository.GetById(id);

            if (region == null)
            {
                throw new Exception("Region not found");
            }

            await _regionRepository.Delete(region);
            await _regionRepository.Save();
        }


    }
}
