using Microsoft.AspNetCore.Identity;

namespace PCStore.Models
{
    public class AppUser : IdentityUser
    {
        public string Occupation { get; set; }
    }
}