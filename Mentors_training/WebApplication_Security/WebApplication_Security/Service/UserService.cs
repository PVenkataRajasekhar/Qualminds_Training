using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApplication_Security.Contracts;
using WebApplication_Security.Model;
using WebApplication_Security.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApplication_Security.Service
{
    public class UserService:IUserService
    {
        private readonly IConfiguration _configuration;
        private readonly Context _context;
        public UserService(IConfiguration configuration,Context context) // DI
        {
            _configuration = configuration;
            _context = context;
        }
        public async Task<string> Login(UserModel user)
        {
            var userRecord=await _context.Users.FirstOrDefaultAsync(Id=> Id.UserName == user.UserName);
            if (userRecord == null)
            {
                return string.Empty;
            }
            else
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_configuration["JWTSECRET:Key"]);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Name, user.UserName)
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(30),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token =tokenHandler.CreateToken(tokenDescriptor);
                string userToken = tokenHandler.WriteToken(token);
                return userToken;
            }
        }
    }
}
