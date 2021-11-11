using System;

namespace Aula251021
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Numeros pares
            int num = 0;
            while(num <= 100)
            {
                if(num % 2 == 0)
                Console.WriteLine(num);

                num++;
            }
            */

            /* Media de todos numeros impares ate 100
            int numeros = 0;
            int qtd = 0;
            int count = 1;

            while(count < 100)
            {
                if(count % 2 != 1)
                {
                    qtd++;
                    numeros += count;
                }

                count++;
            }

            Console.WriteLine("Media de todos números impares até 100 = " + (numeros/qtd));
            */

            /* Algoritmo para fazer multiplicação, sem usar sinal de *
                        Console.WriteLine("Informe dois valores:");
                        double v1 = double.Parse(Console.ReadLine());
                        double v2 = double.Parse(Console.ReadLine());
                        double mult = 0;

                        int i = 1;

                        while(i <= v2)
                        {
                            mult += v1;
                            i++;
                        }

                        Console.WriteLine(mult);
                        */

            /* Fazer um algoritmo que diga se um numero é par ou impar, esse algoritmo deve ficar repetindo ate digitar 0
            int num;

            do
            {
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());
               
                if (num % 2 == 0)
                    Console.WriteLine("Numero par");
                else
                    Console.WriteLine("Número impar");
            } while (num != 0);
            */

            /* verificar numeros de 4digitos, cujo o quadrado da soma dos dois numeros da esquerda e os dois da direita sejam ele mesmo
            int i, m, d, soma, p;
            for(i = 1000; i<= 9999; i++)
            {
                m= i / 100;
                d= i % 100;
                soma = d + m;
                p = soma * soma;
                if(p == i)
                    Console.WriteLine(i);
            }
            */

            /* sequencia de soma de 1/n
            Console.WriteLine("Digite um numero: ");
            double num = int.Parse(Console.ReadLine());
            double s = 0;

            for(double i = 1; i <= num; i++)
            {
                s += (1 / i);
            }

            Console.WriteLine(s);
            */

            /* Numeros Primos
            Console.WriteLine("Digite um número para verificar se é primo: ");
            int num = int.Parse(Console.ReadLine());
            bool primo = true;

            for(double i = 2; i < num; i++)
            {
                if (num % i == 0)
                    primo = false;
            }
            if(primo)
                Console.WriteLine("Numero primo!");
            else
                Console.WriteLine("Não é primo!");
            */

            // Sequencia de Fibonacci
            Console.WriteLine("Digite o numero da sequencia de Fibonacci que deseja visualizar: ");
            int num = int.Parse(Console.ReadLine());
            int fib = 0;
            int fib2 = 0;
            int valor = 0;

            if (num == 1)
                Console.WriteLine($"{num}º núm da sequencia = {valor}");

            else
            {
                fib++;
                valor = fib;
                for (int i = 3; i <= num; i++)
                {
                    valor = fib + fib2;
                    fib2 = fib;
                    fib = valor;
                }
                Console.WriteLine($"{num}º núm da sequencia = {valor}");
            }
        }
    }
}
