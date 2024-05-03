using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using tftChampTraitViewer.Models;

namespace tftChampTraitViewer.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

public DbSet<tftChampTraitViewer.Models.Champion> Champion { get; set; } = default!;
}