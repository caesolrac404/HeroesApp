using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApp.Data.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Age { get; set; }
        public string City { get; set; } = String.Empty;
        public string Picture { get; set; } = String.Empty;
        public List<Rating> Ratings { get; set; }

    }
}
