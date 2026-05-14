using Application.DTOs.Auth;
using BCrypt.Net;
using Domain.Entities;
using Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auth
{
    public class AuthService : IAuthServices
    {
        private readonly IUserRepository _userRepository;
        private readonly JwtService _jwtService;

        public AuthService( IUserRepository userRepository, JwtService jwtservice) {
            
            _userRepository = userRepository;
            _jwtService = jwtservice;
        }


        public async Task<LoginResponseDto> Login(LoginDto dto)
        {
            User user = await _userRepository.GetByEmail(dto.Email);
            if (user == null) {
                throw new Exception("The user or password are incorrect!");
            }
            
            bool isValid = BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash);

            if (!isValid) throw new Exception("The user or password are incorrect!");

            var token = _jwtService.GenerateToken(user);

            return new LoginResponseDto { Token = token, User = new UserDto { Name=user.Name, Email= user.Email, Role=user.Role } };


        }

        public async Task<LoginResponseDto> Register(RegisterDto dto)
        {
            User existingUser = await _userRepository.GetByEmail(dto.Email);

            if (existingUser != null) {
                throw new Exception("The user already exist! Try again with different credentials.");
            }

            User newUser = new User 
            {  
                Id = Guid.NewGuid(), 
                Name=dto.Name, 
                Surname=dto.Surname,
                Phone=dto.Phone,
                Email=dto.Email, 
                PasswordHash=BCrypt.Net.BCrypt.HashPassword(dto.Password), 
                Role="CLIENT" 
            };

            await _userRepository.AddAsync(newUser);

            var token = _jwtService.GenerateToken(newUser);

            return new LoginResponseDto { Token = token, User = new UserDto { Name = newUser.Name, Email = newUser.Email, Role = newUser.Role } };
        }
    }
}
