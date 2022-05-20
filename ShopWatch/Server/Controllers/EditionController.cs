using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopWatch.Server.Services.EditionService;
using ShopWatch.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopWatch.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditionController : ControllerBase
    {
        private readonly IEditionService _editionService;

        public EditionController(IEditionService editionService)
        {
            _editionService = editionService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Edition>>> GetEditions()
        {
            var result = await _editionService.GetEditions();
            return Ok(result);
        }
    }
}
