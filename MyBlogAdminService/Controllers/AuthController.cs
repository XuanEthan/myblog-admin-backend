using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using MyBlogAdminService.Models;
using MyBlogAdminService.Models.Dtos.User;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MyBlogAdminService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (loginDto.UserName != "Admin" || loginDto.Password != "Admin123") // mock data
            {
                return Unauthorized("Tên đăng nhập hoặc mật khẩu không đúng . Hãy thử lại !");
            }
            
            var token = GenerateJwtToken(new User { UserName = loginDto.UserName , Password = loginDto.Password});
            return Ok(new {token});
        }

        private string GenerateJwtToken(User? User)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Role , "ADMIN"),
                new Claim("UserName" , User?.UserName),
            };

            var expireMinutes = int.TryParse(_configuration["Jwt:ExpireMinutes"], out var m) ? m : 10;
            var secretKey = _configuration["Jwt:Key"] ?? throw new InvalidOperationException("Missing secret key");
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new JwtSecurityToken(
                 issuer: _configuration["Jwt:Issuer"] ?? "MyApp",
                 claims: claims,
                 expires: DateTime.Now.AddMinutes(expireMinutes),
                 signingCredentials: creds
                );
            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        }
    }
}
