using System;

namespace Exercicio3
{
    class Program
    {
        static int Maior(int a, int b)
        {
            // Função utilizada no exercício 1.

            if (a > b)
                return a;
            else
                return b;
        }

        // Função utilizada no exercício 2.

        static bool Par(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {

            // Exeercício 1.

            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Exercício 1:\n ");

            Console.WriteLine("Digite o valor de um número inteiro:\n ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de outro número inteiro:\n ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("O maior número digitado foi:\t" + Maior(num1,num2));

            Console.WriteLine("--------------------------------------------------------------------------------");
            
            Console.WriteLine("Exercício 2:\n ");

            int num3 = 0;

            Console.WriteLine("Digite o valor de um número inteiro:\n ");

            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("O número digitado é PAR?\t" + Par(num3));

            Console.ReadKey();
        }
    }
}
