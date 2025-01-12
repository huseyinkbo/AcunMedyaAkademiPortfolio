using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        DbPortfolioEntities1 db = new DbPortfolioEntities1();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            var values = db.TblFeature.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialStatistic()
        {
            var projectcount = db.TblProject.ToList().Count();
            var testimonialcount = db.TblTestimonial.ToList().Count();
            var servicecount = db.TblService.ToList().Count();
            var skillcount = db.TblSkills.ToList().Count();
            ViewBag.ProjectCount = projectcount;
            ViewBag.TestimonialCount = testimonialcount;
            ViewBag.ServiceCount = servicecount;
            ViewBag.SkillCount = skillcount;
            return PartialView();
        }
        public PartialViewResult PartialProfile()
        {
            var values = db.TblProfile.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialHobby()
        {
            var values = db.TblHobby.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.TblSkills.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialService()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialProject()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        [HttpGet]
        public PartialViewResult PartialContact()
        {

            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialContact(TblContact p)
        {
            db.TblContact.Add(p);
            db.SaveChanges();
            return PartialView();
        }
        public PartialViewResult PartialAdress()
        {
            var values = db.TblAdress.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFooter1()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFooter2()
        {
            var values = db.TblAdress.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFooterSMedia()
        {
            var values = db.TblSocialMedias.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialScript()
        {       
            return PartialView();
        }
    }
}