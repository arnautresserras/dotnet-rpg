using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character cleric = new Character();

        [HttpGet]
        public ActionResult<Character> Get()
        {
            return Ok(cleric);
        }
    }
}