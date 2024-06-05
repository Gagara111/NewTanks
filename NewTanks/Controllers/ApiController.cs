using NewTanks.Game;

namespace NewTanks.Controllers
{
    public class ApiController(IProfile profile)
    {
        public string Login(string login, string password)
        {
            return profile.ValidateProfile(login, password) ? "T" : "F";
        }
    }
}
