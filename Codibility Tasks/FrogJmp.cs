using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility_Tasks
{
    class FrogJmp
    {
        public int frogJmp(int X, int Y, int D)
        {
            if(X > Y)  return 0;
            int distance = Y - X;
            if (distance > 0 && distance < D) return 1;
            int jmp = distance / D;
            if (distance % D > 0) jmp++;
            return jmp;
        }
    }
}
