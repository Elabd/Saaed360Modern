using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Application.Abstractions.AuthService;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Infrastructure.Services.Auth
{


    public sealed class JwtFactory : IJwtFactory
    {
        private readonly string _issuer;
        private readonly string _audience;
        private readonly string _key;
        private readonly int _expiryMinutes;
        private readonly int _refreshexpiryDays;

        public JwtFactory(IConfiguration configuration)
        {
            var jwtSection = configuration.GetSection("Jwt");
            _issuer = jwtSection["Issuer"] ?? throw new ArgumentNullException(nameof(_issuer));
            _audience = jwtSection["Audience"] ?? throw new ArgumentNullException(nameof(_audience));
            _key = jwtSection["Key"] ?? throw new ArgumentNullException(nameof(_key));
            _expiryMinutes = int.Parse(jwtSection["ExpiryInMinutes"] ?? "60");
            _refreshexpiryDays = int.Parse(jwtSection["RefreshTokenExpiryInDays"] ?? "7");
        }

        public string Create(Guid userId, string email ,string userName, IEnumerable<Claim>? extraClaims = null)
        {
            var claims = new List<Claim>
            {
                new(JwtRegisteredClaimNames.Sub, userId.ToString()),
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new(JwtRegisteredClaimNames.Email, email),
                new(JwtRegisteredClaimNames.Name, userName)
            };

            if (extraClaims != null)
            {
                claims.AddRange(extraClaims);
            }

            var keyBytes = Encoding.UTF8.GetBytes(_key);
            var signingKey = new SymmetricSecurityKey(keyBytes);
            var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _issuer,
                audience: _audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_expiryMinutes),
                signingCredentials: signingCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public (string AccessToken, string RefreshToken) CreateWithRefresh(Guid userId, string? email, string userName, IEnumerable<string>? roles = null)
        {
            throw new NotImplementedException();
        }
    }
}
