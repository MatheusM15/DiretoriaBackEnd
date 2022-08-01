using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Web.Controllers
{
    [Route("Member")]
    [ApiController]
    public class MemberController : Controller
    {
        private readonly IMemberServices _services;
        public MemberController(IMemberServices services)
        {
            _services = services;
        }
        [HttpGet("GetByName/{name}")]
        public IActionResult GetByName(string name)
        {
            try
            {
                return Ok(_services.GetByName(name));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
