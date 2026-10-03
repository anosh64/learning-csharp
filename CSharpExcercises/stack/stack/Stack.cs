using System.Collections;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace stack
{
    public class MyStack
    {
        ArrayList mystack = new ArrayList();
        public void Push(object obj)
        {
            mystack.Add(obj);
        }

        public object Pop()
        {
            int lastIndex = mystack.Count - 1;
            object objAtLastIndex = mystack[lastIndex];
            mystack.RemoveAt(lastIndex);
            return objAtLastIndex;
        }

        public void Clear()
        {
            mystack.Clear();
        }
    }
}