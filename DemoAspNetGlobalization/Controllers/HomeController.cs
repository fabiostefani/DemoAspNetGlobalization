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
        public IActionResult Get([FromServices] IStringLocalizer localizer, [FromServices] IRegisterUserCommandValidation validation)
        {
            var command = new RegisterUserCommand(string.Empty, string.Empty, string.Empty);
            var result = validation.Validate(command);
            return Ok(new
            {
                Localizer = localizer["HelloWorld"].Value,
                Message2 = localizer["Welcome"].Value,
                Direct = Messages.Teste22,
                Result = result,
                Date = DateTime.Now,
                DateUtc = DateTime.UtcNow
            });
        }
    }
}
