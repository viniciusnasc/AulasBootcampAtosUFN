using System;

namespace Aula281021
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //Criar um vetor e mostrar os numeros no vetor
            Console.Write("Digite a quantidade de numeros no vetor: ");
            int qtd = int.Parse(Console.ReadLine());
            int[] numeros = new int[qtd];

            for(int n = 0; n < qtd; n++)
            {
                Console.Write($"Digite o {n+1}º número: ");
                numeros[n] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Elementos no vetor multiplicados por 2: ");
            for(int i = 0; i < qtd;i++)
            {
                Console.WriteLine($"{numeros[i]*2}");
            }*/

            /*
            int[] numeros = new int[5];
            Console.WriteLine("Digite 5 numeros: ");
            numeros[0] = int.Parse(Console.ReadLine());
            numeros[1] = int.Parse(Console.ReadLine());
            numeros[2] = int.Parse(Console.ReadLine());
            numeros[3] = int.Parse(Console.ReadLine());
            numeros[4] = int.Parse(Console.ReadLine());
            int count = 0;

            Console.WriteLine("Numeros pares: ");
            for(int i = 0; i < 5; i++)
            {
                if(numeros[i] % 2 == 0)
                {
                    count++;
                    Console.WriteLine(numeros[i]);
                }
            }

            Console.WriteLine($"Foram digitados {count} numeros pares!");
            */

            /*
            int[] numeros = new int[10];
            int pares = 0;
            int impares = 0;
            Console.WriteLine("Digite 10 números: ");
            for(int i = 0; i < 10; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for(int j = 0; j <10; j++)
            {
                if (numeros[j] % 2 == 0)
                    pares++;

                else
                    impares++;
            }

            Console.WriteLine($"Foram digitados {pares} números pares e {impares} números ímpares!");
            */

            /*
            int[] numeros = new int[10];
            Console.WriteLine("Digite 10 números: ");
            for (int i = 0; i < 10; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ordem inversa: ");
            for (int j = 9; j >=0; j--)
            {
                Console.WriteLine(numeros[j]);
            }
            */

            /*
            int[] numeros1 = new int[20];
            int[] numeros2 = new int[20];
            int[] numerosSoma = new int[20];

            Console.WriteLine("Digite 20 números para o primeiro vetor: ");
            for (int i = 0; i < 20; i++)
            {
                numeros1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Agora digite 20 números para o segundo vetor: ");
            for (int i = 0; i < 20; i++)
            {
                numeros2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Soma dos dois vetores: ");
            for (int i = 0; i < 20; i++)
            {
                numerosSoma[i] = numeros1[i] + numeros2[i];
                Console.WriteLine(numerosSoma[i]);
            }
            */

            /*
            double[] numeros = new int[30];
            Console.WriteLine("Digite 30 números reais: ");
            for (int i = 0; i < 30; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Posição dos numeros menores que zero no vetor: ");
            for (int i = 0; i < 30; i++)
            {
                if(numeros[i] < 0)
                    Console.Write($"{i+1} ");
            }
            */

            /*
            int[] numeros = new int[10];
            Console.WriteLine("Digite 10 números: ");
            for (int i = 0; i < 10; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Números pares na ordem digitada: ");
            for (int i = 0; i < 10; i++)
            {
                if(numeros[i] % 2 == 0)
                    Console.Write($"{numeros[i]} ");
            }

            Console.WriteLine("\nNúmeros impares na ordem digitada: ");
            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] % 2 != 0)
                    Console.Write($"{numeros[i]} ");
            }*/

            int[] vetor = new int[20];
            int[] nVetor = new int[20];
            int i;

            for(i=0; i<20;i++)
            {
                Console.WriteLine("Digite o elemento " + (i +1));
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 20; i++)
            {
                if (vetor[i] == 0)
                    nVetor[i] = 2;

                else
                    nVetor[i] = vetor[i];
            }

            Console.WriteLine("Vetor original: ");
            for (i = 0; i<20; i++)
            {
                Console.WriteLine("Elemento "+ (i+1)+ " - " + vetor[i]);   
            }
            Console.WriteLine("Vetor novo: ");
            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("Elemento " + (i + 1) + " - " + nVetor[i]);
            }
        }
    }
}
