using System;

namespace Task_07
{
    class Program
    {
        /*Напишете метод, който отпечатва цифрите на дадено десетично число
          в обратен ред. Например 256 трябва да бъде отпечатано като 652.*/
        public static string Circl(string number)
        {
            char[] charArr = number.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }

        static void Main(string[] args)
        {
            Console.Write("Въведете число: ");
            string number = Console.ReadLine();

            Console.WriteLine(Circl(number));
        }
    }
}
