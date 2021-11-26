using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula261121POO
{
    class Pessoa
    {
        public string Nome;
        public string Cpf;
        public int Idade;
        public char Genero;

        public Pessoa(string nome, int idade, char genero)
        {
            Nome = nome;
            Idade = idade;
            Genero = genero;
        }

        public void GetNome()
        {
            Console.WriteLine(Nome);
        }

        public void GetIdade()
        {
            Console.WriteLine(Idade);
        }

        public void GetGenero()
        {
            if(Genero == 'M' || Genero == 'm')
                Console.WriteLine("Mulher");

            else if(Genero == 'H' || Genero == 'h')
                Console.WriteLine("Homem");
        }

        public void GetCpf()
        {
            Console.WriteLine(Cpf);
        }
    }
}
