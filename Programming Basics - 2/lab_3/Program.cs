using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;

namespace lab_3
{
    class Program
    {
        static Random rand = new Random(DateTime.Now.Millisecond);
        static readonly int size = 20;

        static void Main(string[] args)
        {

            byte[] bytes1 = new byte[3];
            byte[] bytes2 = new byte[3];

            #region Task1

            List<string> strings = new List<string>();

            for (int i = 0; i < size; i++)
            {
                rand.NextBytes(bytes1);
                strings.Add(Convert.ToBase64String(bytes1));
            }

            ShowList(strings);

            ShowListSpiral(strings);

            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Task2

            Dictionary<string, string> stringDict = new Dictionary<string, string>();

            for (int i = 0; i < size; i++)
            {
                rand.NextBytes(bytes1);
                rand.NextBytes(bytes2);
                stringDict.Add(Convert.ToBase64String(bytes1), Convert.ToBase64String(bytes2));
            }

            string path = Directory.GetCurrentDirectory() + "\\data.json";

            File.WriteAllText(path, JsonSerializer.Serialize(stringDict));

            ShowDict(JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(path)));

            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Task3

            strings = new List<string>();

            for (int i = 0; i < size; i++)
            {
                byte[] tempBytes = new byte[rand.Next(1, 12)];
                GenBytes(tempBytes);
                strings.Add(System.Text.Encoding.ASCII.GetString(tempBytes));
            }

            ShowList(strings, 2);

            Console.Read();
            var chars = from key in strings
                    where isAccessible(key)
                    select (key.Length % 2 == 0 ? key[0] : key[key.Length - 1]);

            var sortedChars = chars.OrderBy(key => (int)key);

            foreach (var key in sortedChars)
                Console.Write(key + " ");

            #endregion

        }

        static bool isAccessible(string str)
        {
            if (str.ToCharArray().Length != 0)
                return true;
            return false;
        }

        static void ShowList<T>(List<T> list, int lineLength = 10)
        {
            lineLength--;
            int i = 0;
            foreach (T key in list)
            {
                Console.Write(key + " ");
                if (i == lineLength)
                {
                    i = 0;
                    Console.WriteLine();
                }
                else i++;
            }
            Console.WriteLine();

        }
        static void ShowListSpiral<T>(List<T> list)
        {
            for (int i = 0; i < size / 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i + 1) % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(list[i * 10 + (9 - j)] + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else Console.Write(list[i * 10 + j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void ShowDict<T1, T2>(Dictionary<T1, T2> dict)
        {
            foreach (T1 key in dict.Keys)
            {
                Console.WriteLine($"{key} : {dict[key]}");
            }
        }

        static void GenBytes(byte[] bytes)
        {
            for(int i = 0; i <bytes.Length; i++)
            {
                bytes[i] = (byte)(rand.Next(0, 1000) % 2 == 0 ? rand.Next(65, 90) : rand.Next(97, 122));
            }
        }
    }
}
