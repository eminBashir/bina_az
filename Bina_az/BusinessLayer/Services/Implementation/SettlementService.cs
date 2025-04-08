using AutoMapper;
using BusinessLayer.DTO.SettlementDTO_s;
using BusinessLayer.Services.Interfaces;
using DataLayer.Models;
using RepositoryLayer.Interface;

namespace BusinessLayer.Services.Implementation
{
    public class SettlementService : ISettlementService
    {
        private readonly ISettlementRepository settlementRepository;
        private readonly IMapper mapper;

        public SettlementService(ISettlementRepository settlementRepository, IMapper mapper)
        {
            this.settlementRepository = settlementRepository;
            this.mapper = mapper;
        }
        public async Task Create(SettlementCreateDTO createDTO)
        {
            var stlmnt = mapper.Map<Settlement>(createDTO);
            await settlementRepository.Create(stlmnt);
            _ = settlementRepository.Save();
        }
        public async Task<List<SettlementDTO>> GetAllAsync()
        {
            var stlmnts = await settlementRepository.GetAll();
            var stlmntDto = mapper.Map<List<SettlementDTO>>(stlmnts);
            return stlmntDto;
        }

        public async Task<SettlementDTO> GetById(int id)
        {
            var entity = await settlementRepository.GetById(id);

            if (entity == null)
            {
                throw new Exception("Settlement not found");
            }

            var stlmntDto = mapper.Map<SettlementDTO>(entity);
            return stlmntDto;
        }

        public async Task Update(SettlementDTO settlementDTO, int id)
        {
           var stlmnt = await settlementRepository.GetById(id);

            if(stlmnt == null)
            {
                throw new Exception("Settlement not found");
            }

            mapper.Map(settlementDTO, stlmnt); 
            await settlementRepository.Update(stlmnt, id);
            await settlementRepository.Save();
        }
        public async Task Delete(int id)
        {
            var stlmnt = await settlementRepository.GetById(id);

            if(stlmnt == null)
            {
                throw new Exception("Settlement not found");
            }

            await settlementRepository.Delete(stlmnt);
            await settlementRepository.Save();
        }

    }
}
