using System;


namespace Stack
{
    class Stack
    {
        internal class Node
        {
            public int Nr { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set;  }
            public Node(int Nr=0, Node Next=null,Node Previous=null)
            {
                this.Nr = Nr;
                this.Next = Next;
                this.Previous = Previous;
            }
          
        }
        public Stack()
        {
            head = null;
            count = 0;
        }
        public bool IsEmpty
        {
            get
            {
                return (head == null);
            }
        }
        int count;
        public int Count
        {
            get { return count; }
            
        }
       Node head;
        public Node Head { get { return head; } }
        public void Push(int value)
        {
            count++;
            if (head == null)
            {
                head = new Node(value);
                return;

            }
            Node newNode = new Node(value, null, head);
            head = newNode;

        }
        public  bool TryPeek(out int nr)
        {
            if (head == null)
            {
                nr = 0;
                return false;
            }
            nr = head.Nr;
            return true;

        }
        public  bool  TryPop(out int nr)
        {

            if (head == null)
            {
                nr = 0;
                return false;
            }
            count--;
            Node newHead = head.Previous;
            nr = head.Nr;
            head = newHead;
           // head.Next = null;
            return true;
           

        }


      
    }
}
