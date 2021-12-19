using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Calculadora
    {

        public void Calcular()
        {

            Console.WriteLine();
            Console.Write("Digite o primeiro numero da operação: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEscolha a operação desejada: \n");
            Console.WriteLine(" [1] = ADIÇÃO (+)");
            Console.WriteLine(" [2] = SUBTRAÇÃO (-)");
            Console.WriteLine(" [3] = MULTIPLICAÇÃO (*)");
            Console.WriteLine(" [4] = DIVISÃO (/)\n");

            Console.Write("\nOperação n°: ");

            int operacao = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o segundo numero da operação: ");

            double numero2 = double.Parse(Console.ReadLine());


            switch (operacao)
            {
                case 1:
                    double resultadoParcialSoma = numero1 + numero2;
                    Console.WriteLine($"A soma de {numero1} + {numero2} é igual a: {resultadoParcialSoma}\n");
                    break;
                case 2:
                    double resultadoParcialSubtracao = numero1 - numero2;
                    Console.WriteLine($"A subtração de {numero1} - {numero2} é igual a: {resultadoParcialSubtracao}\n");
                   

                    break;
                case 3:
                    double resultadoParcialMultiplicacao = numero1 * numero2;
                    Console.WriteLine($"A Multiplicação de {numero1} * {numero2} é igual a: {resultadoParcialMultiplicacao}\n");
                    

                    break;
                case 4:
                    double resultadoParcialDivisao = numero1 / numero2;
                    Console.WriteLine($"\nA Divisao de {numero1} / {numero2} é igual a: {resultadoParcialDivisao}\n");
                   

                    break;
                default:
                    Console.WriteLine("Opção de operação digitada é inválida");
                    break;

            }

            
        }


    }
}
