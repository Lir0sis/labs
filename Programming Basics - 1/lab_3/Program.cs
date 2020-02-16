using System;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isResultable = false;

            double firstArgX = 0;

            int days = 0;
            double discount = 0f;
            double sum = 0f;

            double secondArgX = 0f;
            double secondArgZ = 0f;

            double result1 = 0.000f;
            double result2 = 0.000f;
            double result3 = 0.000f;

            while (isResultable != true)
            {
                try
                {
                    Console.WriteLine("Ввод данных для первой задачи (Х):");
                    string[] varArray = Console.ReadLine().Split();

                    if (varArray.Length == 1)
                    { 
                        firstArgX = double.Parse(varArray[0]);
                        Array.Clear(varArray, 0, varArray.Length);
                    }
                    else
                    {
                        Console.WriteLine("Больше(меньше) 1-го аргумента!");
                        Console.ReadKey();
                        throw new System.ArgumentException("smthn");
                    }

                    Console.WriteLine("Ввод данных для второй задачи (дни, скидка в процентах, сумма):");
                    varArray = Console.ReadLine().Split();

                    if (varArray.Length == 3)
                    {
                        days = int.Parse(varArray[0]);
                        discount = double.Parse(varArray[1]);
                        sum = double.Parse(varArray[2]);
                        Array.Clear(varArray, 0, varArray.Length);
                    }
                    else
                    {
                        Console.WriteLine("Больше(меньше) 3-х аргументoв!");
                        Console.ReadKey();
                        throw new System.ArgumentException("smthn");
                    }

                    Console.WriteLine("Ввод данных для третей задачи (Х, Z):");
                    varArray = Console.ReadLine().Split();
                    if (varArray.Length == 2)
                    {
                        secondArgX = double.Parse(varArray[0]);
                        secondArgZ = double.Parse(varArray[1]);
                        Array.Clear(varArray, 0, varArray.Length);
                    }
                    else
                    {
                        Console.WriteLine("Больше(меньше) 1-го аргумента!");
                        Console.ReadKey();
                        throw new System.ArgumentException("smthn");
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Что-то пошло не так... Повторите ввод данных");
                    continue;
                }

                try
                {
                    result1 = Math.Sqrt(firstArgX + 2) - Math.Sqrt(firstArgX + 3);
                    
                    for (int i = 1; i < days; i++)
                    {
                        sum = (sum += 3) * (100 + discount);
                    }
                    result2 = sum;

                    if (Math.Pow(secondArgX, 2) * Math.Abs(secondArgX - secondArgZ) == 1) throw new Exception();

                    result3 = (secondArgX + Math.Exp(secondArgZ - 1)) / 
                        (1 - Math.Pow(secondArgX, 2) * Math.Abs(secondArgX - secondArgZ));
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Расчеты выполнить невозможно, повторите попытку.");
                    continue;
                }

                Console.Clear();
                Console.WriteLine($"Результат 1й задачи: {result1}\nРезультат 2й задачи: {result2}\nРезультат 3й задачи: {result3}\n Область вызначения функции: X² ∙ |X - Z| ≠ 1");
               
                isResultable = true;
            }
            Console.ReadKey();
            
        }
    }
}
