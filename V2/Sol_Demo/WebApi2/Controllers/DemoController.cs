using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi2.Controllers
{
    [Produces("application/json")]
    [Route("api/demo2")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet("get")]
        public IActionResult GetData()
        {
            return base.Ok("Hello from Web Api 2");
        }
    }
}