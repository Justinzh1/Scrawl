using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Scrawl.Models;

namespace Scrawl.Controllers
{
    public class NotebooksController : Controller
    {
        private NotebookDBContext db = new NotebookDBContext();

        // GET: Notebook
        public ActionResult Index()
        {
            return View(db.Notebooks.ToList());
        }

        public ActionResult Notebook()
        {
            return View();
        }

        // GET: Notebook/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotebookModel notebookModel = db.Notebooks.Find(id);
            if (notebookModel == null)
            {
                return HttpNotFound();
            }
            return View(notebookModel);
        }

        // GET: Notebook/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Notebook/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID")] NotebookModel notebookModel)
        {
            if (ModelState.IsValid)
            {
                db.Notebooks.Add(notebookModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(notebookModel);
        }

        // GET: Notebook/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotebookModel notebookModel = db.Notebooks.Find(id);
            if (notebookModel == null)
            {
                return HttpNotFound();
            }
            return View(notebookModel);
        }

        // POST: Notebook/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID")] NotebookModel notebookModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notebookModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notebookModel);
        }

        // GET: Notebook/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotebookModel notebookModel = db.Notebooks.Find(id);
            if (notebookModel == null)
            {
                return HttpNotFound();
            }
            return View(notebookModel);
        }

        // POST: Notebook/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NotebookModel notebookModel = db.Notebooks.Find(id);
            db.Notebooks.Remove(notebookModel);
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
