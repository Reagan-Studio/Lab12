using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    internal class MyStack<T>
    {
        protected T[] stack;
        protected int count;
        protected int defaultLength = 12;


        public MyStack() { 
            stack = new T[defaultLength];
            count = 0;
        }
        public MyStack(T[] arr) {
            stack = new T[arr.Length];
            Array.Copy(arr, stack, arr.Length);
            count = arr.Length;
        }
        public MyStack(int length)
        {
            stack = new T[length];
            count = 0;
        }


        public bool IsEmpty => count == 0;
        public int Count => count;


        public virtual void Push(T element)
        {
            if (count == stack.Length)
            {
                Array.Resize(ref stack, count * 2);
            }

            stack[count] = element;
            count++;
        }

        public virtual T Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Пустой стек");
            }

            count--;
            T result = stack[count];
            stack[count] = default;
            return result;
        }

        public virtual T Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Пустой стек");
            }

            return stack[count - 1];
        }

        public override string ToString()
        {
            return string.Join(", ", stack[..count]);
        }


    }
}
