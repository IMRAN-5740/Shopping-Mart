﻿using Microsoft.AspNetCore.Identity;

namespace ArtifitialIntelligence.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}