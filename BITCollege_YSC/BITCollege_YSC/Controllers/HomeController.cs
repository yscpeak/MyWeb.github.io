using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BITCollege_YSC.Data;
using BITCollege_YSC.Models;

namespace BITCollege_YSC.Controllers
{
    /// <summary>
    /// Controller responsible for handling the main views,
    /// includes the homepage (Index), About page, and Contact page.
    /// </summary>
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the BIT College Data Maintenance System.";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "BIT College Data Maintenance System";
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

    }
}