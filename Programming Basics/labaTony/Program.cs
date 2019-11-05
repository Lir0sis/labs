using System;

namespace LAB_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Example1();
            Console.ReadKey();
            Example2();
        }

        static void Example1()
        {
            int n = 0;
            bool @bool = true;
            while (@bool == true)
            {
                try
                {
                    Console.WriteLine("Введіть Н - розмір масиву");
                    n = Convert.ToInt32(Console.ReadLine());
                    @bool = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ви ввели некоректні дані");
                    @bool = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Задовге число");
                    @bool = true;
                }
                if (n <= 0)
                {
                    Console.WriteLine("Ви ввели некоректні дані");
                    @bool = true;
                }
                else
                {
                    @bool = false;
                }
            }
            Console.WriteLine("Вводьте дані до массиву");
            double[] massive = new double[n];
            for (int i = 0; i < n;)
            {
                try
                {
                    massive[i] = Convert.ToDouble(Console.ReadLine());
                    i++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некоректні дані, спробуйте ще раз ");
                }


            }
            int index_min = 0;
            int index_max = 0;

            double min_number = massive[0];
            for (int i = 1; i < n; i++)
            {
                if (massive[i] < min_number)
                {
                    min_number = massive[i];
                    index_min = i;
                }
            }
            double max_number = massive[0];
            for (int i = 1; i < n; i++)
            {
                if (massive[i] > max_number)
                {
                    max_number = massive[i];
                    index_max = i;
                }
            }
            if (index_min > index_max)
            {
                Console.WriteLine("Мінімальне число зустрілось раніше, це число - {0}, його позиція - {1}", min_number, index_min);
            }
            else
            {
                Console.WriteLine("Максимальне число зустрілось раніше, це число - {0}, його позиція - {1}", max_number, index_max);
            }
        }

        static void Example2()
        {
            Console.WriteLine("Завдання 2");
            int[] massive = new int[100];
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                massive[i] = rand.Next(-50, 50);
            }
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Число - {0} = {1}", i, massive[i]);
            }
            int start_index = 0, stop_index = 0;
            int count_of_numbers = 0;
            int index_plus = 0;
            double currentSum = 0;
            double sum = 0;
            for (int i = 0; i < 100; i++)
            {
                if (massive[i] < 0)
                {
                    currentSum += massive[i];
                    count_of_numbers++;

                }
                else
                {
                    if (count_of_numbers >= 2)
                    {
                        currentSum = Math.Abs((currentSum) / (i - 1 - index_plus));
                        if (currentSum >= sum)
                        {
                            sum = currentSum;
                            currentSum = 0;
                            stop_index = i;
                            start_index = index_plus + 1;
                        }
                        count_of_numbers = 0;
                        index_plus = i;
                    }
                    else
                    {
                        currentSum = 0;
                        index_plus = i;
                        count_of_numbers = 0;
                    }
                }

            }
            if (sum == 0)
            {
                Console.WriteLine("Послідовностей не зафіксовано");
            }
            else
            {
                while (start_index < stop_index)
                {
                    Console.Write(massive[start_index] + "; ");
                    start_index++;
                }
                Console.WriteLine("Сума цієй послідовності " + sum);
            }
        }
    }
}
