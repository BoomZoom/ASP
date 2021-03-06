﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Diagnostics;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        static private List<Product> productList = new List<Product>() {
                new Product()
                {
                    Id = 1,
                    Name = "Игровая мышь Armaggeddon AlienCraft II G13 Cosmic Blue - 11 программируемых кнопок, 5600 cpi,11750fps, Laser combi//usb//wireless",
                    Price = 9.99M
                },
                new Product()
                {
                    Id = 2,
                    Name = "Мышь Razer Mamba HyperFlux + игровая поверхность Razer Firefly HyperFlux Bundle USB Black (RZ83-02480100-B3M1)",
                    Price = 91.99M
                },
                new Product()
                {
                    Id = 3,
                    Name = "Мышь Razer Lancehead Wireless Grey (RZ01-02120100-R3G1)",
                    Price = 132.99M
                },
                new Product()
                {
                    Id = 4,
                    Name = "Мышь Logitech G903 Black (ljfi)",
                    Price = 19.33M
                },
                new Product()
                {
                    Id = 5,
                    Name = "Мышь Razer Mamba 16000 Wireless/USB Black (RZ01-01360100-R3G1)",
                    Price = 55.99M
                },
                new Product()
                {
                    Id = 6,
                    Name = "Мышь Roccat Leadr Wireless/USB Black (ROC-11-852)",
                    Price = 12.99M
                },
            };
        static private LibraryContext db = new LibraryContext();
        
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            ViewBag.Products = db.Products.ToList();//productList;
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            //IEnumerable<SelectListItem>
                var a= db.Categoryes.ToDictionary((p)=>p.Id);
            //var categories = db.Categoryes
            //    .Select(x => new SelectListItem() { Text = x.Name, Value = x.Id.ToString() });

            var cat = db.Categoryes.ToList();
            var list = new List<SelectListItem>();
            foreach (var c in cat)
            {
                list.Add(new SelectListItem() { Text = c.Name, Value = c.Id.ToString() });
            }
            

            ViewBag.Categoryes = list;
            ViewBag.ProductId = id;
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            var p = new Product();
            p.CategoryId = product.CategoryId;
            p.Price = Convert.ToDecimal(product.Price);
            //p.Id = product.Id;
            p.Name = product.Name;

            //var a = db.Products.Find(product);
            //if (a!=null)
            //{
            //    a = product;
            //}

            //TODO change item database
             db.Products.Add(p);
            // Debug.WriteLine(product.Category.Name+" "+ product.Category.Name);
            db.SaveChanges();
            //Debug.WriteLine(Request.Form["Categoryes"]);

            var cat = db.Categoryes.ToList();
            var list = new List<SelectListItem>();
            foreach (var c in cat)
            {
                list.Add(new SelectListItem() { Text = c.Name, Value = c.Id.ToString() });
            }


            ViewBag.Categoryes = list;

            ViewBag.Products = db.Products.ToList();
            return View(product);
        }



        public ActionResult ProductId(int id)
        {

            var product = db.Products.ToList().Find((p) => p.Id == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            //ViewBag.Product = product;
            return View(product);
        }
    }
}