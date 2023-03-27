using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_soma_vetor
{
    internal class Program
    {
        static void Main(string[] args) // programa para definir a soma, a media e definir os valores digitados de um vetor
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N, i;
            double soma = 0, media;

            Console.WriteLine("Quantos números você vai digitar?");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            for (i = 0; i < N; i++) // linha de código para definir os elementos do vetor
            {
                Console.Write("Digite um número: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            Console.Write("VALORES = "); // linha de código para escrever os valores digitados anteriormente
            for (i = 0; i < N; i++)
            {
                if (i < (N - 1))
                {
                    Console.Write(vet[i].ToString("F1", CI) + " ");
                }
                else
                {
                    Console.WriteLine(vet[i].ToString("F1", CI));
                }
            }

            Console.Write("SOMA = "); // linha de código para somar cada valor dos vetores
            for (i = 0; i < N; i++)
            {
                soma = soma + vet[i];
            }
            Console.WriteLine(soma.ToString("F2", CI));

            media = soma / N; // linha de código para definir a média dos valores digitados

            Console.WriteLine("MEDIA = " + media.ToString("F2", CI));
        }
    }
}
