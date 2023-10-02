using System;
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
    /// Controller responsible for handling CRUD operations related to Honours State.
    /// </summary>
    public class HonoursStatesController : Controller
    {
        private BITCollege_YSCContext db = new BITCollege_YSCContext();

        // GET: HonoursStates
        public ActionResult Index()
        {
            return View(db.HonoursStates.ToList());  // 這裡也要把db.GradePointStates 改成 db.HonoursStates，否則index.html打不開
        }

        // GET: HonoursStates/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HonoursState honoursState = (HonoursState)db.GradePointStates.Find(id);
            if (honoursState == null)
            {
                return HttpNotFound();
            }
            return View(honoursState);
        }

        // GET: HonoursStates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HonoursStates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GradePointStateId,LowerLimit,UpperLimit,TuitionRateFactor")] HonoursState honoursState)
        {
            if (ModelState.IsValid)
            {
                db.GradePointStates.Add(honoursState);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(honoursState);
        }

        // GET: HonoursStates/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HonoursState honoursState = (HonoursState)db.GradePointStates.Find(id);
            if (honoursState == null)
            {
                return HttpNotFound();
            }
            return View(honoursState);
        }

        // POST: HonoursStates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GradePointStateId,LowerLimit,UpperLimit,TuitionRateFactor")] HonoursState honoursState)
        {
            if (ModelState.IsValid)
            {
                db.Entry(honoursState).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(honoursState);
        }

        // GET: HonoursStates/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HonoursState honoursState = (HonoursState)db.GradePointStates.Find(id);
            if (honoursState == null)
            {
                return HttpNotFound();
            }
            return View(honoursState);
        }

        // POST: HonoursStates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HonoursState honoursState = (HonoursState)db.GradePointStates.Find(id);
            db.GradePointStates.Remove(honoursState);
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
