using BusinessLayer.DTO;
using BusinessLayer.DTO.CityDTO_s;
using DataLayer.Models;

namespace BusinessLayer.Services.Interfaces
{
    public interface ICityService
    {
        Task Create(CityDTO cityDTO);
        Task<CityDTO> GetById(int id);
        Task<List<CityDTO>> GetAllAsync();
        Task<CityWithRegionDTO> GetCityWithRegions(int id);
        Task Delete(int id);
        Task Update(CityDTO cityDTO, int id);
    }
}
