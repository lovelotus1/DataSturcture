using System;
using System.Collections;
namespace Stack1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack myStack = new Stack();//FIFO
            myStack.Push("Hello");
            myStack.Push(2);
            myStack.Push("True");
            myStack.Push(4.5);
            myStack.Push(null);
            myStack.Push("Ends of Stack");

            Console.WriteLine($"The length of the Stack is - {myStack.Count}");
            Console.WriteLine($"myStack has a 3 => {myStack.Contains(3)}");




            Console.WriteLine($"The peak of the Stack is - {myStack.Pop()}");
            myStack.Pop();
            foreach(var item in myStack)
            {
                Console.WriteLine(item);

            }

                
        }
    }
}