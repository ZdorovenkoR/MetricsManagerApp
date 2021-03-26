using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetricsManagerApp.Enums;

namespace MetricsManagerApp.Controllers
{
    [Route("api/metrics/cpu")]
    [ApiController]
    public class CPUController : ControllerBase
    {
        [HttpGet("from/{fromTime}/to/{toTime}/percentiles/{percentile}")]
        public IActionResult GetMetricsByPercentFromManager([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime, [FromRoute] Percentile percentile)
        {
            return Ok();
        }
        [HttpGet("from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsFrommanager([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
        [HttpGet("cluster/from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsFromAllCluster([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
        [HttpGet("cluster/from/{fromTime}/to/{toTime}/percentiles/{percentile}")]
        public IActionResult GetMetricsByPercentileFromAllCluster([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime,
            [FromRoute] Percentile percentile)
        {
            return Ok();
        }

    }

}
//api/metrics/cpu/from/{fromTime}/to/{toTime}/percentiles/{percentile}
//api/metrics/cpu//from/{fromTime}/to/{toTime}/
