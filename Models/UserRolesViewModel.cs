﻿namespace ProyectoMVC3.Models
{
    public class UserRolesViewModel
    {
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public IEnumerable<string>? Roles { get; set; }
    }
}
