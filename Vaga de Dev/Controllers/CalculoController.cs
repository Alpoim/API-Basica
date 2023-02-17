using Calculo.Application;
using Calculo.Domain.IApplication;
using Calculo.Domain.Objetos;
using Microsoft.AspNetCore.Mvc;

namespace Calculo.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CalculoController : ControllerBase
    {
        private readonly ICalculoApplication _calculoApplication;

        public CalculoController(ICalculoApplication calculoApplication)
        {
            _calculoApplication = calculoApplication;
        }

        [HttpGet(Name = "Somar")]
        public ActionResult Somar([FromQuery] Numeros numeros)
        {
            try
            {
                return Ok(_calculoApplication.Somar(numeros));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(Name = "Subtrair")]
        public ActionResult Subtrair([FromQuery] Numeros numeros)
        {
            try
            {
                return Ok(_calculoApplication.Subtrair(numeros));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(Name = "Multiplicar")]
        public ActionResult Multiplicar([FromQuery] Numeros numeros)
        {
            try
            {
                return Ok(_calculoApplication.Multiplicar(numeros));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet(Name = "Dividir")]
        public ActionResult Dividir([FromQuery] Numeros numeros)
        {
            try
            {
                return Ok(_calculoApplication.Dividir(numeros));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}