using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork2
{
    interface ISerializeble
    {
        string Serialize();
        void Deserialize(string str);
    }
}
