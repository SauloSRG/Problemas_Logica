using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Problema_Menor_de_tres
{
    internal class Program
    {
        static void Main(string[] args) // programa para encontrar o menor valor entre 3 valores digitados (programa passível de melhoria através da aplicação de vetor/ matriz)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int valor1, valor2, valor3, menor;

            Console.Write("Primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());
            Console.Write("Terceiro valor: ");
            valor3 = int.Parse(Console.ReadLine());

            if (valor1 <= valor2 && valor1 <= valor3) // linha de código para verificar se o valor1 é o menor entre os três valores
            {
                menor = valor1;
            }
            else if (valor2 <= valor3) // linha de código para verificar se o valor2 é o menor entre o valor2 e o valor3
            {
                menor = valor2;
            }
            else {
                menor = valor3;
            }

            Console.WriteLine("MENOR = " + menor);
        }
    }
}
