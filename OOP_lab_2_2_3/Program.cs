using System;

namespace OOP_lab_2_2_3
{
    class Program
    {
        public static int Max(int[] array)
        {
            int max = array[0];

            for (int i = 0; i < array.Length; ++i)
            {
                if (max <= array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }

        public static int Sum(int[] array)
        {
            int sum = 0;
            int firstIndex = 0;
            int secondIndex = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] > 0)
                {
                    firstIndex = i;

                    break;
                }
            }

            for (int i = firstIndex + 1; i < array.Length; ++i)
            {
                if (array[i] > 0)
                {
                    secondIndex = i;

                    break;
                }
            }

            for (int i = firstIndex + 1; i < secondIndex; ++i)
            {
                sum += array[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int[] array = new int[int.Parse(Console.ReadLine())];

            var random = new Random();

            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = random.Next(-100, 100);
            }

            for (int i = 0; i < array.Length; ++i)
            {
                Console.WriteLine("a[{0}] = {1}", i, array[i]);
            }

            Console.WriteLine("\nMаксимальний елемент масиву: {0}", Max(array));
            Console.WriteLine("Сума елементiв масиву, розташованих мiж першим й другим додатними елементами: {0}", Sum(array));
        }
    }
}
