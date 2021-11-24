using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTask.Day5.Practice
{
    //1. Create a list which will store 5 student names and then
    //display it search it index number
    class Practice1Day5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 student name : ");
            List<string> students = new List<string>(5);
            for (int i = 0; i < 5; i++)
            {
                var student = Console.ReadLine();
                students.Add(student);
            }
            Console.WriteLine("\n");

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();
        }
    }
}
