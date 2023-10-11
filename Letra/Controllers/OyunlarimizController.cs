using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Letra.Controllers
{
    public class OyunlarimizController : Controller
    {
        // GET: Oyunlarimiz
        public ActionResult Index()
        {
            return View();
        }
    }
}