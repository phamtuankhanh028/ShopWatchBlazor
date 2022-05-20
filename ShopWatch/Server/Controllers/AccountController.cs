using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopWatch.Server.Authentication;
using ShopWatch.Shared;

namespace ShopWatch.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private UserAccountService _userAccountService;

        public AccountController(UserAccountService userAccountService)
        {
            _userAccountService = userAccountService;
        }
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ActionResult<UserSession> Login([FromBody] LoginRequest loginRequest)
        {
            var jwtAuthenticationManager = new JwtAuthenticationManager(_userAccountService);
            var userSession = jwtAuthenticationManager.GenerateJwtToken(loginRequest.UserName, loginRequest.Password);
            if(userSession == null)
            {
                return Unauthorized();
            }
            else
            {
                return userSession;
            }
        } 
    }
}
