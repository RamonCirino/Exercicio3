using System;

namespace Avaliacao
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

            // Exercício 1. Implemente o método Maior (a,b) que receba dois números inteiros como parâmetro e retorna qual deles é o maior.

            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Exercício 1:\n ");

            Console.WriteLine("Digite o valor de um número inteiro e pressione a tecla ENTER:\n ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de outro número inteiro e pressione a tecla ENTER:\n ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\t O maior número digitado foi o número:\t" + Maior(num1, num2));

            Console.WriteLine("--------------------------------------------------------------------------------");

            // Exercício 2. O Índice de Massa Corporal (IMC) é uma medida internacional usada para calcular se uma pessoa está no peso ideal.
            // Ele é determinado pela divisão da massa do indivíduo pelo quadrado de sua altura, em que a massa está em Kg e a altura em m.
            // O resultado é comparado com uma tabela de referência que indica o grau de obesidade do indivíduo. Implemente um programa que
            // leia do usuário seu peso e altura e imprima na tela seu IMC, bem como sua classificação de acordo com a tabela de referência.
            // Seu programa deverá implementar e usar a classe IMC que deverá conter:

            // 1. Atributos peso e altura.
            // 2. Métodos construtores.
            // 3. O método Calcular (peso, altura) que retorna o valor numérico do IMC.
            // 4. O método Classificar que baseado no IMC, retorna uma string com a classificação do indivíduo.

            Console.WriteLine("Exercício 2:\n ");

            double peso = 0;
            double altura = 0;
            double ResultadoIMC = 0;

            Console.WriteLine("Este Programa calcula o Índice de Massa Corporal - IMC. \nPara isso digite o valor da massa corporal em Kg e pressione a tecla ENTER: \n ");

            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite o valor numérico da altura em METROS e pressione a tecla ENTER:\n");

            altura = double.Parse(Console.ReadLine());

            IMC imc = new IMC();

            ResultadoIMC = imc.Calcular(peso, altura);

            Console.WriteLine("\n");

            Console.WriteLine("De acordo com os dados informados o IMC é: " + ResultadoIMC);

            Console.WriteLine("\n");

            Console.WriteLine("\t Classificação: " + imc.Classificar(ResultadoIMC));


            Console.WriteLine("--------------------------------------------------------------------------------");

            // 3. Se o resto da divisão de um número inteiro por 2 for zero, então, o número é par, caso contrário, é ímpar. Implemente a 
            // função lógica Par(numero) que retorna verdadeiro caso o número passado como parâmetro seja par ou falso caso ele seja ímpar.

            Console.WriteLine("Exercício 3:\n ");

            int num3 = 0;

            Console.WriteLine("Digite o valor de um número inteiro e pressione a tecla ENTER:\n ");

            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\t O número digitado é PAR? " + Par(num3));

            Console.WriteLine("--------------------------------------------------------------------------------");

            // 4. Qual é o valor da variável x após cada uma das seguintes instruções abaixo serem executadas?

            // a. x = Math.Abs(7.5);
            // b. x = Math.Floor(7.5);
            // c. x = Math.Abs(0.0);
            // d. x = Math.Ceiling(0.0);
            // e. x = Math.Abs(-6.4);
            // f. x = Math.Ceiling(-6.4);
            // g. x = Math.Ceiling(-Math.Abs(-8 + Math.Floor(-5.5)));

            Console.WriteLine("Exercício 4:\n ");

            double x = 0;

            x = Math.Abs(7.5);
            Console.WriteLine("Letra a) x = " + x);

            x = Math.Floor(7.5);
            Console.WriteLine("Letra b) x = " + x);

            x = Math.Abs(0.0);
            Console.WriteLine("Letra c) x = " + x);

            x = Math.Ceiling(7.5);
            Console.WriteLine("Letra d) x = " + x);

            x = Math.Abs(-6.4);
            Console.WriteLine("Letra e) x = " + x);

            x = Math.Ceiling(-6.4);
            Console.WriteLine("Letra f) x = " + x);

            x = Math.Ceiling(-Math.Abs(-8 + Math.Floor(-5.5)));
            Console.WriteLine("Letra g) x = " + x);

            Console.WriteLine("\n");
            Console.WriteLine("\t Pressione a tecla ENTER para sair...");
            Console.ReadKey();

        }



    }
}

