using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTask.Day1.Assignment
{
    //Accept Age from user, if age is more than 18 eligible for vote
    //otherwise it should be displayed as not eligible. Do it with
    //ternary operator
    class Assignment5Day1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Age Value : ");
            int age = Convert.ToInt32(Console.ReadLine());
            var result = age > 18 ? "Vote" : "Not eligible";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
