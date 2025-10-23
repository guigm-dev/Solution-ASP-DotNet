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
    public class DetailsModel : PageModel
    {
        private readonly Project_ASP_DotNet_RazorPages.Data.ApplicationDbContext _context;
        public DetailsModel(Project_ASP_DotNet_RazorPages.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public Student Student { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var student = await _context.Student.FirstOrDefaultAsync(m => m.Id == id);
            if (student is not null)
            {
                Student = student;
                return Page();
            }
            return NotFound();
        }
    }
}