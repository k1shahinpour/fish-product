using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EFReverse.Data;
using EFReverse.Models;

namespace EFReverse.Pages.OnlineProducts
{
    public class DetailsModel : PageModel
    {
        private readonly EFReverse.Data.ApplicationDbContext _context;

        public DetailsModel(EFReverse.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public TblOnlineProduct TblOnlineProduct { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblOnlineProduct = await _context.TblOnlineProduct.FirstOrDefaultAsync(m => m.Id == id);

            if (TblOnlineProduct == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
