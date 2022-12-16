using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5._1
{
    class Magazine : PrintedEdition
    {
        protected int number;

        public Magazine(string name, int number, string text, int pagesCount) : base(name, text, pagesCount)
        {
            this.number = number;
        }

        public override void Show()
        {
            Console.Write("Все журналы из списка: ");
            Show(typeof(Magazine));
        }
    }
}
