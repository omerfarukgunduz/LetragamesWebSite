using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Letra.Models;


namespace Letra.Controllers
{
    public class EkibimizController : Controller
    {
        // GET: Ekibimiz
        Context c = new Context();
        public ActionResult Index()
        {
            var veriler = c.Ekibimiz.ToList();
            return View(veriler);
        }

        [HttpGet]
        public ActionResult YeniUyeEkle()
        {
        return View();
        }


        [HttpPost]
        public ActionResult YeniUyeEkle(Ekibimiz e)

        {
            c.Ekibimiz.Add(e);
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult UyeSil(int id)
        {
            var uye = c.Ekibimiz.Find(id);
            c.Ekibimiz.Remove(uye);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UyeGetir(int id)
        {
            var uye = c.Ekibimiz.Find(id);
            return View("UyeGetir",uye );
        }

        public ActionResult UyeGuncelle(Ekibimiz e)
        {
            var uye = c.Ekibimiz.Find(e.Id);
            uye.UyeAdSoyad = e.UyeAdSoyad;
            uye.UyePozisyon = e.UyePozisyon;
            uye.UyeFotograf = e.UyeFotograf;
            uye.UyeLinkedin = e.UyeLinkedin;
            uye.UyeGithub = e.UyeGithub;
            uye.UyeMail = e.UyeMail;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}