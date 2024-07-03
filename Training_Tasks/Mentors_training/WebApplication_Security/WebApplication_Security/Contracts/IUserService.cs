using Microsoft.AspNetCore.Mvc;
using WebApplication_Security.Model;

namespace WebApplication_Security.Contracts
{
    public interface IUserService
    {
        public Task<string> Login(UserModel user);
        public bool ValidateUser(UserModel user);
    }
}
