using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using operations.Data;
using operations.Model;

namespace operations.Pages.products
{
    public class CreateModel : PageModel
    {
        private readonly operations.Data.operationsContext _context;

        public CreateModel(operations.Data.operationsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public product product { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.product.Add(product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
