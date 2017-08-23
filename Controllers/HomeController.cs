using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dynamicWeb_dotnet.Models;

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
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult HandyManService()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

         public IActionResult References()
        {
            ViewData["Message"] = "Your contact page.";

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
