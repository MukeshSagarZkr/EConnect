using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EConnect.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TokenController(IConfiguration configuration) : ControllerBase
	{
		private readonly string _key = configuration["Jwt:Key"];
		private readonly string _issuer = configuration["Jwt:Issuer"];
		private readonly string _audience = configuration["Jwt:Audience"];

		[HttpPost]
		[Route("generate")]
		public IActionResult GenerateToken([FromBody] UserLogin login)
		{
			if (login.UserName != "admin" || login.Password != "password") // Dummy validation
			{
				return Unauthorized();
			}

			var claims = new[]
			{
				new Claim(JwtRegisteredClaimNames.Sub, login.UserName),
				new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
			};

			var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_key));
			var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

			var token = new JwtSecurityToken(
				issuer: _issuer,
				audience: _audience,
				claims: claims,
				expires: DateTime.Now.AddMinutes(30),
				signingCredentials: creds);

			return Ok(new
			{
				token = new JwtSecurityTokenHandler().WriteToken(token)
			});
		}
	}

	public class UserLogin
	{
		public string UserName { get; set; }
		public string Password { get; set; }
	}
}
