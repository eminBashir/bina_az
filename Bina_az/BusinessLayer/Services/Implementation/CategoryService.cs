using AutoMapper;
using BusinessLayer.DTO.CategoryDTO_s;
using BusinessLayer.Services.Interfaces;
using DataLayer.Models;
using RepositoryLayer.Interface;

namespace BusinessLayer.Services.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }
        public async Task Create(CategoryDTO categoryCreateDTO)
        {
            var category = mapper.Map<Category>(categoryCreateDTO);
            await categoryRepository.Create(category);
            _ = await categoryRepository.Save();
        }
        public async Task<CategoryDTO> GetById(int id)
        {
            var entity = await categoryRepository.GetById(id);

            if (entity == null)
            {
                throw new Exception("Category not found");
            }

            var ctgryDto = mapper.Map<CategoryDTO>(entity);
            return ctgryDto;
        }
        public async Task<List<CategoryDTO>> GetAllAsync()
        {
            var categories = await categoryRepository.GetAll();
            var ctgrDtos = mapper.Map<List<CategoryDTO>>(categories);
            return ctgrDtos;
        }

        public async Task Update(CategoryDTO categoryDTO, int id)
        {
            var category = await categoryRepository.GetById(id);

            if (category == null)
            {
                throw new Exception("Category not found");
            }

            mapper.Map(categoryDTO, category);
            await categoryRepository.Update(category, id);
            await categoryRepository.Save();
        }

        public async Task Delete(int id)
        {
            var category = await categoryRepository.GetById(id);

            if(category == null)
            {
                throw new Exception("Category not found");
            }

            await categoryRepository.Delete(category);
            await categoryRepository.Save();
        }
    }
}
