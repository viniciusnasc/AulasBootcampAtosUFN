using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio 1: conversor de graus Celsius para Fahrenheit
            Console.WriteLine("Digite a temperatura em Celsius: ");
            double tempCelsius = double.Parse(Console.ReadLine());

            double tempFahrenheit = (((9 * tempCelsius)+160)/5);

            Console.WriteLine("Temperatura convertida para Fahrenheit = " + tempFahrenheit);*/

            /* Exercicio 2: Calculo de salário-hora
            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();
            Console.Write("Quantas horas foram trabalhadas? ");
            double horas = double.Parse(Console.ReadLine());
            Console.Write("Qual o valor da hora trabalhada dele? ");
            double salarioHora = double.Parse(Console.ReadLine());

            double salarioTotal = salarioHora * horas;

            Console.WriteLine($"O salário do {nome} será de R$ {salarioTotal.ToString("F2")}.");
            */

            /* Realizar a inversao de variaveis
            int x = 5;
            int y = 7;

            int aux = x;
            x = y;
            y = aux;

            Console.WriteLine(x + "\n" + y);
            */

            /* Verificar quantos dias tem nos anos, meses e dias informados
            Console.Write("Digite a quantidade de anos: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de meses: ");
            int meses = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de dias: ");
            int dias = int.Parse(Console.ReadLine());

            int totalDias = ano * 365 + meses * 30 + dias;
            Console.WriteLine("Total de dias informados: " + totalDias);
            */

            /* Calculo de salário aumentando percentualmente
            Console.Write("Informe o salário do funcionário: ");
            double sal = double.Parse(Console.ReadLine());

            Console.Write("Informe a porcentagem que será aumentada: ");
            double porcentagem = double.Parse(Console.ReadLine());

            if(porcentagem > 1)
                Console.WriteLine($"Salário novo = {(sal+sal*(porcentagem/100)).ToString("F2")}");
            
            else
                Console.WriteLine($"Salário novo = {(sal+sal *porcentagem).ToString("F2")}");
            */

            /* Calculo de salario do funcionario com comissao de 15% sobre vendas
            double veiculo = 30000;

            Console.Write("Informe o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Informe o salário do " + nome + ": ");
            double salarioBase = double.Parse(Console.ReadLine());

            Console.Write("Quantos veículos " + nome + " vendeu esse mes? ");
            int qtdVeiculos = int.Parse(Console.ReadLine());

            double comissao = qtdVeiculos * (veiculo * 0.15);
            double novoSalario = comissao + salarioBase;

            Console.WriteLine("Salário total de R$ " + novoSalario.ToString("F2"));
            */

            /* Percentual de votos nulos, validos e em brancos + total de votos
            Console.Write("Digite a quantidade de votos em branco: ");
            double numBrancos = int.Parse(Console.ReadLine());
            
            Console.Write("Digite a quantidade de votos nulos: ");
            double numNulos = int.Parse(Console.ReadLine());
            
            Console.Write("Digite a quantidade de votos validos: ");
            double numValidos = int.Parse(Console.ReadLine());

            double totalEleitores = numBrancos + numNulos + numValidos;

            Console.WriteLine($"Total de votos = {totalEleitores}");
            Console.WriteLine($"Percentual de votos nulos = {(numNulos *100)/totalEleitores}%");
            Console.WriteLine($"Percentual de votos brancos = {(numBrancos *100)/totalEleitores}%");
            Console.WriteLine($"Percentual de votos validos = {(numValidos *100)/totalEleitores}%");
            */

            /* Mostrar o sucessor e antecessor 
            Console.Write("Digite um numero ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Seu antecessor é {num-1}");
            Console.WriteLine($"Seu sucessor é {num+1}");
            */

            // Media de notas
            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"A nota deste aluno foi de: {(nota1+nota2+nota3)/3}");
        }

    }
}
