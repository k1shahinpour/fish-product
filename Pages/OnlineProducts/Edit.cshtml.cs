using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFReverse.Data;
using EFReverse.Models;

namespace EFReverse.Pages.OnlineProducts
{
    public class EditModel : PageModel
    {
        private readonly EFReverse.Data.ApplicationDbContext _context;

        public EditModel(EFReverse.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TblOnlineProduct).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblOnlineProductExists(TblOnlineProduct.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TblOnlineProductExists(string id)
        {
            return _context.TblOnlineProduct.Any(e => e.Id == id);
        }
    }
}
