using Front_To_Back.DAL;
using Front_To_Back.Models;
using Microsoft.AspNetCore.Mvc;

namespace Front_To_Back.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext? _dbcontext;
        public HomeController(AppDbContext? dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IActionResult Index()

        {
            var products = _dbcontext?.Products.ToList();
            var categories = _dbcontext?.Categories.ToList();
            //var category = new List<Category>
            //{
            //    new Category()
            //    {
            //        Id = 1,
            //        Name = "Shirts"
            //    },
            //    new Category()
            //    {
            //        Id = 2,
            //        Name = "Jeans"
            //    },
            //    new Category()
            //    {
            //        Id = 3,
            //        Name = "SwimWear"
            //    },
            //    new Category()
            //    {
            //        Id = 4,
            //        Name = "SleepWear"
            //    },
            //    new Category()
            //    {
            //        Id = 5,
            //        Name = "SportsWear"
            //    },
            //    new Category()
            //    {
            //        Id = 6,
            //        Name = "JumpSuits"
            //    },
            //    new Category()
            //    {
            //        Id = 7,
            //        Name = "Blazers"
            //    },
            //    new Category()
            //    {
            //        Id = 8,
            //        Name = "Jackets"
            //    },
            //    new Category()
            //    {
            //        Id = 9,
            //        Name = "Shoes"
            //    }
            //};
            //var product = new List<Product>
            //{
            //    new Product()
            //    {
            //        Id = 1,
            //        Image = "cat-1.jpg",
            //        Name = "Men's Dresses",
            //        Price = 123.69m

            //    },
            //    new Product()
            //    {
            //        Id = 2,
            //        Image = "cat-2.jpg",
            //        Name = "Men's Dresses",
            //         Price = 123.69m

            //    },
            //    new Product()
            //    {
            //        Id = 3,
            //        Image = "cat-3.jpg",
            //        Name = "Men's Dresses",
            //         Price = 123.69m
            //    },
            //    new Product()
            //    {
            //        Id = 4,
            //        Image = "cat-4.jpg",
            //        Name = "Men's Dresses",
            //         Price = 123.69m
            //    },
            //    new Product()
            //    {
            //        Id = 5,
            //        Image = "cat-5.jpg",
            //        Name = "Men's Dresses",
            //         Price = 123.69m
            //    },
            //    new Product()
            //    {
            //        Id = 6,
            //        Image = "cat-6.jpg",
            //        Name = "Men's Dresses",
            //         Price = 123.69m
            //    }
            //};
            var homeView = new HomeViewModel
            {
                Categories = categories,
                Products = products
               
            };

            return View(homeView);
        }
    }
}
