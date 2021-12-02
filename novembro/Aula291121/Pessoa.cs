using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula291121WFJogoDaVelha
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }

        public string Viver()
        {
            return "Estou vivo";
        }

        public string Morrer()  
        {
            return "Estou morto";
        }

        public abstract string FazTarefa();
    }
}
