﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BITCollege_YSC.Data;
using BITCollege_YSC.Models;

namespace BITCollege_YSC.Controllers
{
    /// <summary>
    /// Controller responsible for handling CRUD operations related to Regular State.
    /// </summary>
    public class RegularStatesController : Controller
    {
        private BITCollege_YSCContext db = new BITCollege_YSCContext();

        // GET: RegularStates
        public ActionResult Index()
        {
            return View(db.RegularStates.ToList());  // 這裡也要把db.GradePointStates 改成 db.RegularStates，否則index.html打不開
        }

        // GET: RegularStates/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegularState regularState = (RegularState)db.GradePointStates.Find(id);
            if (regularState == null)
            {
                return HttpNotFound();
            }
            return View(regularState);
        }

        // GET: RegularStates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegularStates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GradePointStateId,LowerLimit,UpperLimit,TuitionRateFactor")] RegularState regularState)
        {
            if (ModelState.IsValid)
            {
                db.GradePointStates.Add(regularState);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(regularState);
        }

        // GET: RegularStates/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegularState regularState = (RegularState)db.GradePointStates.Find(id);
            if (regularState == null)
            {
                return HttpNotFound();
            }
            return View(regularState);
        }

        // POST: RegularStates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GradePointStateId,LowerLimit,UpperLimit,TuitionRateFactor")] RegularState regularState)
        {
            if (ModelState.IsValid)
            {
                db.Entry(regularState).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(regularState);
        }

        // GET: RegularStates/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegularState regularState = (RegularState)db.GradePointStates.Find(id);
            if (regularState == null)
            {
                return HttpNotFound();
            }
            return View(regularState);
        }

        // POST: RegularStates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegularState regularState = (RegularState)db.GradePointStates.Find(id);
            db.GradePointStates.Remove(regularState);
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
