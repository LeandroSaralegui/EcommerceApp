using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Auth;

namespace Application.Features.Auth
{
    public interface IAuthServices
    {
        public Task<LoginResponseDto> Register(RegisterDto dto);
        public Task<LoginResponseDto> Login(LoginDto dto);
    }
}
