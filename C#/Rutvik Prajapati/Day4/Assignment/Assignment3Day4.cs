using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTask.Day4.Assignment
{
    //3. Create a user defined Exception DateException class which will validate
    //date should not be less than the current date. If date is less than current
    //date it should throw an exception.

    class DateException : Exception
    {
        public string msg()
        {
            return "Date is less than current date.";
        }
    }
    class Assignment3Day4
    {
        static void Main(string[] args)
        {
            try
            {
                var todayDate = DateTime.Today;
                Console.WriteLine("Enter Date :");
                var userEnteredDate = Convert.ToDateTime(Console.ReadLine());
                if (userEnteredDate < todayDate)
                {
                    throw (new DateException());
                }
                Console.WriteLine($"Entered Date {userEnteredDate} is Proper.");
                Console.ReadLine();
            }
            catch (DateException de)
            {
                Console.WriteLine("Exception Message :{0}", de.msg());
                Console.ReadLine();
            }
        }
    }
}
