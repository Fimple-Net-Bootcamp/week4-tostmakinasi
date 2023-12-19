using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using VirtualPetCare.Core.DTOs.Training;
using VirtualPetCare.Core.Services;

namespace VirtualPetCare.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingService _service;

        public TrainingController(ITrainingService service)
        {
            _service = service;
        }

        [HttpGet("petId")]
        public async Task<IActionResult> GetTrainingHistoriesByPetId(int petId)
        {
            var histories = await _service.GetTrainingHistoriesByPetId(petId);

            return Ok(histories);
        }

        [HttpPost]
        public async Task<IActionResult> AddTrainingToPet([FromBody] AddTrainingToPetDto data)
        {
            await _service.AddTrainingToPet(data);

            return CreatedAtAction(nameof(GetTrainingHistoriesByPetId), new { petId = data.PetId },null);
        }
    }
}
