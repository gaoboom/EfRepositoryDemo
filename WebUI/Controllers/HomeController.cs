using Repositories;
using Repositories.DomainRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.BusinessLogic;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EfRepoContext efRepoContext = new EfRepoContext();
            UserRepository userRepository = new UserRepository(efRepoContext);
            UserBusinessLogic ubl = new UserBusinessLogic(efRepoContext, userRepository);
            var a = ubl.GetAllUsers();
            int b = 0;
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