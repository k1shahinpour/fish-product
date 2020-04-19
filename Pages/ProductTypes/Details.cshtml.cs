using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EFReverse.Data;
using EFReverse.Models;

namespace EFReverse.Pages.ProductTypes
{
    public class DetailsModel : PageModel
    {
        private readonly EFReverse.Data.ApplicationDbContext _context;

        public DetailsModel(EFReverse.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public ProductType ProductType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductType = await _context.ProductType.FirstOrDefaultAsync(m => m.TypeId == id);

            if (ProductType == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
