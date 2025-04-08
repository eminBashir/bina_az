using BusinessLayer.DTO.RegionDTO_s;
using BusinessLayer.Services.Implementation;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BinaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IRegionService regionService;

        public RegionController(IRegionService regionService)
        {
            this.regionService = regionService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegionCreateDTO createDTO)
        {
            await regionService.Create(createDTO);
            return Ok(createDTO);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await regionService.GetById(id);
            return Ok(result);
        }

        [HttpGet("Get-all")]
        public async Task<IActionResult> GetAll()
        {
            var result = await regionService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("GetRegionSettlements{id}")]
        public async Task<IActionResult> GetRegionSettlement(int id)
        {
            var result = await regionService.GetRegionSettlement(id);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(RegionDTO regionDTO, int id)
        {
            await regionService.Update(regionDTO, id);
            return Ok(regionDTO);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await regionService.Delete(id);
            return NoContent();
        }
    }
}
