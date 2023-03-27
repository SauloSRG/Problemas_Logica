using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Retangulo
{
    internal class Program
    {
        static void Main(string[] args) // programa para calcular área, perímetro e diagonal de um retângulo com base em valores digitados
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double largura, altura, area, perimetro, diagonal;

            Console.Write("Base do retângulo: ");
            largura = double.Parse(Console.ReadLine(), CI);
            Console.Write("Altura do retângulo: ");
            altura = double.Parse(Console.ReadLine(), CI);

            area = largura * altura;
            perimetro = 2 * (altura + largura);
            diagonal = Math.Sqrt(Math.Pow(altura, 2.0) + Math.Pow(largura, 2.0));

            Console.WriteLine("ÁREA = " + area.ToString("F4", CI));
            Console.WriteLine("PERÍMETRO = " + perimetro.ToString("F4", CI));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CI));

        }
    }
}
