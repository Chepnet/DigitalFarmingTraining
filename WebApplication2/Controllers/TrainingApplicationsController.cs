using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TrainingApplicationsController : Controller
    {
        private Model1 db = new Model1();

        // GET: TrainingApplications
        public ActionResult Index()
        {
            return View(db.TrainingApplications.ToList());
        }

        // GET: TrainingApplications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainingApplication trainingApplication = db.TrainingApplications.Find(id);
            if (trainingApplication == null)
            {
                return HttpNotFound();
            }
            return View(trainingApplication);
        }

        // GET: TrainingApplications/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrainingApplications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ApplicationId,EventName,FirstName,LastName,email")] TrainingApplication trainingApplication)
        {
            if (ModelState.IsValid)
            {
                db.TrainingApplications.Add(trainingApplication);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trainingApplication);
        }

        // GET: TrainingApplications/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainingApplication trainingApplication = db.TrainingApplications.Find(id);
            if (trainingApplication == null)
            {
                return HttpNotFound();
            }
            return View(trainingApplication);
        }

        // POST: TrainingApplications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ApplicationId,EventName,FirstName,LastName,email")] TrainingApplication trainingApplication)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trainingApplication).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trainingApplication);
        }

        // GET: TrainingApplications/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainingApplication trainingApplication = db.TrainingApplications.Find(id);
            if (trainingApplication == null)
            {
                return HttpNotFound();
            }
            return View(trainingApplication);
        }

        // POST: TrainingApplications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TrainingApplication trainingApplication = db.TrainingApplications.Find(id);
            db.TrainingApplications.Remove(trainingApplication);
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
