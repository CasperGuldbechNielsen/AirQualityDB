﻿using System;
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
    public class MercuriesController : Controller
    {
        private AirDataModel db = new AirDataModel();

        // GET: Mercuries
        //Only take the first 150 rows so that the app will be faster
        public ActionResult Index()
        {
            //separate data entities for chart visualization
            var entities = db.Mercuries.ToList().Take(150);
            
            return View(entities);


        }

        // GET: Mercuries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mercury mercury = db.Mercuries.Find(id);
            if (mercury == null)
            {
                return HttpNotFound();
            }
            return View(mercury);
        }

        // GET: Mercuries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mercuries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Mercury_Id,DateTimeStart,Hg,Unit")] Mercury mercury)
        {
            if (ModelState.IsValid)
            {
                db.Mercuries.Add(mercury);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mercury);
        }

        // GET: Mercuries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mercury mercury = db.Mercuries.Find(id);
            if (mercury == null)
            {
                return HttpNotFound();
            }
            return View(mercury);
        }

        // POST: Mercuries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Mercury_Id,DateTimeStart,Hg,Unit")] Mercury mercury)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mercury).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mercury);
        }

        // GET: Mercuries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mercury mercury = db.Mercuries.Find(id);
            if (mercury == null)
            {
                return HttpNotFound();
            }
            return View(mercury);
        }

        // POST: Mercuries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mercury mercury = db.Mercuries.Find(id);
            db.Mercuries.Remove(mercury);
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
