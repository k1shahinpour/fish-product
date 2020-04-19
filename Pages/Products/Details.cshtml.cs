using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EFReverse.Data;
using EFReverse.Models;

namespace EFReverse.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly EFReverse.Data.ApplicationDbContext _context;

        public DetailsModel(EFReverse.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product.FirstOrDefaultAsync(m => m.ProdId == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
