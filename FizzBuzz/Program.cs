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
            List<string> iList = new List<string>();
            string output = string.Empty;
            Console.WriteLine("Please Enter the Maximum Number");
            int Max = int.Parse(Console.ReadLine());

            for (int i = 1; i < Max+1; i++)
            {
                iList.Clear();

                if (i % 11 == 0)
                {
                    if (i % 13 == 0)
                    {
                        iList.Add("Fezz");
                    }
                    iList.Add("Bong");
                }
                else if (i % 3 == 0)
                {
                    iList.Add("Fizz");
                    if (i % 13 == 0)
                    {
                        iList.Add("Fezz");
                    }
                    if (i % 5 == 0)
                    {
                        iList.Add("Buzz");
                    }
                    if ( i % 7 == 0)
                    {
                        iList.Add("Bang");
                    }
                 }
                else if (i % 5 == 0)
                {
                    if (i % 13 == 0)
                    {
                        iList.Add("Fezz");
                    }
                    iList.Add("Buzz");
                    if (i % 7 == 0)
                    {
                        iList.Add("Bang");
                    }
                }
                else if (i % 7 == 0)
                {
                    if (i % 13 == 0)
                    {
                        iList.Add("Fezz");
                    }
                    iList.Add("Bang");
                }
                else
                {
                    iList.Add(i.ToString());
                }
                if (i % 17 == 0)
                {
                    iList.Reverse();
                }
                output = String.Join("", iList);
                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
    }
}
