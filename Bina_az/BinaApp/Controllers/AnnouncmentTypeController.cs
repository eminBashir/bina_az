using BusinessLayer.DTO.AnnouncTypeDTO_s;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BinaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncmentTypeController : ControllerBase
    {
        private readonly IAnnouncmentTypeService announcmentTypeService;

        public AnnouncmentTypeController(IAnnouncmentTypeService announcmentTypeService)
        {
            this.announcmentTypeService = announcmentTypeService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(AnnouncmentTypeDTO ancmntTypDto)
        {
            await announcmentTypeService.Create(ancmntTypDto);
            return Ok(ancmntTypDto);
        }

        [HttpGet("Get all")]
        public async Task<IActionResult> GetAll()
        {
            var result = await announcmentTypeService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await announcmentTypeService.GetById(id);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(AnnouncmentTypeDTO announcmentTypeDTO, int id)
        {
            await announcmentTypeService.Update(announcmentTypeDTO, id);
            return Ok(announcmentTypeDTO);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await announcmentTypeService.Delete(id);
            return Ok();
        }
    }
}
