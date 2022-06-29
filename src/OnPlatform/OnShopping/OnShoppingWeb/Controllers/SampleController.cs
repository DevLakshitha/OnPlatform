using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnShoppingWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class SampleController
    {
        [HttpGet(Name = "GetHelloWorld")]
        public string Get()
        {
            return "Hello World";
        }
    }
}
