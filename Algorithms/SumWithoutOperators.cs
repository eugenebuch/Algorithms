using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    static class SumWithoutOperators
    {
        public static int Sum(int A, int B)
        {
            if (B == 0) return A;
            int sum = A ^ B;
            int res = (A & B) << 1;
            return Sum(sum, res);
        }
    }
}
