using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsManagerApp.Controllers
{
    [Route("api/metrics/network")]
    [ApiController]
    public class NetworkController : ControllerBase
    {
        [HttpGet ("from/{fromTime}/to/{toTime}/")]
        public IActionResult GetMetricsByNetwork ([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
//api / metrics / network / from /{ fromTime}/ to /{ toTime}/
