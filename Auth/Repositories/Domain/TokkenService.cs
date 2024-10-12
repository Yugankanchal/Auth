using Auth.Models.DTO;
using Auth.Repositories.Abstraction;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Auth.Repositories.Domain
{
    public class TokkenService : ITokkenService
    {
        private readonly IConfiguration _configuration;
        public TokkenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ClaimsPrincipal GetPrincipalFromExpiry(string tokken)
        {
            var TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetConnectionString("DefaultConnection"))),
                ValidateLifetime = false,
            };
            var tokkenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokkenHandler.ValidateToken(tokken, TokenValidationParameters, out securityToken);
            return securityToken;
        }

        public string GetRefreshTokken()
        {
            throw new NotImplementedException();
        }

        public TokkenResponse GetTokken(IEnumerable<Claim> claim)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
