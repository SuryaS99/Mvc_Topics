using System;
using System.Linq;

namespace LinqPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            //Array
            int[] age = { 22, 34, 54, 21, 23, 63, 43, 41 };
            //i is a temproray name to strore data
            //a is a collecion
            //linq query from with select to display data
            Console.WriteLine("\n linq query from with select to display data");
            var a = from i in age where i < 60 select i;//linq query
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            //linq query from with orderby (by default acesending)
            Console.WriteLine("\n linq query from with orderby (by default acesending)");
            var b = from i in age where i < 60 orderby i select i;//linq query
            foreach (var item in b)
            {
                Console.WriteLine(item);
            }

            //linq query from with orderby (by descending)
            Console.WriteLine("\n linq query from with orderby (by descending)");
            var c = from i in age where i < 60 orderby i descending select i;//linq query

            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
        }
    }
}
