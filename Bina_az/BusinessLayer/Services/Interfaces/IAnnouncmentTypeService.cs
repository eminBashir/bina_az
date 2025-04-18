﻿using BusinessLayer.DTO.AnnouncTypeDTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Interfaces
{
    public interface IAnnouncmentTypeService
    {
        Task<List<AnnouncmentTypeDTO>> GetAllAsync();
        Task<AnnouncmentTypeDTO> GetById(int id);
    }
}
