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