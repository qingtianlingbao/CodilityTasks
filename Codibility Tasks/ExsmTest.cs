using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility_Tasks
{
    class ExsmTest
    {
        public static int exsmTest(int n)
        {
            int[] d = new int[30];
            int l = 0;
            int p;
            while (n > 0)
            {
                d[l] = n % 2;
                n /= 2;
                l++;
            }
            for (p = 1; p < 1 + l; ++p)
            {
                int i;
                bool ok = true;
                for (i = 0; i < l - p; ++i)
                {
                    if (d[i] != d[i + p])
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                {
                    return p;
                }
            }
            return -1;
        }
    }
}
