using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork1
{
    internal class Magazine
    {
        private string name;
        private Frequency frequency;
        private DateTime dateOfRelease;
        private int countInCirculation;
        private List<Article> articles;

        public string Name { get { return name; } }
        public Frequency Frequency { get { return frequency; } }
        public DateTime DateOfRelease { get { return dateOfRelease; } }
        public int CountInCirculation { get { return countInCirculation; } }
        public List<Article> Articles { get { return articles; } }

        public Magazine(string name, Frequency frequency, DateTime date, int count) 
        {
            this.name = name;
            this.frequency = frequency;
            this.dateOfRelease = date;
            this.countInCirculation = count;
            this.articles = new List<Article>();
        }

        public Magazine()
        {
            this.name = "Ералаш";
            this.frequency = new Frequency(1, 7);
            this.dateOfRelease = new DateTime(1974, 4, 3);
            this.countInCirculation = 400;
            this.articles = new List<Article>();
        }

        public double AverageRating
        {
            get
            {
                double ratingSum = 0;
                foreach (var article in articles)
                {
                    ratingSum += article.Rating;
                }

                return ratingSum / articles.Count;
            }
        }

        public bool this[Frequency freq]
        {
            get { return this.frequency.Equals(freq); }
        }

        public void AddArticles(params Article[] newArticles) 
        {
            foreach (var article in newArticles)
            {
                this.articles.Add(article);
            }
        }

        public override string ToString()
        {
            return $"Название журнала: {name}\n" +
                $"Частота выхода журнала: {frequency}\n" +
                $"Дата выхода журнала: {dateOfRelease.ToString("dd.MM.yyy")}\n" +
                $"Тираж журнала: {countInCirculation}\n" +
                $"Средний рейтинг статей журнала: {AverageRating}\n" +
                $"Статьи журнала:\n" +
                $"[\n" +
                $"{string.Join(",\n", articles)}" +
                $"]";
        }
    }
}
