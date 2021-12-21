using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQL_1521050560.Models;

namespace LTQL_1521050560.Controllers
{
    public class NVCSinhVien560Controller : Controller
    {
        private LTQLDb db = new LTQLDb();

        // GET: NVCSinhVien560
        public ActionResult Index()
        {
            return View(db.NVCSinhVien560.ToList());
        }

        // GET: NVCSinhVien560/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NVCSinhVien560 nVCSinhVien560 = db.NVCSinhVien560.Find(id);
            if (nVCSinhVien560 == null)
            {
                return HttpNotFound();
            }
            return View(nVCSinhVien560);
        }

        // GET: NVCSinhVien560/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NVCSinhVien560/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSinhVien,HoTen,MaLop")] NVCSinhVien560 nVCSinhVien560)
        {
            if (ModelState.IsValid)
            {
                db.NVCSinhVien560.Add(nVCSinhVien560);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nVCSinhVien560);
        }

        // GET: NVCSinhVien560/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NVCSinhVien560 nVCSinhVien560 = db.NVCSinhVien560.Find(id);
            if (nVCSinhVien560 == null)
            {
                return HttpNotFound();
            }
            return View(nVCSinhVien560);
        }

        // POST: NVCSinhVien560/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSinhVien,HoTen,MaLop")] NVCSinhVien560 nVCSinhVien560)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nVCSinhVien560).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nVCSinhVien560);
        }

        // GET: NVCSinhVien560/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NVCSinhVien560 nVCSinhVien560 = db.NVCSinhVien560.Find(id);
            if (nVCSinhVien560 == null)
            {
                return HttpNotFound();
            }
            return View(nVCSinhVien560);
        }

        // POST: NVCSinhVien560/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NVCSinhVien560 nVCSinhVien560 = db.NVCSinhVien560.Find(id);
            db.NVCSinhVien560.Remove(nVCSinhVien560);
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
