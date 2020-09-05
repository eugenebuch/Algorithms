using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    static class Fibonacci
    {
        public static void Draw(uint n)
        {
            if (n < 1)
            {
                Console.WriteLine("n must be 1 or greater");
            }
            else
            {
                int prev = 0, curr = 1;
                while (n > 0)
                {
                    Console.WriteLine(curr);
                    curr += prev;
                    prev = curr - prev;
                    n--;
                }
            }
        }
    }
}
