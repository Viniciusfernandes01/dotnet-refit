using Microsoft.AspNetCore.Mvc;
using Refit.API.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace Refit.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarshipController : Controller
    {
        private readonly IStarshipsService _starshipsService;

        public StarshipController(IStarshipsService starshipsService)
        {
            _starshipsService = starshipsService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNave(string id)
        {
            var naves = await _starshipsService.GetStarship(id);

            if (naves == null)
                return NotFound(id);
            else
                return Json(naves);
        }
    }
}
