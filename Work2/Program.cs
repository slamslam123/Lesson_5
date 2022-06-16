using System;

namespace Work2
{
    class Program
    {
        static string[] ReversWords(string[] words)
        {
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write($"{words[i]} ");
            }
            return words;
        }
        static string[] ArrayCreation(string text)
        {
            string[] words = text.Split(' ');
            return ReversWords(words);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите случайное предложение: ");
            string text = Console.ReadLine();
            ArrayCreation(text);
            Console.ReadKey();
        }
    }
}
