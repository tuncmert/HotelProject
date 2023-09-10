using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {

        [HttpGet("[action]")]
        public IActionResult GenerateToken() 
        {
            return Ok(new CreateToken().GenerateToken());
        }
        [HttpGet("[action]")]
        public IActionResult GenerateTokenAdmin()
        {
            return Ok(new CreateToken().GenerateTokenAdmin());
        }
        [Authorize]
        [HttpGet("[action]")]
        public IActionResult TestToken() 
        {
            return Ok("Welcome");
        }

        [Authorize(Roles ="Admin,Visitor")]
        [HttpGet("[action]")]
        public IActionResult TestTokenAdmin()
        {
            return Ok("Welcome Admin");
        }
    }
}
