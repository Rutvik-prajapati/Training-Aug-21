using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTask.Day6.Assignment
{
    //Compute add of two number using lambda expression

    public delegate int Addition(int a, int b);
    class Assignment2Day6
    {
        static void Main(string[] args)
        {
            //expression lamda..
            Addition obj = (a, b) => a + b;
            Console.WriteLine("Enter First Number :");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            var num2 = Convert.ToInt32(Console.ReadLine());
            var result = obj(num1, num2);
            Console.WriteLine("Result of two number is : {0}",result);
            Console.ReadLine();

            //statement lamda..
            //Addition obj = delegate (int a, int b)
            //{

            //};
        }
    }
}
