using System;

namespace Task_04
{
    class Program
    {
        /*Напишете метод, който намира колко пъти дадено число се среща
        в даден масив. */
        static int CountNumb(int numb, int[] arr)
        {
            int counter = 0;

            for (int i = 0; i < arr.Length; i++) if (numb == arr[i]) counter++;

            return counter;
        }

        static void Main(string[] args)
        {
            Console.Write("Въведите дължината на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Въведите {0} eлемент: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Въведите число: "); // введите число которое повторяется в массиве,что бы узнать количество повторов
            int number = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0} се среща {1} пъти.", number, CountNumb(number, arr));
        }
    }
}
