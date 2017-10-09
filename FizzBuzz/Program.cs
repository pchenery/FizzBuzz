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
            string PrintString = string.Empty;
            for (int i = 1; i < 201; i++)
            {
                PrintString = string.Empty;
                if (i % 11 == 0)
                {
                    PrintString = "Bong";
                    if (i % 13 == 0)
                    {
                        PrintString = "Fezz" + PrintString;
                    }
                }
                else if (i % 3 == 0)
                {
                    PrintString = "Fizz";
                    if (i % 13 == 0)
                    {
                        PrintString = PrintString + "Fezz";
                    }
                    if (i % 5 == 0)
                    {
                        PrintString = PrintString + "Buzz";
                    }
                    if ( i % 7 == 0)
                    {
                        PrintString = PrintString + "Bang";
                    }
                 }
                else if (i % 5 == 0)
                {
                    PrintString = PrintString + "Buzz";
                    if (i % 13 == 0)
                    {
                        PrintString = "Fezz" + PrintString;
                    }
                    if (i % 7 == 0)
                    {
                        PrintString = PrintString + "Bang";
                    }
                }
                else if (i % 7 == 0)
                {
                    PrintString = "Bang";
                    if (i % 13 == 0)
                    {
                        PrintString = "Fezz" + PrintString;
                    }
                }
                else
                {
                    PrintString = i.ToString();
                }
                Console.WriteLine(PrintString);
            }
            Console.ReadLine();
        }
    }
}
