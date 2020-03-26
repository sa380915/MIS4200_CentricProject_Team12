using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MIS4200_CentricProject_Team12.DAL;
using MIS4200_CentricProject_Team12.Models;

namespace MIS4200_CentricProject_Team12.Controllers
{
    public class recognitionDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: recognitionDetails
        public ActionResult Index()
        {
            var recognitionDetails = db.RecognitionDetails.Include(r => r.Employee).Include(r => r.Recognition);
            return View(recognitionDetails.ToList());
        }

        // GET: recognitionDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recognitionDetails recognitionDetails = db.RecognitionDetails.Find(id);
            if (recognitionDetails == null)
            {
                return HttpNotFound();
            }
            return View(recognitionDetails);
        }

        // GET: recognitionDetails/Create
        public ActionResult Create()
        {
            ViewBag.employeeId = new SelectList(db.Employees, "employeeId", "firstName");
            ViewBag.recognitionId = new SelectList(db.Recognitions, "recognitionId", "recognitionTitle");
            return View();
        }

        // POST: recognitionDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "recognitionDetailsId,employeeId,explanation,recognitionId")] recognitionDetails recognitionDetails)
        {
            if (ModelState.IsValid)
            {
                db.RecognitionDetails.Add(recognitionDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.employeeId = new SelectList(db.Employees, "employeeId", "firstName", recognitionDetails.employeeId);
            ViewBag.recognitionId = new SelectList(db.Recognitions, "recognitionId", "recognitionTitle", recognitionDetails.recognitionId);
            return View(recognitionDetails);
        }

        // GET: recognitionDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recognitionDetails recognitionDetails = db.RecognitionDetails.Find(id);
            if (recognitionDetails == null)
            {
                return HttpNotFound();
            }
            ViewBag.employeeId = new SelectList(db.Employees, "employeeId", "firstName", recognitionDetails.employeeId);
            ViewBag.recognitionId = new SelectList(db.Recognitions, "recognitionId", "recognitionTitle", recognitionDetails.recognitionId);
            return View(recognitionDetails);
        }

        // POST: recognitionDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "recognitionDetailsId,employeeId,explanation,recognitionId")] recognitionDetails recognitionDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recognitionDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.employeeId = new SelectList(db.Employees, "employeeId", "firstName", recognitionDetails.employeeId);
            ViewBag.recognitionId = new SelectList(db.Recognitions, "recognitionId", "recognitionTitle", recognitionDetails.recognitionId);
            return View(recognitionDetails);
        }

        // GET: recognitionDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recognitionDetails recognitionDetails = db.RecognitionDetails.Find(id);
            if (recognitionDetails == null)
            {
                return HttpNotFound();
            }
            return View(recognitionDetails);
        }

        // POST: recognitionDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            recognitionDetails recognitionDetails = db.RecognitionDetails.Find(id);
            db.RecognitionDetails.Remove(recognitionDetails);
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
