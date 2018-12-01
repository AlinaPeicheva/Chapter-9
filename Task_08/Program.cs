using System;

namespace Task_08
{
    class Program
    {
        /*Напишете метод, който пресмята сумата на две цели положителни числа. Числата са представени като масив от цифрите си, като
        последната цифра (единиците) са записани в масива под индекс 0. Направете така, че метода да работи за числа с дължина до 10 000 цифри.*/
        static void Main(string[] args)
        {
            int length;
            int[] Arr1 = new int[10000];
            int[] Arr2 = new int[10000];

            Console.Write("Въведете първото число: ");
            String s1 = Console.ReadLine();
            length = s1.Length;

            for (int i = 0; i < s1.Length; i++)
            {
                Arr1[i] = Convert.ToInt32(s1.Substring(s1.Length - 1 - i, 1));
            }

            Console.Write("Въведете второто число: ");
            String s2 = Console.ReadLine();

            if (s2.Length > length)
            {
                length = s2.Length;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                Arr2[i] = Convert.ToInt32(s2.Substring(s2.Length - 1 - i, 1));
            }

            for (int i = 0; i < length; i++)
            {
                Arr1[i] += Arr2[i];

                if (Arr1[i] >= 10)
                {
                    Arr1[i] -= 10;
                    Arr1[i + 1]++;
                }
            }

            if (Arr1[length] == 1)
            {
                length++;
            }

            Console.WriteLine();
            Console.Write("Резултат: ");

            for (int i = 0; i < length; i++)
            {
                Console.Write(Arr1[length - 1 - i]);
            }

            Console.ReadLine();
        }
    }
}
