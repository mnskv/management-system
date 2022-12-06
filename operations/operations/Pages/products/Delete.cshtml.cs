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
    public class DeleteModel : PageModel
    {
        private readonly operations.Data.operationsContext _context;

        public DeleteModel(operations.Data.operationsContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.product == null)
            {
                return NotFound();
            }
            var product = await _context.product.FindAsync(id);

            if (product != null)
            {
                product = product;
                _context.product.Remove(product);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
