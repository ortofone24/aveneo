using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aveneo.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AveneoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "aveneo.API";
        }
    }
}