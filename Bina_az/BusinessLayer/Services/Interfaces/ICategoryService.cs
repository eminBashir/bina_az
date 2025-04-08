using BusinessLayer.DTO;
using BusinessLayer.DTO.CategoryDTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
