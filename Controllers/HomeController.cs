using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dynamicWeb_dotnet.Models;
using System.IO;

namespace dynamicWeb_dotnet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Home Message.";
            ViewData["Article-1-Heading"] = "Hire a Professional Handyman - Call 12345";
            ViewData["Article-1-Body"] = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.At eam doctus oportere, eam feugait delectus ne. Quo cu vulputate persecuti. Eum ut natum possim comprehensam, habeo dicta scaevola eu nec. Ea adhuc reformidans eam. Pri dolore epicuri eu, ne cum tantas fierent instructior. Pro ridens intellegam ut, sea at graecis scriptorem eloquentiam.";

            ViewData["Article-2-Heading"] = "Furniture Assembly";
            ViewData["Article-2-Body"] = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. At eam doctus oportere, eam feugait delectus ne. Quo cu vulputate persecuti. Eum ut natum possim comprehensam, habeo dicta scaevola eu nec. Ea adhuc reformidans eam.";

            ViewData["Article-3-Heading"] = "Expert Plumbers";
            ViewData["Article-3-Body"] = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. At eam doctus oportere, eam feugait delectus ne. Quo cu vulputate persecuti. Eum ut natum possim comprehensam, habeo dicta scaevola eu nec. Ea adhuc reformidans eam.";

            ViewData["Article-4-Heading"] = "Interior / Exterior Painting";
            ViewData["Article-4-Body"] = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. At eam doctus oportere, eam feugait delectus ne. Quo cu vulputate persecuti. Eum ut natum possim comprehensam, habeo dicta scaevola eu nec. Ea adhuc reformidans eam.";

            return View(); 
        }  

        public IActionResult PriceList()
        {
            var prices = new List<PriceListModel>();

            var price1 = new PriceListModel
            {
                Service = "Oil Change",
                Info = "Car Running Smooth",
                Price = "3.50"
            };

             var price2 = new PriceListModel
            {
                Service = "Mow Lawn",
                Info = "Grass so Short",
                Price = "3.50"
            }; 

             var price3 = new PriceListModel
            {
                Service = "Workout Partner",
                Info = "Body so Fit",
                Price = "3.50"
            }; 

            prices.Add(price1);
            prices.Add(price2);
            prices.Add(price3);

            return View(prices);
        }

        public IActionResult HandyManService()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult References()
        {
            return View();
        }

         [HttpPost]
         public IActionResult References(string message, string name, string email, string website)
        { 
            using (var writer = new StreamWriter(System.IO.File.Open("comments.csv", FileMode.Append)))
            {
                writer.WriteLine($"{message}, {name}, {website}, {email}");
            }
            Console.WriteLine($"{message}, {name}, {website}, {email}");
            ViewData["message"] = message;
            ViewData["name"] = name;
            ViewData["email"] = email;
            ViewData["website"] = website;

            var commentList = new List<ReferenceModel>();

            var newComment = new ReferenceModel
            {
                Message = message,
                Name = name,
                Email = email,
                Website = website
            }; 

            return View();
        }

        public IActionResult ContactUs()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        } 

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        } 
    }
}
