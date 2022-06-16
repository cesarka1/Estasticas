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
            [Route ("GetMedia")]
            public ActionResult<double> GetMedia(string m)
            {
                Media media = new Media();
                return media.CalcularMedia(m);
            }

        }
}
