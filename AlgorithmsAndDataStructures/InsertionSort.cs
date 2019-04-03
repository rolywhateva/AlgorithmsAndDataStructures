using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    ///<summary>
    /// A static class for insertion sort.
    /// </summary>
    /// <remarks> 
    /// Generic.May  only use for types which implement
    ///IComparable
    /// </remarks>
    static class InsertionSort<T> where T : IComparable<T>
    {
        /// <summary>
        /// The sort method for insertion sort.
        /// Sorts the array sent as a parameter and also
        /// returns the array in  sorted order.
        /// Insertion sort has O(n^2) time complexity.
        /// </summary>
        /// <param name="a">The  array to be sorted with insertion sort</param>
        ///<param name="ascending">A bool which is true by default, if it's true(false) meaning  that the array will be 
        ///sorted in ascending(descending) order</param>
        public static T[] Sort(T[] a, bool ascending = true)
        {
            for (int i = 1; i < a.Length; i++)
            {
                T key = a[i];
                int j = i - 1;
                while (j >= 0 && Utilities.LessOrEqual(a[j], key) == ascending)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = key;
            }

            return a;
        }





    }
}
