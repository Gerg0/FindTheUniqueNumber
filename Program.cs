using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheUniqueNumber
{
    class Program
    {
        //There is an array with some numbers.All numbers are equal except for one.Try to find it!
        static void Main(string[] args)
        {
            int[] test = new int[] { 1, 2, 2, 2 };
            
            Console.WriteLine(GetUnique(test));
            Console.ReadLine();
        }
        public static int GetUnique(IEnumerable<int> numbers)
        {
            int solution = 0;
            int[] array = numbers.ToArray();
            Dictionary<int, int> d = new Dictionary<int, int>();
            foreach (var i in array)
            {
                if (d.ContainsKey(i))
                {
                    d[i]++;
                }
                else
                {
                    d.Add(i, 1);
                }
            }
            foreach (var i in d)
            {
                if (i.Value==1)
                {
                    solution = i.Key;
                }
            }

            return solution;
        }
        public static int BestPractice(IEnumerable<int> numbers)
        {
            return numbers.GroupBy(x => x).Single(x => x.Count() == 1).Key;
        }
    }
}
