using Letra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Letra.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        Context c = new Context();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HakkimizdaPartial()
        {
            var veriler = c.Hakkimizda.ToList();
            return PartialView(veriler);
        }

        public PartialViewResult OyunlarimizPartial()
        {
            var veriler = c.Oyunlarimiz.ToList();
            return PartialView(veriler);
        }

        public PartialViewResult EkibimizPartial()
        {
            var veriler = c.Ekibimiz.ToList();
            return PartialView(veriler);
        }













        [HttpGet]
        public PartialViewResult Iletisim()
        {
            return PartialView();
        }


        [HttpPost]
        public PartialViewResult Iletisim(İletisim i)
        {
            c.İletisim.Add(i);
            c.SaveChanges();
            return PartialView();
        }


    }
}