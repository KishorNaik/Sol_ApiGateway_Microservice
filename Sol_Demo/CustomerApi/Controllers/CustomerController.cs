using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerApi.Controllers
{
    [Produces("application/json")]
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet("getcustomer")]
        public IActionResult GetCustomerName()
        {
            return base.Ok((Object)"Kishor Naik");
        }
    }
}