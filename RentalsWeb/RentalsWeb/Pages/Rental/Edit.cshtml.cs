using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AliaksandrWeb.Models;

namespace AliaksandrWeb.Pages.Rental
{
    public class EditModel : PageModel
    {
        private readonly AliaksandrWeb.Models.ApplicationDbContext _context;

        public EditModel(AliaksandrWeb.Models.ApplicationDbContext context)
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
           ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id");
           ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "Id");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Rental).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RentalExists(Rental.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RentalExists(int id)
        {
            return _context.Rentals.Any(e => e.Id == id);
        }
    }
}
