using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Auth
{
    public class LoginResponseDto
    {
        public string Token {  get; set; }
        public UserDto User { get; set; }

        public LoginResponseDto() { }

        public LoginResponseDto(string token, UserDto user) {
            Token=token;
            User=user;
        }
    }
}
