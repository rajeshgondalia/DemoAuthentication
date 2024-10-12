using Microsoft.AspNetCore.Identity;

namespace DemoAuthentication.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        public string? Address { get; set; } = string.Empty;
        public string? File { get; set; } = string.Empty; 
    }
}
