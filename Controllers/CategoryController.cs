using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LearningHub.Model;

namespace LearningHub.Controllers
{
    public class CategoryController : Controller
    {
        private LearningHubDBContext db = new LearningHubDBContext();

        // GET: Category
        public ActionResult Index()
        {
            return View(db.tbl_Category.ToList());
        }

        // GET: Category/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Category tbl_Category = db.tbl_Category.Find(id);
            if (tbl_Category == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Category);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoryId,CategoryName,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn")] tbl_Category objCategory)
        {
            if (ModelState.IsValid)
            {
                objCategory.CategoryId = Guid.NewGuid();
                db.tbl_Category.Add(objCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(objCategory);
        }

        // GET: Category/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Category tbl_Category = db.tbl_Category.Find(id);
            if (tbl_Category == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Category);
        }

        // POST: Category/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoryId,CategoryName,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn")] tbl_Category tbl_Category)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Category);
        }

        // GET: Category/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Category tbl_Category = db.tbl_Category.Find(id);
            if (tbl_Category == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Category);
        }

        // POST: Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            tbl_Category tbl_Category = db.tbl_Category.Find(id);
            db.tbl_Category.Remove(tbl_Category);
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
