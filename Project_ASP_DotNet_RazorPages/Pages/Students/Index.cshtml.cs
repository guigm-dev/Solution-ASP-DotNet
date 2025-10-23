using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project_ASP_DotNet_RazorPages.Data;
using Project_ASP_DotNet_RazorPages.Models;
namespace Project_ASP_DotNet_RazorPages.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly Project_ASP_DotNet_RazorPages.Data.ApplicationDbContext _context;
        public IndexModel(Project_ASP_DotNet_RazorPages.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<Student> Student { get; set; } = default!;
        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}