﻿namespace EKart.Infrastructure.Models
{
    public class UserRegisterModel
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool? IsSeller { get; set; }
    }
}
