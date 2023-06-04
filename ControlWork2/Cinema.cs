using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork2
{
    internal class Cinema : ISerializeble
    {
        public int Key { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Category { get; set; }
        public int SeatCount { get; set; }
        public int HallsCount { get; set; }
        public int State { get; set; }

        public void Deserialize(string str)
        {
            string[] fields = str.Split(';');

            Key = int.Parse(fields[0]);
            Name = fields[1];
            Address = fields[2];
            Category = fields[3];
            SeatCount = int.Parse(fields[4]);
            HallsCount = int.Parse(fields[5]);
            State = int.Parse(fields[6]);
        }

        public string Serialize()
        {
            return $"{Key};{Name};{Address};{Category};{SeatCount};{HallsCount};{State}";
        }
    }
}
