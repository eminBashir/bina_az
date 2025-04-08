using BusinessLayer.DTO.CategoryDTO_s;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BinaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryDTO categoryCreateDTO)
        {
            await categoryService.Create(categoryCreateDTO);
            return Ok(categoryCreateDTO);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await categoryService.GetById(id);
            return Ok(result);
        }

        [HttpGet("Get all")]
        public async Task<IActionResult> GetAll()
        {
            var result = await categoryService.GetAllAsync();
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(CategoryDTO categoryDTO,int id)
        {
            await categoryService.Update(categoryDTO,id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await categoryService.Delete(id);
            return Ok();
        }
    }
}
