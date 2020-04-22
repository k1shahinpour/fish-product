using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFReverse.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFReverse.Controllers
{
    public class productController : Controller
    {
        private readonly ApplicationDbContext _context;

        public productController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: product
        [Route("api/pro")]
        public IActionResult Index()
        {
            //var model = _context.TblOnlineProduct;

            var model =(from op in _context.TblOnlineProduct
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
                             op.Photo,
                             op.MealPrice
                         }).ToList();

            

            return new JsonResult(model);
        }

        // GET: product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}