using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_soma_impares
{
    internal class Program
    {
        static void Main(string[] args) // programa para somar todos os valores impares de um determinado intervalo
        {
            int x, y, i, soma, troca;

            Console.WriteLine("Digite dois números:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y) // linha de código para arrumar os valores de x e y em crescente/decrescente
            {
                troca = x;
                x = y;
                y = troca;
            }
            else
            {
                troca = 0;
                x = x;
                y = y;
            }

            soma = 0;

            for (i = x + 1; i < y; i++) // linha de código para somar os valores impares entre um intervalo e outro
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
                else
                {
                    soma = soma;
                }
            }

            Console.WriteLine("Soma dos Impares = " + soma);

        }
    }
}
