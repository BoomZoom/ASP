namespace WebApplication1.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication1.Models.LibraryContext context)
        {

            List<Category> categories = new List<Category>()
            {
                new Category (){Name="first"},
                new Category (){Name="second"},
                new Category (){Name="last"},
            };
            context.Categoryes.AddRange(categories);
            List<Product> products = new List<Product>() {
                new Product(){Name="1",Price=10,CategoryId=1},
                new Product(){Name="3",Price=10,CategoryId=1},
                new Product(){Name="4",Price=10,CategoryId=1},
                new Product(){Name="2",Price=10,CategoryId=1},
                new Product(){Name="5",Price=10,CategoryId=2},
                new Product(){Name="6",Price=10,CategoryId=2},
                new Product(){Name="7",Price=10,CategoryId=2},
                new Product(){Name="8",Price=10,CategoryId=2},
                new Product(){Name="9",Price=10 ,CategoryId=3},
                new Product(){Name="10",Price=10,CategoryId=3},
                new Product(){Name="11",Price=10,CategoryId=3},
                new Product(){Name="12",Price=10,CategoryId=3},
            };
            context.Products.AddRange(products);
            List<Sales> sales = new List<Sales>()
            {
                new Sales(){Product=products[0],Count=100,Date=new DateTime(2018, 10, 24)},
                new Sales(){Product=products[5],Count=100,Date=new DateTime(2018, 10, 23)},
                new Sales(){Product=products[8],Count=5,Date=new DateTime(2018, 10, 22)},
                new Sales(){Product=products[8],Count=190,Date=new DateTime(2018, 10, 24)},
                new Sales(){Product=products[1],Count=100,Date=new DateTime(2018, 10, 23)},
                new Sales(){Product=products[2],Count=10,Date=new DateTime(2018, 10, 22)},
            };
            context.Sales.AddRange(sales);

        }
    }
}
