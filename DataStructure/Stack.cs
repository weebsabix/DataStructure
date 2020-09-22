using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Stack
    {
        //creating the array
        int[] stack;
        int sp;
        int max;

        public Stack(int size)
        {
            max = size;
            stack = new int[max];
            sp = 0;
        }

        //method for pushing
        public void Push(int item)
        {
            if (sp < max)
            {
                stack[sp] = item; //[sp++] [++sp]
                sp++;
            }
            else
            {
                throw new Exception("Stack Full!");
            }
        }

        //method for popping
        public int Pop()
        {
            if (sp > 0)
            {
                sp--;
                return stack[sp]; //[sp--] [--sp]
            }
            else
            { 
                throw new Exception("Stack Empty!");
            }
        }
    }
}
