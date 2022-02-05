using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AliaksandrWeb.Models;

namespace AliaksandrWeb.Pages.Rental
{
    public class CreateModel : PageModel
    {
        private readonly AliaksandrWeb.Models.ApplicationDbContext _context;

        public CreateModel(AliaksandrWeb.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id");
        ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public AliaksandrWeb.Models.Rental Rental { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Rentals.Add(Rental);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}