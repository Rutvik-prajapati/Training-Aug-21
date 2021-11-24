using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTask.Day1.Assignment
{
    //Create a weekday enum and accept week day number
    //and display week day.
    class Assignment3Day1
    {
        enum weekDay
        {
            Sunday = 1,  //1
            Monday,      //2
            Tuesday,     //3
            Wednesday,   //4
            Thursday,    //5
            Friday,      //6
            Saturday     //7
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number from 1 to 7 :");

            int weekDayNum = Convert.ToInt32(Console.ReadLine());

            switch (weekDayNum)
            {
                case 1:
                    Console.WriteLine(weekDay.Sunday);
                    break;
                case 2:
                    Console.WriteLine(weekDay.Monday);
                    break;
                case 3:
                    Console.WriteLine(weekDay.Tuesday);
                    break;
                case 4:
                    Console.WriteLine(weekDay.Wednesday);
                    break;
                case 5:
                    Console.WriteLine(weekDay.Thursday);
                    break;
                case 6:
                    Console.WriteLine(weekDay.Friday);
                    break;
                case 7:
                    Console.WriteLine(weekDay.Saturday);
                    break;
            }
            Console.ReadLine();
        }
    }
}
