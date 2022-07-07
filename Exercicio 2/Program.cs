using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {   
            int n1 = 0, n2 = 1, n3 = 0, k = 0;
            bool check = false;
            do{
                Console.WriteLine("\nInsira um numero positivo");
                k = int.Parse(Console.ReadLine());
            }while(k<0);

            while(n3 <= k)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                if(n3 == k)
                {
                    check = true;
                }
            }

            if(check)
            {
                Console.WriteLine($"O numero {k} pertence a sequencia Fibonacci");
            }
            else
            {
                Console.WriteLine($"O numero {k} nao pertence a sequencia Fibonacci");
            }
        }
    }
}