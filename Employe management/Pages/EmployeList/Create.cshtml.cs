using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employe_management.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Employe_management.Pages.EmployeList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
       
        [BindProperty]
        public Employe Employe { get; set; }

        public void OnGet()
        {



        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Employe.AddAsync(Employe);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
