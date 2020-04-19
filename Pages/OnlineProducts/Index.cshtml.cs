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
    public class IndexModel : PageModel
    {
        private readonly EFReverse.Data.ApplicationDbContext _context;

        public IndexModel(EFReverse.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<TblOnlineProduct> TblOnlineProduct { get;set; }

        public async Task OnGetAsync()
        {
            TblOnlineProduct = await _context.TblOnlineProduct.ToListAsync();
        }
    }
}
