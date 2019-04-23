using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility_Tasks
{
    class CyclicRotation
    {
        public static int[] cyclicRotation(int[] A, int K)
        {

            if ( A.Length <= 1) return A;

            K = K % A.Length;

            int[] B = new int[K + A.Length];

            for (int i = K, j = 0; i < K + A.Length & j < A.Length; i++, j++)
            {
                B[i] = A[j];
            }
            int len = A.Length;

            while (K > 0)
            {
                B[K-1] = A[len-1];
                len--;
                K--;
            }

            int[] C = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                C[i] = B[i];
            }

            return C;
        }

    }
}
