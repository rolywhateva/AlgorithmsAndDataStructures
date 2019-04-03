using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    class Monede
    {
        static int[] plata(int[] v,int sum)
        {
            int[] rez = new int[v.Length];
            Array.Sort(v, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
      
            for(int penny =0;penny<v.Length;penny++)
            {
                rez[penny] = sum / v[penny];
                sum = sum % v[penny];

            }
            return rez;

        }
        static void Test(int[] v, int sum)
        {
            int[] rez = plata(v, sum);
            StringBuilder builder = new StringBuilder();
            int testsum = 0;
            builder.Append(sum + "=");
            for (int i = 0; i < rez.Length - 1; i++)
                if (rez[i] != 0)
                {
                    builder.Append(v[i] + "*" + rez[i] + "+");
                    testsum += v[i] * rez[i];

                }
            if (rez[rez.Length - 1] == 0)
                builder.Remove(builder.Length - 1, 1);
            else
            {
                testsum += v[rez.Length-1] * rez[rez.Length-1];
                builder.Append(v[rez.Length - 1] + "*" + rez[rez.Length - 1]);

            }
            if (testsum == sum)

                Console.WriteLine(builder.ToString());
            else
                Console.WriteLine("Gresit");
          

        }
        static void Main(string[] args)
        {
            int[] v = new int[] { 1000, 100, 10, 5, 1 };
            int sum = 2913;
            Console.WriteLine(string.Join(",",plata(v,sum)));
            Test(v, sum);
            Test(new int[] {100,20,7,15,5,3 }, 360);
            Test(new int[] { 98, 96, 5, 3 }, 3687);

        }
    }
}
