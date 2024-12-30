using Microsoft.AspNetCore.Mvc;
using System;

namespace SimpleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCurrentTime()
        {
            return Ok(new 
            { 
                CurrentTime = DateTime.Now, 
                Message = "Time from .NET Core API" 
            });
        }
    }
}