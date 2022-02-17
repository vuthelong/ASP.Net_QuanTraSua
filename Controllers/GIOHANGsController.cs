using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASP.NET_QuanTraSua.Models;

namespace ASP.NET_QuanTraSua.Controllers
{
    public class GIOHANGsController : Controller
    {
        private Model1 db = new Model1();

        // GET: GIOHANGs
        public ActionResult Index()
        {
            var gIOHANG = db.GIOHANG.Include(g => g.DONHANG);
            return View(gIOHANG.ToList());
        }

        // GET: GIOHANGs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GIOHANG gIOHANG = db.GIOHANG.Find(id);
            if (gIOHANG == null)
            {
                return HttpNotFound();
            }
            return View(gIOHANG);
        }

        // GET: GIOHANGs/Create
        public ActionResult Create()
        {
            ViewBag.MaDH = new SelectList(db.DONHANG, "MaDH", "PhuongThucThanhToan");
            return View();
        }

        // POST: GIOHANGs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaGH,MaDH")] GIOHANG gIOHANG)
        {
            if (ModelState.IsValid)
            {
                db.GIOHANG.Add(gIOHANG);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaDH = new SelectList(db.DONHANG, "MaDH", "PhuongThucThanhToan", gIOHANG.MaDH);
            return View(gIOHANG);
        }

        // GET: GIOHANGs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GIOHANG gIOHANG = db.GIOHANG.Find(id);
            if (gIOHANG == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDH = new SelectList(db.DONHANG, "MaDH", "PhuongThucThanhToan", gIOHANG.MaDH);
            return View(gIOHANG);
        }

        // POST: GIOHANGs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaGH,MaDH")] GIOHANG gIOHANG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gIOHANG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaDH = new SelectList(db.DONHANG, "MaDH", "PhuongThucThanhToan", gIOHANG.MaDH);
            return View(gIOHANG);
        }

        // GET: GIOHANGs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GIOHANG gIOHANG = db.GIOHANG.Find(id);
            if (gIOHANG == null)
            {
                return HttpNotFound();
            }
            return View(gIOHANG);
        }

        // POST: GIOHANGs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            GIOHANG gIOHANG = db.GIOHANG.Find(id);
            db.GIOHANG.Remove(gIOHANG);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
