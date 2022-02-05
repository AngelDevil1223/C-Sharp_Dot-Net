using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AliaksandrWeb.Models;

namespace AliaksandrWeb.Pages.Customer
{
    public class IndexModel : PageModel
    {
        private readonly AliaksandrWeb.Models.ApplicationDbContext _context;

        public IndexModel(AliaksandrWeb.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<AliaksandrWeb.Models.Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
