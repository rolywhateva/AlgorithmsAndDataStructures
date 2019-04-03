using System;


namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            for (int i = 0; i < 10; i++)
                stack.Push(i);
            bool valid = stack.TryPeek(out int nr);
            if (valid)
                Console.WriteLine(nr);
            else
                Console.WriteLine("Nu sunt elemente");
            Console.WriteLine(stack.Count);
            Console.WriteLine();
            Console.WriteLine();
           while(!stack.IsEmpty)
            {
           
               stack.TryPeek(out int val);
                Console.WriteLine(val);
                stack.TryPop(out val);
            }
        }
    }
}
