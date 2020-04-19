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
    public class DeleteModel : PageModel
    {
        private readonly EFReverse.Data.ApplicationDbContext _context;

        public DeleteModel(EFReverse.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblOnlineProduct = await _context.TblOnlineProduct.FindAsync(id);

            if (TblOnlineProduct != null)
            {
                _context.TblOnlineProduct.Remove(TblOnlineProduct);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
