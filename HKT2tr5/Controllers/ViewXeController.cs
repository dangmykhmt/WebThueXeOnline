using HKT2tr5.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HKT2tr5.Controllers
{
    public class ViewXeController : Controller
    {
        private readonly AppDbContext context;

        public ViewXeController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: ViewXe
        public IActionResult Index()
        {
            var appDbContext = context.Xe.Include(x => x.LoaiXe).Include(x => x.Tinh).Include(x => x.DongXe).ThenInclude(x=>x.NhaSanXuat);
            //var appDbContext = context.Xe.Include(x => x.LoaiXe).Include(x => x.MauXe).Include(x => x.Tinh).Include(x => x.DongXe).ThenInclude(x => x.NhaSanXuat);
            return View(appDbContext.ToList());


            //var viewXe = (from x in context.Xe
            //              join dx in context.DongXe                         
            //              join m in context.MauXe

            //              where dx.NhaSanXuatId == id
            //              select new DongXeItem()
            //              {
            //                  Id = dx.DongXeId,
            //                  Name = dx.TenDongXe
            //              }).ToList();

        }

        // GET: ViewXe/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ViewXe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ViewXe/Create
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

        // GET: ViewXe/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ViewXe/Edit/5
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

        // GET: ViewXe/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ViewXe/Delete/5
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