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
    }
}
