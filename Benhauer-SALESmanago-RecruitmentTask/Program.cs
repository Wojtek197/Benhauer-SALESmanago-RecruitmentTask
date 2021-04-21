using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benhauer_SALESmanago_RecruitmentTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>()
            {
                "Adam",
                "Bartek",
                "Tomek",
                "Marzena",
                "Przemek",
                "Adam",
                "Tomek",
                "Aldona",
                "Marzena"
            };
            GetSortedName(nameList);
            Console.WriteLine("----------------------------");
            GetUniqueNames(nameList);
            Console.WriteLine("----------------------------");
            GetFirstLetters(nameList);
            Console.WriteLine("----------------------------");
            Console.WriteLine(IsPalindrome("witam"));
            Console.WriteLine(IsPalindrome("kajak"));
            Console.ReadKey();
        }

        private static void PrintList(List<string> list)
        {
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }
        }

        private static bool IsPalindrome(string v)
        {
            return v.SequenceEqual(v.Reverse());
        }

        private static List<string> GetFirstLetters(List<string> nameList)
        {
            IEnumerable<string> result = nameList.AsQueryable().Cast<string>().Select(str => str.Substring(0, 1));
            List<string> resultList = result.ToList();
            PrintList(resultList);
            return resultList;
        }

        private static List<string> GetSortedName(List<string> nameList)
        {
            nameList.Sort();
            PrintList(nameList);
            return nameList;
        }
        private static List<string> GetUniqueNames(List<string> nameList)
        {
            List<string> distinctNames = nameList.Distinct().ToList();
            PrintList(distinctNames);
            return distinctNames;
        }
    }
}
