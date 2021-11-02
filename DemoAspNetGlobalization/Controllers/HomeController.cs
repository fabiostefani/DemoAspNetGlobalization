using DemoAspNetGlobalization.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;

namespace DemoAspNetGlobalization.Controllers
{
    [ApiController]  
    [Route("Home")]
    public class HomeController : ControllerBase
    {
        //https://localhost:44336/home?culture=en-US
        //
        //https://localhost:44336/home
        [HttpGet]
        public IActionResult Get([FromServices] IStringLocalizer<Messages> localizer)
        {
            return Ok(new
            {
                Message = localizer["HelloWorld"].Value,
                Message2 = localizer["Teste"].Value,
                Date = DateTime.Now,
                DateUtl = DateTime.UtcNow
            });
        }
    }
}
