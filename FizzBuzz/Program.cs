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
            //For loop to count to 100
            for (int i = 1; i <= 100; i++)
            {
                int threeNumbers = i % 3;
                int fiveNumbers = i % 5;

                //If loop to check if reminder is 0 for 3 and 5
                if(threeNumbers == 0 && fiveNumbers == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                //Else if for 5
                else if (fiveNumbers == 0)
                {
                    Console.WriteLine("Buzz");
                }
                //Else if for 3
                else if (threeNumbers == 0)
                {
                    Console.WriteLine("Fizz");
                }
                //Else to print numbers
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
