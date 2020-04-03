using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ParksClient.Models
{
    public class ParksClientContext : IdentityDbContext<ApplicationUser>
    {
      public ParksClientContext(DbContextOptions options) : base(options) { }
    }
}