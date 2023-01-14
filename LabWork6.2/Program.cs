using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork6._2
{
    class CarStatement : IComparable<CarStatement>, IComparer<CarStatement>
    {
        public string CarModel { get; private set; }
        public string LastnameOfOwner { get; private set; }
        public int YearOfBuying { get; private set; }
        public int CarMileage { get; private set; }

        public CarStatement(string carModel, string lastnameOfOwner, int yearOfBuying, int carMileage) 
        {
            this.CarModel = carModel;
            this.CarMileage = carMileage;
            this.LastnameOfOwner = lastnameOfOwner;
            this.YearOfBuying = yearOfBuying;
        }

        public int Compare(CarStatement x, CarStatement y) // сравнение по году как сравнитель
        {
            if (x == null)
                return -1;

            if (y == null)
                return 1;

            if (x.YearOfBuying > y.YearOfBuying)
                return 1;

            if (x.YearOfBuying == y.YearOfBuying)
                return 0;

            return -1;
        }

        public int CompareTo(CarStatement other) //стандартное сравнение по пробегу
        {
            if (other == null || this.CarMileage > other.CarMileage)
                return 1;

            if (this.CarMileage == other.CarMileage)
                return 0;

            return -1;
        }

        public override string ToString()
        {
            return $"{CarModel} {LastnameOfOwner} {YearOfBuying} {CarMileage}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<CarStatement> array = new List<CarStatement>();
            array.Add(new CarStatement("Дастер", "Разиньков", 2014, 50000));
            array.Add(new CarStatement("Калина", "Тихонов", 2015, 120000));
            array.Add(new CarStatement("Логан", "Овеченоко", 2019, 90000));
            array.Add(new CarStatement("Матиз", "Лукьянчиков", 2011, 90000));
            array.Add(new CarStatement("Жигули", "Асмолов", 2013, 120000));

            array.Sort(new CarStatement("", "", 0, 0)); // пустой объект выступает в роли сравнителя(метод Compare(x, y) сравнение по году) 

            array = array.Where(car => car.YearOfBuying < 2015).ToList();

            array.Sort(); //стандартное сравнение методом CompareTo(other) по пробегу

            Console.WriteLine(String.Join("\n\r", array));
            Console.ReadLine();
        }
    }
}
