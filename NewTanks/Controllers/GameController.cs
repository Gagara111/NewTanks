using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NewTanks.Controllers
{
    public class GameController : Controller
    {

        public IActionResult Game()
        {
            return View();
        }

    }
}
