using Microsoft.AspNetCore.Mvc;
using Mapster;

namespace TestMapster.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
       
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
        [HttpGet("Users")]
        public IActionResult Get()
        {
            PersonalizeMapper.ConfigMapper();
            var user = new User();
            var userDto =user.GetUsers().Adapt<List<UserDto>>();            
            return Ok(userDto);
        }
        
    }
}