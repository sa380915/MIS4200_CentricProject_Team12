using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MIS4200_CentricProject_Team12.Models;

namespace MIS4200_CentricProject_Team12.Controllers
{
    public class recognitonDetailsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: recognitonDetails
        public ActionResult Index()
        {
            return View(db.recognitonDetails.ToList());
        }

        // GET: recognitonDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recognitonDetails recognitonDetails = db.recognitonDetails.Find(id);
            if (recognitonDetails == null)
            {
                return HttpNotFound();
            }
            return View(recognitonDetails);
        }

        // GET: recognitonDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: recognitonDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "recognitionDetailsId")] recognitonDetails recognitonDetails)
        {
            if (ModelState.IsValid)
            {
                db.recognitonDetails.Add(recognitonDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recognitonDetails);
        }

        // GET: recognitonDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recognitonDetails recognitonDetails = db.recognitonDetails.Find(id);
            if (recognitonDetails == null)
            {
                return HttpNotFound();
            }
            return View(recognitonDetails);
        }

        // POST: recognitonDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "recognitionDetailsId")] recognitonDetails recognitonDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recognitonDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recognitonDetails);
        }

        // GET: recognitonDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recognitonDetails recognitonDetails = db.recognitonDetails.Find(id);
            if (recognitonDetails == null)
            {
                return HttpNotFound();
            }
            return View(recognitonDetails);
        }

        // POST: recognitonDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            recognitonDetails recognitonDetails = db.recognitonDetails.Find(id);
            db.recognitonDetails.Remove(recognitonDetails);
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
