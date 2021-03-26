using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MetricsManagerApp.Controllers
{
    [Route("api/metrics/ram/available")]
    [ApiController]
    public class RAMController : ControllerBase
    {
        static void FreeRAM()
        {
            //найти подходящее пространство имен. System.Menegment; не определяется VS. 
        }
    }
}
//api/metrics/ram/available (размер свободной оперативной памяти в мегабайтах)