using IntroMVCCore.Models;
using Microsoft.AspNetCore.Mvc;

/*namespace IntroMVCCore.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult Education()
        {

            ViewData["Name"] = "Sadid"; //Dictionary

            ViewBag.Name = "Sadid";
            ViewBag.Id = "123";
            return View();
        }
        public IActionResult Education2()
        {
            PersonalInfo personalInfo1 = new PersonalInfo();
            personalInfo1.Title = "SSC";
            personalInfo1.Result = 5.00f;
            personalInfo1.Year = 2018;

            PersonalInfo personalInfo2 = new PersonalInfo()
            {
                Title = "HSC",
                Result = 5.00f,
                Year = 2020
            };
            PersonalInfo[] personalInfos = new PersonalInfo[] { personalInfo1, personalInfo2 };
            return View(personalInfos); //model Binding
        }
    }
}*/

namespace IntroMVCCore.Controllers
{
    public class PortfolioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bio()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult Education()
        {
            return View();
        }

        public ActionResult Reference()
        {
            return View();
        }
    }
}