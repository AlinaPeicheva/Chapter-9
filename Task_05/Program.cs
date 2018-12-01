using System;

namespace Task_05
{
    class Program
    {
        /*Напишете метод, който проверява дали елемент, намиращ се на дадена
        позиция от масив, е по-голям от двата му съседа. Тествайте метода дали работи коректно.*/
        static void CompareNumb(int pos, int[] arr)
        {
            if (pos == 0)
            {
                if (arr[0] < arr[1]) Console.WriteLine("{0} е по-малко от дясното число.", arr[0]);
                else if (arr[0] > arr[1]) Console.WriteLine("{0} е по-голямо от дясното число.", arr[0]);
                else Console.WriteLine("{0} е равно на дясното число.", arr[0]);
            }
            else if (pos == arr.Length - 1)
            {
                if (arr[arr.Length - 1] < arr[arr.Length - 2]) Console.WriteLine("{0} е по-малко от лявото число.", arr[pos]);
                else if (arr[arr.Length - 1] > arr[arr.Length - 2]) Console.WriteLine("{0} е по-голямо от лявото число.", arr[pos]);
                else Console.WriteLine("{0} е равно на лявото число.", arr[pos]);
            }
            else
            {
                if (arr[pos] < arr[pos - 1])
                {
                    if (arr[pos] < arr[pos + 1]) Console.WriteLine("{0} е по-малко от съседните числа.", arr[pos]);
                    else if (arr[pos] == arr[pos + 1]) Console.WriteLine("{0} е по-малък от лявото и равен на дясното число.", arr[pos]);
                    else Console.WriteLine("{0} е по-малък от лявото и по-голям от дясното число", arr[pos]);
                }
                else if (arr[pos] == arr[pos - 1])
                {
                    if (arr[pos] < arr[pos + 1]) Console.WriteLine("{0} е равно на лявато и по-малко от дясното число.", arr[pos]);
                    else if (arr[pos] == arr[pos + 1]) Console.WriteLine("{0} е равно на съседнити числа.", arr[pos]);
                    else Console.WriteLine("{0} е равно на лявато и по-голямо от дясното число..", arr[pos]);
                }
                else
                {
                    if (arr[pos] < arr[pos + 1]) Console.WriteLine("{0}  е по-голямо от лявато и по-малко от дясното число.", arr[pos]);
                    else if (arr[pos] == arr[pos + 1]) Console.WriteLine("{0}  е по-голямо от лявато и равно на дясното число.", arr[pos]);
                    else Console.WriteLine("{0} е по-голямо от съседните числа.", arr[pos]);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Въведете дължината на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Въведете {0} eлемент: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Въведите позицията в масива: ");
            int pos = Int32.Parse(Console.ReadLine());

            CompareNumb(pos, arr);
        }
    }
}
