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
            Product product = GetById(id);
            return View(product);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            Session["ID"] = id;
            List<Product> products = Session["products"] as List<Product>;
            return products.Any(x => x == products[id])
                ? View(products.First(x => x == products[id]))
                : (ActionResult)RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            int id = (int)Session["ID"];
            if (!ModelState.IsValid)
                return View();
            List<Product> products = Session["products"] as List<Product>;
            products[id] = product;
            Session["products"] = products;
            return RedirectToAction("Index");
        }

        public ActionResult Remove(int id)
        {
            ViewBag.ID = id;
            Product product = GetById(id);
            List<Product> products = Session["products"] as List<Product>;
            products.Remove(product);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (!ModelState.IsValid)
                return View();
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