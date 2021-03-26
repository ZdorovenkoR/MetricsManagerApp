using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace MetricsManagerApp.Controllers
{
    [Route("api/metrics/hdd/left")]
    [ApiController]
    public class HDDController : ControllerBase
    {
        static void  FreeSpaceHDD()
        {
            DriveInfo[] allHDD = DriveInfo.GetDrives();
            foreach (DriveInfo MyHDDInfo in allHDD)
            {

                double freeSpaceInByte = MyHDDInfo.AvailableFreeSpace;
                var freeSpaceInMegabyte = freeSpaceInByte * 1024;
                return;
            }

        }
    }
}

//api/metrics/hdd/left (размер оставшегося свободного дискового пространства в мегабайтах)

