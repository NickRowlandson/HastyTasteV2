using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/**
 * @author: Nick Rowlandson & Tim Harasym
 * @description: Final Assignment - MVC Restaurant with Cart
 * @date: August 19 2016
 * @version: 0.0.3 
 */
namespace COMP2007_FinalProject_HastyTaste.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ViewResult Index()
        {
            return View("Error");
        }

        public ViewResult NotFound()
        {
            Response.StatusCode = 404;
            return View("NotFound");
        }
    }
}