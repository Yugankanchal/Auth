using Microsoft.AspNetCore.Identity;

namespace Auth.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
    }   
}
