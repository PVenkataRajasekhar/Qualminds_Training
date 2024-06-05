using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication_Security.Contracts;
using WebApplication_Security.Model;
using System.Threading.Tasks;
using WebApplication_Security.Service;
using WebApplication_Security.Data;
using Microsoft.EntityFrameworkCore;
using WebApplication_Security.Filters;


namespace WebApplication_Security.Controllers
{

    
    [ApiController]
    [Route("api/Users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly Context _context;
        
        public UserController(IUserService userService,Context context)
        {
            _userService = userService;
            _context = context;
           
        }
        [Authorize]
        [ServiceFilter(typeof(LogTrackAttribute))]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserModel>>> Get()
        {
            return await _context.Users.ToListAsync();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<string>> Login(UserModel user)
        {
            if (_userService.ValidateUser(user))
            {
                var token = await _userService.Login(user);
                return Ok(new { Token = token });
            }
            return Unauthorized("Invalid credentials");
        }
    }
}

