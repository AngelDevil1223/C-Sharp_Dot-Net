using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AliaksandrWeb.Models;

namespace AliaksandrWeb.Pages.Rental
{
    public class DeleteModel : PageModel
    {
        private readonly AliaksandrWeb.Models.ApplicationDbContext _context;

        public DeleteModel(AliaksandrWeb.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AliaksandrWeb.Models.Rental Rental { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rental = await _context.Rentals
                .Include(r => r.Customer)
                .Include(r => r.Movie).FirstOrDefaultAsync(m => m.Id == id);

            if (Rental == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rental = await _context.Rentals.FindAsync(id);

            if (Rental != null)
            {
                _context.Rentals.Remove(Rental);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
