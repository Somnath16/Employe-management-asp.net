using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employe_management.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Employe_management.Pages.EmployeList
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Employe> Employes { get; set; }

        public async Task OnGet()
        {
            Employes = await _db.Employe.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var employe = await _db.Employe.FindAsync(id);
            if (employe != null)
            {
                _db.Employe.Remove(employe);
                await _db.SaveChangesAsync();

                return RedirectToPage("Index");

            }
            return RedirectToPage();
        }
    }
}
