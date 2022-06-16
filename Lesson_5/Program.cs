using System;

namespace Work1
{
    class Program
    {
        static string[] ArrayCreation(string text)
        {
            string[] words = text.Split(' ');
            return words;
        }
        static string[] DataOutput(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"{words[i]} ");
            }
            return words;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите случайное предложение: ");
            string text = Console.ReadLine();
            ArrayCreation(text);
            string[] words = ArrayCreation(text);
            DataOutput(words);
            Console.ReadKey();
        }
    }
}
