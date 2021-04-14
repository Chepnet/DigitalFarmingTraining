using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2;
using PagedList;

namespace WebApplication2.Controllers
{
    public class FarmersTrainingsController : Controller
    {
        private Model1 db = new Model1();

        // GET: FarmersTrainings
        public ActionResult Index()
        {
            return View(db.FarmersTrainings.ToList());
        }
        public ActionResult Index1(string option, string search, int? pageNumber, string sort)
        {

            //if the sort parameter is null or empty then we are initializing the value as descending name  
            ViewBag.SortByName = string.IsNullOrEmpty(sort) ? "descending Event" : "";
            //if the sort value is gender then we are initializing the value as descending gender  
            ViewBag.SortByTrainerName = sort == "TrainerName" ? "descending TrainerName" : "TrainerName";

            //here we are converting the db.Students to AsQueryable so that we can invoke all the extension methods on variable records.  
            var records = db.FarmersTrainings.AsQueryable();

            if (option == "TrainingTime")
            {
                records = records.Where(x => x.TrainingTime.ToString() == search || search == null);
            }
            else if (option == "TrainerName")
            {
                records = records.Where(x => x.TrainerName == search || search == null);
            }
            else
            {
                records = records.Where(x => x.EventName.StartsWith(search) || search == null);
            }

            switch (sort)
            {

                case "descending Event":
                    records = records.OrderByDescending(x => x.EventName);
                    break;

                case "descending TrainerName":
                    records = records.OrderByDescending(x => x.TrainerName);
                    break;

                case "TrainerName":
                    records = records.OrderBy(x => x.TrainerName);
                    break;

                default:
                    records = records.OrderBy(x => x.EventName);
                    break;

            }
          
            return View(records.ToPagedList(pageNumber ?? 1, 3));
        }
    


// GET: FarmersTrainings/Details/5
public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FarmersTraining farmersTraining = db.FarmersTrainings.Find(id);
            if (farmersTraining == null)
            {
                return HttpNotFound();
            }
            return View(farmersTraining);
        }

      

        // GET: FarmersTrainings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FarmersTrainings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TrainingId,TrainerName,EventName,Description,TrainingTme")] FarmersTraining farmersTraining)
        {
            if (ModelState.IsValid)
            {
                db.FarmersTrainings.Add(farmersTraining);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(farmersTraining);
        }

        // GET: FarmersTrainings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FarmersTraining farmersTraining = db.FarmersTrainings.Find(id);
            if (farmersTraining == null)
            {
                return HttpNotFound();
            }
            return View(farmersTraining);
        }

        // POST: FarmersTrainings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TrainingId,TrainerName,EventName,Description,TrainingTme")] FarmersTraining farmersTraining)
        {
            if (ModelState.IsValid)
            {
                db.Entry(farmersTraining).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(farmersTraining);
        }

        // GET: FarmersTrainings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FarmersTraining farmersTraining = db.FarmersTrainings.Find(id);
            if (farmersTraining == null)
            {
                return HttpNotFound();
            }
            return View(farmersTraining);
        }

        // POST: FarmersTrainings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FarmersTraining farmersTraining = db.FarmersTrainings.Find(id);
            db.FarmersTrainings.Remove(farmersTraining);
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
