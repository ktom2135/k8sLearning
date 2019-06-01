using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace netCoreApiForDokcer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static int count = 0;

        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            count++;

            if (count < 10)
            {
                return Ok($"Current count is {count}, will fail after {10 - count}");
            }

            return new BadRequestResult();
        }
    }
}
