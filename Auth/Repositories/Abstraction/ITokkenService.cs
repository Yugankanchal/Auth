using Auth.Models.DTO;
using System.Security.Claims;

namespace Auth.Repositories.Abstraction
{
    public interface ITokkenService
    {
        TokkenResponse GetTokken(IEnumerable<Claim> claim);
        string GetRefreshTokken();
        ClaimsPrincipal GetPrincipalFromExpiry(string tokken);

    }
}
