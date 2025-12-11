using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program2
    {
        public static void Main1(String[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(2);
            list.Add(30);
            list.Add(4);
            list.Add(55);
            list.Add(60);
            list.Add(7);
            list.Add(8);

            var even = from l1 in list 
                       where l1 % 2 == 0 
                       select l1;

            Console.WriteLine("Printing Even values");
            foreach (var item in even)
            {
                Console.WriteLine(item);
            }


            int max_val = list.Max();
            int min_val = list.Min();
            Console.WriteLine($" Max value in list is :{max_val} and min value is :{min_val}");

            even = from l1 in list
                   where l1 > 20
                   orderby l1 descending
                   select l1;

            Console.WriteLine("Printing value greater than 20 in descending order ");

            foreach (var item in even)
            {
                Console.WriteLine(item);
            }

        }
    }
}
