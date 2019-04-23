using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility_Tasks
{
    class PermMissingElem
    {
        public static int permMissingElem(int[] A)
        {
            int max = A.Length;
            int me = 0;
            Array.Sort(A);
            for(int i = 0; i < max; i++)
            {
                if (A[i] != i + 1)
                {
                    me = i + 1;
                    break;
                }
            }
            if (me == 0) return max + 1;
            else return me;

        }
    }
}
