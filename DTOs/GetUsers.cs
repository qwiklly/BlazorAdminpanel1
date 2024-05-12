﻿using System.ComponentModel.DataAnnotations;

namespace BlazorAdminpanel.DTOs
{
    public class ApplicationUserDTO
    {
        [Required, DataType(DataType.EmailAddress), EmailAddress]

        public string Email { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}