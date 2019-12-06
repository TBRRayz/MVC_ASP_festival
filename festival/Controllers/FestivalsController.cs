using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using festival.Models;
using festival.ViewModels;

namespace festival.Controllers
{
    public class FestivalsController : Controller
    {
        // GET: Festivals
        public ViewResult Index()
        {
            var festivals = GetFestivals();

            return View(festivals);

        }

        private IEnumerable<Festival> GetFestivals()
        {
            return new List<Festival>
            {
                new Festival{ Id = 1, Name = "Defqon"},
                new Festival { Id = 2, Name = "Decibel"}
            };
        }

        // GET: festivals/random
        public ActionResult Random()
        {
            var festival = new Festival() {Name = "Defqon"};
            var users = new List<User>
            {
                new User {Name = "user 1"},
                new User {Name = "user 2"}
            };

            var viewModel = new RandomFestivalViewModel
            {
                Festival = festival,
                Users = users
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        [Route("Festivals/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}