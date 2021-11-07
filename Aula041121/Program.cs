using System;
using System.Collections.Generic;

namespace Aula041121
{
    class Program
    {
        static void Main(string[] args)
        {
            #region exercicio calculadora
            /*
            char opcao;
            do
            {
                Console.Write("Digite o primeiro valor: ");
                double num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o tipo de operação (+,-,/,*): ");
                char operacao = char.Parse(Console.ReadLine());
                opcao = operacao;

                Console.Write("Digite o segundo valor: ");
                double num2 = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case '+':
                        Console.WriteLine(Soma(num1, num2));
                        break;

                    case '-':
                        Console.WriteLine(Subtracao(num1, num2));
                        break;

                    case '*':
                        Console.WriteLine(Multiplicacao(num1, num2));
                        break;

                    case '/':
                        Console.WriteLine(Divisao(num1, num2));
                        break;

                    default:
                        Console.WriteLine("Tipo de operação não encontrada!");
                        break;
                }
                if (!(operacao == '/' && num2 == 0))
                {
                    Console.Write("\nDigite q para sair, ou qualquer tecla para nova operação: ");
                    opcao = char.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("\nDigite uma nova operação: ");
                }
            }
            while (opcao != 'q');
        }


        static double Soma(double x, double y)
        {
            return (x + y);
        }

        static double Subtracao(double x, double y)
        {
            return (x - y);
        }

        static double Multiplicacao(double x, double y)
        {
            return (x * y);
        }

        static string Divisao(double x, double y)
        {
            if (y == 0)
                return "Impossível realizar divisão por zero!";

            else
                return (x / y).ToString("F2");
        }

        static void menu()
        { }
    }
}
*/
            #endregion

            int[] vetor = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Vetor: ");
            ExibirVetor(vetor);

            Console.WriteLine("\n\nExibição do vetor em ordem inversa: ");
            ExibirVetorInverso(vetor);

            Console.WriteLine("\n\nExibição dos vetores de acordo com seus indices:");
            ExibirPorIndice(vetor);

            Console.WriteLine("\n\nExibição dos vetores de acordo com seus numeros (par ou impar): ");
            ExibirPorNumero(vetor);
        }

        static void ExibirVetor(int[] vet)
        {
            foreach (int x in vet)
            {
                Console.Write(x + " ");
            }
        }

        static void ExibirVetorInverso(int[] vet)
        {
            for(int i = vet.Length; i> 0; i--)
            {
                Console.Write(vet[i-1] + " ");
            }
        }

        static void ExibirPorIndice(int[] vet)
        {
            int[] vetPar = new int[vet.Length/2];
            int[] vetImpar = new int[vet.Length / 2];

            Console.WriteLine("Indices pares: ");

            for(int i = 0; i < vet.Length; i++)
            {
                if (i % 2 == 0)
                    vetPar[i/2] = vet[i];
            }
            ExibirVetor(vetPar);

            Console.WriteLine("\nIndices impares: ");
            for (int i = 0; i < vet.Length; i++)
            {
                if (i % 2 != 0)
                    vetImpar[i / 2] = vet[i];
            }
            ExibirVetor(vetImpar);
        }

        static void ExibirPorNumero(int[] vet)
        {
            List<int> listaPares = new();
            List<int> listaImpares = new();

            for(int i = 0; i < vet.Length; i++)
            {
                if (vet[i] % 2 == 0)
                    listaPares.Add(vet[i]);

                else
                    listaImpares.Add(vet[i]);
            }

            int[] pares = new int[listaPares.Count];
            int[] impares = new int[listaImpares.Count];

            foreach (int x in listaPares)
            {
                pares[listaPares.IndexOf(x)] = x;
            }
            foreach(int x in listaImpares)
            {
                impares[listaImpares.IndexOf(x)] = x;
            }

            Console.WriteLine("Números pares: ");
            ExibirVetor(pares);

            Console.WriteLine("\nNumeros impares: ");
            ExibirVetor(impares);
        }
    }
}