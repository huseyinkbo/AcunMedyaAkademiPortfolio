using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class AboutController : Controller
    {
        DbPortfolioEntities1 db = new DbPortfolioEntities1();
        public ActionResult AboutList()
        {
            var values = db.TblAbout.ToList();//asd
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAbout(TblAbout p)
        {
            db.TblAbout.Add(p);
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }
        public ActionResult DeleteAbout(int id)
        {
            var value = db.TblAbout.Find(id);
            db.TblAbout.Remove(value);
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = db.TblAbout.Find(id);
            return View(value);


        }
        [HttpPost]
        public ActionResult UpdateAbout(TblAbout p)
        {
            var value = db.TblAbout.Find(p.AboutId);
            value.Description = p.Description;
            value.Title = p.Title;
            value.ImageUrl = p.ImageUrl;            
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}