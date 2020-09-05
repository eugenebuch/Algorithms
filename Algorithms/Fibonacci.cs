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
                long prev = 0, curr = 1;
                while (n > 0)
                {
                    try
                    {
                        Console.Write(curr + (n == 1 ? "" : ", "));
                        curr = checked(curr + prev);
                        prev = curr - prev;
                        n--;
                    } catch
                    {
                        Console.WriteLine("The num is too big, can't continue working...");
                        break;
                    }
                }
            }
        }
    }
}
