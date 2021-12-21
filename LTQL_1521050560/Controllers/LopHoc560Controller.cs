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
    public class LopHoc560Controller : Controller
    {
        private LTQLDb db = new LTQLDb();

        // GET: LopHoc560
        public ActionResult Index()
        {
            return View(db.LopHoc560.ToList());
        }

        // GET: LopHoc560/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc560 lopHoc560 = db.LopHoc560.Find(id);
            if (lopHoc560 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc560);
        }

        // GET: LopHoc560/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LopHoc560/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLop,TenLop")] LopHoc560 lopHoc560)
        {
            if (ModelState.IsValid)
            {
                db.LopHoc560.Add(lopHoc560);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lopHoc560);
        }

        // GET: LopHoc560/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc560 lopHoc560 = db.LopHoc560.Find(id);
            if (lopHoc560 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc560);
        }

        // POST: LopHoc560/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLop,TenLop")] LopHoc560 lopHoc560)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lopHoc560).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lopHoc560);
        }

        // GET: LopHoc560/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc560 lopHoc560 = db.LopHoc560.Find(id);
            if (lopHoc560 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc560);
        }

        // POST: LopHoc560/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LopHoc560 lopHoc560 = db.LopHoc560.Find(id);
            db.LopHoc560.Remove(lopHoc560);
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
