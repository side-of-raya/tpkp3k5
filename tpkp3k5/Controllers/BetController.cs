using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tpkp3k5.Models;

namespace tpkp3k5.Controllers
{
    public class BetController : Controller
    {
        private kekDBContext db = new kekDBContext();
        public ActionResult List()
        {
            //List<Bet> list = db.Bets.ToList();
            return View(); //list
        }

        public ActionResult Create(int eventID)
        {
            Event obj = db.Events.Find(eventID);
            Bet newBet = new Bet();
            newBet.e = obj;
            return View(newBet);
        }

        [HttpPost]
        public ActionResult Create(Bet bet)
        {
            try
            {
                db.Bets.Add(bet);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(bet.e);
            }
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Event/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                //db.Entry(book).State = EntityState.Modified;
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Event/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Event/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
