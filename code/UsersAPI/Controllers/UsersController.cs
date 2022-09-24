using Microsoft.AspNetCore.Mvc;

namespace UsersAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class UsersController : ControllerBase
  {
    [HttpGet("GetDateTime")]
    public IActionResult GetDateTime()
    {
      var datetime = new
      {
        Data = DateTime.Now.ToLongDateString(),
        Time = DateTime.Now.ToLongTimeString()
      };

      return Ok(datetime);
    }
  }
}