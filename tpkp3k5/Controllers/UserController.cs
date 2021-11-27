using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using tpkp3k5.Models;

namespace tpkp3k5.Controllers
{
    public class UserController : Controller
    {
        private kekDBContext db = new kekDBContext();
        public ActionResult List()
        {
            List<User> list = db.Users.ToList();
            return View(list);
        }

        public ActionResult Edit(int id)
        {
            User user = db.Users.Find(id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            try
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
