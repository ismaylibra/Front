using Front_To_Back.Models;
using Microsoft.AspNetCore.Mvc;

namespace Front_To_Back.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()

        {
            var category = new List<Categories>
            {
                new Categories()
                {
                    Id = 1,
                    Name = "Shirts"
                },
                new Categories()
                {
                    Id = 2,
                    Name = "Jeans"
                },
                new Categories()
                {
                    Id = 3,
                    Name = "SwimWear"
                },
                new Categories()
                {
                    Id = 4,
                    Name = "SleepWear"
                },
                new Categories()
                {
                    Id = 5,
                    Name = "SportsWear"
                },
                new Categories()
                {
                    Id = 6,
                    Name = "JumpSuits"
                },
                new Categories()
                {
                    Id = 7,
                    Name = "Blazers"
                },
                new Categories()
                {
                    Id = 8,
                    Name = "Jackets"
                },
                new Categories()
                {
                    Id = 9,
                    Name = "Shoes"
                }
            };
            var product = new List<Products>
            {
                new Products()
                {
                    Id = 1,
                    Image = "cat-1.jpg",
                    Name = "Men's Dresses",
                    Price = "$123.69"

                },
                new Products()
                {
                    Id = 2,
                    Image = "cat-2.jpg",
                    Name = "Men's Dresses",
                     Price = "$123.69"

                },
                new Products()
                {
                    Id = 3,
                    Image = "cat-3.jpg",
                    Name = "Men's Dresses",
                     Price = "$123.69"
                },
                new Products()
                {
                    Id = 4,
                    Image = "cat-4.jpg",
                    Name = "Men's Dresses",
                     Price = "$123.69"
                },
                new Products()
                {
                    Id = 5,
                    Image = "cat-5.jpg",
                    Name = "Men's Dresses",
                     Price = "$123.69"
                },
                new Products()
                {
                    Id = 6,
                    Image = "cat-6.jpg",
                    Name = "Men's Dresses",
                     Price = "$123.69"
                }
            };
            var homeView = new HomeViewModel
            {
                Categories = category,
                Products = product
               
            };

            return View(homeView);
        }
    }
}
