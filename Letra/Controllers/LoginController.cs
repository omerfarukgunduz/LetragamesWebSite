using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Letra.Models;

namespace Letra.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();

        public ActionResult Index()
        {
            return View();
        }
    }
}