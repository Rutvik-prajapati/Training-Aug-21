using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTask.Day7.Assignment
{
    class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Deparment { get; set; }
    }
    class Incentive
    {
        public int ID { get; set; }
        public double IncentiveAmount { get; set; }
        public DateTime IncentiveDate { get; set; }
    }
    class Assignment1Day7
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ ID=1,FirstName="John",LastName="Abraham",Salary=1000000,JoiningDate=new DateTime(2013,1,1),Deparment="Banking"},
                new Employee(){ID=2,FirstName="Michael",LastName="Clarke",Salary=800000,JoiningDate=new DateTime(),Deparment="Insurance" },
                new Employee(){ID=3,FirstName="oy",LastName="Thomas",Salary=700000,JoiningDate=new DateTime() ,Deparment="Insurance"},
                new Employee(){ID=4,FirstName="Tom",LastName="Jose",Salary=600000,JoiningDate=new DateTime() ,Deparment="Banking"},
                new Employee(){ID=4,FirstName="TestName2",LastName="Lname%",Salary=600000,JoiningDate=new DateTime(2013,1,1) ,Deparment="Services"}
            };
            List<Incentive> incentives = new List<Incentive>()
            {
                new Incentive(){ ID=1,IncentiveAmount=5000,IncentiveDate=new DateTime(2013,02,02)},
                new Incentive(){ID=2,IncentiveAmount=10000,IncentiveDate=new DateTime(2013,02,4)},
                new Incentive(){ID=1,IncentiveAmount=6000,IncentiveDate=new DateTime(2012,01,5)},
                new Incentive(){ID=2,IncentiveAmount=3000,IncentiveDate=new DateTime(2012,01,5)}
            };
            //1. Get employee details from employees object whose employee
            //name is “John” (note restrict operator)
            Console.WriteLine("1. Get employee details from employees object whose employee name is “John” (note restrict operator)");
            IEnumerable <Employee> empResult1 = from emp in employees
                                              where emp.FirstName == "John"
                                              select emp;
            //OR

            //IEnumerable<Employee> empResult = employees.Where(x => x.FirstName == "John").ToList();

            foreach (var emp in empResult1)
            {
                Console.WriteLine($"Id:{emp.ID}  FirstName:{emp.FirstName}   LastName:{emp.LastName}   Salary:{emp.Salary}   Joining Date:{emp.JoiningDate}   Department:{emp.Deparment}");
            }
            Console.WriteLine("\n");

            //2. Get FIRSTNAME,LASTNAMe from employees object(note project
            //operator)
            Console.WriteLine("2. Get FIRSTNAME,LASTNAMe from employees object(note project operator)");
            IEnumerable<Employee> empResult2 = from emp in employees
                                               select new Employee()
                                               {
                                                   FirstName = emp.FirstName,
                                                   LastName = emp.LastName
                                               };
            //OR
            //IEnumerable<Employee> empResult2 = employees.Select(x => new Employee()
            //                                                    {
            //                                                        FirstName = x.FirstName,
            //                                                        LastName= x.LastName
            //                                                    });

            foreach (var emp in empResult2)
            {
                Console.WriteLine($"FirstName:{emp.FirstName}   LastName:{emp.LastName}");
            }
            Console.WriteLine("\n");
            //3. Select FirstName, IncentiveAmount from employees and
            //incentives object for those employees who have
            //incentives.(join operator)

            Console.WriteLine("3. Select FirstName, IncentiveAmount from employees and incentives object for those employees who have incentives.(join operator)");
            var empResult3 = (from emp in employees
                              join incentive in incentives
                              on emp.ID equals incentive.ID
                              select new
                              {
                                  FirstName = emp.FirstName,
                                  IncentiveAmount = incentive.IncentiveAmount
                              }).ToList();
                    //OR
            //var empResult3 = employees.Join(
            //                            incentives,
            //                            employee => employee.ID,
            //                            incentive => incentive.ID,
            //                            (employee, incentive) => new
            //                            {
            //                                FirstName = employee.FirstName,
            //                                IncentiveAmount = incentive.IncentiveAmount
            //                            }
            //                            ).ToList();
            foreach (var emp in empResult3)


            {
                Console.WriteLine($"FirstName:{emp.FirstName}   Incentive Amount:{emp.IncentiveAmount}");
            }
            Console.WriteLine("\n");

            //4. Get department wise maximum salary from employee table
            //order by salary ascending (note group by)
            Console.WriteLine("4. Get department wise maximum salary from employee table order by salary ascending (note group by)");
            var empResult4 = (from emp in employees
                              group emp by emp.Deparment into empDepartGroup
                              orderby empDepartGroup.Key descending
                              select new
                              {
                                  Department = empDepartGroup.Key,
                                  Salary = empDepartGroup.Max(x => x.Salary)
                              });
            foreach (var emp in empResult4)
            {
                Console.WriteLine($"Department:{emp.Department}  Salary:{emp.Salary}");
            }
            Console.WriteLine("\n");

            //5. Select department, total salary with respect to a
            //department from employees object where total salary
            //greater than 800000 order by TotalSalary
            //descending(group by having)
            Console.WriteLine("5. Select department, total salary with respect to a department from employees object where total salary greater than 800000 order by TotalSalary descending(group by having)");
            var empResult5 = from emp in employees
                             group emp by emp.Deparment into empDepartGroup
                             orderby empDepartGroup.Sum(z=>z.Salary) descending
                             where empDepartGroup.Sum(y => y.Salary) > 800000
                             select new
                             {
                                 Department = empDepartGroup.Key,
                                 TotalSalary = empDepartGroup.Sum(x => x.Salary)
                             };

            foreach (var emp in empResult5)
            {
                Console.WriteLine($"Department:{emp.Department}  Salary:{emp.TotalSalary}");
            }
            Console.ReadLine();
        }

    }
}
