using DraftSiteModels.InputModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DraftSiteApi.Controllers
{
    public class UserController : ControllerBase
    {
        public UserController()
        {

        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody]DraftSiteToken model)
        {
            var user = HttpContext.User;

            //if (user == null)
            //    return BadRequest(new { message = "Username or password is incorrect" });

            //var claims = new List<Claim>
            //{
            //    new Claim(ClaimTypes.Name, model.Username)
            //};

            //var userIdentity = new ClaimsIdentity(claims, "login");

            //ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            //await HttpContext.SignInAsync(principal);

            //// return basic user info and authentication token
            //return Ok(new
            //{
            //    user.Username
            //});
            return NotFound();
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> GetProfile([FromBody]DraftSiteToken model)
        {
            return NotFound();
        }
    }
}
