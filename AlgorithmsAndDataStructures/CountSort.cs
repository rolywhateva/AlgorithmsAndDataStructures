using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    /// <summary>
    /// Generic  static class for the  count sort.
    /// </summary>
    /// <typeparam name="T">A type which inherits IComparable</typeparam>
    static class CountSort<T> where T : IComparable<T>
    {
        /// <summary>
        /// Static method for  the CountingSort Algorithm.
        /// </summary>
        /// <param name="a">An array of type T </param>
        /// <param name="ascending">True(false) if the  array is ought to be sorted
        /// in ascending(descending) order.</param>
        /// <returns></returns>
        static public T[] Sort(T[] a, bool ascending= true )
        {
            SortedDictionary<T, int> frecq = new SortedDictionary<T, int>();
            for (int i = 0; i < a.Length; i++)
                if (frecq.ContainsKey(a[i]))
                    frecq[a[i]]++;
                else
                    frecq.Add(a[i], 1);
            int k;
            if (ascending)
                k = 0;
            else
                k = a.Length - 1;
            
               foreach(KeyValuePair<T,int> pair in frecq)
                {
                for (int i = 0; i < pair.Value; i++)
                    if (ascending)
                        a[k++] = pair.Key;
                    else
                        a[k--] = pair.Key;
                }
        
            return a;
             
            
                      
        }


    }
}
