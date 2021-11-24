using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTask.Day6.Assignment
{
    //Compute area of rectangle using func delegate

    public delegate void calculate(int a, int b);
    class Assignment1Day6
    {
        public static void RectangleArea(int l,int b)
        {
            var result = l * b;
            Console.WriteLine("Rectangle Area Result : {0}",result);
        }
        static void Main(string[] args)
        {
            calculate cal = new calculate(Assignment1Day6.RectangleArea);
            Console.WriteLine("Enter Rectangel length :");
            var length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Rectangel width :");
            var width = Convert.ToInt32(Console.ReadLine());
            cal.Invoke(length, width);
            Console.ReadLine();
        }
    }
}
