using System;

namespace Task_09
{
    class Program
    {
        // Напишете метод, който намира най-големия елемент в част от масив. Използвайте метода, за да сортирате низходящо даден масив.
        public static int GetMax(int[] array, int start, int end)
        {
            int maxNum = array[start];

            for (int i = start + 1; i < end; i++)
            {
                if (array[i] > maxNum) maxNum = array[i];
            }

            return maxNum;
        }

        public static void Main(string[] args)
        {
            Console.Write("Въведете дължината на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Въведете {0} елемент: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Write("\nВъведете границите на интервала");
            Console.Write("\nВъведете първия индекс: ");
            int startIndex = Int32.Parse(Console.ReadLine());

            Console.Write("Въведете последния индекс: ");
            int endIndex = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Най-голямото число в интервала е {0}-{1} is {2}.", startIndex, endIndex, GetMax(arr, startIndex, endIndex));
        }
    }
}
