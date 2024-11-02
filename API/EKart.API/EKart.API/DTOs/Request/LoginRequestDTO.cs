﻿using System.ComponentModel.DataAnnotations;

namespace EKart.API.DTOs.Request
{
    public class LoginRequestDTO
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
