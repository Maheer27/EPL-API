using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services.Users;
using ViewModel;

namespace EPL_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService Userrepo;
        public UserController(IUserService userrepo)
        {
            Userrepo = userrepo;
        }

        [HttpPost]
        public IActionResult  Register(AddUserVM uservm)
        {
            
                if (Userrepo.AddUser(uservm))
                 return Ok();
                else
                return BadRequest();
        }

        [HttpPost]
        public async Task< IActionResult> Login(LoginUserVM loginvm)
        {
            if (await Userrepo.Login(loginvm)!="")
                return Ok();
            else
                return BadRequest();
        }
    }
}
