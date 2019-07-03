using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        Stack<string> myStack = new Stack<string>();
        public bool IsEmpty()
        {
            return this.myStack.Any();
        }

        public Stack<string> PushRange(string[] items)
        {
            foreach (var item in items)
            {
                this.myStack.Push(item.ToString());
            }
            return myStack;
        }
    }
}
