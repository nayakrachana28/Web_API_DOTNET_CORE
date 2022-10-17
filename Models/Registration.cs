﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web_API_DOTNET_CORE.Models
{
    public partial class Registration
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public string? Password { get; set; }
    }
}
