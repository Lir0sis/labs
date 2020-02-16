using System;

namespace lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int size;
            while (true) 
            {
                try
                {
                    Console.Write("n = ");
                    size = int.Parse(Console.ReadLine());
                }
                catch
                {
                    continue;
                }
                break;
            }
            int[,] arr = new int[size, size];
            int sum = 0;

            for (int i = size - 1; i > -size; i--)
            {
                int x = i > 0 ? i : 0;
                int y = i < 0 ? -i : 0;

                for (int j = 0; ; j++)
                {
                    if (x + j >= size || y + j >= size)
                        break;
                    count++;
                    arr[y + j, x + j] = count;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Array:");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    sum = arr[i, j] > 30 ? sum + arr[i, j] : sum;
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("sum( >30 ) = " + sum);
        }
    }
}
