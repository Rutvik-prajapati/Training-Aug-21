using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTask.Day1.Assignment
{
    //Store your name in one string and find out how many
    //vowel characters are there in your name.
    class Assignment2Day1
    {
        static void Main(string[] args)
        {
            var name = "Rutvik";
            int countVowel = 0;
            for (var i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' ||
                    name[i] == 'o' || name[i] == 'u' || name[i] == 'A' ||
                    name[i] == 'E' || name[i] == 'I' || name[i] == 'O' ||
                    name[i] == 'U')
                {
                    countVowel++;
                }
            }
            Console.WriteLine("String : " + name);
            Console.WriteLine("Number of Vowel in string :" + countVowel);
            Console.ReadLine();
        }
    }
}
