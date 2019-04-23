using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility_Tasks
{
    class BinaryGap
    {
        public static int binaryGap(int N)
        {
            var binary = Convert.ToString(N, 2);
            Console.WriteLine("The binary of integer {0} is {1} : ", N, binary);
            int gap = 0;
            int max = 0;
            foreach (var ch in binary)
            {
                if (ch.Equals('0')) gap++;
                if (ch.Equals('1'))
                {
                    if (max < gap)
                    {
                        max = gap;
                    }
                    gap = 0;
                }
            }
            return max;
        }
    }
}
