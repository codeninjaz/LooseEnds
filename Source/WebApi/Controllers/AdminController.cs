using System.Linq;
using System.Web.Mvc;
using GnuggisWebApi.Models;
using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Controllers
{
    [RequireHttps]
    [Authorize(Roles = Role.Admin)]
    [RoutePrefix("admin")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Users()
        {
            var userInformation = new UsersViewModel();            
            using (var ctx = new ApplicationDbContext())
            {
                userInformation.Users = ctx.Users.ToList();
                userInformation.Count = ctx.Users.Count();
            }

            return View(userInformation);
        }

        [Route("user/edit/{userId}")]
        public ActionResult EditUser(string userId)
        {
            ApplicationUser user;
            using (var ctx = new ApplicationDbContext())
            {
                user = ctx.Users.Single(m => m.Id == userId);
            }

            return View(user);
        }

        [HttpPost]
        [Route("user/edit/{userId}")]
        public ActionResult EditUser(ApplicationUser user, FormCollection form)
        {

            var userInfo = new UsersViewModel();            

            using (var ctx = new ApplicationDbContext())
            {
                var userToChange = ctx.Users.Single(m => m.Id == user.Id);

                if (form["Admin"].Contains("true"))
                {
                    userToChange.Roles.Add(new Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole() { RoleId = "1", UserId = user.Id });
                }

                userToChange.UserName = user.UserName;

                ctx.SaveChanges();

                userInfo.Users = ctx.Users.ToList();
                userInfo.Count = ctx.Users.Count();
            }

            return View("~/Views/Admin/Users.cshtml", userInfo);
        }

        [Route("user/delete/{userId}")]
        public ActionResult DeleteUser(string userId)
        {
            var userInfo = new UsersViewModel();
            ApplicationUser user;
            using (var ctx = new ApplicationDbContext())
            {
                user = ctx.Users.Single(m => m.Id == userId);
                ctx.Users.Remove(user);

                ctx.SaveChanges();

                userInfo.Users = ctx.Users.ToList();
                userInfo.Count = ctx.Users.Count();
            }

            return View("~/Views/Admin/Users.cshtml", userInfo);
        }
    }
}