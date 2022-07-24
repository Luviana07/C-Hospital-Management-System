using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HastaTakip.Models.Entity;

namespace HastaTakip.Controllers
{
    public class hastaController : Controller
    {
        // GET: hasta
        public ActionResult Index()
        {
            return View();
        }
    }
}