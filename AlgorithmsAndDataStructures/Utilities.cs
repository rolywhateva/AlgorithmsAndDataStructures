using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
namespace AlgorithmsAndDataStructures
{
    static class Utilities
    {

       public  delegate T[] sortFunctionDelegate<T>(T[] a,bool ascending=true) where T : IComparable<T>;



        /// <summary>
        /// This function  checks if a is smaller or equal to b
        /// Generic type
        /// </summary>
        /// <typeparam name="T">A type that implements IComparable</typeparam>
        /// <param name="a">A  value/object/variable of type T  </param>
        /// <param name="b">A  value/object/variable of type T</param>
        /// <returns>True if a is  less or equal to b, false otherwhise</returns>
        public static bool LessOrEqual<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) <= 0;
        }
        /// <summary>
        /// This function checks if an array is sorted.
        /// </summary>
        /// <typeparam name="T">A type that implements IComparable</typeparam>
        /// <param name="a">The array to be checked, generic type.</param>
        /// <param name="ascending">If the bool parameter is true(false) then it checks
        /// if  the passed aray is sorted in ascending(descending) order</param>
        /// <returns>true if it's sorted( in ascending or descending order),false otherwhise</returns>
        public static bool IsSorted<T>(T[] a, bool ascending = true) where T : IComparable<T>
        {
            for (int i = 0; i < a.Length - 1; i++)
                if (LessOrEqual(a[i], a[i + 1]) != ascending)
                    return false;
            return true;
        }
        
        /// <summary>
        /// A function which generates an array of  random  long numbers
        /// </summary>
        ///
        /// <param name="noOfValues">The number of values to generate </param>
        /// <param name="maxValue">The biggest possible value to  generate(by default its. long.MaxValue</param>
        /// <returns>The generated array </returns>
        static public long[] GenerateArray( ulong  noOfValues, long  maxValue = long.MaxValue)
        {
            long[] newArray;
            newArray = new long[noOfValues];
            Random rnd = new Random();
            ulong length = (ulong)newArray.LongLength;
            for (ulong i = 0; i < length; i++)
                newArray[i] = rnd.Next() % maxValue;
            return newArray;
        }
        /// <summary>
        /// Measures the time taken by a  sorting function to sort an array.
        /// </summary>
        /// <typeparam name="T">A type which implements IComparable</typeparam>
        /// <param name="a">An one dimensional array of type T </param>
        /// <param name="sortFunction">The sort function  to test,delegate.</param>
        /// <returns>Timespan  obtained by measuring the time
        /// taken by  the sorting method</returns>
        static public TimeSpan  Measure<T>(T[] a,sortFunctionDelegate<T> sortFunction) where T:IComparable<T>
        {
            Stopwatch executionTime = new Stopwatch();
            executionTime.Start();
            sortFunction(a);
            executionTime.Stop();
            return executionTime.Elapsed;
          
        }
        /// <summary>
        /// A method which  exchanges two variables
        /// </summary>
        /// <typeparam name="T">A type </typeparam>
        /// <param name="a">The first variable, type ref.</param>
        /// <param name="b">The  second variable, type ref.</param>
        static public void Exchange<T>(ref T a, ref T b) where T : IComparable<T>
        {
            T temp = a;
            a = b;
            b = temp;
        }


    }
}
