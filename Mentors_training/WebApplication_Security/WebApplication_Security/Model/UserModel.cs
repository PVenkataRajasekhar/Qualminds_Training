﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication_Security.Model
{
    public class UserModel
    {
        public int Id { get; set; }
        public string UserName {  get; set; }
        public string Password { get; set; }
        public string Role {  get; set; }
    }
}
