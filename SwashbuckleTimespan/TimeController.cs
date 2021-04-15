using System;
using Microsoft.AspNetCore.Mvc;

namespace SwashbuckleTimespan.Controllers
{
    public class TSResult
    {
        public TimeSpan time { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class TimeController : ControllerBase
    {
        [HttpGet]
        public TSResult Get()
        {
            return new TSResult();
        }
    }
}
