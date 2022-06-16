using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EstatisticasAPI.Models;

namespace EstatisticasAPI.Controllers
{    
        [Route("[controller]")]
        [ApiController]
        public class MedianaController : ControllerBase
        {
            [HttpGet]
            [Route ("GetMediana")]
            public ActionResult<double> GetMediana(string ValoresSeparadosPorEspaço)
            {
                Mediana mediana = new Mediana();
                return mediana.CalcularMediana(ValoresSeparadosPorEspaço);
            }

        }
}
