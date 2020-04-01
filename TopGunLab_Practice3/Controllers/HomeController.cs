using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopGunLab_Practice3.Models;

namespace TopGunLab_Practice3.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
        public ActionResult Index()
        {
            if (Session["products"] == null)
            {
                Session["products"] = new List<Product>();
            }
            return View(Session["products"]);
        }

        public ActionResult Details(int id)
        {
            int index = id;
            Product product = GetById(index);
            return View(product);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            List<Product> products = Session["products"] as List<Product>;
            products.Add(product);
            Session["products"] = products;
            return RedirectToAction("Index");
        }
        private Product GetById(int id)
        {
            List<Product> products = Session["products"] as List<Product>;
            Product product = products[id];
            return product;
        }
    }
}