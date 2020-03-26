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
            if (Session["products"]==null)
            {
                Session["products"] = new List<Product> {
                    new Product (){Name = "Milk", Quantity = "2 l"},
                    new Product (){Name = "Tomatoes", Quantity = "5 kg"},
                    new Product (){Name = "Grechka", Quantity = "400 g"}
                    };
            }
            return View(Session["products"]);
        }

        public ActionResult Details(int id)
        {
            int index = id;
            Product product = GetById(index);
            return View(product);
        }

        private void Add(Product product)
        {
            List<Product> products = (List<Product>)Session["products"];
            products.Add(product);
            Session["products"] = products;
        }
        private Product GetById(int id)
        {
            List<Product> products = (List<Product>)Session["products"];
            Product product = products[id];
            return product;
        }
    }
}