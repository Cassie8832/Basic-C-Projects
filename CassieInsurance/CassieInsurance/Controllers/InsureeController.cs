using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CassieInsurance.Models;

namespace CassieInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            int DetermineAge(Insuree insuree1)
            {
                // Save today's date.
                var today = DateTime.Today;

                // Calculate the age.
                var age = today.Year - insuree1.DateOfBirth.Year;

                // Go back to the year in which the person was born in case of a leap year
                if (insuree.DateOfBirth.Date > today.AddYears(-age)) age--;
                return age;
            }

            decimal DetermineInsuranceQuote(Insuree insuree1)
            {
                decimal insuranceQuote = 50.00M;

                bool is18OrUnder = (DetermineAge(insuree1) <= 18);
                bool is19To25 = (DetermineAge(insuree1) <= 25 && DetermineAge(insuree1) > 18);

                if (is18OrUnder)
                    insuranceQuote += 100.00M;
                else if (is19To25)
                    insuranceQuote += 50.00M;
                else
                    insuranceQuote += 25.00M;

                bool carBefore2000 = (insuree1.CarYear < 2000);
                bool carAfter2015 = (insuree1.CarYear > 2015);

                if (carBefore2000)
                    insuranceQuote += 25.00M;
                else if (carAfter2015)
                    insuranceQuote += 25.00M;

                if (insuree1.CarMake == "Porsche")
                    insuranceQuote += 25.00M;

                if (insuree1.CarMake == "Porsche" && insuree1.CarModel == "911 Carrera")
                    insuranceQuote += 25.00M;

                if (insuree1.SpeedingTickets >= 1)
                    insuranceQuote += (10 * insuree1.SpeedingTickets);

                if (insuree1.DUI == true)
                    insuranceQuote *= 1.25m;

                if (insuree1.CoverageType == true)
                    insuranceQuote *= 1.5M;

                return insuranceQuote;

            }

            if (ModelState.IsValid)
            {
                insuree.Quote = DetermineInsuranceQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
