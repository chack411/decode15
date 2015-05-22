using Microsoft.AspNet.Mvc;
using decode15.Models;

namespace decode15.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(CreateUser());
        }

        public User CreateUser()
        {
            User user = new User()
            {
                Name = "Akira",
                Message = "de:code 2015 へようこそ！"
            };

            return user;
        }
    }
}
