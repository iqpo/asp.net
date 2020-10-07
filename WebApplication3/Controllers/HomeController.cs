using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Lee(int? n) // Nullable Type : Null이 들어와도 컴파일러가 정상동작하게 됨.
        {
            ViewBag.Message = $"Your contact page. {n.ToString()}";

            return View();
        }
    }
}