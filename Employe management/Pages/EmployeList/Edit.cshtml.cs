using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employe_management.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Employe_management.Pages.EmployeList
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Employe Employe { get; set; }

        public async Task OnGet(int id)
        {
            Employe = await _db.Employe.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var EmployeFromDb = await _db.Employe.FindAsync(Employe.Id);
                EmployeFromDb.Name = Employe.Name;
                EmployeFromDb.Contact = Employe.Contact;
                EmployeFromDb.Email = Employe.Email;
                EmployeFromDb.Salary = Employe.Salary;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
