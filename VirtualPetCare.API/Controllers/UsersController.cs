using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VirtualPetCare.Core.DTOs.User;
using VirtualPetCare.Core.Services;

namespace VirtualPetCare.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IPetService _petService;

        public UsersController(IUserService userService, IPetService petService)
        {
            _userService = userService;
            _petService = petService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var userList = await _userService.GetAllAsync();

            return Ok(userList);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _userService.GetByIdAsync(id);

            return Ok(user);
        }

        [HttpGet("statistics/{id}")]
        public async Task<IActionResult> GetStatisticById(int id)
        {
            var user = await _userService.GetUserStatisticsAsync(id);

            return Ok(user);
        }

        [HttpGet("{id}/pets")]
        public async Task<IActionResult> GetAllPets(int id)
        {
            var pets = await _petService.GetByOwnerIdAsync(id);

            return Ok(pets);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserCreateDto dto)
        {
            var user = await _userService.CreateAsync(dto);

            return CreatedAtAction(nameof(GetById), new { Id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UserUpdateDto dto)
        {
            await _userService.UpdateAsync(id,dto);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userService.RemoveAsync(id);

            return NoContent();
        }
    }
}
