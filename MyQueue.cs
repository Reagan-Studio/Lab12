using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    internal class MyQueue<T> 
    {
        MyNode<T> head;
        MyNode<T> tail; 
        int count;

        public MyQueue()
        {
            count = 0;
        }


        public void Enqueue(T data)
        {
            MyNode<T> node = new MyNode<T>(data);
            MyNode<T> tempNode = tail;
            tail = node;
            if (count == 0)
            {
                head = tail;
            }
            else
            {
                tempNode.Next = tail;
            }
            count++;
        }
  

        public T Dequeue()
        {
            if (count == 0)
            {
                throw new InvalidOperationException();
            }
            T output = head.Data;
            head = head.Next;
            count--;
            return output;
        }
      
        public T First
        {
            get
            {
                if (IsEmpty)
                {
                    throw new InvalidOperationException();
                }
                return head.Data;
            }
        }
     
        public T Last
        {
            get
            {
                if (IsEmpty)
                {
                    throw new InvalidOperationException();
                }
                return tail.Data;
            }
        }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            MyNode<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
    }
}
