using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula261121POO
{
    class Curso
    {
        public string Nome;

        public Curso(string nome)
        {
            Nome = nome;
        }

        public void ExibeDisciplina()
        {
            Disciplina d = new("Csharp", 100);
            d.GetNome();
        }
    }
}
