using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project_ASP_DotNet_RazorPages.Data;
using Project_ASP_DotNet_RazorPages.Models;
namespace Project_ASP_DotNet_RazorPages.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly Project_ASP_DotNet_RazorPages.Data.ApplicationDbContext _context;
        public CreateModel(Project_ASP_DotNet_RazorPages.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public Student Student { get; set; } = default!;
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Student.Add(Student);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}