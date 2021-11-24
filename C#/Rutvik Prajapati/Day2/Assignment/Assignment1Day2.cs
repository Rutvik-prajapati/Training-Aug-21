using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTask.Day2.Assignment
{
    class person
    {
        private string firstName, lastName, email;
        private DateTime dateOfBirth;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set
            {
                string[] items = value.Split('@');
                if (items.Length != 2)
                {
                    throw new ArgumentException("Invalid email address");
                }
                email = value;
            }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                if (value > DateTime.Today)
                {
                    throw new ArgumentException("Date of birth can't be in the future");
                }
                dateOfBirth = value;
            }
        }


        public person(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.DateOfBirth = dateOfBirth;
        }

        person(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        person(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
        }

        //read-only properties
        public bool Adult
        {
            get
            {
                DateTime eighteen = dateOfBirth.AddYears(18); // 18th birthday
                if (DateTime.Today >= eighteen)
                    return true; // adult if 18 or over
                return false; // otherwise minor
            }
        }

        public string SunSign
        {
            get
            {
                var month = dateOfBirth.Month;
                var day = dateOfBirth.Day;
                if (month == 12)
                {
                    if (day < 22)
                        return "Sagittarius";
                    else
                        return "capricorn";
                }
                else if (month == 1)
                {
                    if (day < 20)
                        return "Capricorn";
                    else
                        return "aquarius";
                }
                else if (month == 2)
                {
                    if (day < 19)
                        return "Aquarius";
                    else
                        return "pisces";
                }
                else if (month == 3)
                {
                    if (day < 21)
                        return "Pisces";
                    else
                        return "aries";
                }
                else if (month == 4)
                {
                    if (day < 20)
                        return "Aries";
                    else
                        return "taurus";
                }
                else if (month == 5)
                {
                    if (day < 21)
                        return "Taurus";
                    else
                        return "gemini";
                }
                else if (month == 6)
                {
                    if (day < 21)
                        return "Gemini";
                    else
                        return "cancer";
                }
                else if (month == 7)
                {
                    if (day < 23)
                        return "Cancer";
                    else
                        return "leo";
                }
                else if (month == 8)
                {
                    if (day < 23)
                        return "Leo";
                    else
                        return "virgo";
                }
                else if (month == 9)
                {
                    if (day < 23)
                        return "Virgo";
                    else
                        return "libra";
                }
                else if (month == 10)
                {
                    if (day < 23)
                        return "Libra";
                    else
                        return "scorpio";
                }
                else if (month == 11)
                {
                    if (day < 22)
                        return "scorpio";
                    else
                        return "sagittarius";
                }
                else
                    return "something wrong";
            }
        }

        public string ChineseSign
        {
            get
            {
                var month = dateOfBirth.Month;
                var day = dateOfBirth.Day;
                if (month == 12)
                {
                    if (day < 22)
                        return "rat";
                    else
                        return "ox";
                }
                else if (month == 1)
                {
                    if (day < 20)
                        return "ox";
                    else
                        return "tiger";
                }
                else if (month == 2)
                {
                    if (day < 19)
                        return "tiger";
                    else
                        return "rabbit";
                }
                else if (month == 3)
                {
                    if (day < 21)
                        return "rabbit";
                    else
                        return "dragon";
                }
                else if (month == 4)
                {
                    if (day < 20)
                        return "dragon";
                    else
                        return "snake";
                }
                else if (month == 5)
                {
                    if (day < 21)
                        return "snake";
                    else
                        return "horse";
                }
                else if (month == 6)
                {
                    if (day < 21)
                        return "horse";
                    else
                        return "goat";
                }
                else if (month == 7)
                {
                    if (day < 23)
                        return "goat";
                    else
                        return "monkey";
                }
                else if (month == 8)
                {
                    if (day < 23)
                        return "monkey";
                    else
                        return "rooster";
                }
                else if (month == 9)
                {
                    if (day < 23)
                        return "rooster";
                    else
                        return "dog";
                }
                else if (month == 10)
                {
                    if (day < 23)
                        return "dog";
                    else
                        return "pig";
                }
                else if (month == 11)
                {
                    if (day < 22)
                        return "pig";
                    else
                        return "rat";
                }
                else
                    return "something wrong";
            }
        }

        public string ScreenName
        {
            get
            {
                return FirstName + LastName + dateOfBirth.Year;
            }
        }
        public bool Birthday
        {
            get
            {
                DateTime today = DateTime.Today;
                if (today.Month == dateOfBirth.Month && today.Day == dateOfBirth.Day)
                {
                    return true;
                }
                return false;
            }
        }
    }
    class Assignment1Day2
    {
        static void Main(string[] args)
        {
            person[] personList = new person[5];

            Console.WriteLine("Enter Person Details");
            for (int i = 0; i < personList.Length; i++)
            {
                Console.WriteLine("First Name :");
                var fname = Console.ReadLine();
                Console.WriteLine("Last Name :");
                var lname = Console.ReadLine();
                Console.WriteLine("Email :");
                var email = Console.ReadLine();
                Console.WriteLine("Date of Birth :");
                DateTime dob = Convert.ToDateTime(Console.ReadLine());
                personList[i] = new person(fname, lname, email, dob);
                Console.WriteLine("\n");
            }

            Console.WriteLine($"Person Details In Tabular form");
            for (int i = 0; i < personList.Length; i++)
            {
                Console.WriteLine("Name : {0}", personList[i].ScreenName);

                Console.WriteLine("First Name : {0}", personList[i].FirstName);

                Console.WriteLine("Last Name : {0}", personList[i].LastName);

                Console.WriteLine("Email : {0}", personList[i].Email);

                Console.WriteLine("Date of Birth : {0}", personList[i].DateOfBirth);

                Console.WriteLine("Sun sign : {0}", personList[i].SunSign);

                Console.WriteLine("Chinese Sign : {0}", personList[i].ChineseSign);

                Console.WriteLine("Is Adult? : {0}", personList[i].Adult);

                Console.WriteLine("Today Is BirthDay? : {0}", personList[i].Birthday);

                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
