using System;

namespace Aula291021
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Ler uma matriz 4x4 e fazer a soma de todos seus numeros
            int[,] matriz = new int[4, 4];
            int count = 0;
            Console.WriteLine("Dogite 16 números para integrar a matriz: ");

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j <4; j++)
                {
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    count += matriz[i, j];
                }
            }

            Console.WriteLine("Valor total dos números na matriz = " + count);
            */

            /*
            int[,] matriz = new int[4, 3];
            Console.WriteLine("Digite 12 numeros para agregar a matriz: ");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Números cuja a soma dos indices i+j são pares: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write(matriz[i, j]);
                    }
                }
            }

            Console.WriteLine("\nMatriz com a segunda coluna *2 e terceira linha *3: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (j == 1)
                        matriz[i, j] = matriz[i, j] * 2;

                    if (i == 2)
                        matriz[i, j] = matriz[i, j] * 3;

                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            */

            /*
            int[,] mat = new int[3, 3];
            int somadiag1 = 0;
            int somadiag2 = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mat[i, j] = i * j;
                }
            }

            Console.WriteLine("Números na diagonal: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        Console.Write(mat[i, j] + " ");
                        somadiag1 += mat[i, j];
                    }
                }
            }

            Console.WriteLine("\nDiagonal 2: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j + i == 2)
                    {
                        Console.Write(mat[i, j] + " ");
                        somadiag2 += mat[i, j];
                    }
                }
            }

            bool igual = (somadiag1 == somadiag2);

            if(igual)
                Console.WriteLine("\nA soma das diagonais são iguais");

            else
                Console.WriteLine("\nA soma das diagonais são diferentes");
            */

            /*
            int[,] mat = new int[5, 5];
            int[] diagP = new int[5];
            int[] diagS = new int[5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mat[i, j] = 1;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(i == j)
                    diagP[i] = mat[i,j];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i + j == 4)
                        diagS[i] = mat[i, j];
                }
            }

            bool iguais = true;

            for(int i = 0; i < 5; i++)
            {
                if (diagP[i] != diagS[i])
                    iguais = false;
            }

            if(iguais)
                Console.WriteLine("Os numeros das duas diagonais são iguais!");

            else
                Console.WriteLine("Os numeros das duas diagonais são diferentes!");
            */

            // Exercicios
            /*
            int[,] mat = new int[4, 4];
            int[,] mat2 = new int[4, 4];
            int[,] matSoma = new int[4, 4];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mat[i, j] = 1;
                    mat2[i, j] = 2;
                }
            }
            */

            
            int[,] jogos = new int[20, 2];

            Console.WriteLine("Digite os gols dos times");
            for(int i = 0; i < 20; i++)
            {

            }

        }
    }
}
