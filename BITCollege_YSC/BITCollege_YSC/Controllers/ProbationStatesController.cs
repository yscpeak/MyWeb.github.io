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
    /// Controller responsible for handling CRUD operations related to Probation State.
    /// </summary>
    public class ProbationStatesController : Controller
    {
        private BITCollege_YSCContext db = new BITCollege_YSCContext();

        // GET: ProbationStates
        public ActionResult Index()
        {
            return View(db.ProbationStates.ToList());  // 這裡也要把db.GradePointStates 改成 db.ProbationStates，否則index.html打不開
        }

        // GET: ProbationStates/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProbationState probationState = (ProbationState)db.GradePointStates.Find(id);
            if (probationState == null)
            {
                return HttpNotFound();
            }
            return View(probationState);
        }

        // GET: ProbationStates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProbationStates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GradePointStateId,LowerLimit,UpperLimit,TuitionRateFactor")] ProbationState probationState)
        {
            if (ModelState.IsValid)
            {
                db.GradePointStates.Add(probationState);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(probationState);
        }

        // GET: ProbationStates/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProbationState probationState = (ProbationState)db.GradePointStates.Find(id);
            if (probationState == null)
            {
                return HttpNotFound();
            }
            return View(probationState);
        }

        // POST: ProbationStates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GradePointStateId,LowerLimit,UpperLimit,TuitionRateFactor")] ProbationState probationState)
        {
            if (ModelState.IsValid)
            {
                db.Entry(probationState).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(probationState);
        }

        // GET: ProbationStates/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProbationState probationState = (ProbationState)db.GradePointStates.Find(id);
            if (probationState == null)
            {
                return HttpNotFound();
            }
            return View(probationState);
        }

        // POST: ProbationStates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProbationState probationState = (ProbationState)db.GradePointStates.Find(id);
            db.GradePointStates.Remove(probationState);
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
