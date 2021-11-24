using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTask.Day3.Assignment
{
    //Implement all the oops concept for Employee payroll system.

    interface IEmp
    {
        void CreateEmployee();
        void Salary();
        void Display();
    }

    abstract class Employee : IEmp
    {
        static int EmployeeID;
        string Name, Address, PanNum;

        public virtual void CreateEmployee()
        {
            EmployeeID++;
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Address: ");
            Address = Console.ReadLine();
            Console.Write("Enetr pan Number: ");
            PanNum = Console.ReadLine();
        }

        public virtual void Display()
        {
            Console.WriteLine($"EmployeeId  {EmployeeID} Name is {Name} Address is {Address} PanNum is {PanNum} ");
        }


        public abstract void Salary();

    }

    class PartTime : Employee
    {
        int NoOfHours, TotalSales;
        float SalesPerHour;

        public override void CreateEmployee()
        {
            base.CreateEmployee();
            Console.Write("Eneter No. Of Hours: ");
            NoOfHours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter TotalSales: ");
            TotalSales = Convert.ToInt32(Console.ReadLine());
            SalesPerHour = (float)TotalSales / NoOfHours;
        }

        public override void Salary()
        {
            Console.WriteLine($"The Salary of Employee is Rs{NoOfHours * 40 + SalesPerHour * 500}");
        }


    }

    class FullTime : Employee
    {
        decimal Basic, HRA, TA, DA, TotalPay;

        public override void CreateEmployee()
        {
            base.CreateEmployee();
            Console.Write("Eneter base pay: ");
            Basic = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Rent if Employee living in rental accomodation? Or enter 0.");
            HRA = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter TA and Da: ");
            TA = Convert.ToDecimal(Console.ReadLine());
            DA = Convert.ToDecimal(Console.ReadLine());


        }

        public override void Salary()
        {
            Console.WriteLine($"total salary of the employee is {Basic + HRA + TA + DA}");
        }

    }
    class Assignment1Day3
    {
        public void employeeIntialize(IEmp emp)
        {
            if (emp.GetType().Name == "PartTime")
            {
                PartTime partTime = (PartTime)emp;
                partTime.CreateEmployee();
                emp.Salary();

            }
            else if (emp.GetType().Name == "FullTime")
            {
                FullTime fullTime = (FullTime)emp;
                fullTime.CreateEmployee();
                emp.Salary();
            }
        }
        static void Main(string[] args)
        {
            IEmp employee = null;
            Console.WriteLine("Enter 1 for part time and 2 full time employee");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    employee = new PartTime();
                    break;
                case 2:
                    employee = new FullTime();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            var Assignment1Day3 = new Assignment1Day3();
            Assignment1Day3.employeeIntialize(employee);
            Console.ReadLine();
        }
    }
}
