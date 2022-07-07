using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 13, sum = 0, k = 0;

            while(k < i)
            {
                k++;
                sum += k;
            }
            Console.WriteLine(sum);
            // a saida e 91
        }
    }
}
