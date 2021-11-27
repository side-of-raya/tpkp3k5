using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tpkp3k5.Models;

namespace tpkp3k5.Controllers
{
    public class EventController : Controller
    {
        private kekDBContext db = new kekDBContext();
        public ActionResult Index()
        {
            List<Event> list = db.Events.ToList();
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }


        public ActionResult Fulfill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Event @event)
        {
            try
            {
                db.Events.Add(@event);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            Event @event = db.Events.Find(id);
            return View(@event);
        }

        [HttpPost]
        public ActionResult Edit(Event e)
        {
            try
            {
                db.Entry(e).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
