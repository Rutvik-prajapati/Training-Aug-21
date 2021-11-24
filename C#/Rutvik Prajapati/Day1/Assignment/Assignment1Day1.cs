using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTask.Day1.Assignment
{
    //Print sum of all the even numbers
    class Assignment1Day1
    {
        static void Main(string[] args)
        {
            
            int total = 0;

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    total = total + i;
                    Console.WriteLine("even number : " + i);
                }
            }
            Console.WriteLine("Sum of even Numbers : " + total);
            Console.ReadLine();
        }
    }
}
