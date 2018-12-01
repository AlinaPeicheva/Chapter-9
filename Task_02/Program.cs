using System;

namespace Task_02
{
    class Program
    {
        /*Създайте метод GetMax() с два целочислени (int) параметъра, който
        връща по-голямото от двете числа. Напишете програма, която прочита
        три цели числа от конзолата и отпечатва най-голямото от тях, използвайки метода GetMax().*/
        static int a;

        static void GetMax(int first, int second)
        {
            if (first > second) a = first;
            else a = second;                    
        }

        static void Main(string[] args)                         // вводишь три числа и выводить максимальное 
        {
            Console.Write("Въведете първото число: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Въведете второто число: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Въведете третото число: ");
            int c = Int32.Parse(Console.ReadLine());

            GetMax(a, b);
            GetMax(a, c);

            Console.WriteLine("Най-голямото число е {0}", a);
        }
    }
}
