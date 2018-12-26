using CKEditorDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CKEditorDemo.Controllers
{
    public class HomeController : Controller
    {
        MakaleDBEntities db = new MakaleDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            var makale = db.Makales.ToList();
            return View(makale);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Makale m)
        {
          
            db.Makales.Add(m);
            db.SaveChanges();
            return RedirectToAction("Create", "Home");
        }

    }
}