using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class SimpleLinkedList
    {
        #region nod
        class Node
        {
            public int Nr { get; }
            public Node Next { get; set; }
            public Node(int Nr, Node Next)
            {
                this.Nr = Nr;
                this.Next = Next;
            }
            public Node()
            {

            }
        }
        #endregion
        Node head;
        public SimpleLinkedList()
        {
            head = null;
        }
        public SimpleLinkedList(int nr)
        {
            head = new Node(nr, null);

        }
        public int Count
        {
            get
            {
                Node node = head;
                int count = 0;
                while (node != null)
                {
                    node = node.Next;
                    count++;
                }
                return count;
            }
        }
        public void AddAtEnd(int nr)
        {
            if (head == null)
            {
                head = new Node(nr, null);
                return;
            }
            Node p = head;
            while (p.Next != null)
                p = p.Next;
            Node newNode = new Node(nr, null);
            p.Next = newNode;
        }
        public void Print()
        {
            Node p = head;
            while (p != null)
            {
                Console.WriteLine(p.Nr);
                p = p.Next;
            }

        }
        public void AddAtStart(int nr)
        {
            Node newNode = new Node(nr, head);
            head = newNode;
        }
        public int RemoveAtStart()
        {
            Node removed = new Node();
            removed = head;
            head = head.Next;
            int toReturn = removed.Nr;
            removed = null;
            return toReturn;

        }
        public int RemoveFromEnd()
        {
            Node removed = new Node();
            Node node = head;
            while (node.Next.Next != null)
            {
                node = node.Next;
            }
            int toReturn = node.Next.Nr;
            node.Next = null;
            return toReturn;



        }
        public int RemoveFromPosition(int poz)
        {
            if (poz == 0)
                return RemoveAtStart();
            if (poz == Count - 1)
                return RemoveFromEnd();
            int index = 0;
            Node node = head;
            while (node != null && index <poz - 2)
            {
                node = node.Next;
                index++;
            }
            if (node == null)
                throw new Exception("Position is bigger");

            Node toRemove = node.Next;
            node.Next = node.Next.Next;
            return toRemove.Nr;



        }
        public int SearchAtPosition(int poz)
        {

            int index = 0;
            Node node = head;
            while (node != null && index < poz)
            {
                node = node.Next;
                index++;
            }
            if (node == null)
                throw new Exception($"{poz}>{index}");
            else
                return node.Nr;
        }



    }
}
