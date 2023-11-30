using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{    
    internal class Program
    {
        static void TestStack(Stack stack)
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                stack.Push(r.Next(0, 100));
            }
            Console.WriteLine($"Capacity = {stack.GetCapacity()}");
            Console.WriteLine(stack.ToString());
            bool ok;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(stack.Pop(out ok));
            }
            Console.WriteLine($"Capacity = {stack.GetCapacity()}");
            Console.WriteLine($"Top = {stack.Top(out ok)}");
            Console.WriteLine(stack.ToString());
            Console.WriteLine();
        }
        static void TestExpandableStack(ExpandableStack stack)
        {
            Random r = new Random();
            for (int i = 0; i < 8; i++)
            {
                stack.Push(r.Next(0, 100));
            }            
            Console.WriteLine($"Capacity = {stack.GetCapacity()}");
            Console.WriteLine($"Size = {stack.GetSize()}");
            Console.WriteLine(stack.ToString());
            stack.Shrink();
            Console.WriteLine($"Capacity = {stack.GetCapacity()}");
            Console.WriteLine($"Size = {stack.GetSize()}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Stack:");
            Stack stack1 = new Stack();
            TestStack(stack1);

            Console.WriteLine("ExpandableStack:");
            ExpandableStack stack2 = new ExpandableStack(12, 1.6);
            TestStack(stack2);
            TestExpandableStack(stack2);
        }
    }
}
