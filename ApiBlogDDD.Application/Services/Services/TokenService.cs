using ApiBlogDDD.Domain.Entities;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApiBlogDDD.Application.Services.Services
{
    public class TokenService : ITokenService
    {
        private readonly Settings _settings;

        public TokenService(IOptions<Settings> settings)
        {
            _settings = settings.Value;
        }

        public string GenerateToken(Authenticate obj)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_settings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, obj.Username.ToString()),
                    new Claim(ClaimTypes.NameIdentifier, obj.Id.ToString())
                }),

                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
