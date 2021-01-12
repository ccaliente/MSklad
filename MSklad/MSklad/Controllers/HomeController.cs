using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MSklad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSklad.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext context;

        
        public HomeController()
        {
            this.context = new ApplicationDbContext();
        }
        [Authorize]
        public ActionResult Index()
        {
            bool isUserAdmin = User.IsInRole("Admin");
            if (isUserAdmin)
                return View("AdminIndex");
            int userCount = context.Users.Count();

            //if (userCount == 0)
            //{
            //    var roleStore = new RoleStore<IdentityRole>(new ApplicationDbContext());
            //    var roleManager = new RoleManager<IdentityRole>(roleStore);
            //    roleManager.Create(new IdentityRole("Admin"));
            //}
            ViewBag.UserCount = userCount;
            return View();

        }
        [Authorize]
        public ActionResult AdminIndex()
        {
            return View();

        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}