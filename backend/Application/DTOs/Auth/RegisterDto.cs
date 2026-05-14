using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Auth
{
    public class RegisterDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Password must have at least 6 characters")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Password must include uppercase, lowercase, and a number.")]
        public string Password { get; set; }

        public RegisterDto() { }

        public RegisterDto(string _name, string _surname, string _phone, string _email, string _password) { 
            
            Name = _name;
            Surname = _surname;
            Phone = _phone;
            Email = _email;
            Password = _password;
        }
    }
}
