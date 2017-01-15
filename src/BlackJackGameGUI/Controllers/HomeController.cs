using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlackJackGameGUI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BlackJackGameGUI.Controllers
{
    public class HomeController : Controller
    {
        private BlackJack _blackJack;
        // GET: /<controller>/
        public IActionResult Index()
        {
            _blackJack = new BlackJack();
            return View(_blackJack);
        }

        public IActionResult NextCard()
        {
            return View();
        }

        public IActionResult Pass()
        {
            return View();
        }
    }
}
