using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5._3
{
    abstract class Data
    {
        public abstract void Show();
        public abstract void Filter();
        public abstract void Save();
        public List<int> FilteredIndexes { get; protected set; }
    }
}
