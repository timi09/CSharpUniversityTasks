using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5._1
{
    class Book : PrintedEdition
    {
        protected string publishingHouse;

        public Book(string name, string publishingHouse, string text, int pagesCount) : base(name, text, pagesCount)
        {
            this.publishingHouse = publishingHouse;
        }

        public override void Show()
        {
            Console.Write("Все книги из списка: ");
            Show(typeof(Book));
        }
    }
}
