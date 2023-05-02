using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    internal class MyStackMinMaxComparator<T1, T2> : MyStack<T1> where T2 : IComparer<T1>
    {
        private T1[] maxes;
        private T1[] mins;
        private T2 comparer;

        private int minIndex;
        private int maxIndex;

        public int Minindex
        {
            get { return count - minIndex - 1; }
            set { minIndex = value; }
        }

        public int MaxIndex
        {
            get { return count - maxIndex - 1; }
            set { maxIndex = value; }
        }

        public MyStackMinMaxComparator(T2 comparer) : base()
        {
            maxes = new T1[defaultLength];
            mins = new T1[defaultLength];
            this.comparer = comparer;
        }

        public MyStackMinMaxComparator(int length, T2 comparer) : base(length)
        {
            maxes = new T1[length];
            mins = new T1[length];
            this.comparer = comparer;
        }

        public T1 GetMax()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Стек пуст");
            }

            T1 max = maxes[Count - 1];
            T1 top = Peek();

            if (Count == 1 || comparer.Compare(top, max) > 0)
            {
                maxes[Count - 1] = top;
            }
            else
            {
                maxes[Count - 1] = max;
            }

            return maxes[Count - 1];
        }

        public T1 GetMin()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Стек пуст");
            }

            T1 min = mins[Count - 1];
            T1 top = Peek();

            if (Count == 1 || comparer.Compare(top, min) < 0)
            {
                mins[Count - 1] = top;
            }
            else
            {
                mins[Count - 1] = min;
            }

            return mins[Count - 1];
        }

        public override void Push(T1 item)
        {
            base.Push(item);

            if (Count == 1 || comparer.Compare(item, maxes[Count - 2]) > 0)
            {
                maxes[Count - 1] = item;
                maxIndex = Count - 1;
            }
            else
            {
                maxes[Count - 1] = maxes[Count - 2];
            }

            if (Count == 1 || comparer.Compare(item, mins[Count - 2]) < 0)
            {
                mins[Count - 1] = item;
                minIndex = Count - 1;
            }
            else
            {
                mins[Count - 1] = mins[Count - 2];
            }
        }

        public override T1 Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Стек пуст");
            }


            if (Count > 0 && maxIndex == Count - 1)
            {
                T1[] temp = new T1[Count - 1];
                Array.Copy(maxes, temp, Count - 1);
                maxes = temp;
                maxIndex = Array.IndexOf(stack.ToArray(), GetMax());
            }

            if (Count > 0 && minIndex == Count - 1)
            {
                T1[] temp = new T1[Count - 1];
                Array.Copy(mins, temp, Count - 1);
                mins = temp;
                minIndex = Array.IndexOf(stack.ToArray(), GetMin());
            }


            T1 item = base.Pop();
            maxes[Count] = default(T1);
            mins[Count] = default(T1);

            return item;
        }
    }


}
