using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Letra.Models;

namespace Letra.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            var veriler = c.Admin.ToList();
            return View(veriler);
        }

        [HttpGet]
        public ActionResult YeniAdminEkle()
        { 
            return View(); 
        
        }

        [HttpPost]
        public ActionResult YeniAdminEkle(Admin a) 

        {
            c.Admin.Add(a);
            c.SaveChanges();
        return RedirectToAction("Index");

        }

        public ActionResult AdminSil(int id)
        {
            var adm=c.Admin.Find(id);
            c.Admin.Remove(adm);
            c.SaveChanges();    
            return RedirectToAction("Index");   
        }

        public ActionResult AdminGetir(int id) 
        {
            var admin = c.Admin.Find(id);
            return View("AdminGetir",admin);
        }

        public ActionResult AdminGuncelle(Admin a)
        {
            var adm = c.Admin.Find(a.Id);
            adm.KullaniciAdi=a.KullaniciAdi; 
            adm.Sifre=a.Sifre;
            c.SaveChanges();
            return RedirectToAction("Index");


        }
    }

}
