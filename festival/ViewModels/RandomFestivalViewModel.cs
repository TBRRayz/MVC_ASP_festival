using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using festival.Models;

namespace festival.ViewModels
{
    public class RandomFestivalViewModel
    {
        public Festival Festival { get; set; }
        public List<User> Users { get; set; }
    }
}