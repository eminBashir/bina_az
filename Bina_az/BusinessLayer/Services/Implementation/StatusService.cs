using AutoMapper;
using BusinessLayer.DTO.StatusDTO_s;
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
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository statusRepository;
        private readonly IMapper mapper;

        public StatusService(IStatusRepository statusRepository, IMapper mapper)
        {
            this.statusRepository = statusRepository;
            this.mapper = mapper;
        }
        public async Task Create(StatusDTO statusDTO)
        {
            var status = mapper.Map<Status>(statusDTO);
            await statusRepository.Create(status);
            _ = await statusRepository.Save();
        }
        public async Task<List<StatusDTO>> GetAll()
        {
            var statuses = await statusRepository.GetAll();
            var statusDto = mapper.Map<List<StatusDTO>>(statuses);
            return statusDto;
        }

        public async Task<StatusDTO> GetById(int id)
        {
            var status = await statusRepository.GetById(id);

            if (status == null)
            {
                throw new Exception("Status not found");
            }

            var statusDto = mapper.Map<StatusDTO>(status);
            return statusDto;
        }

        public async Task Update(StatusDTO statusDTO, int id)
        {
            var status = await statusRepository.GetById(id);

            if (status == null)
            {
                throw new Exception("Status not found");
            }

            mapper.Map(statusDTO, status);
            await statusRepository.Update(status, id);
            await statusRepository.Save();
        }
        public async Task Delete(int id)
        {
            var status = await statusRepository.GetById(id);

            if (status == null)
            {
                throw new Exception("Status not found");
            }

            await statusRepository.Delete(status);
            await statusRepository.Save();
        }
    }
}
