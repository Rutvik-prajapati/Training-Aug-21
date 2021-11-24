using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTask.Day4.Assignment
{
    //1. Create a user defined Exception Class AgeException.If Age is less than
    //0 it should be thrown an exception.And you need to handle that exception in
    //student class.

    //Note to create a user defined exception class you need to derive it from
    //System.Exception class.
    class AgeException : Exception
    {
        public AgeException(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Student
    {
        int age;

        public string StudentName { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw (new AgeException("Invalid Age"));
                }
                age = value;
            }
        }
    }
    class Assignment1Day4
    {
        static void Main(string[] args)
        {
            try
            {
                Student student = new Student();
                Console.WriteLine("Enter Student Name : ");
                student.StudentName = Console.ReadLine();
                Console.WriteLine("Enter Student Age :");
                student.Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Student name {student.StudentName} and Age {student.Age}");
                Console.ReadLine();
            }
            catch (AgeException msg)
            {
                Console.WriteLine(msg.Message.ToString());
                Console.ReadLine();
            }

        }
    }
}
