using System;

namespace Aula221021
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um algoritmo para ler as tres notas de n alunos e falar sua media
            Console.Write("Quantos alunos tem na turma?: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"\nDigite a primeira nota do {i}º aluno");
                double n1 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Digite a segunda nota do {i}º aluno");
                double n2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Digite a terceira nota do {i}º aluno");
                double n3 = double.Parse(Console.ReadLine());

                double media = (n1 + n2 + n3) / 3;
                if(media >= 6)
                    Console.WriteLine($"Aluno {i} aprovado com nota {media.ToString("F1")}");

                else
                    Console.WriteLine($"Aluno {i} reprovado com nota {media.ToString("F1")}");
            }
            */

            /* Algoritmo com a tabuada de um numero n
            Console.WriteLine("Digite um numero para ver sua tabuada: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i+1} x {num} = {num*(i+1)}");
            }
            */

            /*
            Console.WriteLine("numeros entre  1000 e 1999 que divididos por 11 o resto é 5: ");

            for(int i = 1000; i <= 1999; i++)
            {
                if(i % 11 == 5)
                    Console.WriteLine(i);
            }
            */

            /* Algoritmo para ler numeros pares ou impares com valores de inicio e final
            Console.Write("Qual o valor inicial da contagem? ");
            int inicio = int.Parse(Console.ReadLine());
            Console.Write("E o valor final? ");
            int final = int.Parse(Console.ReadLine());

            Console.Write("Voce deseja pular os valores impares ou pares? ");
            string cond = Console.ReadLine().ToLower();

            if (cond == "par" || cond == "p")
            {
                if (inicio % 2 == 0)
                    for (int i = inicio; i <= final; i = i + 2)
                        Console.WriteLine(i);
                
                else
                    for (int i = inicio + 1; i <= final; i = i + 2)
                        Console.WriteLine(i);
            }

            else if (cond == "impar" || cond == "i")
            {
                if (inicio % 2 != 0)
                    for (int i = inicio; i <= final; i = i + 2)
                        Console.WriteLine(i);
                
                else
                    for (int i = inicio + 1; i <= final; i = i + 2)
                        Console.WriteLine(i);
            }
            */

            /* Algoritmo para invalidar numeros menores que 1 ou maiores que 4
            Console.Write("Digite um numero: ");
            int opcao = int.Parse(Console.ReadLine());

            while(opcao < 1 || opcao > 4)
            {
                Console.WriteLine("Opcao invalida!");
                Console.Write("Digite um numero: ");
                opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("OK");
            */

            /* Mostrar valores de 1 a 20 de polegadas em centimetros
            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{i} polegada = {(i*2.54).ToString("F2")} centimetros");
            }
            */

            /* Mostrar o fatorial de um numero n
            Console.WriteLine("Digite um número para ver seu fatorial: ");
            int x = int.Parse(Console.ReadLine());
            int count = 1;

            for (int i = 1; i <= x; i++)
                count *= i;

            Console.WriteLine($"Fatorial de {x} = {count}");
            */

            // Desafio proposto em aula mostrar resultado dos 50 primeiros da serie:
            // (1000/1) - (997/2) + (994/3) - (991/4)...
            double num1 = 1000;
            double num2 = 1;
            double valor = 0;

            for(int i = 0; i < 25; i++)
            {
                valor += (num1 / num2);
                num1 = num1 - 3;
                num2++;
                valor -= (num1 / num2);
                num1 = num1 - 3;
                num2++;
            }

            Console.WriteLine("Resultado = " + valor);
        }
    }
}

