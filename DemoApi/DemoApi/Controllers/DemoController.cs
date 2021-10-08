using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{    
    [ApiController]
    [Route("Demo")]
    public class DemoController
    {
        [HttpGet]
        public String Get()
        {
            return "Hello World";
        }

    }
}
