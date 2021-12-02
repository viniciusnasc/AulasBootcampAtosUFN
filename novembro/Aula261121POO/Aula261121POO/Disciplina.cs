using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula261121POO
{
    class Disciplina 
    {
        private string Nome;
        private int CargaHoraria;

        public Disciplina(string nome, int cargaHoraria)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
        }

        public void GetNome()
        {
            Console.WriteLine(Nome);
        }

        public void GetCargaHoraria()
        {
            Console.WriteLine(CargaHoraria);
        }
    }
}
