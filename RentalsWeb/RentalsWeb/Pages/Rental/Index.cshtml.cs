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
    public class IndexModel : PageModel
    {
        private readonly AliaksandrWeb.Models.ApplicationDbContext _context;

        public IndexModel(AliaksandrWeb.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<AliaksandrWeb.Models.Rental> Rental { get;set; }

        public async Task OnGetAsync()
        {
            Rental = await _context.Rentals
                .Include(r => r.Customer)
                .Include(r => r.Movie).ToListAsync();
        }
    }
}
