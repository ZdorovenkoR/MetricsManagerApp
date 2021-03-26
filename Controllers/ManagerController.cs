using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsManagerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
           [HttpPost("register")]
           public IActionResult RegisterAgent ([FromBody] AgentInfo agentInfo)
        {
            return Ok();
        }
            [HttpPut ("eneble/agentId}")]
            public IActionResult EnebleAgentId ([FromRoute] int agentId)
        {
            return Ok();
        }
            [HttpPut("disable/{agentId}")]
            public IActionResult DisableAgentId ([FromRoute] int agentId)
        {
            return Ok();
        }
    }
    public class AgentInfo
    {
        public int AgentId { get; }
        public Uri AgentAddAdress { get; }
    }
}
