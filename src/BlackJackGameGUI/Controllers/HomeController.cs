using BlackJackGameGUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
            SetSession(_blackJack);
            return View(_blackJack);
        }

        public IActionResult NextCard()
        {
            _blackJack = JsonConvert.DeserializeObject<BlackJack>(HttpContext.Session.GetString("BlackJack"));
            _blackJack.GivePlayerAnotherCard();
            SetSession(_blackJack);
            return View(nameof(Index), _blackJack);
        }

        public IActionResult Pass()
        {
            _blackJack = JsonConvert.DeserializeObject<BlackJack>(HttpContext.Session.GetString("BlackJack"));
            _blackJack.PassToDealer();
            SetSession(_blackJack);
            return View(nameof(Index), _blackJack);
        }

        private void SetSession(BlackJack blackjack)
        {
            HttpContext.Session.SetString("BlackJack", JsonConvert.SerializeObject(blackjack));
        }
    }
}
