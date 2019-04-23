using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codibility_Tasks;

namespace Codibility_Tasks
{
    class Programme
    {
        static void Main(string[] args)
        {
            var maxGap = BinaryGap.binaryGap(2);
            Console.WriteLine("The maxBinaryGap of integer 2 is {0}", maxGap);

            int[] A = { 3, 8, 9, 7, 6 };
            var cyclicRotationReturn = CyclicRotation.cyclicRotation(A, 3);
            Console.WriteLine("The cyclicRotationReturn of array is {0}", cyclicRotationReturn);

            int[] B = { 9, 3, 9, 3, 9, 7, 9};
            var oe = OddOccurrencesInArray.oddOccurrencesInArray(B);
            Console.WriteLine("The oddOccurrencesInArray of array is {0}", oe);

            int[] C1 = { 2, 3, 1, 5};
            int[] C2 = { 2 };
            int[] C3 = { 2, 3, 4, 5 };
            int[] C4 = { 1, 2, 3, -1, 4 };
            var me1 = PermMissingElem.permMissingElem(C1);
            var me2 = PermMissingElem.permMissingElem(C2);
            var me3 = PermMissingElem.permMissingElem(C3);
            Console.WriteLine("The permMissingElem of array is {0}", me1);

            var count1 = CountDiv.countDiv(0, 0, 11);
            var count2 = CountDiv.countDiv(10, 10, 7);

            string s = "my.song.mp3 11b\r\ngreatSong.flac 1000b\r\nnot3.txt 5b\r\nvideo.mp4 200b\r\ngame.exe 100b\r\nmov!e.mkv 10000b";
            ReturnFileTypeSeperately.returnFileTypeSeperately(s);

            var count = LinkedList.linkedList(C4);


            int Test = 955;
            ExsmTest.exsmTest(Test);
        }
    }
}
