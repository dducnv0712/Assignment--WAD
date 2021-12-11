using Assignment_WAD.Models;
using StudentManage.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_WAD.Controllers
{
    public class HomeController : Controller
    {
        private MyDBContext myDBContext = new MyDBContext();
        public ActionResult Index()
        {
            var result = myDBContext.StudentLate.ToList();
            return View(result);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "rollNumber,fullName,Method,Fines,Cause")] StudentLate st) {
            if (ModelState.IsValid)
            {
                myDBContext.StudentLate.Add(st);
                myDBContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create");
        }
    }
}