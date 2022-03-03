using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            stack.Push(20);
            stack.Push(23);
            stack.Push(43);
            stack.Push(44);
            stack.Push(89);
            Console.Write("total number of elements in the stack are: ");
            Console.WriteLine(stack.Count);
            Console.Write("total number of elements in the stack are:" + stack.Peek());
            Console.WriteLine("the element on the top of stack is:" + stack.Peek());
            Console.Write("total number of elements in the stack are: ");
            Console.WriteLine(stack.Count);
            Console.ReadLine();
        }
    }
}
