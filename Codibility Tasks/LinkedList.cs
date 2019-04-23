using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility_Tasks
{
    class LinkedList
    {
        public static int linkedList(int[] A)
        {
            LinkedList<int> list = new LinkedList<int>();
            int len = A.Length;
            LinkedListNode<int> node = list.AddFirst(A[0]);

            for (int i = 0; i < len; )
            {
                if(list.Last() == -1)
                return list.Count;
                node = list.Last;
                i = A[i];
                list.AddAfter(node, A[i]);
            }
            return 0;
        }
    }
}
