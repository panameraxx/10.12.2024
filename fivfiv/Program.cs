using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fivfiv
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 3, 7, 1, 9, 5, 3, 6, 3 };
            //int count = 0;
            //foreach (int x in array)
            //{
            //    if (x == 3)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            //int count = array.Count(x => x == 3);
            //Console.WriteLine(count);


            //string[] people = { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };
            //string first = Array.Find(people, person => person.Length > 3);
            //string last = Array.FindLast(people, person => person.Length > 3);
            //string[] all = Array.FindAll(people, person => person.Length == 3);
            //Array.Sort(people, 1, 3);
            //Console.WriteLine(first);
            //Console.WriteLine(last);

            //foreach (var name in all)
            //{
            //    Console.WriteLine(name);
            //}
            //foreach (var person in people)
            //{
            //    Console.Write($"{person} ");
            //}

            int[] arr = { 3, 7, 1, 9, 5, 6, 8, 10 };
            arr = arr.Where(x => x % 2 != 0).ToArray();
            foreach (var elem in arr)
            {
                Console.Write(elem + " ");
            }
            int sum = arr.Sum();
            Console.WriteLine("Сумма = " + sum);
            Console.ReadKey();
            
        }
    }
}
