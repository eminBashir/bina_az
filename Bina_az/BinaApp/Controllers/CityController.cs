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
    }
}
