using System;
using System.Linq;

namespace LinqQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            //string array
            string[] names = { "Ali", "Dipak", "Nisha", "Garima", "Imran", "Sneha", "Firoz", "Sahnu", "Disha" };
            //contains is used to check the character in the object
            var a = from name in names where name.Contains("a") select name;

            // we can use var or string
            foreach (string item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
