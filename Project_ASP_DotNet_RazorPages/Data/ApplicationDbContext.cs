using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_ASP_DotNet_RazorPages.Models;
namespace Project_ASP_DotNet_RazorPages.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Project_ASP_DotNet_RazorPages.Models.Student> Student { get; set; } = default!;
    }
}