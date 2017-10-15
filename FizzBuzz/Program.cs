using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Maximum Number");
            int Max = int.Parse(Console.ReadLine());

            foreach (var result in Enumerable.Range(1, Max).Select(n => FizzBuzz(n)))
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static private string FizzBuzz(int value)
        {
            List<string> iList = new List<string>();
            string output = string.Empty;
           
            iList.Clear();

            if (value % 11 == 0)
            {
                if (value % 13 == 0)
                {
                    iList.Add("Fezz");
                }
                iList.Add("Bong");
            }
            else if (value % 3 == 0)
            {
                iList.Add("Fizz");
                if (value % 13 == 0)
                {
                    iList.Add("Fezz");
                }
                if (value % 5 == 0)
                {
                    iList.Add("Buzz");
                }
                if ( value % 7 == 0)
                {
                    iList.Add("Bang");
                }
            }
            else if (value % 5 == 0)
            {
                if (value % 13 == 0)
                {
                    iList.Add("Fezz");
                }
                iList.Add("Buzz");
                if (value % 7 == 0)
                {
                    iList.Add("Bang");
                }
            }
            else if (value % 7 == 0)
            {
                if (value % 13 == 0)
                {
                    iList.Add("Fezz");
                }
                iList.Add("Bang");
            }
            else
            {
                iList.Add(value.ToString());
            }
            if (value % 17 == 0)
            {
                iList.Reverse();
            }
            output = String.Join("", iList);
            return output;
        }
    }
}
