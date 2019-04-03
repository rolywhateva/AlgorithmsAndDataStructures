using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    /// <summary>
    /// A class which implements a method for  selection sort.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    static class SelectionSort<T> where T : IComparable<T>
    {
        /// <summary>
        /// The function which sorts   a collection using selection sort.
        /// </summary>
        /// <param name="a">The  array to be sorted </param>
        /// <param name="ascending">If it's true(false),then the array will be  sorted in ascending
        /// (descending)order</param>
        /// <returns>the sorted array</returns>
        public static T[] Sort(T[] a, bool ascending = true)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {

                int pmin = i;
                for (int j = i + 1; j < a.Length; j++)
                    if (Utilities.LessOrEqual<T>(a[j], a[pmin]) == ascending)
                        pmin = i;

                Utilities.Exchange<T>(ref a[i], ref a[pmin]);
            }
            return a;
        }

    }
}
