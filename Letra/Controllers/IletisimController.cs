using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Letra.Models;

namespace Letra.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        Context c = new Context();

        public ActionResult Index()
        {
            var veriler = c.İletisim.ToList();
            return View(veriler);
        }

        public ActionResult MesajSil(int id)
        {
            var msj = c.İletisim.Find(id);
            c.İletisim.Remove(msj);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}