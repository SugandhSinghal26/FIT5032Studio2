using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FIT5032Assignment.Models;

namespace FIT5032Assignment.Controllers
{
    public class ExercisController : Controller
    {
        private FIT5032Assignment_Models db = new FIT5032Assignment_Models();

        // GET: Exercis
        public ActionResult Index()
        {
            return View(db.Exercises.ToList());
        }

        // GET: Exercis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exercis exercis = db.Exercises.Find(id);
            if (exercis == null)
            {
                return HttpNotFound();
            }
            return View(exercis);
        }

        // GET: Exercis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exercis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description")] Exercis exercis)
        {
            if (ModelState.IsValid)
            {
                db.Exercises.Add(exercis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(exercis);
        }

        // GET: Exercis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exercis exercis = db.Exercises.Find(id);
            if (exercis == null)
            {
                return HttpNotFound();
            }
            return View(exercis);
        }

        // POST: Exercis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description")] Exercis exercis)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exercis).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exercis);
        }

        // GET: Exercis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exercis exercis = db.Exercises.Find(id);
            if (exercis == null)
            {
                return HttpNotFound();
            }
            return View(exercis);
        }

        // POST: Exercis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Exercis exercis = db.Exercises.Find(id);
            db.Exercises.Remove(exercis);
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
