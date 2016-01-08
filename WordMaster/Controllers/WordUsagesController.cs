using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WordMaster.Models;

namespace WordMaster.Controllers
{
    public class WordUsagesController : Controller
    {
        private WordMasterContext db = new WordMasterContext();

        // GET: WordUsages
        public ActionResult Index()
        {
            return View(db.WordUsages.ToList());
        }

        // GET: WordUsages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WordUsage wordUsage = db.WordUsages.Find(id);
            if (wordUsage == null)
            {
                return HttpNotFound();
            }
            return View(wordUsage);
        }

        // GET: WordUsages/Create
        public ActionResult Create(int? id)
        {
			return View(new WordUsage()
			{
				WordID = (int)id
			});
        }


		// POST: WordUsages/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WordUsage wordUsage)
        {
            if (ModelState.IsValid)
            {
                db.WordUsages.Add(wordUsage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wordUsage);
        }

        // GET: WordUsages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WordUsage wordUsage = db.WordUsages.Find(id);
            if (wordUsage == null)
            {
                return HttpNotFound();
            }
            return View(wordUsage);
        }

        // POST: WordUsages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WordUsageID,Usage")] WordUsage wordUsage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wordUsage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wordUsage);
        }

        // GET: WordUsages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WordUsage wordUsage = db.WordUsages.Find(id);
            if (wordUsage == null)
            {
                return HttpNotFound();
            }
            return View(wordUsage);
        }

        // POST: WordUsages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WordUsage wordUsage = db.WordUsages.Find(id);
            db.WordUsages.Remove(wordUsage);
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
