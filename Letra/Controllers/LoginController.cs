using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Letra.Models;

namespace Letra.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin a)
        {
            var adminkullanici = c.Admin.FirstOrDefault(x => x.KullaniciAdi == a.KullaniciAdi && x.Sifre == a.Sifre);
            if (adminkullanici != null)
            {
                FormsAuthentication.SetAuthCookie(adminkullanici.KullaniciAdi, false);
                Session["KullaniciAdi"] = adminkullanici.KullaniciAdi.ToString();
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult LogOut()
        {
         FormsAuthentication.SignOut(); 
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
    
}