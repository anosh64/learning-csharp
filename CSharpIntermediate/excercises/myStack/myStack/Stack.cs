using System;
using System.Collections;

namespace myStack
{
    public class Stack
    {
        private ArrayList stack = new ArrayList();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("object passed cannot be null!");
            }
            stack.Add(obj);
        }

        public object Pop()
        {
            if (stack.Count == 0)
            {
                return new InvalidOperationException("stack is empty! cannot be popped!");
            }

            int lastIndex = stack.Count - 1;
            object objInLastIndex = stack[lastIndex];
            stack.RemoveAt(lastIndex);

            return objInLastIndex;
        }

        public void Clear()
        {
            stack.Clear();
        }
    }
}