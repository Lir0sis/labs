using System;
using System.Collections.Generic;
using System.Text;

namespace lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 1
            

            var random = new Random();
            int[] givenArray = new int[200];

            for (int i = 0; i < 200; i++)
                givenArray[i] = i - 100;
            Array.Sort(givenArray);
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Лабораторна 6 ---- Завдання 1 - 2";
            WriteArray("Початковий масив", givenArray);

            List<int> Sorter = new List<int>(givenArray);
            Sorter.RemoveAt(0);
            Sorter.RemoveAt(Sorter.Count - 1);
            Array.Clear(givenArray, 0, givenArray.Length);
            givenArray = Sorter.ToArray();

            WriteArray("Кінцевий масив", givenArray);

            Array.Clear(givenArray, 0, givenArray.Length);

            //task 2

            int zeroCount = 0;

            givenArray = new int[200];
            for (int i = 0; i < 200; i++)
                givenArray[i] = random.Next(200) - 100;
            Array.Sort(givenArray);

            WriteArray("Початковий масив", givenArray);

            while (Sorter.IndexOf(0) != -1)
            {
                Sorter.Remove(0);
                zeroCount++;
            }

            for (int i = 0; i < zeroCount; i++)
                Sorter.Insert(0, 0);

            Array.Clear(givenArray, 0, 200);
            givenArray = Sorter.ToArray();

            WriteArray("Кінцевий масив", givenArray);
        }

        static public void WriteArray(string message, int[] array)
        {
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorLeft = 2;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
                if (i != 0 && (i + 1) % 20 == 0)
                {
                    Console.WriteLine();
                    Console.CursorLeft = 2;
                }
            }
        }
    }
}
