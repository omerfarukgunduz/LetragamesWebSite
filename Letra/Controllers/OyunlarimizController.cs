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

        [HttpGet]
        public ActionResult YeniOyunEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniOyunEkle(Oyunlarimiz o)
        {
            c.Oyunlarimiz.Add(o);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult OyunSil(int id)
        {
            var oyn = c.Oyunlarimiz.Find(id);
            c.Oyunlarimiz.Remove(oyn);
            c.SaveChanges();    
            return RedirectToAction("Index");
        }

        public ActionResult OyunGetir(int id) 
        {
            var oyn = c.Oyunlarimiz.Find(id);
            return View("OyunGetir", oyn);
        }

        public ActionResult OyunGuncelle(Oyunlarimiz o)
        {
            var oyn=c.Oyunlarimiz.Find(o.Id);
            oyn.OyunAdi = o.OyunAdi;
            oyn.OyunAciklamasi = o.OyunAciklamasi;
            oyn.OyunFotografi = o.OyunFotografi;
            oyn.OyunLinki = o.OyunLinki;
            c.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}