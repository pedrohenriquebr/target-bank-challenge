using Microsoft.AspNetCore.Mvc;
using TargetInvestimentos.Api.Adapters;
using TargetInvestimentos.Api.Models;
using TargetInvestimentos.Api.Services;
using TargetInvestimentos.Domain.Entities;
using TargetInvestimentos.Domain.Interfaces;
using TargetInvestimentos.Domain.Validations;
using TargetInvestimentos.Infrastructure;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TargetInvestimentos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestimentosController : ControllerBase
    {

        private Context _context;
        private readonly IClientService _service;

        public InvestimentosController(Context context)
        {
            _context = context;
            _service = new ClientService(context);
        }

        [HttpPost("client")]
        public async Task<IActionResult> PostClient([FromBody] RegisterClientCommand command)
        {
            try
            {
                var entity = InvestimentosAdapter.RegisterModelToEntity(command);
                await _service.RegisterClient(entity);

                return Ok(new RegisterClientResult
                {
                    Cadastrado = true,
                    OferecerPlanoVip = ClientValidations.ValidateIsVip(entity)
                });

            }catch(Exception e)
            {
                return BadRequest(new
                {
                    Message = e.Message,
                    Cadastrado = false
                });
            }
        }

    }
}
