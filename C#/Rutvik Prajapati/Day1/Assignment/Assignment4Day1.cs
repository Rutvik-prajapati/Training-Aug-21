using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTask.Day1.Assignment
{
    //Accept 10 student Name,Address,Hindi,English,Maths Marks ,do
    //the total and compute Grade. Note do it with Array and display
    //the result in grid format
    class Assignment4Day1
    {
        static void Main(string[] args)
        {
            string[] studentName = new string[10];
            string[] studentAddress = new string[10];
            int[] hindi = new int[10];
            int[] english = new int[10];
            int[] maths = new int[10];
            int[] total = new int[10];

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Enter Student{i} Name:");
                studentName[i] = Console.ReadLine();

                Console.WriteLine("Enter Address : ");
                studentAddress[i] = Console.ReadLine();

                Console.WriteLine("Enter Hindi mark : ");
                hindi[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter English mark : ");
                english[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter maths mark : ");
                maths[i] = Convert.ToInt32(Console.ReadLine());

                total[i] = hindi[i] + english[i] + maths[i];

                Console.WriteLine("\n");
            }

            char gradeEvaluate(int totalValue)
            {
                if (totalValue >= 140)
                {
                    return 'A';
                }
                else if (totalValue >= 130)
                {
                    return 'B';
                }
                else if (totalValue >= 120)
                {
                    return 'C';
                }
                else if (totalValue >= 110)
                {
                    return 'D';
                }
                else if (totalValue >= 100)
                {
                    return 'E';
                }
                else
                {
                    return 'F';
                }
            }

            Console.WriteLine("Name     Address     hindi       english     maths       total       grade");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{studentName[i]}        {studentAddress[i]}     {hindi[i]}      {english[i]}        {maths[i]}      {total[i]}      {gradeEvaluate(total[i])}");
            }
            Console.ReadLine();
        }
    }
}
