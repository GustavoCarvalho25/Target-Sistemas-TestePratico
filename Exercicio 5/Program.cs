using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string word, wordReverse = "";

            Console.WriteLine("Escreva uma palavra");
            word = Console.ReadLine();

            for(int j = word.Length - 1; j >= 0; j--)
            {
                wordReverse += word[j];
            }
            Console.WriteLine($"A palavra '{word}' invertida e '{wordReverse}'");
        }
    }
}
