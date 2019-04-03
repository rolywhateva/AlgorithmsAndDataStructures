using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleLinkedList list = new SimpleLinkedList();
            for (int i = 0; i < 10; i++)
                list.AddAtEnd(i);
            list.RemoveFromPosition(0);
            list.Print();
                 
           
        }
    }
}
