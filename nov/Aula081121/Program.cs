using System;

namespace Aula081121
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ex1");
            double[] vet = new double[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Calculo(vet);

            Console.WriteLine("\nEx2");
            int[,] mat = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mat[i, j] = 1 + i + j;
                }
            }
            MostrarMatriz(mat);
            MenorElemento(mat);
            MaiorElemento(mat);
        }

        static void MostrarMatriz(int[,] mat)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mat[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Calculo(double[] vet)
        {
            for (int i = 1; i <= vet.Length; i++)
            {
                double val = vet[i - 1] * i;
                Console.Write(val + " ");
            }
        }

        static void MenorElemento(int[,] mat)
        {
            int count = mat[0, 0];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (mat[i, j] < count)
                        count = mat[i, j];
                }
            }

            Console.WriteLine("Menor elemento da matriz é o " + count);
        }

        static void MaiorElemento(int[,] mat)
        {
            for (int i = 0; i < 3; i++)
            {
                int count = mat[i, 0];
                for (int j = 0; j < 3; j++)
                {
                    if (mat[i, j] > count)
                        count = mat[i, j];
                }

                Console.WriteLine($"Maior elemento da {i + 1}º linha = {count}");
            }
        }
    }
}
