using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using festival.Models;

namespace festival.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ViewResult Index()
        {
            var users = GetUsers();

            return View(users);
        }

        public ActionResult details(int id)
        {
            var user = GetUsers().SingleOrDefault(c => c.Id == id);

            if (user == null)
                return HttpNotFound();

            return View(user);
        }

        private IEnumerable<User> GetUsers()
        {
            return new List<User>
            {
                new User {Id = 1, Name = "Robin Reep"},
                new User {Id = 2, Name = "Alex de Ronde"}
            };
        }
    }
}