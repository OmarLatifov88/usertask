using Microsoft.AspNetCore.Identity;

namespace user_register.Areas.Admin.Models;

public class AppUser : IdentityUser
{
    public string Fullname { get; set; }

    public bool IsActive { get; set; }
}
