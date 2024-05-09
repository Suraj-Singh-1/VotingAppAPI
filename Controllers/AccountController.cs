using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VotingAppAPI.Services.IServices;

namespace VotingAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        ILoginService _loginService;
        public AccountController(ILoginService loginService) 
        {
            _loginService= loginService;
        }


        [HttpGet(Name = "login")]
        public IActionResult Login()
        {
            try
            {
                var isValidUser = _loginService.isUserValid("ahdb","ahdb");
                return Ok(isValidUser);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
