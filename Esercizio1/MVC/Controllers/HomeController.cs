using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;
using MVC.Models;

namespace MVC.Controllers {
    public class HomeController : Controller {
        DomainModel dm = new DomainModel();

        public ActionResult Index() {
            return View();
        }

        public ActionResult AllMenus() {
            ViewBag.Message = "Ecco tutti i nostri squisiti Menu!";
            List<Menu> result = dm.VisualizzaMenus();
            ViewBag.Menus = result;
            return View();
        }

        public ActionResult MenuGiorno() {
            ViewBag.Message = "";
            return View();
        }

        public ActionResult DoveSiamo() {
            ViewBag.Message = "";
            return View();
        }

        [HttpGet]
        public ActionResult MenuGiorno(Menu menu) {
            ViewBag.Message = "";
            Menu result = dm.VisualizzaMenu(menu);
            ViewBag.Menu = result;
            return View();
        }
    }
}