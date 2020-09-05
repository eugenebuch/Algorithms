using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    static class PrimeFactorization
    {
        private static List<int> divs = new List<int>();
        private static bool IsPrime(int num)
        {
            if (num == 2)
            {
                return true;
            }

            if (num % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void PrintList()
        {
            if (divs.Count == 1)
            {
                Console.WriteLine("The numbre is Prime, so I can't factorize it");
                return;
            }
            List<int> history = new List<int>();
            foreach (var elem in divs)
            {
                if (history.Contains(elem)) continue;
                Console.WriteLine(elem + "\tx" + divs.Count(x => x == elem));
                history.Add(elem);
            }
        }
        public static void Run(int num)
        {
            // wrapper method
            Factorize(num);
        }
        private static int Factorize(int num)
        {
            if (IsPrime(num))
            {
                divs.Add(num);
                PrintList();
                return -1;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    divs.Add(i);
                    return Factorize(num / i);
                }
            }
            return -1;
        }
    }
}
