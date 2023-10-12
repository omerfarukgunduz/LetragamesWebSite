using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Letra.Models;

namespace Letra.Controllers
{
    public class HakkimizdaController : Controller
    {
        // GET: Hakkimizda
        Context c = new Context();
        public ActionResult Index()
        {
            var veriler = c.Hakkimizda.ToList();
            return View(veriler);
        }
    }
}