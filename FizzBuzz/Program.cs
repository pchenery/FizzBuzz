using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Maximum Number");
            int Max = int.Parse(Console.ReadLine());

            foreach (var result in Enumerable.Range(1, Max).Select(n => FizzBuzz.GetValue(n)))
                Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
