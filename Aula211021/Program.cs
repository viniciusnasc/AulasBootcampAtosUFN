using System;

namespace Aula211021
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um algoritmo que leia um numero e corresponda ao mes
            Console.WriteLine("Digite o número do mês: ");
            int mes = int.Parse(Console.ReadLine());

            switch(mes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;

                case 2:
                    Console.WriteLine("Fevereiro");
                    break;

                case 3:
                    Console.WriteLine("Março");
                    break;

                case 4:
                    Console.WriteLine("Abril");
                    break;
                
                case 5:
                    Console.WriteLine("Maio");
                    break;
                
                case 6:
                    Console.WriteLine("Junho");
                    break;
                
                case 7:
                    Console.WriteLine("Julho");
                    break;
                
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                
                case 9:
                    Console.WriteLine("Setembro");
                    break;
                
                case 10:
                    Console.WriteLine("Outubro");
                    break;
                
                case 11:
                    Console.WriteLine("Novembro");
                    break;
                
                case 12:
                    Console.WriteLine("Dezembro");
                    break;

                default:
                    Console.WriteLine("Não há mês com o valor informado!");
                    break;
            */

            /* Fazer a calculadora da ultima aula utilizando switch
            Console.WriteLine("!Calculadora!");
            Console.Write("Digite o primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o tipo de operação (+ - / *): ");
            char operacao = char.Parse(Console.ReadLine());
            while (operacao != '*' && operacao != '/' && operacao != '+' && operacao != '-')
            {
                Console.WriteLine("Não reconheço o tipo de operação informado!");
                Console.Write("Digite o tipo de operação (+ - / *): ");
                operacao = char.Parse(Console.ReadLine());
            }

            Console.Write("Digite o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (operacao)
            {
                case '+':
                    Console.WriteLine("Resultado da soma = " + (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("Resultado da subtração = " + (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("Resultado da multiplicação = " + (num1 * num2));
                    break;

                case '/':
                    if (num2 == 0)
                        Console.WriteLine("Não é possível realizar divisão por zero!");
                    
                    else
                        Console.WriteLine("Resultado da divisão = " + (num1 / num2));
                    
                    break;
            }
            */

            /* Fazer um calculo com desconto conforme o tipo de cliente
            Console.Write("Digite o valor original da compra: ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tipo de comprador\n1 - cliente comum;\n2 - funcionario;\n3 - cliente vip");
            int tipo = int.Parse(Console.ReadLine());
            double desconto;

            switch(tipo)
            {
                case 2:
                    desconto = 0.1;
                    valor = valor - (valor * desconto);
                    Console.WriteLine("O valor do produto ficou em R$ " + valor.ToString("F2"));
                    break;

                case 3:
                    desconto = 0.05;
                    valor = valor - (valor * desconto);
                    Console.WriteLine("O valor do produto ficou em R$ " + valor.ToString("F2"));
                    break;

                case 1:
                    Console.WriteLine("Cliente sem descontos, valor do produto ficou em R$ " + valor.ToString("F2"));
                    break;

                default:
                    Console.WriteLine("Tipo de cliente não encontrado!");
                    break;
            }
            */

            /*Digitar um numero, se for par, permanece ele, se não, transforma em par
            Console.Write("Digite um numero: ");
            int num = int.Parse(Console.ReadLine());

            num = num % 2 == 0 ? num : num+1;

            Console.WriteLine(num);
            */

            /*
            for(int i = 1; i<11; i++)
            {
                Console.WriteLine($"{i}");
            }
            */

            /*
            for (int i = 20; i >= 5; i--)
                Console.WriteLine(i + " ");
            */

            /*
            Console.WriteLine("Digite o numero de inicio: ");
            int inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero final: ");
            int final = int.Parse(Console.ReadLine());

            if (inicio < final)
            {
                for (int i = inicio; i <= final; i++)
                    Console.WriteLine(i);
            }
            else
            {
                for (int i = inicio; i >= final; i--)
                    Console.WriteLine(i);
            }
            */

            // Fazer um algoritmo que leia um número n e escreva de 0 a 100 pulando de n em n
            Console.WriteLine("Digite o numero que será pulado: ");
            int x = int.Parse(Console.ReadLine());
            
            for(int i = 0; i <= 100; i+=x)
                Console.WriteLine(i);
        }
    }
}

