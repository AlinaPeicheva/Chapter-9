using System;

namespace Task_01
{
    class Program
    {
        /*Напишете метод, който при подадено име отпечатва на конзолата "Hello, <name>!" (например "Hello, Peter!"). */

        static void ReturnName(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            ReturnName(Console.ReadLine());
        }
    }
}
