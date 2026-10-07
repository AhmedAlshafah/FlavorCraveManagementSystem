using System;
using System.Collections.Generic;
using System.Text;

namespace FlavorCraveManagementSystem.Models
{
    public class User
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public string FullName { get; set; } = "";
        public string Email { get; set; } = "";
        public string RoleName { get; set; } = "";



    }
}
