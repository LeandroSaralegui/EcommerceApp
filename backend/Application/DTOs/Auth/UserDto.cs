using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Auth
{
    public class UserDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public UserDto() { }

        public UserDto(string name, string email, string role) { 
            Name = name;
            Email = email;
            Role = role;
        }
    }
}
