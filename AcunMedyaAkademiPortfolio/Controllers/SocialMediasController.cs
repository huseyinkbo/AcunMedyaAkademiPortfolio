using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class SocialMediasController : Controller
    {
        // GET: SocialMedias
        DbPortfolioEntities1 db = new DbPortfolioEntities1();
        public ActionResult Index()
        {
            var values = db.TblSocialMedias.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateSocialMedias()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSocialMedias(TblSocialMedia p)
        {
            db.TblSocialMedias.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSocialMedias(int id)
        {
            var value = db.TblSocialMedias.Find(id);
            db.TblSocialMedias.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSocialMedias(int id)
        {
            var value = db.TblSocialMedias.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSocialMedias(TblSocialMedia p)
        {
            var value = db.TblSocialMedias.Find(p.SocialMediaID);
            value.socialmediaImageUrl = p.socialmediaImageUrl;
            value.socialMediaUrl = p.socialMediaUrl;
           
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}