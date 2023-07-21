using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Secret_Santa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet("SignUp")]
        public async Task<IActionResult> SignUp([FromBody] string UserName, string Password)
        {
            var data = await JwtAuthObj.UserLogin(UserName, Password);
            //if (data.Item2)
            //{
            //    HttpContext.Session.SetString("username", UserName);
            //    string test = HttpContext.Session.GetString("username");
            //}
            return Ok(JsonConvert.SerializeObject(data));
        }
    }
}
