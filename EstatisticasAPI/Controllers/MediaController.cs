using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EstatisticasAPI.Models;

namespace EstatisticasAPI.Controllers
{    
        [Route("[controller]")]
        [ApiController]
        public class MediaController : ControllerBase
        {
            [HttpGet]
            [Route ("GetMedia2")]
            public ActionResult<string> GetMedia2(double valor1, double valor2)
            {
                Media media = new Media();
                string[] valores = {valor1.ToString(), valor2.ToString()};
                return media.CalcularMedia(valores).ToString();
            }

            [HttpGet]
            [Route("GetMedia3")]
            public ActionResult<string> GetMedia3(double valor1,double valor2,double valor3)
            {
                Media media = new Media();
                string[] valores = {valor1.ToString(), valor2.ToString(), valor3.ToString()};
                return media.CalcularMedia(valores).ToString();
                
            }
        }
}
