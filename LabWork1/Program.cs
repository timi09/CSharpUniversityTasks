using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUniversityTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.Write("Введите количество фунтов: ");
                int oldPhounds = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите количество шиллингов: ");
                int oldShillings = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите количество пенсов: ");
                int oldPences = Convert.ToInt32(Console.ReadLine());

                OldBritishCurrency oldPrice = new OldBritishCurrency(oldPhounds, oldShillings, oldPences);

                Console.Write("Устаревших фунтов: ");
                Console.WriteLine(oldPrice);

                NewBritishCurrency newPrice = new NewBritishCurrency(0, oldPrice.GetCurrentPences());

                Console.Write("Десятичных фунтов: ");
                Console.WriteLine(newPrice);
                Console.WriteLine();
            }
        }
    }

    public class OldBritishCurrency
    {
        public const int MaxPences = 12;

        public const int MaxShillings = 20;

        public int Phounds { get; private set; }

        public int Shillings { get; private set; }

        public int Pences { get; private set; }

        public OldBritishCurrency(int phounds, int shillings, int pences)
        {
            this.Phounds = phounds;
            this.Shillings = shillings;
            this.Pences = pences;
            PencesOverflow();
            ShillingsOverflow();
        }

        public int GetCurrentShillings()
        {
            return Phounds * MaxShillings + Shillings;
        }

        public int GetCurrentPences() 
        {
            int currentShillings = GetCurrentShillings();
            return currentShillings * MaxPences + Pences;
        }

        public override string ToString()
        {
            return $"£{Phounds}.{Shillings}.{Pences}";
        }

        private void PencesOverflow() 
        {
            if(Pences >= MaxPences) 
            {
                Shillings += Pences / MaxPences;
                Pences %= MaxPences;
            }
        }

        private void ShillingsOverflow()
        {
            if (Shillings >= MaxShillings)
            {
                Phounds += Shillings / MaxShillings;
                Shillings %= MaxShillings;
            }
        }
    }

    public class NewBritishCurrency
    {
        public const int MaxPences = 100;

        public int Phounds { get; private set; }

        public int Pences { get; private set; }

        public NewBritishCurrency(int phounds, int pences)
        {
            this.Phounds = phounds;
            this.Pences = pences;
            PencesOverflow();
        }

        public override string ToString() 
        {
            return $"£{Phounds}.{Pences}";
        }

        private void PencesOverflow()
        {
            if (Pences >= MaxPences)
            {
                Phounds += Pences / MaxPences;
                Pences %= MaxPences;
            }
        }
    }
}
