using BusinessLayer.DTO;
using DataLayer.Models;

namespace BusinessLayer.Services.Interfaces
{
    public interface ICityService
    {
        Task Create(CityDTO cityDTO);
        Task<CityDTO> GetById(int id);
        Task<List<City>> GetAllAsync();
        void Delete(CityDTO cityDTO, int id);
        void Update(CityDTO cityDTO, int id);
    }
}
