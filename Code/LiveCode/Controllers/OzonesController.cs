using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LiveCode.Models;

namespace LiveCode.Controllers
{
    public class OzonesController : Controller
    {
        private AirDataModel db = new AirDataModel();

        // GET: Ozones
        public ActionResult Index()
        {
            return View(db.Ozones.ToList().Take(50));
        }

        // GET: Ozones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ozone ozone = db.Ozones.Find(id);
            if (ozone == null)
            {
                return HttpNotFound();
            }
            return View(ozone);
        }

        // GET: Ozones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ozones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Ozone_Id,DateTimeStart,Ozone1,Unit")] Ozone ozone)
        {
            if (ModelState.IsValid)
            {
                db.Ozones.Add(ozone);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ozone);
        }

        // GET: Ozones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ozone ozone = db.Ozones.Find(id);
            if (ozone == null)
            {
                return HttpNotFound();
            }
            return View(ozone);
        }

        // POST: Ozones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Ozone_Id,DateTimeStart,Ozone1,Unit")] Ozone ozone)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ozone).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ozone);
        }

        // GET: Ozones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ozone ozone = db.Ozones.Find(id);
            if (ozone == null)
            {
                return HttpNotFound();
            }
            return View(ozone);
        }

        // POST: Ozones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ozone ozone = db.Ozones.Find(id);
            db.Ozones.Remove(ozone);
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
