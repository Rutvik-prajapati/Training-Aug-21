using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTask.Day4.Assignment
{
    //2. Create a user defined exception class NameException which will validate
    //a Name and name should contain only character.If name does not contain proper
    //value it should throw an exception.You need to handle exception in student
    //class.

    class NameException : Exception
    {
        public string msg()
        {
            return "Name is not Valid.";
        }
    }

    class Student1
    {
        string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (!IsAllLetters(value))
                {
                    throw (new NameException());
                }
                name = value;
            }
        }

        public static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }
    }
    class Assignment2Day4
    {
        static void Main(string[] args)
        {
            try
            {
                Student1 student = new Student1();
                Console.WriteLine("Enter Student Name :");
                student.Name = Console.ReadLine();

                Console.WriteLine($"Student Name is {student.Name}");
                Console.ReadLine();
            }
            catch (NameException ne)
            {
                Console.WriteLine("Exception message : {0}", ne.msg());
                Console.ReadLine();
            }

        }
    }
}
