using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFReverse.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFReverse.Pages.Pro
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public IActionResult OnGetData()
        {
            var model = from op in _context.TblOnlineProduct
                        join p in _context.Product on op.ProdId equals p.ProdId
                        join pt in _context.ProductType on p.TypeId equals pt.TypeId
                        join ps in _context.PosData on op.PosId equals ps.PosId
                        join ca in _context.Category on p.CateId equals ca.CatId
                        select new
                        {
                            p.ProdNameEn,
                            op.PosId,
                            op.Qty,
                            op.FreshPrice,
                            pt.TypeName,
                            ps.Loacation,
                        };
            return new JsonResult(model);
        }
    }
}