﻿using BusinessLayer.DTO;
using BusinessLayer.DTO.RegionDTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Interfaces
{
    public interface IRegionService
    {
        Task Create(RegionCreateDTO createDTO);
        Task<RegionGetDto> GetById(int id);
        Task<List<RegionDTO>> GetAllAsync();
        Task Update(RegionDTO regionDTO, int id);
        Task Delete(int id);
        
    }
}
