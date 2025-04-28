using BusinessLayer.DTO.CategoryDTO_s;

namespace BusinessLayer.Services.Interfaces
{
    public interface ICategoryService
    {
        Task Create(CategoryDTO categoryCreateDTO);
        Task<CategoryDTO> GetById(int id);
        Task<List<CategoryDTO>> GetAllAsync();
        Task Update(CategoryDTO categoryDTO, int id);
        Task Delete(int id);
    }
}
