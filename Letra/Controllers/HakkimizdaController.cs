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
        

        public ActionResult HakkimizdaGetir(int id)
        {
            var hak = c.Hakkimizda.Find(id);
            return View("HakkimizdaGetir",hak);
        }

        public ActionResult HakkimizdaGuncelle(Hakkimizda a)
        {
            var hakmzd = c.Hakkimizda.Find(a.Id);
            hakmzd.Aciklama = a.Aciklama;
            hakmzd.LogoLink = a.LogoLink;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}