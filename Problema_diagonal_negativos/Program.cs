using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_diagonal_negativos
{
    internal class Program
    {
        static void Main(string[] args) // programa para definir os elementos de uma matriz quadrada, definir sua diagonal principal e verificar quantos valores negativos foram digitados
        {
            int N, i, j, quantidade = 0;

            Console.WriteLine("Qual a ordem da matriz?");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N]; 

            for ( i = 0; i < N; i++) // linha de código para definir cada elemento da matriz
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL:"); 
            for (i = 0; i < N; i++) // linha de código para definir a diagonal principal da matriz
            {
                Console.Write(mat[i, i] + " ");
            }

            for (i = 0; i < N; i++) // linha de código para contar quantos valores negativos aparecem na matriz
            {
                for (j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        quantidade = quantidade + 1;
                    }
                }
            }

            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + quantidade);
        }
    }
}
