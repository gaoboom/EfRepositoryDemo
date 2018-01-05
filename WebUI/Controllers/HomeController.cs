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
            ViewBag.ContextID = efRepoContext.Id;
            var a = ubl.GetAllUsers();
            return View(a);
        }

        public ActionResult Index2()
        {
            EfRepoContext efRepoContext = new EfRepoContext();
            UserRepository userRepository = new UserRepository(efRepoContext);
            UserBusinessLogic ubl = new UserBusinessLogic(efRepoContext, userRepository);
            var a = ubl.GetAllUsers();
            ViewBag.ContextID = efRepoContext.Id;
            return View("Index", a);
        }

        public ActionResult Index3()
        {
            EfRepoContext efRepoContext = new EfRepoContext();
            UserRepository userRepository = new UserRepository(efRepoContext);
            UserBusinessLogic ubl = new UserBusinessLogic(efRepoContext, userRepository);
            var a = ubl.GetAllUsers();
            a[0].UserAccount = "BenBenBen";
            ViewBag.ContextID = efRepoContext.Id;
            return View("Index", a);
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