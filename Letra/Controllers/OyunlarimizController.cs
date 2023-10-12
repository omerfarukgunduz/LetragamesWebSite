using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Letra.Models;


namespace Letra.Controllers
{
    public class OyunlarimizController : Controller
    {
        // GET: Oyunlarimiz
        Context c = new Context();

        public ActionResult Index()
        {
            var veriler = c.Oyunlarimiz.ToList();
            return View(veriler);
        }
    }
}