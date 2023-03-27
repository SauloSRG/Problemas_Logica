using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Crescente
{
    internal class Program
    {
        static void Main(string[] args) // programa para identificar se dois valores digitados estão em ordem crescente ou decrescente
        {
            int x, y;

            Console.WriteLine("Digite dois números:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != y) // linha de código para verificar se a ordem de x e y é crescente ou decrescente e finalizar quando dois valores iguais são digitados
            {
                if (x < y)
                {
                    Console.WriteLine("CRESCENTE!");
                }
                else
                {
                    Console.WriteLine("DECRESCENTE!");
                }

                Console.WriteLine("Digite outros dois números: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
        }
    }
}
