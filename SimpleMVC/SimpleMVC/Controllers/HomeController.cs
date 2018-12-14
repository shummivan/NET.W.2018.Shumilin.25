using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleMVC.Models;
using SimpleMVC.Helpers;
using BLL.Interface.Interface;
using BLL;
using DAL.Interface.Interface;
using DAL;
using ORM;
using Ninject;
using SimpleMVC.Helpers;
using DependencyResolver;

namespace SimpleMVC.Controllers
{
    public class HomeController : Controller
    {
        private IKernel resolver;
        IService service2;

        //private readonly IService service = new Service(new UnitOfWork(new SimpleDBContext()));        

        public HomeController()
        {
            resolver = new StandardKernel();
            resolver.ConfigurateResolver();
        }
        public ActionResult Index(int page = 1)
        {
            service2 = resolver.Get<IService>();
            var user = Mapper.Map(service2.GetAllAccounts());


            //var t = service2.GetBrand(2);

            int pageSize = 8; // количество объектов на страницу
            IEnumerable<MvcAccount> phonesPerPages = user.Skip((page - 1) * pageSize).Take(pageSize);
            Pagination pageInfo = new Pagination { PageNumber = page, PageSize = pageSize, TotalItems = user.ToList().Count };
            IndexViewModel ivm = new IndexViewModel { PageInfo = pageInfo, Brands = user.ToList() };
            return View(ivm);
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