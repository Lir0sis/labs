#define tests

using System;
using System.Text;
using System.Collections.Generic;


namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть початкове речення: ");
            string startString = Console.ReadLine();

            String string1 = new String(startString);

            string input = "";
            int choice = 0;
#if test
            Console.WriteLine("Кількість літер: " + string1.LettersCount());
            string1.AddWord("бойся");
            string1.RemoveWord("початкове");
            string1.InsertWord("ну ок", 2);
            Console.WriteLine("Кільіксть слів: " + string1.WordCount());
            string1.InsertWord("word", 6);
            Console.WriteLine("Найдовші слова: " + string1.LongestWord());
            Console.WriteLine("Найкоротші слова: " + string1.ShorttestWord());
            Console.Read();
            System.Environment.Exit(0);
#endif
            while (true)
            {
                System.Threading.Thread.Sleep(1500);

                Console.Clear();

                #region
                Console.WriteLine("Речення: " + string1.GetSentence() + "\n    -----------------");
                Console.WriteLine("Оберіть дію над реченням:"
                   + "\n 1.Додати слово"
                   + "\n 2.Видалити слово"
                   + "\n 3.Вставити слово"
                   + "\n 4.Кількість літер"
                   + "\n 5.Кількість слів"
                   + "\n 6.Найдовші слова"
                   + "\n 7.Найкоротші слова"
                   + "\n 8.Наявність слова"
                   + "\n 9.Слово на позиції"
                   + "\n 0.Порівняти речення");
                #endregion

                Console.Write("Ваш вибір: "); input = Console.ReadLine();

                if (IsParseable(input))
                    choice = int.Parse(input);
                else
                {
                    Console.WriteLine("Не вірний вибір...");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Введіть слово: "); input = Console.ReadLine();
                        string1.AddWord(input);
                        break;
                    case 2:
                        Console.Write("Введіть слово: "); input = Console.ReadLine();
                        string1.RemoveWord(input);
                        break;
                    case 3:
                        Console.Write("Введіть слово: "); input = Console.ReadLine();
                        Console.Write("Введіть позицію: "); choice = int.Parse(Console.ReadLine());
                        string1.InsertWord(input, choice);
                        break;
                    case 4:
                        Console.WriteLine("Кільіксть літер: " + string1.LettersCount());
                        break;
                    case 5:
                        Console.WriteLine("Кільіксть слів: " + string1.WordCount());
                        break;
                    case 6:
                        Console.WriteLine("Найдовші слова: " + string1.LongestWord());
                        break;
                    case 7:
                        Console.WriteLine("Найкоротші слова: " + string1.ShorttestWord());
                        break;
                    case 8:
                        Console.Write("Введіть слово: "); input = Console.ReadLine();
                        string1.WordSearch(input);
                        break;
                    case 9:
                        Console.Write("Введіть слово: "); input = Console.ReadLine();
                        string1.ShowWordAt(int.Parse(input));
                        break;
                    case 0:
                        Console.Write("Введіть речення: "); input = Console.ReadLine();
                        string1.CompareSentence(input);
                        break;
                    case 2020:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Не вірний вибір...");
                        break;
                }
            }          
        }

        public static bool IsParseable(string input)
        {
            try
            {
                int.Parse(input);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }

    class String
    {
        private string sentence;
        private string[] sentenceWords;

        public String(string sentence)
        {
            sentence = sentence.Insert(0, "\u0000");
            sentence = sentence.Trim();
            sentence = sentence.Remove(0, 1);
            sentence = sentence.Trim();

            if (sentence != " " && sentence != "")
                this.sentence = sentence;
            else
                this.sentence = "Це початкове речення";

            this.sentence += " ";
            sentenceWords = sentence.Split(" ");
        }

        public void AddWord(string word) 
        {
            if (!IsOneWord(ref word))
                return;
            sentence += word + " ";

            UpdateArray(sentence);
            WriteOutput();
        }
        public void RemoveWord(string word) 
        {
            if (!IsOneWord(ref word))
                return;

            if (sentence.ToLower().Contains(word.ToLower()))
            {
                sentence = sentence.ToLower().Remove(sentence.ToLower().IndexOf(word.ToLower()), word.Length + 1);
                WriteOutput();
            }
            else
                Console.WriteLine("Речення не містить такого слова!");

            UpdateArray(sentence);
        }
        public void InsertWord(string word, int pos) 
        {
            if(pos > WordCount())
            {
                AddWord(word);
                return;
            }

            if (!IsOneWord(ref word))
                return;

            int count = 0;
            int lastpos = 0;
            
            while (true)
            {
                if (count >= pos)
                    break;
                lastpos = sentence.IndexOf(' ', lastpos + 1);
                count++;
            }
            sentence = sentence.Insert(lastpos, " " + word);

            UpdateArray(sentence);
            WriteOutput();

        }
        public int LettersCount() 
        {
            return sentence.Length - WordCount();
        }
        public int WordCount() 
        {
            return sentenceWords.Length;
        }
        public string LongestWord() 
        {
            List<string> LongestWords = new List<string>();
            int pos = 0;
            for (int i = 1; i < WordCount() - 1; i++)
            {
                if (sentenceWords[pos].Length < sentenceWords[i].Length)
                {
                    pos = i;

                    if (LongestWords.Count != 0) 
                        LongestWords.Clear();

                    LongestWords.Add(sentenceWords[pos]);
                }
                else if (sentenceWords[pos].Length == sentenceWords[i].Length)
                    LongestWords.Add(sentenceWords[i]);

            }
            return ArrayToString(",", LongestWords.ToArray());
        }
        public string ShorttestWord() 
        {
            List<string> ShorttestWords = new List<string>();
            int pos = 0;
            for (int i = 1; i < WordCount() - 1; i++)
            {
                if (sentenceWords[pos].Length < sentenceWords[i].Length)
                {
                    pos = i;

                    if (ShorttestWords.Count != 0)
                        ShorttestWords.Clear();

                    ShorttestWords.Add(sentenceWords[pos]);
                }
                else if (sentenceWords[pos].Length == sentenceWords[i].Length)
                    ShorttestWords.Add(sentenceWords[i]);

            }
            return ArrayToString(",", ShorttestWords.ToArray());
        }
        public bool WordSearch(string word)
        {
            return sentence.ToLower().Contains(word.ToLower());
        }
        public string ShowWordAt(int index)
        {
            if (index >= sentenceWords.Length)
                index = sentenceWords.Length - 1;
            return sentenceWords[index];
        }
        public void CompareSentence(string sentence) 
        {
            if (this.sentence.Trim().ToLower() == sentence.Trim().ToLower())
                Console.WriteLine("Речення однакові");
            else
                Console.WriteLine("Речення відмінні");
        }
        private void WriteOutput()
        {
            Console.WriteLine("Нове речення: \"" + sentence + "\"");
        }
        private bool IsOneWord(ref string word)
        {
            word.Trim();
            if (word.Contains(" "))
            {
                Console.WriteLine("Ви ввели більше 1го слова!");
                return false;
            }
            return true;
        }
        private void UpdateArray(string sentence)
        {
            sentenceWords = sentence.TrimEnd().Split(" ");
        }
        private string ArrayToString(string combiner, string[] array)
        {
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i] + combiner;
            }
            return result.TrimEnd();
        }
        public string GetSentence()
        {
            return sentence;
        }
    }
}