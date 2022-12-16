using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5._1
{
    class Textbook : Book
    {
        protected string subject;
        protected int grade;
        public Textbook(string name, string publishingHouse, string subject, int grade, string text, int pagesCount) : base(name, publishingHouse, text, pagesCount)
        {
            this.subject = subject;
            this.grade = grade;
        }

        public override void Show()
        {
            Console.Write("Все учебники из списка: ");
            Show(typeof(Textbook));
        }
    }
}
