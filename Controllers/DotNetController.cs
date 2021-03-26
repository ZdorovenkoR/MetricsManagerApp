using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetricsManagerApp.Enums;

namespace MetricsManagerApp.Controllers
{
    [Route("api/metrics/dotnet/errors-count/")]
    [ApiController]
    public class DotNetController : ControllerBase
    {
        [HttpGet("from/{fromTime}/to/{toTime}")]
        public IActionResult ErrorsCount ([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }

    }
}
//api/metrics/dotnet/errors-count/from/{fromTime}/to/{toTime}
