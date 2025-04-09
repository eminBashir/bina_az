using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Http;
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
    }
}
