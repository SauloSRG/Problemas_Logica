using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro
{
    internal class Program
    {
        static void Main(string[] args) // programa teste para escrever dados de duas pessoas e ter uma noção da média de idades entre elas
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int idade1, idade2;
            string nome1, nome2;
            double media;

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            idade2 = int.Parse(Console.ReadLine());

            media = (double) (idade1 + idade2) / 2.0;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1", CI));




        }
    }
}
