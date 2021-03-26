using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using MetricsManagerApp.Controllers;
using System;
using Xunit;

namespace MetricsMnagerAppTests
{
    namespace MetricsManagerTests
    {
        public class CpuControllerUnitTests
        {
            private CPUController controller;

            public CpuControllerUnitTests()
            {
                controller = new CPUController();
            }

            [Fact]
            public void GetMetricsFromAgent_ReturnsOk()
            {
            
                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);

              
                var result = controller.GetMetricsFromAgent(fromTime, toTime);

              
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
        }
        public class DotNetControllerUnitTests
        {
            private DotNetController controller;

            public DotNetControllerUnitTests()
            {
                controller = new DotNetController();
            }

            [Fact]
            public void GetMetricsFromAgent_ReturnsOk()
            {

                
                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);


                var result = controller.GetMetricsFromAgent(fromTime, toTime);


                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
        }
        public class NetworkControllerUnitTests
        {
            private NetworkController controller;

            public NetworkControllerUnitTests()
            {
                controller = new NetworkController();
            }

            [Fact]
            public void GetMetricsFromAgent_ReturnsOk()
            {


                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);


                var result = controller.GetMetricsFromAgent(fromTime, toTime);


                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
        }
    }

}
