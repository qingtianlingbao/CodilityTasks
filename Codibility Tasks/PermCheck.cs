using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility_Tasks
{
    class PermCheck
    {
        public static int permCheck(int[] A)
        {
            int len = A.Length;
            int isPerm = 1;
            if (len <= 2) isPerm = 1;
            Array.Sort(A);
            int min = A[0];
            for (int i = 0; i < len; i++)
            {
                if (A[i] != min++)
                {
                    isPerm = 0;
                    break;
                }
            }
            return isPerm;
        }
    }
}
