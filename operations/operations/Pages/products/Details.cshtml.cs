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
    public class DetailsModel : PageModel
    {
        private readonly operations.Data.operationsContext _context;

        public DetailsModel(operations.Data.operationsContext context)
        {
            _context = context;
        }

      public product product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.product == null)
            {
                return NotFound();
            }

            var product = await _context.product.FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            else 
            {
                product = product;
            }
            return Page();
        }
    }
}
