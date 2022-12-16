using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("книга 1", "1", "", 1);
            Book book2 = new Book("книга 2", "1", "", 1);
            Book book3 = new Book("книга 3", "1", "", 1);
            Book book4 = new Book("книга 4", "1", "", 1);
            Textbook textbook1 = new Textbook("учебник 1", "1", "math", 5, "", 1);
            Textbook textbook2 = new Textbook("учебник 2", "1", "math", 5, "", 1);
            Textbook textbook3 = new Textbook("учебник 3", "1", "math", 5, "", 1);
            Magazine magazine1 = new Magazine("журнал 1", 1, "", 1);
            Magazine magazine2 = new Magazine("журнал 2", 2, "", 1);

            book1.Add();
            book2.Add();
            book3.Add();
            book4.Add();

            textbook1.Add();
            textbook2.Add();
            textbook3.Add();

            magazine1.Add();
            magazine2.Add();

            book1.Show();

            textbook3.Show();

            magazine1.Show();

            Console.ReadLine();
        }
    }
}
