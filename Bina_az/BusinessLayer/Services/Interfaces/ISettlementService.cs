using BusinessLayer.DTO.RegionDTO_s;
using BusinessLayer.DTO.SettlementDTO_s;

namespace BusinessLayer.Services.Interfaces
{
    public interface ISettlementService
    {
        Task Create(SettlementCreateDTO createDTO);
        Task<SettlementDTO> GetById(int id);
        Task<List<SettlementDTO>> GetAllAsync();
        Task Update(SettlementDTO settlementDTO, int id);
        Task Delete(int id);
    }
}
