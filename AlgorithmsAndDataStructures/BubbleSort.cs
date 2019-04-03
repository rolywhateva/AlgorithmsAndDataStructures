using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    class BubbleSort<T> where T:IComparable<T>
    {
        /// <summary>
        /// Sorts an array of type T with bubble sort.
        /// T must implement IComparable.
        /// 
        /// </summary>
        /// <param name="a">An array of type T </param>
        /// <param name="ascending">true(false), if  the array ought to be sorted
        /// in ascending(descending) order </param>
        /// <returns>the sorted array </returns>
        public static T[] Sort(T[] a, bool ascending = true)
        {
            bool sorted;
            do
            {
                sorted = true;
                for (int i = 0; i < a.Length - 1; i++)
                    if (Utilities.LessOrEqual(a[i], a[i + 1]) == ascending)
                    {
                        Utilities.Exchange(ref a[i], ref a[i + 1]);
                        sorted = false;
                    }


            } while (!sorted);
            return a;
        }
    }
}
