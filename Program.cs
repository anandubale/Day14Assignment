using System;

namespace LinkedListProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.push(70);
            linkedListStack.push(30);
            linkedListStack.push(56);
            linkedListStack.pop();
            linkedListStack.peek();
            linkedListStack.isEmpty();
            linkedListStack.isFull();
            linkedListStack.Display();
            */
            LinkedListQueue linkedListQueues = new LinkedListQueue();
            linkedListQueues.Enqueue(56);
            linkedListQueues.Enqueue(30);
            linkedListQueues.Enqueue(70);
            linkedListQueues.Display();




        }
    }
}
