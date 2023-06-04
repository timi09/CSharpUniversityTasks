using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork2
{
    internal class Film
    {
        public int Key { get; set; }
        public string Name { get; set; }
        public Person Director { get; set; }
        public Person Operator { get; set; }
        public List<Person> Actors { get; set; }
        public string Genre { get; set; }
        public string FilmStudio { get; set; }
    }
}
