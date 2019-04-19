using System;
using System.Collections.Generic;
using System.Linq;

namespace exc3
{
    public class A
    {
        public A()
        {
        }

       // public List<string> list = new List<string>() { "Text", "Computer", "Automation", "Visual Studio", "Auto Parts", " " };


        public void CompareLenght(string a, string b)
        {
            if (a.Length == b.Length)
            {
                Console.WriteLine("{0} and {1} have the same lenght", a, b);
            }
            else if (a.Length > b.Length)
            {
                Console.WriteLine("{0} is longer than {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} is longer than {1}", b, a);
            }

        }

        public static List<int> AddElements(int num)
        {
            List<int> listOne = new List<int>();

            for (int i = 0; i < num; i++)
            {
                listOne.Add(i);
            }
            return listOne;

        }

        public static bool CompareList<T>(List<int> one, List<int> two)
        {
            if (one.Count == two.Count)
            {
                Console.WriteLine("List {0} and {1} have the same size", nameof(one), nameof(two));
            } 
            else if (one.Count > two.Count)
            {
                Console.WriteLine("List {0} has bigger size than {1}", nameof(one), nameof(two));
            }
            else
            {
                Console.WriteLine("List {0} has bigger size than {1}", nameof(two), nameof(one));
            }
            return false;
        }
        public static bool SortList<T>(string order)
        {
            List<string> list = new List<string>() { "Text", "Computer", "Automation", "Visual Studio", "Auto Parts", " " };
            Console.WriteLine(list.Count);

            if (order == "asc")
            {
                list.Sort();
                foreach (var item in list)
                {
                    Console.WriteLine(item);

                }
            }
            else if (order == "desc")
            {
                var descending = from i in list

                               orderby i descending

                               select i;

                //list.OrderByDescending(item =>item);
                foreach (var item in descending)
                {
                    Console.WriteLine(item);

                }
            }
            else
            {
                Console.WriteLine("Order can be only ASC or DESC");
            }
            return false;

        }

        public static bool FilterList<T>()
        {

            List<string> list = new List<string>() { "Text", "Computer", "Automation", "Visual Studio", "Auto Parts", " " };
            Console.WriteLine("Items on the list: {0}",list.Count);

            list.RemoveAll(item => item == " ");

            foreach (var item in list)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Items after using the filter: {0}", list.Count);
            return false;

        }
        public static bool Duplicates()
        {
            List<int> list = new List<int>() { 1, 1, 2, 3, 4, 4, 5, 6, 7, 8, 10 };
            List<int> distinct = list.Distinct().ToList();

            foreach (int value in distinct)
            {
                Console.WriteLine(value);
            }

            return false;
        }

    }
}
