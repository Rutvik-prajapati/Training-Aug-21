using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTask.Day5.Practice
{
    //2. Create a stack which will store Age of person and display it
    //last in first out order.
    class Practice2Day5
    {
        static void Main(string[] args)
        {
            var ageOfPerson = new Stack<int>();
            ageOfPerson.Push(20);
            ageOfPerson.Push(25);
            ageOfPerson.Push(16);
            ageOfPerson.Push(12);
            ageOfPerson.Push(30);

            foreach (var age in ageOfPerson)
            {
                Console.WriteLine("Age : {0}",age);
            }

            var agePOP = ageOfPerson.Pop();
            Console.WriteLine("Popped Value : {0}",agePOP);
            agePOP = ageOfPerson.Pop();
            Console.WriteLine("Popped Value : {0}",agePOP);
            agePOP = ageOfPerson.Pop();
            Console.WriteLine("Popped Value : {0}",agePOP);

            Console.ReadLine();
        }
    }
}
