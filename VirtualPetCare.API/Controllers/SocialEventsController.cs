using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VirtualPetCare.Core.DTOs.SocialInteraction;
using VirtualPetCare.Core.Services;

namespace VirtualPetCare.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialEventsController : ControllerBase
    {
        private readonly ISocialInteractionService _service;

        public SocialEventsController(ISocialInteractionService interactionService)
        {
            _service = interactionService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSocialEvent(SocialInteractionCreateDto data)
        {
            await _service.CreateAndStartSocialInteraction(data);

            return Ok();
        }

        [HttpGet("{petId}")]
        public async Task<IActionResult> GetSocialEventsByPetId(int petId)
        {
            var events = await _service.GetSocialInteractionsByPetId(petId);

            return Ok(events);
        }
    }
}
