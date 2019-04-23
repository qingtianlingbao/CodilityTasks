using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility_Tasks
{
    class OddOccurrencesInArray
    {
        public static int oddOccurrencesInArray(int[] A)
        {
            if (A.Length == 1)
            {
                return A[0];
            }
            var oe = 0;
            for (int i = 0; i < A.Length; i++)
            {
                oe ^= A[i];
            }
            return oe;
        }
    }
}
