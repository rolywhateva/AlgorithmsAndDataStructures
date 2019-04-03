using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    class CompareExecution
    {
        static void Main()
        {
            bool debug = true;
            if(debug)
            {
                long[] a = { -2, -3, -2, 0, 0, 0, -8, 9, -3, -3, -2, -1, -10, -10, 0, 1, 2, 3, -4, 5, -4, -10, 2, 3, 4, 0, 0, 0, 1, 2, -3, 4, 5, 9 };
                CountSort<long>.Sort(a,false);
                Console.WriteLine("({0})", string.Join(",", a));
                Console.ReadKey();
                return;
            }
           
            long[] array, tempArray;
            ulong noOfValues = 100000;
            array = Utilities.GenerateArray(noOfValues);
            tempArray = (long[])array.Clone();
            TimeSpan execution = Utilities.Measure<long>(array, InsertionSort<long>.Sort);
            Console.WriteLine("For insertion sort, it took {0} ms to sort  {1} integers.",
                                execution.Milliseconds, noOfValues);


            array = (long[])tempArray.Clone();
            execution = Utilities.Measure<long>(array, SelectionSort<long>.Sort);
            Console.WriteLine("For  selection sort, it took {0} ms to sort  {1} integers.",
                               execution.Milliseconds, noOfValues);
            /*
            array = (long[])tempArray.Clone();
            execution = Utilities.Measure<long>(array, BubbleSort<long>.Sort);
            Console.WriteLine("For  bubble sort, it took {0} ms to sort  {1} integers.",
                            execution.Milliseconds, noOfValues);
               */
            array = (long[])tempArray.Clone();
            execution = Utilities.Measure<long>(array, CountSort<long>.Sort);
            Console.WriteLine("For  bubble sort, it took {0} ms to sort  {1} integers.",
                            execution.Milliseconds, noOfValues);
           

            Console.ReadKey();
            return;
        }
    }
}
