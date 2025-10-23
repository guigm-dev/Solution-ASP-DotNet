using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_ASP_DotNet_MVC.Models;
namespace Project_ASP_DotNet_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Project_ASP_DotNet_MVC.Models.StudentModel> StudentModel { get; set; } = default!;
    }
}