using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }

        public User() { }
        public User(string _name, string _surname, string _email, string _phone, string _password, string _role) 
        { 
            Name = _name;
            Surname = _surname;
            Email = _email;
            Phone = _phone;
            PasswordHash = _password;
            Role = _role;
        }
    }
}
