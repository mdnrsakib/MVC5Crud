using Asp.NetMVCCrud.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.NetMVCCrud.Controllers
{
    public class BatchesController : Controller
    {
        BatchDbContext db = new BatchDbContext();
        // GET: Batches
        public ActionResult Index()
        {
            return View(db.Batches.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Batch b)
        {
            if(ModelState.IsValid)
            {
                db.Batches.Add(b);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            ViewBag.Id = id;
            return View(db.Batches.First(b=>b.BatchId == id));
        }
        [HttpPost]
        public ActionResult Edit(Batch b)
        {
            if (ModelState.IsValid)
            {
                db.Entry(b).State =EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(b);
        }
        public ActionResult Delete(int id)
        {
            return View(db.Batches.First(b => b.BatchId == id));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DoDelete(int id)
        {
            Batch b = new Batch { BatchId= id };
            db.Entry(b).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}