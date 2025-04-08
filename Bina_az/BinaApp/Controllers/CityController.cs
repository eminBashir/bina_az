using BusinessLayer.DTO;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BinaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CityDTO cityDTO)
        {
            await _cityService.Create(cityDTO);
            return Ok(cityDTO);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _cityService.GetById(id);
            return Ok(result);
        }

        [HttpGet("Get all")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _cityService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("GetCityRegions/{id}")]
        public async Task<IActionResult> GetCityWithRegions(int id)
        {
            var result = await _cityService.GetCityWithRegions(id);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(CityDTO cityDTO, int id)
        {
            await _cityService.Update(cityDTO, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _cityService.Delete(id);
            return NoContent();
        }

     

    }
}
