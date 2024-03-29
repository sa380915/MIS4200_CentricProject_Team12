﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MIS4200_CentricProject_Team12.DAL;
using MIS4200_CentricProject_Team12.Models;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNet.Identity;

namespace MIS4200_CentricProject_Team12.Controllers
{
    public class RecognitionsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Recognitions
        public ActionResult Index()
        {
            return View(db.Recognitions.ToList());
        }

        // GET: Recognitions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recognition recognition = db.Recognitions.Find(id);
            if (recognition == null)
            {
                return HttpNotFound();
            }
            return View(recognition);
        }

        // GET: Recognitions/Create
        public ActionResult Create()

        {
            SmtpClient myClient = new SmtpClient();
            // the following line has to contain the email address and password of someone
            // authorized to use the email server (you will need a valid Ohio account/password
            // for this to work)
            myClient.Credentials = new NetworkCredential("AuthorizedUser", "UserPassword");
            MailMessage myMessage = new MailMessage();
            // the syntax here is email address, username (that will appear in the email)
            MailAddress from = new MailAddress("md753815@ohio.edu", "SysAdmin");
            myMessage.From = from;
            myMessage.To.Add("matthewdonahue7@gmail.com"); // this should be replaced with model data
                                                    // as shown at the end of this document
            myMessage.Subject = "MVC Email test";
            // the body of the email is hard coded here but could be dynamically created using data
            // from the model- see the note at the end of this document
            myMessage.Body = "This is the body of the mail message. This can be essentially any length, and could come ";
            myMessage.Body += "from the database, a variable, the return of another method...";
            try
            {
                myClient.Send(myMessage);
                TempData["mailError"] = "";
            }
            catch (Exception ex)
            {
                // this captures an Exception and allows you to display the message in the View
                TempData["mailError"] = ex.Message;
            }
            return View();

        }

        // POST: Recognitions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "recognitionId,recognizedby,description,recognitionPoints")] Recognition recognition)
        {
            if (ModelState.IsValid)
            {
                //Guid empId;
                //Guid.TryParse(User.Identity.GetUserId(), out empId);
                //recognitionDetails.recognizedby = empId;

                db.Recognitions.Add(recognition);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recognition);
        }

        // GET: Recognitions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recognition recognition = db.Recognitions.Find(id);
            if (recognition == null)
            {
                return HttpNotFound();
            }
            return View(recognition);
        }

        // POST: Recognitions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "recognitionId,recognizedBy,description,recognitionPoints")] Recognition recognition)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recognition).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recognition);
        }

        // GET: Recognitions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recognition recognition = db.Recognitions.Find(id);
            if (recognition == null)
            {
                return HttpNotFound();
            }
            return View(recognition);
        }

        // POST: Recognitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recognition recognition = db.Recognitions.Find(id);
            db.Recognitions.Remove(recognition);
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
