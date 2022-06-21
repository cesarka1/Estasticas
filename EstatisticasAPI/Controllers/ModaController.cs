using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EstatisticasAPI.Models;

namespace EstatisticasAPI.Controllers
{    
        [Route("[controller]")]
        [ApiController]
        public class ModaController : ControllerBase
        {
            [HttpGet]
            [Route ("GetModa")]
            public ActionResult<double> GetModa(string ValoresSeparadosPorEspaço)
            {
                Moda moda = new Moda();
                return moda.CalcularModa(ValoresSeparadosPorEspaço);                                                                    
            }

        }
}
