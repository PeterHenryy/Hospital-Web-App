using Microsoft.AspNetCore.Identity;

namespace HospitalWebApp.Models.Identity
{
    public class AppRole : IdentityRole<int>
    {
        public string? Description { get; set; }
    }
}
