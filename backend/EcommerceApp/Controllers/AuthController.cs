using Application.DTOs.Auth;
using Domain.Entities;
using Application.Features.Auth;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthServices _authServices;

        public AuthController(IAuthServices authServices)
        {
            _authServices = authServices;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto) {
            try {
                LoginResponseDto response = await _authServices.Login(dto);
                return Ok(response);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto dto) {
            try {
                LoginResponseDto response = await _authServices.Register(dto);
                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }  
        }
    }
}
