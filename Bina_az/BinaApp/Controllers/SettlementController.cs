using BusinessLayer.DTO.SettlementDTO_s;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BinaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettlementController : ControllerBase
    {
        private readonly ISettlementService settlementService;

        public SettlementController(ISettlementService settlementService)
        {
            this.settlementService = settlementService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(SettlementCreateDTO createDTO)
        {
            await settlementService.Create(createDTO);
            return Ok(createDTO);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await settlementService.GetById(id);
            return Ok(result);
        }

        [HttpGet("Get all")]
        public async Task<IActionResult> GetAll()
        {
            var result = await settlementService.GetAllAsync();
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(SettlementDTO settlementDTO, int id)
        {
            await settlementService.Update(settlementDTO, id);
            return Ok(settlementDTO);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await settlementService.Delete(id);
            return NoContent();
        }


    }
}
