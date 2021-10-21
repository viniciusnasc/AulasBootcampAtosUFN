using System;

namespace Aula201021
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio em aula: 
            T, F, T, F, F, F, T, F, T
            T, T, F, T, T, F, F, T, T
            */

            /* Verificar se o numero informado é igual a constante x
            const int x = 5;
            Console.Write("Qual o numero armazenada na minha variavel? ");
            int num = int.Parse(Console.ReadLine());

            if(!(x==num))
            {
                Console.WriteLine("O número é diferente da variável!");
                if (num > x)
                {
                    Console.WriteLine("Seu número é maior que a variavel!");
                }
                else
                {
                    Console.WriteLine("Seu numero é menor que a variavel!");
                }
            }
            else
            {
                Console.WriteLine("Você acertou o numero da variavel!");
            }
            */

            /*Console.WriteLine("!Calculadora!");
            Console.Write("Digite o primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Digite 1 para soma, 2 para subtração, 3 para multiplicação e 4 para divisão: ");
            int operacao = int.Parse(Console.ReadLine());

            if (operacao == 4)
            {
                if(num2 == 0)
                {
                    Console.WriteLine("Não é possível realizar divisão por zero!");
                }
                else
                {
                    Console.WriteLine("Resultado da divisão = " + (num1/num2));
                }
            }
            else if(operacao == 1)
            {
                Console.WriteLine("Resultado da soma = " + (num1 + num2));
            }
            else if(operacao == 2)
            {
                Console.WriteLine("Resultado da subtração = " + (num1 - num2));
            }
            else if(operacao == 3)
            {
                Console.WriteLine("Resultado da multiplicação = " + (num1 * num2));
            }
            else
            {
                Console.WriteLine("Tipo de operacao invalido!");
            }*/

            /* Aumento de salário conforme condição
            Console.WriteLine("Digite o valor do salário do funcionário: ");
            double sal = double.Parse(Console.ReadLine());
            double novoSal, aumento;

            if(sal <= 900)
            {
                aumento = 0.05 * sal;
                novoSal = sal + aumento;
                Console.WriteLine($"Salário antigo = R$ {sal}\nAumento de 5% no valor de R$ {aumento}\nNovo salário = R$ {novoSal.ToString("F2")}");
            }
            else if(sal > 900 && sal <= 1400)
            {
                aumento = 0.08 * sal;
                novoSal = sal + aumento;
                Console.WriteLine($"Salário antigo = R$ {sal}\nAumento de 5% no valor de R$ {aumento}\nNovo salário = R$ {novoSal.ToString("F2")}");
            }
            else
            {
                aumento = 0.1 * sal;
                novoSal = sal + aumento;
                Console.WriteLine($"Salário antigo = R$ {sal}\nAumento de 5% no valor de R$ {aumento}\nNovo salário = R$ {novoSal.ToString("F2")}");
            }*/

            /* Tipo de triangulos
            Console.WriteLine("Descubra o tipo de triangulo!");
            Console.Write("Digite o valor do primeiro lado: ");
            double lado1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do segundo lado: ");
            double lado2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do terceiro lado: ");
            double lado3 = double.Parse(Console.ReadLine());

            if(lado1 > (lado2+lado3) || lado2 > (lado1+lado3) || lado3 > (lado1+lado2))
            {
                Console.WriteLine("Impossivel criar um triangulo com os valores informados!");
            }
            else if(lado1 == lado2 && lado1 == lado3 && lado2 ==lado3)
            {
                Console.WriteLine("Seu triangulo é equilatero, tem os tres lados iguais!");
            }
            else if(lado1 != lado2 && lado2 != lado3 && lado3 != lado1)
            {
                Console.WriteLine("Seu triangulo tem tres lados diferentes, ele é escaleno!");
            }
            else
            {
                Console.WriteLine("Seu triangulo tem dois lados iguais, ele é Isósceles!");
            }*/

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if(idade < 18 || idade > 67)
            {
                Console.WriteLine("Você não pode doar sangue!");
            }
            else
            {
                Console.WriteLine("Pode doar sangue!");
            }
        }
    }
}
