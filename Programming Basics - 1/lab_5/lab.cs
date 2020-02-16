using System;

namespace lab_5
{
    class lab
    {
        static void Main(string[] args)
        {
            while (true) {

                Console.Clear();
                int Number;
                float[] Xmin, Xmax;
                float FinXmax = 0f, FinXmin = 0f;

                Console.WriteLine("Лабораторна №5, завдання 1.25");
                Console.WriteLine("Введіть кількість відрізків (N>1)");

                while (true)
                {
                    Console.Write("N = ");
                    try
                    {
                        Number = int.Parse(Console.ReadLine());
                        if (Number == 1) throw new Exception();
                    }
                    catch
                    {
                        continue;
                    }
                    break;
                }

                Xmin = new float[Number];
                Xmax = new float[Number];

                Console.Clear();
                Console.WriteLine("Введіть Хmin Ta Xmax для кожного відрізка");

                for (int i = 0; i < Number; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write($"{i + 1}. Xmin = ");
                            Xmin.SetValue(float.Parse(Console.ReadLine()), i);

                            Console.Write("   Xmax = ");
                            Xmax.SetValue(float.Parse(Console.ReadLine()), i);
                        }
                        catch
                        {
                            continue;
                        }
                        break;
                    }
                }


                Console.Clear();
                Console.WriteLine("Точки(а), що належать всім відрізкам:");

                for (int i = 0; i < Number - 1; i++)
                {
                    if (Xmin[i + 1] > Xmin[i])
                        FinXmin = Xmin[i + 1];
                    else if (Xmin[i + 1] <= Xmin[i])
                        FinXmin = Xmin[i];

                    if (Xmax[i + 1] < Xmax[i])
                        FinXmax = Xmax[i + 1];
                    else if (Xmax[i + 1] >= Xmax[i])
                        FinXmax = Xmax[i];
                }

                if (FinXmax > FinXmin)
                    Console.WriteLine($"Від {FinXmin} до {FinXmax}");
                else if (FinXmin == FinXmax)
                    Console.WriteLine($"{FinXmax}");
                else
                    Console.WriteLine("Не існує...");

                bool Continue = false;
                while (true)
                {
                    Console.WriteLine("Повторити? (Y/N)");
                    ConsoleKey Key = Console.ReadKey().Key;
                    if (Key == ConsoleKey.Y)
                        Continue = true;
                    else if (Key == ConsoleKey.N)
                        Continue = false;
                    else 
                    {
                        Console.Clear();
                        continue;
                    }
                    break;
                }
                    
                if (Continue == false)
                    break;
                
            }
            Console.Clear();
            Console.WriteLine("Роботу завершено");
        }
    }
}
