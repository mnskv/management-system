using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using operations.Data;
using operations.Model;

namespace operations.Pages.products
{
    public class IndexModel : PageModel
    {
        private readonly operations.Data.operationsContext _context;

        public IndexModel(operations.Data.operationsContext context)
        {
            _context = context;
        }

        public IList<product> product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.product != null)
            {
                product = await _context.product.ToListAsync();
            }
        }
    }
}
