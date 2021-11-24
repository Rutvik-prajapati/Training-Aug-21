using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTask.Day5.Assignment
{
    class Mobike
    {
        public int BikeNumber { get; set; }
        public int PhoneNumber { get; set; }
        public string Name { get; set; }
        public int Days { get; set; }
        public void input(int bikenum, int phonenum,string name,int days)
        {
            this.BikeNumber = bikenum;
            this.PhoneNumber = phonenum;
            this.Name = name;
            this.Days = days;
        }

        public int compute()
        {
            int temp,total=0;
            if (Days>=5 || Days<=5)
            {
                temp = Days - 5;
                total = 5 * 500;
                if (temp>=5)
                {
                    temp = temp - 5;
                    total = total + (5 * 400);
                    total = total + (temp * 200);
                }
            }
            return total;
        }

        public void display()
        {
            Console.WriteLine($"Bike No.:{BikeNumber}         PhoneNo.:{PhoneNumber}             No. of days.:{Days}         Charge : {this.compute()}");
        }
    }
    class Assignment1Day5
    {
        public static Mobike Add()
        {
            Mobike mobike = new Mobike();
            Console.WriteLine($"Enter Bike Number :");
            var bikeNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter Phone Number : ");
            var phoneNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter Name : ");
            var name = Console.ReadLine();
            Console.WriteLine($"Enter Days Number : ");
            var days = Convert.ToInt32(Console.ReadLine());
            mobike.input(bikeNum,phoneNum,name,days);
            mobike.compute();
            mobike.display();
            return mobike;
        }
        public static Mobike Edit()
        {
            Console.WriteLine("Enter Value for update/edit information..");
            Mobike mobike = new Mobike();
            Console.WriteLine($"Enter Bike Number :");
            var bikeNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter Phone Number : ");
            var phoneNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter Name : ");
            var name = Console.ReadLine();
            Console.WriteLine($"Enter Days Number : ");
            var days = Convert.ToInt32(Console.ReadLine());
            mobike.input(bikeNum, phoneNum, name, days);
            mobike.compute();
            mobike.display();
            return mobike;
        }
        static void Main(string[] args)
        {
            List<Mobike> mobilesList = new List<Mobike>(10);
            Mobike mobike = new Mobike();
            
            while(true)
            {
                if (mobilesList.Count>0)
                {
                    Console.WriteLine("\nRental Bike List..");
                    foreach (var item in mobilesList)
                    {
                        Console.WriteLine($"Bike No.:{item.BikeNumber}         PhoneNo.:{item.PhoneNumber}             No. of days.:{item.Days}         Charge : {item.compute()}");
                    }
                }
                Console.WriteLine("Select Any Option:");
                Console.WriteLine(" 1.Add \n 2.Delete \n 3.Edit \n 4.Search");
                var num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        mobike = Assignment1Day5.Add();
                        mobilesList.Add(mobike);
                        break;
                    case 2:
                        mobilesList.RemoveAt(mobilesList.Count - 1);
                        break;
                    case 3:
                        Console.WriteLine("Enter List Index value between 0-9");
                        var indexNum = Convert.ToInt32(Console.ReadLine());
                        mobilesList[indexNum] = Assignment1Day5.Edit();
                        break;
                    case 4:
                        Console.WriteLine("For Searching specific item from list..");
                        Console.WriteLine("Enter Bikenumber..");
                        var bikenum = Convert.ToInt32(Console.ReadLine());
                        var item = mobilesList.Find(x => x.BikeNumber == bikenum);
                        Console.WriteLine($"Bike No.:{item.BikeNumber}         PhoneNo.:{item.PhoneNumber}             No. of days.:{item.Days}         Charge : {item.compute()}");
                        break;
                    default:
                        break;
                }
            }


        }
    }
}
