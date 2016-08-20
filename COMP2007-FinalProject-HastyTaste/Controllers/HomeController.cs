using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2007_FinalProject_HastyTaste.Models;

/**
 * @author: Nick Rowlandson & Tim Harasym
 * @description: Final Assignment - MVC Restaurant with Cart
 * @date: August 19 2016
 * @version: 0.0.3 
 */
namespace COMP2007_FinalProject_HastyTaste.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu()
        {
            ViewBag.Message = "Check out our delicious menu!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}