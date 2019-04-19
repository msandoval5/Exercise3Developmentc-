using System;
using System.Collections.Generic;

namespace exc3
{
    class Program
    {
        static void Main(string[] args)
        {
            A.SortList<string>("desc");
            A.FilterList<string>();
            A.Duplicates();

            /*
            A.CompareLenght("hola", "mama");
            A.AddElements(8);
            A.CompareList<int>(A.AddElements(5), A.AddElements(6)); */

            B b = new B();
            b.CompareLenght("mariana", "marian");
            b.Display();


            IA a = new Methd();
            a.Display();


        }

        public interface IA
        {
            void Display();
        }

        public class Methd : IA
        {
            public void Display()
            {
                Console.WriteLine("Hello Interface");
            }
        }


    }
}
