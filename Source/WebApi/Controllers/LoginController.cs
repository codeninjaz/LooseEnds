using System;
using System.Web.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [RequireHttps]
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
    }
}