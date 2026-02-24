using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Interface
{
    internal class MyStack<T>
    {

        private T[] items;
        private int top;
        private int capacity;

        public MyStack(int size)
        {
            capacity = size;
            items = new T[capacity];
            top = -1; 
        }

        public void Push(T item)
        {
            if (top == capacity - 1)
            {
                Console.WriteLine("Stack Overflow! Cannot add more items.");
                return;
            }

            items[++top] = item;
        }

      
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty. Cannot pop.");
            }

            return items[top--];
        }

    
        public bool IsEmpty()
        {
            return top == -1;
        }

  
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Console.WriteLine("Stack elements:");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(items[i]);
            }


        }
    }
}