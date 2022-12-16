using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5._1
{
    abstract class PrintedEdition
    {
        protected string name;
        protected string text;
        protected int pagesCount;
        protected static List<PrintedEdition> list = new List<PrintedEdition>();

        public PrintedEdition(string name, string text, int pagesCount) 
        {
            this.name = name;
            this.text = text;
            this.pagesCount = pagesCount;
        }

        public virtual void Add() 
        {
            list.Add(this);
        }

        public virtual void Show() 
        {
            Show(typeof(PrintedEdition));
        }

        protected virtual void Show(Type type)
        {
            foreach (PrintedEdition edition in list)
            {
                if (edition.GetType() == type)
                {
                    Console.Write(edition + " ");
                }
            }
            Console.Write("\n");
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {name}";
        }
    }
}
