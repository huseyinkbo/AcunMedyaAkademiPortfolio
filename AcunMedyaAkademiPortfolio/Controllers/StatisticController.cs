using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbPortfolioEntities1 db = new DbPortfolioEntities1();
        // GET: Statistic
        public ActionResult Index()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.skillCount =   db.TblSkills.Count();
            ViewBag.skillAvgValue = db.TblSkills.Average(x => x.Value);
            ViewBag.lastSkillTitleName = db.GetLastSkillTitle().FirstOrDefault();
            ViewBag.mvcCategoryProjectCount = db.TblProject.Where(x => x.ProjectCategoryId == 4).Count();
            return View();
        }
    }
}