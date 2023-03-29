using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork1
{
    internal class Article
    {
        public Person Person { get; set; }
        public string Title { get; set; }
        public double Rating { get; set; }

        public Article(Person person, string title, double rating)
        {
            Person = person;
            Title = title;
            Rating = rating;
        }

        public Article()
        {
            Person = new Person("Иванов", "Иван");
            Title = "Статья";
            Rating = 5.5;
        }

        public override string ToString()
        {
            return $"Название статьи: {Title}\n" +
                $"Автор статьи: {Person}\n" +
                $"Рейтинг статьи: {Rating}";
        }
    }
}
