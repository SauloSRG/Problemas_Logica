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
        static void Main(string[] args) // programa para tester os 4 possíveis tipos de variáveis e escrever todas as informações digitadas
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int idade;
            double salario;
            char genero;
            string nome;

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o salario: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o genero: ");
            genero = char.Parse(Console.ReadLine());

            Console.WriteLine("A funcionaria " + nome + ", de genero " + genero + ", ganha " + salario.ToString("f2", CultureInfo.InvariantCulture) + " de salário e tem " + idade + "anos");
        }
    }
}
