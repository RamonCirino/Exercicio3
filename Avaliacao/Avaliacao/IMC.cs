using System;
using System.Collections.Generic;
using System.Text;

namespace Avaliacao
{
    class IMC
    {
        // Declaração dos atributos:

        private double peso;
        private double altura;

        // Construtor Padrão:

        public IMC()
        {
            this.peso = 0;
            this.altura = 0;
        }

        // Método da classe (Assinatura da classe):

        public IMC(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }

        // Método Calcular (Retorna o valor numérico do IMC):

        public double Calcular(double peso, double altura)
        {
            double imc = (peso / (altura * altura));
            return imc;
        }

        // Método Classificar (Retorna uma string com a classificação do indivíduo):

        public string Classificar(double imc)
        {
            if (imc < 16)
            {
                return "Magreza Geve";
            }
            else if (imc > 16 && imc < 17)
            {
                return "Magreza Moderada";
            }
            else if (imc > 17 && imc < 18.5)
            {
                return "Magreza Leve";
            }
            else if (imc > 18.5 && imc < 25)
            {
                return "Saudável";
            }
            else if (imc > 25 && imc < 30)
            {
                return "Sobrepeso";
            }
            else if (imc > 30 && imc < 35)
            {
                return "Obesidade Grau I";
            }
            else if (imc > 35 && imc < 40)
            {
                return "Obesidade Grau II (Severa)!";
            }
            else if (imc > 40)
            {
                return "Obesidade Grau III (Mórbida)!";
            }

            return "";
        }
    }
}

