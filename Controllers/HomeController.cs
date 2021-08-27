using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FullStackTest.Models;

namespace FullStackTest.Controllers
{
    public class HomeController : Controller
    {
        private IDbService _dbservice;
        public HomeController(IDbService dbservice )
        {
            _dbservice = dbservice;
        }

        [Route("/")]
        public IActionResult LoanList()
        {
            return View();
        }

        [Route("/import")]
        public IActionResult Import()
        {
            return View();
        }

        [Route("/about")]
        public IActionResult About()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
