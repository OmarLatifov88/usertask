using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using user_register.Areas.Admin.Models;

namespace user_register.Contexts;

public class ProniaDbContext : IdentityDbContext
{
    public ProniaDbContext(DbContextOptions<ProniaDbContext> options) : base(options)
    {
    }



    public DbSet<AppUser> appusers { get; set; } = null!;
}
   
