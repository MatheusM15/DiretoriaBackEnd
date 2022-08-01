using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Web.Controllers
{
    [Route("Sister")]
    [ApiController]
    public class SisterController : Controller
    {
        private readonly ISisterServices _sisterServices;
        public SisterController(ISisterServices sisterServices)
        {
            _sisterServices = sisterServices;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_sisterServices.GetAll());    

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetByName/{name}")]
        public IActionResult GetByName(string name)
        {
            try
            {
                return Ok(_sisterServices.GetByName(name));
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
