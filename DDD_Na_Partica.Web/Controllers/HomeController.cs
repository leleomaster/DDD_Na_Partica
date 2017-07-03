using DDD_Na_Partica.Application.IppServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDD_Na_Partica.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            List<string> nomes = new List<string>();

            nomes.Add("leo");
            nomes.Add("leleo");
            nomes.Add("leleomaster");
            nomes.Add("leleo jr");
            nomes.Add("leo jr");

            ViewBag.Nomes = nomes;
            ViewBag.Id = 32;

            ViewData["Nomes_ViewData"] = nomes;

            TempData["Nomes_TempData"] = nomes;

            return View();
        }        
    }
}