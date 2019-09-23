using Microsoft.AspNetCore.Mvc;
using MIO.Football.MVC.Models.ViewModels;

namespace MIO.Football.MVC.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View(new SearchViewModel());
        }

        public IActionResult SessionTimeout()
        {
            return View();
        }
    }
}