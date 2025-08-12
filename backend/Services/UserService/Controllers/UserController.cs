using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace UserService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("profile")]
        [Authorize] 
        public IActionResult GetProfile()
        {
           return Ok(new { id = 1, name = "John Doe", role = "Customer" });
        }
    }
}
