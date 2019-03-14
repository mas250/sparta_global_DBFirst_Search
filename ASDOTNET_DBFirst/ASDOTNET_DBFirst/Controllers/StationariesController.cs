using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASDOTNET_DBFirst;

namespace ASDOTNET_DBFirst.Controllers
{
    public class StationariesController : Controller
    {
        private MatSchoolDBEntities1 db = new MatSchoolDBEntities1();

        // GET: Stationaries
        public ActionResult Index()
        {
            return View(db.Stationaries.ToList());
        }

        // GET: Stationaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stationary stationary = db.Stationaries.Find(id);
            if (stationary == null)
            {
                return HttpNotFound();
            }
            return View(stationary);
        }

        // GET: Stationaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stationaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "stationaryName,price,supplier,StationaryID")] Stationary stationary)
        {
            if (ModelState.IsValid)
            {
                db.Stationaries.Add(stationary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stationary);
        }

        // GET: Stationaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stationary stationary = db.Stationaries.Find(id);
            if (stationary == null)
            {
                return HttpNotFound();
            }
            return View(stationary);
        }

        // POST: Stationaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "stationaryName,price,supplier,StationaryID")] Stationary stationary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stationary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stationary);
        }

        // GET: Stationaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stationary stationary = db.Stationaries.Find(id);
            if (stationary == null)
            {
                return HttpNotFound();
            }
            return View(stationary);
        }

        // POST: Stationaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stationary stationary = db.Stationaries.Find(id);
            db.Stationaries.Remove(stationary);
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
