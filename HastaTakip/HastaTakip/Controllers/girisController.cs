using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HastaTakip.Controllers
{
    public class girisController : Controller
    {
        // GET: giris
        public ActionResult giris()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult giris(string username,string password)
        {
            return View();
        }
    }
}