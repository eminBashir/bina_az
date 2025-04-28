using BusinessLayer.DTO.StatusDTO_s;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BinaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IStatusService statusService;

        public StatusController(IStatusService statusService)
        {
            this.statusService = statusService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(StatusDTO statusDTO)
        {
            await statusService.Create(statusDTO);
            return Ok(statusDTO);
        }

        [HttpGet("Get all")]
        public async Task<IActionResult> GetAll()
        {
            var result = await statusService.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await statusService.GetById(id);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(StatusDTO statusDTO, int id)
        {
            await statusService.Update(statusDTO, id);
            return Ok(statusDTO);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await statusService.Delete(id);
            return NoContent();
        }
    }
}
