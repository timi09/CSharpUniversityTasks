using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork2
{
    internal class Repertoire
    {
        public int Key { get; set; }
        public DateTime Date { get; set; }
        public Session Session { get; set; }
        public float Price { get; set; }
        public int FreeSeatsCount { get; set; }
    }
}
