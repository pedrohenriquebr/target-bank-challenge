using Microsoft.AspNetCore.Mvc;
using TargetInvestimentos.Infrastructure;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TargetInvestimentos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestimentosController : ControllerBase
    {

        private Context _context;

        public InvestimentosController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetStatus()
        {
            return Ok("ok");
        }

    }
}
