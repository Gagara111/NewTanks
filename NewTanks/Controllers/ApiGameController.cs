using Microsoft.AspNetCore.Mvc;
using NewTanks.Game.Interfaces;

namespace NewTanks.Controllers
{
    public class ApiGameController(IProfile profile)
    {
        public IActionResult Login(string login, string password)
        {
            if (profile.ValidateProfile(login, password))
            {
                return new RedirectToActionResult("Lobby", controllerName: "Game", routeValues: null);
            }
            return new JsonResult("Failure");
        }

    }
}