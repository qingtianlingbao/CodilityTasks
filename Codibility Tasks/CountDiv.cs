using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility_Tasks
{
    class CountDiv
    {
        public static int countDiv(int A, int B, int K)
        {
            int countDiv = 0;
            for(int i = A; i <= B; i++)
            {
                if (i % K == 0)
                  countDiv++;
            }
            return countDiv;
        }
    }
}
