 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

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
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
           

            ViewBag.Products = productList;
            return View();
        }

        public ActionResult ProductId(int id)
        {
            ViewBag.Product = productList[id];
            return View();
        }
    }
}